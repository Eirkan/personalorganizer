namespace PO.Types.DataSets {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(false)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("NewDataSet")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class EVENTDataSet : global::System.Data.DataSet {
        
        private EVENTDataTable tableEVENT;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public EVENTDataSet() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected EVENTDataSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["EVENT"] != null)) {
                    base.Tables.Add(new EVENTDataTable(ds.Tables["EVENT"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public EVENTDataTable EVENT {
            get {
                return this.tableEVENT;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            EVENTDataSet cln = ((EVENTDataSet)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["EVENT"] != null)) {
                    base.Tables.Add(new EVENTDataTable(ds.Tables["EVENT"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableEVENT = ((EVENTDataTable)(base.Tables["EVENT"]));
            if ((initTable == true)) {
                if ((this.tableEVENT != null)) {
                    this.tableEVENT.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "EVENTDataSet";
            this.Prefix = "";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableEVENT = new EVENTDataTable();
            base.Tables.Add(this.tableEVENT);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeEVENT() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            EVENTDataSet ds = new EVENTDataSet();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        public delegate void EVENTRowChangeEventHandler(object sender, EVENTRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        [PO.Types.Attributes.FullTableName("PersonelOrganizerDb.dbo.EVENT")]
        [PO.Types.Attributes.AutoIncColName("")]
        public partial class EVENTDataTable : global::System.Data.TypedTableBase<EVENTRow> {
            
            private global::System.Data.DataColumn columnEventID;
            
            private global::System.Data.DataColumn columnUserID;
            
            private global::System.Data.DataColumn columnSubject;
            
            private global::System.Data.DataColumn columnLocation;
            
            private global::System.Data.DataColumn columnStartDateTime;
            
            private global::System.Data.DataColumn columnEndDateTime;
            
            private global::System.Data.DataColumn columnDuration;
            
            private global::System.Data.DataColumn columnNote;
            
            private global::System.Data.DataColumn columnFrequency;
            
            private global::System.Data.DataColumn columnNumberOfOccurence;
            
            // KB- Bu custom member TypedDataSetGen tool'u tarafindan eklendi.
            public const string TableSchemaName = "dbo";
            
            // KB- Bu custom member TypedDataSetGen tool'u tarafindan eklendi.
            public const string DbName = "PersonelOrganizerDb";
            
            // KB- Bu custom member TypedDataSetGen tool'u tarafindan eklendi.
            public const string TableFullName = "PersonelOrganizerDb.dbo.EVENT";
            
            // KB- Bu custom member TypedDataSetGen tool'u tarafindan eklendi.
            public const string AutoIncrementColumnName = "";
            
            // KB- Bu custom member TypedDataSetGen tool'u tarafindan eklendi.
            public const bool HasAutoIncrementColumn = false;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTDataTable() {
                this.TableName = "EVENT";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal EVENTDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected EVENTDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn EventIDColumn {
                get {
                    return this.columnEventID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn UserIDColumn {
                get {
                    return this.columnUserID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn SubjectColumn {
                get {
                    return this.columnSubject;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn LocationColumn {
                get {
                    return this.columnLocation;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn StartDateTimeColumn {
                get {
                    return this.columnStartDateTime;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn EndDateTimeColumn {
                get {
                    return this.columnEndDateTime;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn DurationColumn {
                get {
                    return this.columnDuration;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn NoteColumn {
                get {
                    return this.columnNote;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn FrequencyColumn {
                get {
                    return this.columnFrequency;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn NumberOfOccurenceColumn {
                get {
                    return this.columnNumberOfOccurence;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRow this[int index] {
                get {
                    return ((EVENTRow)(this.Rows[index]));
                }
            }
            
            public event EVENTRowChangeEventHandler EVENTRowChanging;
            
            public event EVENTRowChangeEventHandler EVENTRowChanged;
            
            public event EVENTRowChangeEventHandler EVENTRowDeleting;
            
            public event EVENTRowChangeEventHandler EVENTRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddEVENTRow(EVENTRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRow AddEVENTRow(System.Guid EventID, System.Guid UserID, string Subject, string Location, System.DateTime StartDateTime, System.DateTime EndDateTime, int Duration, string Note, int Frequency, int NumberOfOccurence) {
                EVENTRow rowEVENTRow = ((EVENTRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        EventID,
                        UserID,
                        Subject,
                        Location,
                        StartDateTime,
                        EndDateTime,
                        Duration,
                        Note,
                        Frequency,
                        NumberOfOccurence};
                rowEVENTRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowEVENTRow);
                return rowEVENTRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRow FindByEventID(System.Guid EventID) {
                return ((EVENTRow)(this.Rows.Find(new object[] {
                            EventID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                EVENTDataTable cln = ((EVENTDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new EVENTDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnEventID = base.Columns["EventID"];
                this.columnUserID = base.Columns["UserID"];
                this.columnSubject = base.Columns["Subject"];
                this.columnLocation = base.Columns["Location"];
                this.columnStartDateTime = base.Columns["StartDateTime"];
                this.columnEndDateTime = base.Columns["EndDateTime"];
                this.columnDuration = base.Columns["Duration"];
                this.columnNote = base.Columns["Note"];
                this.columnFrequency = base.Columns["Frequency"];
                this.columnNumberOfOccurence = base.Columns["NumberOfOccurence"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnEventID = new global::System.Data.DataColumn("EventID", typeof(global::System.Guid), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEventID);
                this.columnUserID = new global::System.Data.DataColumn("UserID", typeof(global::System.Guid), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnUserID);
                this.columnSubject = new global::System.Data.DataColumn("Subject", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSubject);
                this.columnLocation = new global::System.Data.DataColumn("Location", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLocation);
                this.columnStartDateTime = new global::System.Data.DataColumn("StartDateTime", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnStartDateTime);
                this.columnEndDateTime = new global::System.Data.DataColumn("EndDateTime", typeof(global::System.DateTime), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEndDateTime);
                this.columnDuration = new global::System.Data.DataColumn("Duration", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDuration);
                this.columnNote = new global::System.Data.DataColumn("Note", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnNote);
                this.columnFrequency = new global::System.Data.DataColumn("Frequency", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFrequency);
                this.columnNumberOfOccurence = new global::System.Data.DataColumn("NumberOfOccurence", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnNumberOfOccurence);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnEventID}, true));
                this.columnEventID.AllowDBNull = false;
                this.columnEventID.Unique = true;
                this.columnUserID.AllowDBNull = false;
                this.columnSubject.MaxLength = 200;
                this.columnLocation.MaxLength = 100;
                this.columnNote.MaxLength = 500;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRow NewEVENTRow() {
                return ((EVENTRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new EVENTRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(EVENTRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EVENTRowChanged != null)) {
                    this.EVENTRowChanged(this, new EVENTRowChangeEvent(((EVENTRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EVENTRowChanging != null)) {
                    this.EVENTRowChanging(this, new EVENTRowChangeEvent(((EVENTRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EVENTRowDeleted != null)) {
                    this.EVENTRowDeleted(this, new EVENTRowChangeEvent(((EVENTRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EVENTRowDeleting != null)) {
                    this.EVENTRowDeleting(this, new EVENTRowChangeEvent(((EVENTRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveEVENTRow(EVENTRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                EVENTDataSet ds = new EVENTDataSet();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "EVENTDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class EVENTRow : global::System.Data.DataRow {
            
            private EVENTDataTable tableEVENT;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal EVENTRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableEVENT = ((EVENTDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Guid EventID {
                get {
                    return ((global::System.Guid)(this[this.tableEVENT.EventIDColumn]));
                }
                set {
                    this[this.tableEVENT.EventIDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.Guid UserID {
                get {
                    return ((global::System.Guid)(this[this.tableEVENT.UserIDColumn]));
                }
                set {
                    this[this.tableEVENT.UserIDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string Subject {
                get {
                    try {
                        return ((string)(this[this.tableEVENT.SubjectColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Subject\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.SubjectColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string Location {
                get {
                    try {
                        return ((string)(this[this.tableEVENT.LocationColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Location\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.LocationColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime StartDateTime {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableEVENT.StartDateTimeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'StartDateTime\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.StartDateTimeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public System.DateTime EndDateTime {
                get {
                    try {
                        return ((global::System.DateTime)(this[this.tableEVENT.EndDateTimeColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'EndDateTime\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.EndDateTimeColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Duration {
                get {
                    try {
                        return ((int)(this[this.tableEVENT.DurationColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Duration\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.DurationColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string Note {
                get {
                    try {
                        return ((string)(this[this.tableEVENT.NoteColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Note\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.NoteColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int Frequency {
                get {
                    try {
                        return ((int)(this[this.tableEVENT.FrequencyColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Frequency\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.FrequencyColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public int NumberOfOccurence {
                get {
                    try {
                        return ((int)(this[this.tableEVENT.NumberOfOccurenceColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'NumberOfOccurence\' in table \'EVENT\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEVENT.NumberOfOccurenceColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsSubjectNull() {
                return this.IsNull(this.tableEVENT.SubjectColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetSubjectNull() {
                this[this.tableEVENT.SubjectColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsLocationNull() {
                return this.IsNull(this.tableEVENT.LocationColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetLocationNull() {
                this[this.tableEVENT.LocationColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsStartDateTimeNull() {
                return this.IsNull(this.tableEVENT.StartDateTimeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetStartDateTimeNull() {
                this[this.tableEVENT.StartDateTimeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsEndDateTimeNull() {
                return this.IsNull(this.tableEVENT.EndDateTimeColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetEndDateTimeNull() {
                this[this.tableEVENT.EndDateTimeColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsDurationNull() {
                return this.IsNull(this.tableEVENT.DurationColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetDurationNull() {
                this[this.tableEVENT.DurationColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsNoteNull() {
                return this.IsNull(this.tableEVENT.NoteColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetNoteNull() {
                this[this.tableEVENT.NoteColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsFrequencyNull() {
                return this.IsNull(this.tableEVENT.FrequencyColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetFrequencyNull() {
                this[this.tableEVENT.FrequencyColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsNumberOfOccurenceNull() {
                return this.IsNull(this.tableEVENT.NumberOfOccurenceColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetNumberOfOccurenceNull() {
                this[this.tableEVENT.NumberOfOccurenceColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class EVENTRowChangeEvent : global::System.EventArgs {
            
            private EVENTRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRowChangeEvent(EVENTRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public EVENTRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
