using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace Segway.EF.SegwayCntxt;

[Serializable]
[DataContract]
[Table("Manufacturing_Component_Events")]
/// <summary>Public Class - Manufacturing_Component_Events</summary>
public partial class Manufacturing_Component_Events //: NHibernateBase
{
    /// <summary>Property - ID</summary>
    [DataMember]
    [Column("ID")]
    [DataObjectField(true, false, false)]
    public virtual Guid ID { get; set; }

    private String?_Parent_Serial;
    /// <summary>Property - Parent_Serial</summary>
    [DataMember]
    [Column("Parent_Serial")]
    [DataObjectField(false, false, false, 20)]
    public virtual String?Parent_Serial
    {
        get { return _Parent_Serial; }
        set
        {
            _Parent_Serial = value;
            if ((String.IsNullOrEmpty(_Parent_Serial) == false) && (_Parent_Serial.Length > 20)) _Parent_Serial = _Parent_Serial.Substring(0, 20);
        }
    }

    private String?_Event_Type;
    /// <summary>Property - Event_Type</summary>
    [DataMember]
    [Column("Event_Type")]
    [DataObjectField(false, false, true, 40)]
    public virtual String?Event_Type
    {
        get { return _Event_Type; }
        set
        {
            _Event_Type = value;
            if ((String.IsNullOrEmpty(_Event_Type) == false) && (_Event_Type.Length > 40)) _Event_Type = _Event_Type.Substring(0, 40);
        }
    }

    private String?_Event_Status;
    /// <summary>Property - Event_Status</summary>
    [DataMember]
    [Column("Event_Status")]
    [DataObjectField(false, false, true, 20)]
    public virtual String?Event_Status
    {
        get { return _Event_Status; }
        set
        {
            _Event_Status = value;
            if ((String.IsNullOrEmpty(_Event_Status) == false) && (_Event_Status.Length > 20)) _Event_Status = _Event_Status.Substring(0, 20);
        }
    }

    private String?_Event_Data;
    /// <summary>Property - Event_Data</summary>
    [DataMember]
    [Column("Event_Data")]
    [DataObjectField(false, false, true, 200)]
    public virtual String?Event_Data
    {
        get { return _Event_Data; }
        set
        {
            _Event_Data = value;
            if ((String.IsNullOrEmpty(_Event_Data) == false) && (_Event_Data.Length > 200)) _Event_Data = _Event_Data.Substring(0, 200);
        }
    }

    private String?_Location;
    /// <summary>Property - Location</summary>
    [DataMember]
    [Column("Location")]
    [DataObjectField(false, false, true, 20)]
    public virtual String?Location
    {
        get { return _Location; }
        set
        {
            _Location = value;
            if ((String.IsNullOrEmpty(_Location) == false) && (_Location.Length > 20)) _Location = _Location.Substring(0, 20);
        }
    }

    /// <summary>Property - Date_Time_Created</summary>
    [DataMember]
    [Column("Date_Time_Created")]
    [DataObjectField(false, false, false)]
    public virtual DateTime Date_Time_Created { get; set; }

    /// <summary>Property - Date_Time_Removed</summary>
    [DataMember]
    [Column("Date_Time_Removed")]
    [DataObjectField(false, false, true)]
    public virtual DateTime? Date_Time_Removed { get; set; }

    private String?_Created_By;
    /// <summary>Property - Created_By</summary>
    [DataMember]
    [Column("Created_By")]
    [DataObjectField(false, false, true, 50)]
    public virtual String?Created_By
    {
        get { return _Created_By; }
        set
        {
            _Created_By = value;
            if ((String.IsNullOrEmpty(_Created_By) == false) && (_Created_By.Length > 50)) _Created_By = _Created_By.Substring(0, 50);
        }
    }

    private String?_Removed_By;
    /// <summary>Property - Removed_By</summary>
    [DataMember]
    [Column("Removed_By")]
    [DataObjectField(false, false, true, 50)]
    public virtual String?Removed_By
    {
        get { return _Removed_By; }
        set
        {
            _Removed_By = value;
            if ((String.IsNullOrEmpty(_Removed_By) == false) && (_Removed_By.Length > 50)) _Removed_By = _Removed_By.Substring(0, 50);
        }
    }

    private String?_Site;
    /// <summary>Property - Site</summary>
    [DataMember]
    [Column("Site")]
    [DataObjectField(false, false, true, 5)]
    public virtual String?Site
    {
        get { return _Site; }
        set
        {
            _Site = value;
            if ((String.IsNullOrEmpty(_Site) == false) && (_Site.Length > 5)) _Site = _Site.Substring(0, 5);
        }
    }

    private String?_Work_Order;
    /// <summary>Property - Work_Order</summary>
    [DataMember]
    [Column("Work_Order")]
    [DataObjectField(false, false, true, 50)]
    public virtual String?Work_Order
    {
        get { return _Work_Order; }
        set
        {
            _Work_Order = value;
            if ((String.IsNullOrEmpty(_Work_Order) == false) && (_Work_Order.Length > 50)) _Work_Order = _Work_Order.Substring(0, 50);
        }
    }



    /// <summary>Public Method - Copies the contents of an instance of type: Manufacturing_Component_Events into this instance</summary>
    /// <param name="copy">Manufacturing_Component_Events - instance to copy</param>
    /// <param name="copyID">Boolean - indicates whether to copy the key field</param>
    public virtual void Copy(Manufacturing_Component_Events copy, Boolean copyID = false)
    {
        if (copy != null)
        {
            if (copyID == true) this.ID = copy.ID;
            this.Parent_Serial = copy.Parent_Serial;
            this.Event_Type = copy.Event_Type;
            this.Event_Status = copy.Event_Status;
            this.Event_Data = copy.Event_Data;
            this.Location = copy.Location;
            this.Date_Time_Created = copy.Date_Time_Created;
            this.Date_Time_Removed = copy.Date_Time_Removed;
            this.Created_By = copy.Created_By;
            this.Removed_By = copy.Removed_By;
            this.Site = copy.Site;
            this.Work_Order = copy.Work_Order;

            // base.Copy((NHibernateBase)copy);
        }
    }

    /// <summary>Public Method - Returns a new copied instance of type: Manufacturing_Component_Events</summary>
    /// <param name="copyID">Boolean - indicates whether to copy the key field</param>
    /// <returns>Manufacturing_Component_Events - copied instance</returns>
    public virtual Manufacturing_Component_Events Copy(Boolean copyID = false)
    {
        Manufacturing_Component_Events copy = new Manufacturing_Component_Events();
        copy.Copy(this, copyID);
        return copy;
    }

    /// <summary>Public Method - Updates the contents of an instance of type: Manufacturing_Component_Events into this instance</summary>
    /// <param name="rec">Manufacturing_Component_Events - instance to update from</param>
    public virtual void Update(Manufacturing_Component_Events rec)
    {
        if (rec != null)
        {
            if (String.IsNullOrEmpty(rec.Parent_Serial) == false) this.Parent_Serial = rec.Parent_Serial;
            if (String.IsNullOrEmpty(rec.Event_Type) == false) this.Event_Type = rec.Event_Type;
            if (String.IsNullOrEmpty(rec.Event_Status) == false) this.Event_Status = rec.Event_Status;
            if (String.IsNullOrEmpty(rec.Event_Data) == false) this.Event_Data = rec.Event_Data;
            if (String.IsNullOrEmpty(rec.Location) == false) this.Location = rec.Location;
            this.Date_Time_Created = rec.Date_Time_Created;
            if (rec.Date_Time_Removed != null) this.Date_Time_Removed = rec.Date_Time_Removed;
            if (String.IsNullOrEmpty(rec.Created_By) == false) this.Created_By = rec.Created_By;
            if (String.IsNullOrEmpty(rec.Removed_By) == false) this.Removed_By = rec.Removed_By;
            if (String.IsNullOrEmpty(rec.Site) == false) this.Site = rec.Site;
            if (String.IsNullOrEmpty(rec.Work_Order) == false) this.Work_Order = rec.Work_Order;

            // base.Update((NHibernateBase)rec);
        }
    }


    /// <summary>Operator - Determines if two Manufacturing_Component_Events objects are equal</summary>
    /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
    /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
    /// <param name="compareID">Boolean - determines whether to compare the ID member</param>
    /// <returns>Boolean - True=Equal; False=Not Equal</returns>
    public static Boolean Compare(Manufacturing_Component_Events lhs, Manufacturing_Component_Events rhs, Boolean compareID = false)
    {
        if ((((Object)lhs) == null) && (((Object)rhs) == null)) return true;
        if ((((Object)lhs) != null) && (((Object)rhs) == null)) return false;
        if ((((Object)lhs) == null) && (((Object)rhs) != null)) return false;


        if (compareID == true)
        {
            if (lhs.ID != rhs.ID) return false;
        }

        if (lhs.Parent_Serial != rhs.Parent_Serial)
        {
            if ((String.IsNullOrEmpty(lhs.Parent_Serial) == false) && (String.IsNullOrEmpty(rhs.Parent_Serial) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Parent_Serial) != String.IsNullOrEmpty(rhs.Parent_Serial)) return false;
        }

        if (lhs.Event_Type != rhs.Event_Type)
        {
            if ((String.IsNullOrEmpty(lhs.Event_Type) == false) && (String.IsNullOrEmpty(rhs.Event_Type) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Event_Type) != String.IsNullOrEmpty(rhs.Event_Type)) return false;
        }

        if (lhs.Event_Status != rhs.Event_Status)
        {
            if ((String.IsNullOrEmpty(lhs.Event_Status) == false) && (String.IsNullOrEmpty(rhs.Event_Status) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Event_Status) != String.IsNullOrEmpty(rhs.Event_Status)) return false;
        }

        if (lhs.Event_Data != rhs.Event_Data)
        {
            if ((String.IsNullOrEmpty(lhs.Event_Data) == false) && (String.IsNullOrEmpty(rhs.Event_Data) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Event_Data) != String.IsNullOrEmpty(rhs.Event_Data)) return false;
        }

        if (lhs.Location != rhs.Location)
        {
            if ((String.IsNullOrEmpty(lhs.Location) == false) && (String.IsNullOrEmpty(rhs.Location) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Location) != String.IsNullOrEmpty(rhs.Location)) return false;
        }

        if (lhs.Date_Time_Created != rhs.Date_Time_Created) return false;

        if ((lhs.Date_Time_Removed != null) && (rhs.Date_Time_Removed != null))
        {
            if (lhs.Date_Time_Removed.Value != rhs.Date_Time_Removed.Value) return false;
        }
        else if ((lhs.Date_Time_Removed == null) != (rhs.Date_Time_Removed == null)) return false;

        if (lhs.Created_By != rhs.Created_By)
        {
            if ((String.IsNullOrEmpty(lhs.Created_By) == false) && (String.IsNullOrEmpty(rhs.Created_By) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Created_By) != String.IsNullOrEmpty(rhs.Created_By)) return false;
        }

        if (lhs.Removed_By != rhs.Removed_By)
        {
            if ((String.IsNullOrEmpty(lhs.Removed_By) == false) && (String.IsNullOrEmpty(rhs.Removed_By) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Removed_By) != String.IsNullOrEmpty(rhs.Removed_By)) return false;
        }

        if (lhs.Site != rhs.Site)
        {
            if ((String.IsNullOrEmpty(lhs.Site) == false) && (String.IsNullOrEmpty(rhs.Site) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Site) != String.IsNullOrEmpty(rhs.Site)) return false;
        }

        if (lhs.Work_Order != rhs.Work_Order)
        {
            if ((String.IsNullOrEmpty(lhs.Work_Order) == false) && (String.IsNullOrEmpty(rhs.Work_Order) == false)) return false;
            if (String.IsNullOrEmpty(lhs.Work_Order) != String.IsNullOrEmpty(rhs.Work_Order)) return false;
        }

        return true;
    }


    /// <summary>Operator - Determines if two Manufacturing_Component_Events objects are equal</summary>
    /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
    /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
    /// <returns>Boolean - True=Equal; False=Not Equal</returns>
    public static Boolean operator ==(Manufacturing_Component_Events lhs, Manufacturing_Component_Events rhs)
    {
        return Compare(lhs, rhs, true);
    }

    /// <summary>Operator - Determines if two Manufacturing_Component_Events objects are not equal</summary>
    /// <param name="lhs">Service_Users - object on the left hand side of the operator</param>
    /// <param name="rhs">Service_Users - object on the right hand side of the operator</param>
    /// <returns>Boolean - True=Not Equal; False=Equal</returns>
    public static Boolean operator !=(Manufacturing_Component_Events lhs, Manufacturing_Component_Events rhs)
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
    public override Boolean Equals(object obj)
    {
        return base.Equals(obj);
    }
}
