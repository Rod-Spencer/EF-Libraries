using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;


namespace Segway.EF.SegwayCntxt
{
    [Serializable]
    [DataContract]
    /// <summary>Public Class - Valence_Battery_Master</summary>
    public partial class Valence_Battery_Master //: NHibernateBase
    {
        /// <summary>Property - Rec_ID</summary>
        [DataMember]
        [DataObjectField(true, false, false)]
        public virtual int Rec_ID { get; set; }

        /// <summary>Property - Date_Time_Created</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual DateTime Date_Time_Created { get; set; }

        /// <summary>Property - Date_Time_Updated</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Date_Time_Updated { get; set; }

        /// <summary>Property - Valence_Manufacture_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Valence_Manufacture_Date { get; set; }

        private String? _Valence_Number;
        /// <summary>Property - Valence_Number</summary>
        [DataMember]
        [DataObjectField(false, false, true, 10)]
        public virtual String? Valence_Number
        {
            get { return _Valence_Number; }
            set
            {
                _Valence_Number = value;
                if ((String.IsNullOrEmpty(_Valence_Number) == false) && (_Valence_Number.Length > 10)) _Valence_Number = _Valence_Number.Substring(0, 10);
            }
        }

        private String? _Battery_Serial_Number;
        /// <summary>Property - Battery_Serial_Number</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Battery_Serial_Number
        {
            get { return _Battery_Serial_Number; }
            set
            {
                _Battery_Serial_Number = value;
                if ((String.IsNullOrEmpty(_Battery_Serial_Number) == false) && (_Battery_Serial_Number.Length > 20)) _Battery_Serial_Number = _Battery_Serial_Number.Substring(0, 20);
            }
        }

        private String? _Part_Number;
        /// <summary>Property - Part_Number</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Part_Number
        {
            get { return _Part_Number; }
            set
            {
                _Part_Number = value;
                if ((String.IsNullOrEmpty(_Part_Number) == false) && (_Part_Number.Length > 20)) _Part_Number = _Part_Number.Substring(0, 20);
            }
        }

        /// <summary>Property - Valence_Ship_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Valence_Ship_Date { get; set; }

        private String? _Valence_File_Name;
        /// <summary>Property - Valence_File_Name</summary>
        [DataMember]
        [DataObjectField(false, false, true, 200)]
        public virtual String? Valence_File_Name
        {
            get { return _Valence_File_Name; }
            set
            {
                _Valence_File_Name = value;
                if ((String.IsNullOrEmpty(_Valence_File_Name) == false) && (_Valence_File_Name.Length > 200)) _Valence_File_Name = _Valence_File_Name.Substring(0, 200);
            }
        }

        private String? _Customer_Name;
        /// <summary>Property - Customer_Name</summary>
        [DataMember]
        [DataObjectField(false, false, true, 100)]
        public virtual String? Customer_Name
        {
            get { return _Customer_Name; }
            set
            {
                _Customer_Name = value;
                if ((String.IsNullOrEmpty(_Customer_Name) == false) && (_Customer_Name.Length > 100)) _Customer_Name = _Customer_Name.Substring(0, 100);
            }
        }

        /// <summary>Property - Under_Warranty_YN</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual Char? Under_Warranty_YN { get; set; }

        /// <summary>Property - Failure_Notification_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Failure_Notification_Date { get; set; }

        private String? _Failure_Reason;
        /// <summary>Property - Failure_Reason</summary>
        [DataMember]
        [DataObjectField(false, false, true, 100)]
        public virtual String? Failure_Reason
        {
            get { return _Failure_Reason; }
            set
            {
                _Failure_Reason = value;
                if ((String.IsNullOrEmpty(_Failure_Reason) == false) && (_Failure_Reason.Length > 100)) _Failure_Reason = _Failure_Reason.Substring(0, 100);
            }
        }

        private String? _Failure_Notes;
        /// <summary>Property - Failure_Notes</summary>
        [DataMember]
        [DataObjectField(false, false, true, 100)]
        public virtual String? Failure_Notes
        {
            get { return _Failure_Notes; }
            set
            {
                _Failure_Notes = value;
                if ((String.IsNullOrEmpty(_Failure_Notes) == false) && (_Failure_Notes.Length > 100)) _Failure_Notes = _Failure_Notes.Substring(0, 100);
            }
        }

        private String? _Service_Request_Number;
        /// <summary>Property - Service_Request_Number</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Service_Request_Number
        {
            get { return _Service_Request_Number; }
            set
            {
                _Service_Request_Number = value;
                if ((String.IsNullOrEmpty(_Service_Request_Number) == false) && (_Service_Request_Number.Length > 20)) _Service_Request_Number = _Service_Request_Number.Substring(0, 20);
            }
        }

        private String? _Failure_User;
        /// <summary>Property - Failure_User</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Failure_User
        {
            get { return _Failure_User; }
            set
            {
                _Failure_User = value;
                if ((String.IsNullOrEmpty(_Failure_User) == false) && (_Failure_User.Length > 20)) _Failure_User = _Failure_User.Substring(0, 20);
            }
        }

        /// <summary>Property - Receipt_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Receipt_Date { get; set; }

        private String? _Receipt_Location;
        /// <summary>Property - Receipt_Location</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Receipt_Location
        {
            get { return _Receipt_Location; }
            set
            {
                _Receipt_Location = value;
                if ((String.IsNullOrEmpty(_Receipt_Location) == false) && (_Receipt_Location.Length > 20)) _Receipt_Location = _Receipt_Location.Substring(0, 20);
            }
        }

        private String? _Receipt_Notes;
        /// <summary>Property - Receipt_Notes</summary>
        [DataMember]
        [DataObjectField(false, false, true, 100)]
        public virtual String? Receipt_Notes
        {
            get { return _Receipt_Notes; }
            set
            {
                _Receipt_Notes = value;
                if ((String.IsNullOrEmpty(_Receipt_Notes) == false) && (_Receipt_Notes.Length > 100)) _Receipt_Notes = _Receipt_Notes.Substring(0, 100);
            }
        }

        private String? _Receipt_User;
        /// <summary>Property - Receipt_User</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Receipt_User
        {
            get { return _Receipt_User; }
            set
            {
                _Receipt_User = value;
                if ((String.IsNullOrEmpty(_Receipt_User) == false) && (_Receipt_User.Length > 20)) _Receipt_User = _Receipt_User.Substring(0, 20);
            }
        }

        /// <summary>Property - RMA_Request_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? RMA_Request_Date { get; set; }

        private String? _RMA_Request_User;
        /// <summary>Property - RMA_Request_User</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? RMA_Request_User
        {
            get { return _RMA_Request_User; }
            set
            {
                _RMA_Request_User = value;
                if ((String.IsNullOrEmpty(_RMA_Request_User) == false) && (_RMA_Request_User.Length > 20)) _RMA_Request_User = _RMA_Request_User.Substring(0, 20);
            }
        }

        /// <summary>Property - NCM_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? NCM_Date { get; set; }

        private String? _Valence_RMA_Number;
        /// <summary>Property - Valence_RMA_Number</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Valence_RMA_Number
        {
            get { return _Valence_RMA_Number; }
            set
            {
                _Valence_RMA_Number = value;
                if ((String.IsNullOrEmpty(_Valence_RMA_Number) == false) && (_Valence_RMA_Number.Length > 20)) _Valence_RMA_Number = _Valence_RMA_Number.Substring(0, 20);
            }
        }

        /// <summary>Property - Valence_RMA_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Valence_RMA_Date { get; set; }

        private String? _Failure_Battery_Location;
        /// <summary>Property - Failure_Battery_Location</summary>
        [DataMember]
        [DataObjectField(false, false, true, 64)]
        public virtual String? Failure_Battery_Location
        {
            get { return _Failure_Battery_Location; }
            set
            {
                _Failure_Battery_Location = value;
                if ((String.IsNullOrEmpty(_Failure_Battery_Location) == false) && (_Failure_Battery_Location.Length > 64)) _Failure_Battery_Location = _Failure_Battery_Location.Substring(0, 64);
            }
        }

        /// <summary>Property - Warranty_End_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Warranty_End_Date { get; set; }

        private String? _Seg_Lot_ID;
        /// <summary>Property - Seg_Lot_ID</summary>
        [DataMember]
        [DataObjectField(false, false, true, 20)]
        public virtual String? Seg_Lot_ID
        {
            get { return _Seg_Lot_ID; }
            set
            {
                _Seg_Lot_ID = value;
                if ((String.IsNullOrEmpty(_Seg_Lot_ID) == false) && (_Seg_Lot_ID.Length > 20)) _Seg_Lot_ID = _Seg_Lot_ID.Substring(0, 20);
            }
        }

        /// <summary>Property - Seg_Ship_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Seg_Ship_Date { get; set; }

        /// <summary>Property - Seg_Warr_Months</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual int Seg_Warr_Months { get; set; }

        /// <summary>Property - Seg_Warr_End_Date</summary>
        [DataMember]
        [DataObjectField(false, false, true)]
        public virtual DateTime? Seg_Warr_End_Date { get; set; }

        private String? _Created_By;
        /// <summary>Property - Created_By</summary>
        [DataMember]
        [DataObjectField(false, false, false, 30)]
        public virtual String? Created_By
        {
            get { return _Created_By; }
            set
            {
                _Created_By = value;
                if ((String.IsNullOrEmpty(_Created_By) == false) && (_Created_By.Length > 30)) _Created_By = _Created_By.Substring(0, 30);
            }
        }

        private String? _Updated_By;
        /// <summary>Property - Updated_By</summary>
        [DataMember]
        [DataObjectField(false, false, false, 30)]
        public virtual String? Updated_By
        {
            get { return _Updated_By; }
            set
            {
                _Updated_By = value;
                if ((String.IsNullOrEmpty(_Updated_By) == false) && (_Updated_By.Length > 30)) _Updated_By = _Updated_By.Substring(0, 30);
            }
        }

        /// <summary>Property - Create_Date</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual DateTime Create_Date { get; set; }

        /// <summary>Property - Record_Date</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual DateTime Record_Date { get; set; }

        /// <summary>Property - RowPointer</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual Guid RowPointer { get; set; }

        /// <summary>Property - Note_Exists_Flag</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual Byte Note_Exists_Flag { get; set; }

        /// <summary>Property - In_Workflow</summary>
        [DataMember]
        [DataObjectField(false, false, false)]
        public virtual Byte In_Workflow { get; set; }



        /// <summary>Public Method - Copies the contents of an instance of type: Valence_Battery_Master into this instance</summary>
        /// <param name="copy">Valence_Battery_Master - instance to copy</param>
        /// <param name="copyID">Boolean - indicates whether to copy the key field</param>
        public virtual void Copy(Valence_Battery_Master? copy, Boolean copyID = false)
        {
            if (copy != null)
            {
                if (copyID == true) this.Rec_ID = copy.Rec_ID;
                this.Date_Time_Created = copy.Date_Time_Created;
                this.Date_Time_Updated = copy.Date_Time_Updated;
                this.Valence_Manufacture_Date = copy.Valence_Manufacture_Date;
                this.Valence_Number = copy.Valence_Number;
                this.Battery_Serial_Number = copy.Battery_Serial_Number;
                this.Part_Number = copy.Part_Number;
                this.Valence_Ship_Date = copy.Valence_Ship_Date;
                this.Valence_File_Name = copy.Valence_File_Name;
                this.Customer_Name = copy.Customer_Name;
                this.Under_Warranty_YN = copy.Under_Warranty_YN;
                this.Failure_Notification_Date = copy.Failure_Notification_Date;
                this.Failure_Reason = copy.Failure_Reason;
                this.Failure_Notes = copy.Failure_Notes;
                this.Service_Request_Number = copy.Service_Request_Number;
                this.Failure_User = copy.Failure_User;
                this.Receipt_Date = copy.Receipt_Date;
                this.Receipt_Location = copy.Receipt_Location;
                this.Receipt_Notes = copy.Receipt_Notes;
                this.Receipt_User = copy.Receipt_User;
                this.RMA_Request_Date = copy.RMA_Request_Date;
                this.RMA_Request_User = copy.RMA_Request_User;
                this.NCM_Date = copy.NCM_Date;
                this.Valence_RMA_Number = copy.Valence_RMA_Number;
                this.Valence_RMA_Date = copy.Valence_RMA_Date;
                this.Failure_Battery_Location = copy.Failure_Battery_Location;
                this.Warranty_End_Date = copy.Warranty_End_Date;
                this.Seg_Lot_ID = copy.Seg_Lot_ID;
                this.Seg_Ship_Date = copy.Seg_Ship_Date;
                this.Seg_Warr_Months = copy.Seg_Warr_Months;
                this.Seg_Warr_End_Date = copy.Seg_Warr_End_Date;
                this.Created_By = copy.Created_By;
                this.Updated_By = copy.Updated_By;
                this.Create_Date = copy.Create_Date;
                this.Record_Date = copy.Record_Date;
                this.RowPointer = copy.RowPointer;
                this.Note_Exists_Flag = copy.Note_Exists_Flag;
                this.In_Workflow = copy.In_Workflow;
            }
        }

        /// <summary>Public Method - Returns a new copied instance of type: Valence_Battery_Master</summary>
        /// <param name="copyID">Boolean - indicates whether to copy the key field</param>
        /// <returns>Valence_Battery_Master - copied instance</returns>
        public virtual Valence_Battery_Master Copy(Boolean copyID = false)
        {
            Valence_Battery_Master copy = new Valence_Battery_Master();
            copy.Copy(this, copyID);
            return copy;
        }

        /// <summary>Public Method - Updates the contents of an instance of type: Valence_Battery_Master into this instance</summary>
        /// <param name="rec">Valence_Battery_Master - instance to update from</param>
        public virtual void Update(Valence_Battery_Master? rec)
        {
            if (rec != null)
            {
                this.Date_Time_Created = rec.Date_Time_Created;
                if (rec.Date_Time_Updated != null) this.Date_Time_Updated = rec.Date_Time_Updated;
                if (rec.Valence_Manufacture_Date != null) this.Valence_Manufacture_Date = rec.Valence_Manufacture_Date;
                if (String.IsNullOrEmpty(rec.Valence_Number) == false) this.Valence_Number = rec.Valence_Number;
                if (String.IsNullOrEmpty(rec.Battery_Serial_Number) == false) this.Battery_Serial_Number = rec.Battery_Serial_Number;
                if (String.IsNullOrEmpty(rec.Part_Number) == false) this.Part_Number = rec.Part_Number;
                if (rec.Valence_Ship_Date != null) this.Valence_Ship_Date = rec.Valence_Ship_Date;
                if (String.IsNullOrEmpty(rec.Valence_File_Name) == false) this.Valence_File_Name = rec.Valence_File_Name;
                if (String.IsNullOrEmpty(rec.Customer_Name) == false) this.Customer_Name = rec.Customer_Name;
                if (rec.Under_Warranty_YN != null) this.Under_Warranty_YN = rec.Under_Warranty_YN;
                if (rec.Failure_Notification_Date != null) this.Failure_Notification_Date = rec.Failure_Notification_Date;
                if (String.IsNullOrEmpty(rec.Failure_Reason) == false) this.Failure_Reason = rec.Failure_Reason;
                if (String.IsNullOrEmpty(rec.Failure_Notes) == false) this.Failure_Notes = rec.Failure_Notes;
                if (String.IsNullOrEmpty(rec.Service_Request_Number) == false) this.Service_Request_Number = rec.Service_Request_Number;
                if (String.IsNullOrEmpty(rec.Failure_User) == false) this.Failure_User = rec.Failure_User;
                if (rec.Receipt_Date != null) this.Receipt_Date = rec.Receipt_Date;
                if (String.IsNullOrEmpty(rec.Receipt_Location) == false) this.Receipt_Location = rec.Receipt_Location;
                if (String.IsNullOrEmpty(rec.Receipt_Notes) == false) this.Receipt_Notes = rec.Receipt_Notes;
                if (String.IsNullOrEmpty(rec.Receipt_User) == false) this.Receipt_User = rec.Receipt_User;
                if (rec.RMA_Request_Date != null) this.RMA_Request_Date = rec.RMA_Request_Date;
                if (String.IsNullOrEmpty(rec.RMA_Request_User) == false) this.RMA_Request_User = rec.RMA_Request_User;
                if (rec.NCM_Date != null) this.NCM_Date = rec.NCM_Date;
                if (String.IsNullOrEmpty(rec.Valence_RMA_Number) == false) this.Valence_RMA_Number = rec.Valence_RMA_Number;
                if (rec.Valence_RMA_Date != null) this.Valence_RMA_Date = rec.Valence_RMA_Date;
                if (String.IsNullOrEmpty(rec.Failure_Battery_Location) == false) this.Failure_Battery_Location = rec.Failure_Battery_Location;
                if (rec.Warranty_End_Date != null) this.Warranty_End_Date = rec.Warranty_End_Date;
                if (String.IsNullOrEmpty(rec.Seg_Lot_ID) == false) this.Seg_Lot_ID = rec.Seg_Lot_ID;
                if (rec.Seg_Ship_Date != null) this.Seg_Ship_Date = rec.Seg_Ship_Date;
                this.Seg_Warr_Months = rec.Seg_Warr_Months;
                if (rec.Seg_Warr_End_Date != null) this.Seg_Warr_End_Date = rec.Seg_Warr_End_Date;
                if (String.IsNullOrEmpty(rec.Created_By) == false) this.Created_By = rec.Created_By;
                if (String.IsNullOrEmpty(rec.Updated_By) == false) this.Updated_By = rec.Updated_By;
                this.Create_Date = rec.Create_Date;
                this.Record_Date = rec.Record_Date;
                this.RowPointer = rec.RowPointer;
                this.Note_Exists_Flag = rec.Note_Exists_Flag;
                this.In_Workflow = rec.In_Workflow;

                // base.Update((NHibernateBase)rec);
            }
        }


        /// <summary>Operator - Determines if two Valence_Battery_Master objects are equal</summary>
        /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
        /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
        /// <param name="compareID">Boolean - determines whether to compare the ID member</param>
        /// <returns>Boolean - True=Equal; False=Not Equal</returns>
        public static Boolean Compare(Valence_Battery_Master? lhs, Valence_Battery_Master? rhs, Boolean compareID = false)
        {
            if ((((Object?)lhs) == null) && (((Object?)rhs) == null)) return true;
            if ((((Object?)lhs) != null) && (((Object?)rhs) == null)) return false;
            if ((((Object?)lhs) == null) && (((Object?)rhs) != null)) return false;


            if (compareID == true)
            {
                if (lhs?.Rec_ID != rhs?.Rec_ID) return false;
            }

            if (lhs?.Date_Time_Created != rhs?.Date_Time_Created) return false;

            if ((lhs?.Date_Time_Updated != null) && (rhs?.Date_Time_Updated != null))
            {
                if (lhs?.Date_Time_Updated.Value != rhs?.Date_Time_Updated.Value) return false;
            }
            else if ((lhs?.Date_Time_Updated == null) != (rhs?.Date_Time_Updated == null)) return false;

            if ((lhs?.Valence_Manufacture_Date != null) && (rhs?.Valence_Manufacture_Date != null))
            {
                if (lhs?.Valence_Manufacture_Date.Value != rhs?.Valence_Manufacture_Date.Value) return false;
            }
            else if ((lhs?.Valence_Manufacture_Date == null) != (rhs?.Valence_Manufacture_Date == null)) return false;

            if (lhs?.Valence_Number != rhs?.Valence_Number)
            {
                if ((String.IsNullOrEmpty(lhs?.Valence_Number) == false) && (String.IsNullOrEmpty(rhs?.Valence_Number) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Valence_Number) != String.IsNullOrEmpty(rhs?.Valence_Number)) return false;
            }

            if (lhs?.Battery_Serial_Number != rhs?.Battery_Serial_Number)
            {
                if ((String.IsNullOrEmpty(lhs?.Battery_Serial_Number) == false) && (String.IsNullOrEmpty(rhs?.Battery_Serial_Number) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Battery_Serial_Number) != String.IsNullOrEmpty(rhs?.Battery_Serial_Number)) return false;
            }

            if (lhs?.Part_Number != rhs?.Part_Number)
            {
                if ((String.IsNullOrEmpty(lhs?.Part_Number) == false) && (String.IsNullOrEmpty(rhs?.Part_Number) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Part_Number) != String.IsNullOrEmpty(rhs?.Part_Number)) return false;
            }

            if ((lhs?.Valence_Ship_Date != null) && (rhs?.Valence_Ship_Date != null))
            {
                if (lhs?.Valence_Ship_Date.Value != rhs?.Valence_Ship_Date.Value) return false;
            }
            else if ((lhs?.Valence_Ship_Date == null) != (rhs?.Valence_Ship_Date == null)) return false;

            if (lhs?.Valence_File_Name != rhs?.Valence_File_Name)
            {
                if ((String.IsNullOrEmpty(lhs?.Valence_File_Name) == false) && (String.IsNullOrEmpty(rhs?.Valence_File_Name) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Valence_File_Name) != String.IsNullOrEmpty(rhs?.Valence_File_Name)) return false;
            }

            if (lhs?.Customer_Name != rhs?.Customer_Name)
            {
                if ((String.IsNullOrEmpty(lhs?.Customer_Name) == false) && (String.IsNullOrEmpty(rhs?.Customer_Name) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Customer_Name) != String.IsNullOrEmpty(rhs?.Customer_Name)) return false;
            }

            if ((lhs?.Under_Warranty_YN != null) && (rhs?.Under_Warranty_YN != null))
            {
                if (lhs?.Under_Warranty_YN.Value != rhs?.Under_Warranty_YN.Value) return false;
            }
            else if ((lhs?.Under_Warranty_YN == null) != (rhs?.Under_Warranty_YN == null)) return false;

            if ((lhs?.Failure_Notification_Date != null) && (rhs?.Failure_Notification_Date != null))
            {
                if (lhs?.Failure_Notification_Date.Value != rhs?.Failure_Notification_Date.Value) return false;
            }
            else if ((lhs?.Failure_Notification_Date == null) != (rhs?.Failure_Notification_Date == null)) return false;

            if (lhs?.Failure_Reason != rhs?.Failure_Reason)
            {
                if ((String.IsNullOrEmpty(lhs?.Failure_Reason) == false) && (String.IsNullOrEmpty(rhs?.Failure_Reason) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Failure_Reason) != String.IsNullOrEmpty(rhs?.Failure_Reason)) return false;
            }

            if (lhs?.Failure_Notes != rhs?.Failure_Notes)
            {
                if ((String.IsNullOrEmpty(lhs?.Failure_Notes) == false) && (String.IsNullOrEmpty(rhs?.Failure_Notes) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Failure_Notes) != String.IsNullOrEmpty(rhs?.Failure_Notes)) return false;
            }

            if (lhs?.Service_Request_Number != rhs?.Service_Request_Number)
            {
                if ((String.IsNullOrEmpty(lhs?.Service_Request_Number) == false) && (String.IsNullOrEmpty(rhs?.Service_Request_Number) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Service_Request_Number) != String.IsNullOrEmpty(rhs?.Service_Request_Number)) return false;
            }

            if (lhs?.Failure_User != rhs?.Failure_User)
            {
                if ((String.IsNullOrEmpty(lhs?.Failure_User) == false) && (String.IsNullOrEmpty(rhs?.Failure_User) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Failure_User) != String.IsNullOrEmpty(rhs?.Failure_User)) return false;
            }

            if ((lhs?.Receipt_Date != null) && (rhs?.Receipt_Date != null))
            {
                if (lhs?.Receipt_Date.Value != rhs?.Receipt_Date.Value) return false;
            }
            else if ((lhs?.Receipt_Date == null) != (rhs?.Receipt_Date == null)) return false;

            if (lhs?.Receipt_Location != rhs?.Receipt_Location)
            {
                if ((String.IsNullOrEmpty(lhs?.Receipt_Location) == false) && (String.IsNullOrEmpty(rhs?.Receipt_Location) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Receipt_Location) != String.IsNullOrEmpty(rhs?.Receipt_Location)) return false;
            }

            if (lhs?.Receipt_Notes != rhs?.Receipt_Notes)
            {
                if ((String.IsNullOrEmpty(lhs?.Receipt_Notes) == false) && (String.IsNullOrEmpty(rhs?.Receipt_Notes) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Receipt_Notes) != String.IsNullOrEmpty(rhs?.Receipt_Notes)) return false;
            }

            if (lhs?.Receipt_User != rhs?.Receipt_User)
            {
                if ((String.IsNullOrEmpty(lhs?.Receipt_User) == false) && (String.IsNullOrEmpty(rhs?.Receipt_User) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Receipt_User) != String.IsNullOrEmpty(rhs?.Receipt_User)) return false;
            }

            if ((lhs?.RMA_Request_Date != null) && (rhs?.RMA_Request_Date != null))
            {
                if (lhs?.RMA_Request_Date.Value != rhs?.RMA_Request_Date.Value) return false;
            }
            else if ((lhs?.RMA_Request_Date == null) != (rhs?.RMA_Request_Date == null)) return false;

            if (lhs?.RMA_Request_User != rhs?.RMA_Request_User)
            {
                if ((String.IsNullOrEmpty(lhs?.RMA_Request_User) == false) && (String.IsNullOrEmpty(rhs?.RMA_Request_User) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.RMA_Request_User) != String.IsNullOrEmpty(rhs?.RMA_Request_User)) return false;
            }

            if ((lhs?.NCM_Date != null) && (rhs?.NCM_Date != null))
            {
                if (lhs?.NCM_Date.Value != rhs?.NCM_Date.Value) return false;
            }
            else if ((lhs?.NCM_Date == null) != (rhs?.NCM_Date == null)) return false;

            if (lhs?.Valence_RMA_Number != rhs?.Valence_RMA_Number)
            {
                if ((String.IsNullOrEmpty(lhs?.Valence_RMA_Number) == false) && (String.IsNullOrEmpty(rhs?.Valence_RMA_Number) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Valence_RMA_Number) != String.IsNullOrEmpty(rhs?.Valence_RMA_Number)) return false;
            }

            if ((lhs?.Valence_RMA_Date != null) && (rhs?.Valence_RMA_Date != null))
            {
                if (lhs?.Valence_RMA_Date.Value != rhs?.Valence_RMA_Date.Value) return false;
            }
            else if ((lhs?.Valence_RMA_Date == null) != (rhs?.Valence_RMA_Date == null)) return false;

            if (lhs?.Failure_Battery_Location != rhs?.Failure_Battery_Location)
            {
                if ((String.IsNullOrEmpty(lhs?.Failure_Battery_Location) == false) && (String.IsNullOrEmpty(rhs?.Failure_Battery_Location) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Failure_Battery_Location) != String.IsNullOrEmpty(rhs?.Failure_Battery_Location)) return false;
            }

            if ((lhs?.Warranty_End_Date != null) && (rhs?.Warranty_End_Date != null))
            {
                if (lhs?.Warranty_End_Date.Value != rhs?.Warranty_End_Date.Value) return false;
            }
            else if ((lhs?.Warranty_End_Date == null) != (rhs?.Warranty_End_Date == null)) return false;

            if (lhs?.Seg_Lot_ID != rhs?.Seg_Lot_ID)
            {
                if ((String.IsNullOrEmpty(lhs?.Seg_Lot_ID) == false) && (String.IsNullOrEmpty(rhs?.Seg_Lot_ID) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Seg_Lot_ID) != String.IsNullOrEmpty(rhs?.Seg_Lot_ID)) return false;
            }

            if ((lhs?.Seg_Ship_Date != null) && (rhs?.Seg_Ship_Date != null))
            {
                if (lhs?.Seg_Ship_Date.Value != rhs?.Seg_Ship_Date.Value) return false;
            }
            else if ((lhs?.Seg_Ship_Date == null) != (rhs?.Seg_Ship_Date == null)) return false;

            if (lhs?.Seg_Warr_Months != rhs?.Seg_Warr_Months) return false;

            if ((lhs?.Seg_Warr_End_Date != null) && (rhs?.Seg_Warr_End_Date != null))
            {
                if (lhs?.Seg_Warr_End_Date.Value != rhs?.Seg_Warr_End_Date.Value) return false;
            }
            else if ((lhs?.Seg_Warr_End_Date == null) != (rhs?.Seg_Warr_End_Date == null)) return false;

            if (lhs?.Created_By != rhs?.Created_By)
            {
                if ((String.IsNullOrEmpty(lhs?.Created_By) == false) && (String.IsNullOrEmpty(rhs?.Created_By) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Created_By) != String.IsNullOrEmpty(rhs?.Created_By)) return false;
            }

            if (lhs?.Updated_By != rhs?.Updated_By)
            {
                if ((String.IsNullOrEmpty(lhs?.Updated_By) == false) && (String.IsNullOrEmpty(rhs?.Updated_By) == false)) return false;
                if (String.IsNullOrEmpty(lhs?.Updated_By) != String.IsNullOrEmpty(rhs?.Updated_By)) return false;
            }

            if (lhs?.Create_Date != rhs?.Create_Date) return false;

            if (lhs?.Record_Date != rhs?.Record_Date) return false;

            if (lhs?.RowPointer != rhs?.RowPointer) return false;

            if (lhs?.Note_Exists_Flag != rhs?.Note_Exists_Flag) return false;

            if (lhs?.In_Workflow != rhs?.In_Workflow) return false;

            return true;
        }


        /// <summary>Operator - Determines if two Valence_Battery_Master objects are equal</summary>
        /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
        /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
        /// <returns>Boolean - True=Equal; False=Not Equal</returns>
        public static Boolean operator ==(Valence_Battery_Master lhs, Valence_Battery_Master rhs)
        {
            return Compare(lhs, rhs, true);
        }

        /// <summary>Operator - Determines if two Valence_Battery_Master objects are not equal</summary>
        /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
        /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
        /// <returns>Boolean - True=Not Equal; False=Equal</returns>
        public static Boolean operator !=(Valence_Battery_Master lhs, Valence_Battery_Master rhs)
        {
            return !(lhs == rhs);
        }

        /// <summary>Override Method - Returns a hash code</summary>
        /// <returns>int - Hash code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>Override Method - Determines if object is equal</summary>
        /// <returns>Boolean</returns>
        public override Boolean Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
