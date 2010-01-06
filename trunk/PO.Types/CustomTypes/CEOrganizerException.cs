using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PO.Types.Enumerations;

namespace PO.Types.CustomTypes
{
    [Serializable ()]
    public class CEOrganizerException
    {
        private EnumExceptionType mExType;
        private string mErrorMessage;
        private string mErrorCode;
        private string mInnerExceptionString;

        public EnumExceptionType ExType
        {
            get { return mExType; }
            set { mExType = value; }
        }

        public string ErrorMessage
        {
            get { return mErrorMessage ; }
            set { mErrorMessage  = value; }
        }
        
        public string ErrorCode
        {
            get { return mErrorCode ; }
            set { mErrorCode = value; }
        }

        public string InnerExceptionString
        {
            get { return mInnerExceptionString; }
            set { mInnerExceptionString = value; }
        }

        public CEOrganizerException()
        {
            this.mExType = EnumExceptionType.SystemException;
            this.mErrorMessage = "Hata Oluştu";
            this.mErrorCode = "SistemHatası";
            this.mInnerExceptionString = ""; 
        }
        public CEOrganizerException(EnumExceptionType pExType, string perrMessage, string pErrCode)
        {
            this.mExType = pExType ;
            this.mErrorMessage = perrMessage ;
            this.mErrorCode = pErrCode ;
            this.mInnerExceptionString = "";
        }


    }
}
