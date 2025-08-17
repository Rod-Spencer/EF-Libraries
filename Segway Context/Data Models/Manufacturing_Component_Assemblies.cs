using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Segway.EF.SegwayCntxt;

[Table("Manufacturing_Component_Assemblies")]
public partial class Manufacturing_Component_Assemblies
{
    /// <summary>Property - ID</summary>
    [DataMember]
    [Column("ID")]
    [DataObjectField(true, false, false)]
    public virtual Guid ID { get; set; }

    private String? _Parent_Serial;
    /// <summary>Property - Parent_Serial</summary>
    [DataMember]
    [Column("PARENT_SERIAL")]
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

    private String? _Child_Serial;
    /// <summary>Property - Child_Serial</summary>
    [DataMember]
    [Column("CHILD_SERIAL")]
    [DataObjectField(false, false, false, 20)]
    public virtual String? Child_Serial
    {
        get { return _Child_Serial; }
        set
        {
            _Child_Serial = value;
            if ((String.IsNullOrEmpty(_Child_Serial) == false) && (_Child_Serial.Length > 20)) _Child_Serial = _Child_Serial.Substring(0, 20);
        }
    }

    private String? _Part_Type;
    /// <summary>Property - Part_Type</summary>
    [DataMember]
    [Column("PART_TYPE")]
    [DataObjectField(false, false, true, 20)]
    public virtual String? Part_Type
    {
        get { return _Part_Type; }
        set
        {
            _Part_Type = value;
            if ((String.IsNullOrEmpty(_Part_Type) == false) && (_Part_Type.Length > 20)) _Part_Type = _Part_Type.Substring(0, 20);
        }
    }

    private String? _Position;
    /// <summary>Property - Position</summary>
    [DataMember]
    [Column("POSITION")]
    [DataObjectField(false, false, true, 20)]
    public virtual String? Position
    {
        get { return _Position; }
        set
        {
            _Position = value;
            if ((String.IsNullOrEmpty(_Position) == false) && (_Position.Length > 20)) _Position = _Position.Substring(0, 20);
        }
    }

    /// <summary>Property - Date_Time_Created</summary>
    [DataMember]
    [Column("DATE_TIME_CREATED")]
    [DataObjectField(false, false, false)]
    public virtual DateTime? Date_Time_Created { get; set; }

    /// <summary>Property - Date_Time_Removed</summary>
    [DataMember]
    [Column("DATE_TIME_REMOVED")]
    [DataObjectField(false, false, true)]
    public virtual DateTime? Date_Time_Removed { get; set; }

    private String? _Created_By;
    /// <summary>Property - Created_By</summary>
    [DataMember]
    [Column("CREATED_BY")]
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
    [Column("REMOVED_BY")]
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
    [Column("SITE")]
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
    [Column("WORK_ORDER")]
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
