using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using PO.Types.CustomTypes;
using PO.Types.Attributes;
using System.IO;

namespace PO.DataService
{
    internal class PODataObject : IPODataObject
    {
         private SqlConnection mConnection;
        private SqlTransaction mTransaction;
        private bool mIsTransactional;
        private static Hashtable mDataSetTypes;
        private static object mTsObject;

        private const IsolationLevel ISOLATION_LEVEL = IsolationLevel.ReadCommitted;

        #region "Static methods"

        static PODataObject()
        {
            mTsObject = new object();
            mDataSetTypes = new Hashtable();
        }
        #endregion


        private CDataSetMetaData GetDatasetMetadata(DataTable pDt)
        {

            // Custom tool disinda bir datatable... 
            if (pDt.GetType().IsDefined(typeof(FullTableNameAttribute), false) == false)
                return null;

            if (mDataSetTypes.ContainsKey(pDt.GetType().FullName))
                return (CDataSetMetaData)(mDataSetTypes[pDt.GetType().FullName]);

            lock (mTsObject)
            {
                if (mDataSetTypes.ContainsKey(pDt.GetType().FullName))
                    return (CDataSetMetaData)(mDataSetTypes[pDt.GetType().FullName]);

                CDataSetMetaData oMeta = new CDataSetMetaData();
                oMeta.dataSetTypeName = pDt.GetType().FullName;
                if (pDt.GetType().IsDefined(typeof(FullTableNameAttribute), false))
                {
                    FullTableNameAttribute dbAttribute = (FullTableNameAttribute)pDt.GetType().GetCustomAttributes(typeof(FullTableNameAttribute), false)[0];
                    oMeta.fullTableName = dbAttribute.FullTableName;
                }
                if (pDt.GetType().IsDefined(typeof(AutoIncColNameAttribute), false))
                {
                    AutoIncColNameAttribute autoAttribute = (AutoIncColNameAttribute)pDt.GetType().GetCustomAttributes(typeof(AutoIncColNameAttribute), false)[0];
                    oMeta.autoIncrementColumnName = autoAttribute.AutoIncColName;
                }

                // CommandBuilder kullanarak commandleri olustur ve bu commentleri cache'le. 
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + oMeta.fullTableName);
                cmd.Connection = mConnection;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder mCommandBuilder = new SqlCommandBuilder(da);
                if (mIsTransactional)
                    da.SelectCommand.Transaction = mTransaction;
                SqlCommand cmdInsertCommand = mCommandBuilder.GetInsertCommand();
                oMeta.insertCommand = cmdInsertCommand.CommandText;
                if (oMeta.autoIncrementColumnName != string.Empty)
                {
                    oMeta.insertCommand += ";" + cmd.CommandText + " WHERE " + oMeta.autoIncrementColumnName + " = SCOPE_IDENTITY();";
                }
                oMeta.insertParameterList = new SqlParameter[cmdInsertCommand.Parameters.Count];
                cmdInsertCommand.Parameters.CopyTo(oMeta.insertParameterList, 0);

                SqlCommand cmdUpdateCommand = mCommandBuilder.GetUpdateCommand();
                oMeta.updateCommand = cmdUpdateCommand.CommandText;
                oMeta.updateParameterList = new SqlParameter[cmdUpdateCommand.Parameters.Count];
                cmdUpdateCommand.Parameters.CopyTo(oMeta.updateParameterList, 0);

                SqlCommand cmdDeleteCommand = mCommandBuilder.GetDeleteCommand();
                oMeta.deleteCommand = cmdDeleteCommand.CommandText;
                oMeta.deleteParameterList = new SqlParameter[cmdDeleteCommand.Parameters.Count];
                cmdDeleteCommand.Parameters.CopyTo(oMeta.deleteParameterList, 0);


                mDataSetTypes.Add(pDt.GetType().FullName, oMeta);
                return oMeta;
            }
        }

        public PODataObject(string pConnectionString, string pDefaultDB, bool pIsTransactional)
        {
            if (pDefaultDB != string.Empty)
            {
                pConnectionString = pConnectionString + ";Initial Catalog=" + pDefaultDB;
            }
            mConnection = new SqlConnection(pConnectionString);
            mIsTransactional = pIsTransactional;
            try
            {
                if (pIsTransactional)
                {
                    mConnection.Open();
                    BeginTransaction();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void BeginTransaction()
        {
            mTransaction = mConnection.BeginTransaction(ISOLATION_LEVEL);
        }

        private void OpenConnection()
        {
            if (mIsTransactional == false)
            {
                mConnection.Open();
            }
        }
        private void CloseConnection()
        {
            if (mIsTransactional == false)
            {
                mConnection.Close();
            }
        }


        #region PODataObject Members

        public bool IsDataObjectTransactional
        {
            get { return mIsTransactional; }
        }

        public void CommitTransaction()
        {
            if (mIsTransactional)
            {
                mTransaction.Commit();
                mConnection.Close();
            }
        }

        public void RollbackTransaction()
        {
            if (mIsTransactional)
            {
                mTransaction.Rollback();
                mConnection.Close();
            }
        }


        public int ExecuteSqlStatement(System.Data.SqlClient.SqlCommand pCommand)
        {
            OpenConnection();
            pCommand.Connection = mConnection;
            if (mIsTransactional)
            {
                pCommand.Transaction = mTransaction;
            }

            try
            {
                int mRowsAffected = pCommand.ExecuteNonQuery();
                return mRowsAffected;
            }
            catch (Exception ex)
            {
                if (pCommand != null) ex.Data.Add("SQL", pCommand.CommandText);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void GetRecords(System.Data.DataTable pDataTable, System.Data.SqlClient.SqlCommand pCommand)
        {
            GetRecords(pDataTable, pCommand, false);
        }

        public void GetRecords(System.Data.DataTable pDataTable, System.Data.SqlClient.SqlCommand pCommand, bool ignoreSchema, LoadOption? pLoadOption)
        {
            OpenConnection();
            pCommand.Connection = mConnection;
            SqlDataAdapter da = new SqlDataAdapter(pCommand);
            if (mIsTransactional)
            {
                da.SelectCommand.Transaction = mTransaction;
            }
            try
            {
                if (!ignoreSchema && !String.IsNullOrEmpty(pDataTable.TableName) && pDataTable.TableName != "Table1")
                    da.MissingSchemaAction = MissingSchemaAction.Error;

                if (pLoadOption.HasValue)
                    da.FillLoadOption = pLoadOption.Value;

                da.Fill(pDataTable);
                if (pDataTable.TableName == "")
                    pDataTable.TableName = "Table1";
            }
            catch (Exception ex)
            {
                if (pCommand != null) ex.Data.Add("SQL", pCommand.CommandText);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void GetRecords(System.Data.DataTable pDataTable, System.Data.SqlClient.SqlCommand pCommand, bool ignoreSchema)
        {
            GetRecords(pDataTable, pCommand, ignoreSchema, null);
        }

        public void Update(System.Data.DataTable pDataTable)
        {
            Update(pDataTable, true, false);
        }


        public void Update(DataTable pDataTable, bool pAcceptChangesDuringUpdate, bool pContinueUpdateonError)
        {
            OpenConnection();
            try
            {
                CDataSetMetaData oMeta = GetDatasetMetadata(pDataTable);

                if (oMeta == null)
                    throw new NotSupportedException("Standart datatable, diger update metodunu kullan.");

                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand(oMeta.insertCommand, mConnection);
                da.InsertCommand.UpdatedRowSource = UpdateRowSource.Both;
                foreach (SqlParameter p in oMeta.insertParameterList)
                {
                    da.InsertCommand.Parameters.Add((SqlParameter)((ICloneable)p).Clone());
                }
                da.UpdateCommand = new SqlCommand(oMeta.updateCommand, mConnection);
                foreach (SqlParameter p in oMeta.updateParameterList)
                {
                    da.UpdateCommand.Parameters.Add((SqlParameter)((ICloneable)p).Clone());
                }

                da.DeleteCommand = new SqlCommand(oMeta.deleteCommand, mConnection);
                foreach (SqlParameter p in oMeta.deleteParameterList)
                {
                    da.DeleteCommand.Parameters.Add((SqlParameter)((ICloneable)p).Clone());
                }

                if (mIsTransactional)
                {
                    da.InsertCommand.Transaction = mTransaction;
                    da.UpdateCommand.Transaction = mTransaction;
                    da.DeleteCommand.Transaction = mTransaction;
                }

                da.ContinueUpdateOnError = pContinueUpdateonError;
                da.AcceptChangesDuringUpdate = pAcceptChangesDuringUpdate;
                da.Update(pDataTable);

            }
            catch (Exception ex)
            {
                if (pDataTable != null)
                    if (ex.Data["SQL"] == null)
                        ex.Data.Add("SQL", pDataTable.TableName + " guncellenirken");
                throw ex;
            }
            finally
            {
                CloseConnection();
            }

        }

        private string GetIdentityColumnName(DataTable pDataTable)
        {

            List<string> mColNames = (from DataColumn o in pDataTable.Columns
                                      where o.AutoIncrement == true
                                      select o.ColumnName).ToList();
            if (mColNames.Count == 0)
                return string.Empty;
            else
                return mColNames[0];
        }


        public void Update(System.Data.DataTable pDataTable, System.Data.SqlClient.SqlCommand pCommand)
        {

            OpenConnection();
            pCommand.Connection = mConnection;
            SqlDataAdapter da = new SqlDataAdapter(pCommand);
            SqlDataAdapter daIdent = new SqlDataAdapter(pCommand);
            if (mIsTransactional)
            {
                da.SelectCommand.Transaction = mTransaction;
            }
            try
            {
                SqlCommandBuilder mCommandBuilder = new SqlCommandBuilder(da);
                string sIdentityColumnName = GetIdentityColumnName(pDataTable);
                SqlCommand mInsertCommand = mCommandBuilder.GetInsertCommand();
                if (sIdentityColumnName != string.Empty)
                {
                    mInsertCommand.CommandText += ";" + pCommand.CommandText + " WHERE " + sIdentityColumnName + " = SCOPE_IDENTITY();";
                }
                mInsertCommand.UpdatedRowSource = UpdateRowSource.Both;
                daIdent.InsertCommand = mInsertCommand;
                daIdent.UpdateCommand = mCommandBuilder.GetUpdateCommand();
                daIdent.DeleteCommand = mCommandBuilder.GetDeleteCommand();
                daIdent.Update(pDataTable);
            }
            catch (Exception ex)
            {
                if (pDataTable != null)
                    if (ex.Data["SQL"] == null) ex.Data.Add("SQL", pDataTable.TableName + " guncellenirken");
                throw ex;
            }
            finally
            {
                CloseConnection();
            }

        }

        public object ExecuteScalar(System.Data.SqlClient.SqlCommand pCommand)
        {
            OpenConnection();
            pCommand.Connection = mConnection;
            SqlDataAdapter da = new SqlDataAdapter(pCommand);
            if (mIsTransactional)
            {
                pCommand.Transaction = mTransaction;
            }
            try
            {
                object oReturn = pCommand.ExecuteScalar();
                return oReturn;
            }
            catch (Exception ex)
            {
                if (pCommand != null) ex.Data.Add("SQL", pCommand.CommandText);
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        #endregion
    }
}
