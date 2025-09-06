using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SpenSoft.EF.Segway;

[Table("Manufacturing_Component_Serialized")]
public partial class Manufacturing_Component_Serialized
{
    /// <summary>Property - ID</summary>
    [DataMember]
    [Column("ID")]
    [DataObjectField(true, false, false)]
    public virtual Guid ID { get; set; }

    private String? _Serial_Number;
    /// <summary>Property - Serial_Number</summary>
    [DataMember]
    [Column("SERIAL_NUMBER")]
    [DataObjectField(false, false, false, 20)]
    public virtual String? Serial_Number
    {
        get { return _Serial_Number; }
        set
        {
            _Serial_Number = value;
            if ((String.IsNullOrEmpty(_Serial_Number) == false) && (_Serial_Number.Length > 20)) _Serial_Number = _Serial_Number.Substring(0, 20);
        }
    }

    private String? _Model_Name;
    /// <summary>Property - Model_Name</summary>
    [DataMember]
    [Column("MODEL_NAME")]
    [DataObjectField(false, false, true, 20)]
    public virtual String? Model_Name
    {
        get { return _Model_Name; }
        set
        {
            _Model_Name = value;
            if ((String.IsNullOrEmpty(_Model_Name) == false) && (_Model_Name.Length > 20)) _Model_Name = _Model_Name.Substring(0, 20);
        }
    }

    private String? _Part_Number;
    /// <summary>Property - Part_Number</summary>
    [DataMember]
    [Column("PART_NUMBER")]
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

    /// <summary>Property - Date_Time_Created</summary>
    [DataMember]
    [Column("DATE_TIME_CREATED")]
    [DataObjectField(false, false, true)]
    public virtual DateTime? Date_Time_Created { get; set; }

    /// <summary>Property - Date_Time_Removed</summary>
    [DataMember]
    [Column("DATE_TIME_REMOVED")]
    [DataObjectField(false, false, true)]
    public virtual DateTime? Date_Time_Removed { get; set; }

    private String? _Status;
    /// <summary>Property - Status</summary>
    [DataMember]
    [Column("STATUS")]
    [DataObjectField(false, false, true, 10)]
    public virtual String? Status
    {
        get { return _Status; }
        set
        {
            _Status = value;
            if ((String.IsNullOrEmpty(_Status) == false) && (_Status.Length > 10)) _Status = _Status.Substring(0, 10);
        }
    }

    /// <summary>Property - Active</summary>
    [DataMember]
    [Column("ACTIVE")]
    [DataObjectField(false, false, true)]
    public virtual Boolean? Active { get; set; }

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

}
