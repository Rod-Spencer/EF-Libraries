using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SpenSoft.EF.Segway;

[Serializable]
[DataContract]
[Table("Manufacturing_Component_Data")]
/// <summary>Public Class - Manufacturing_Component_Data</summary>
public partial class Manufacturing_Component_Data //: NHibernateBase
{
    /// <summary>Property - ID</summary>
    [DataMember]
    [Column("ID")]
    [DataObjectField(true, false, false)]
    public virtual Guid ID { get; set; }

    private String? _Parent_Serial;
    /// <summary>Property - Parent_Serial</summary>
    [DataMember]
    [Column("Parent_Serial")]
    [DataObjectField(false, false, false, 20)]
    public virtual String? Parent_Serial
    {
        get { return _Parent_Serial; }
        set
        {
            _Parent_Serial = value;
            if ((String.IsNullOrEmpty(_Parent_Serial) == false) && (_Parent_Serial.Length > 20)) _Parent_Serial = _Parent_Serial.Substring(0, 20);
        }
    }

    private String? _Data_Type;
    /// <summary>Property - Data_Type</summary>
    [DataMember]
    [Column("Data_Type")]
    [DataObjectField(false, false, true, 40)]
    public virtual String? Data_Type
    {
        get { return _Data_Type; }
        set
        {
            _Data_Type = value;
            if ((String.IsNullOrEmpty(_Data_Type) == false) && (_Data_Type.Length > 40)) _Data_Type = _Data_Type.Substring(0, 40);
        }
    }

    private String? _Data;
    /// <summary>Property - Data</summary>
    [DataMember]
    [Column("Data")]
    [DataObjectField(false, false, true, 200)]
    public virtual String? Data
    {
        get { return _Data; }
        set
        {
            _Data = value;
            if ((String.IsNullOrEmpty(_Data) == false) && (_Data.Length > 200)) _Data = _Data.Substring(0, 200);
        }
    }

    private String? _Location;
    /// <summary>Property - Location</summary>
    [DataMember]
    [Column("Location")]
    [DataObjectField(false, false, true, 20)]
    public virtual String? Location
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

    private String? _Created_By;
    /// <summary>Property - Created_By</summary>
    [DataMember]
    [Column("Created_By")]
    [DataObjectField(false, false, true, 50)]
    public virtual String? Created_By
    {
        get { return _Created_By; }
        set
        {
            _Created_By = value;
            if ((String.IsNullOrEmpty(_Created_By) == false) && (_Created_By.Length > 50)) _Created_By = _Created_By.Substring(0, 50);
        }
    }

    private String? _Removed_By;
    /// <summary>Property - Removed_By</summary>
    [DataMember]
    [Column("Removed_By")]
    [DataObjectField(false, false, true, 50)]
    public virtual String? Removed_By
    {
        get { return _Removed_By; }
        set
        {
            _Removed_By = value;
            if ((String.IsNullOrEmpty(_Removed_By) == false) && (_Removed_By.Length > 50)) _Removed_By = _Removed_By.Substring(0, 50);
        }
    }

    private String? _Site;
    /// <summary>Property - Site</summary>
    [DataMember]
    [Column("Site")]
    [DataObjectField(false, false, true, 5)]
    public virtual String? Site
    {
        get { return _Site; }
        set
        {
            _Site = value;
            if ((String.IsNullOrEmpty(_Site) == false) && (_Site.Length > 5)) _Site = _Site.Substring(0, 5);
        }
    }

    private String? _Work_Order;
    /// <summary>Property - Work_Order</summary>
    [DataMember]
    [Column("Work_Order")]
    [DataObjectField(false, false, true, 50)]
    public virtual String? Work_Order
    {
        get { return _Work_Order; }
        set
        {
            _Work_Order = value;
            if ((String.IsNullOrEmpty(_Work_Order) == false) && (_Work_Order.Length > 50)) _Work_Order = _Work_Order.Substring(0, 50);
        }
    }

}
