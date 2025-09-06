using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SpenSoft.EF.Segway;

[Table("PT_US_Cities")]
public partial class PT_US_Cities
{
    /// <summary>Property - Rec_ID</summary>
    [DataMember]
    [DataObjectField(true, false, false)]
    [Column("REC_ID")]
    public virtual int Rec_ID { get; set; }

    private String? _Postal_Zip_Code;
    /// <summary>Property - Postal_Zip_Code</summary>
    [DataMember]
    [Column("POSTAL_ZIP_CODE")]
    [DataObjectField(false, false, true, 20)]
    public virtual String? Postal_Zip_Code
    {
        get { return _Postal_Zip_Code; }
        set
        {
            _Postal_Zip_Code = value;
            if ((String.IsNullOrEmpty(_Postal_Zip_Code) == false) && (_Postal_Zip_Code.Length > 20)) _Postal_Zip_Code = _Postal_Zip_Code.Substring(0, 20);
        }
    }

    private String? _Postal_State_Code;
    /// <summary>Property - Postal_State_Code</summary>
    [DataMember]
    [Column("POSTAL_STATE_CODE")]
    [DataObjectField(false, false, true, 5)]
    public virtual String? Postal_State_Code
    {
        get { return _Postal_State_Code; }
        set
        {
            _Postal_State_Code = value;
            if ((String.IsNullOrEmpty(_Postal_State_Code) == false) && (_Postal_State_Code.Length > 5)) _Postal_State_Code = _Postal_State_Code.Substring(0, 5);
        }
    }

    /// <summary>Property - Latitude</summary>
    [DataMember]
    [Column("LATITUDE")]
    [DataObjectField(false, false, true)]
    public virtual Double? Latitude { get; set; }

    /// <summary>Property - Longitude</summary>
    [DataMember]
    [Column("LONGITUDE")]
    [DataObjectField(false, false, true)]
    public virtual Double? Longitude { get; set; }

    private String? _City_Name;
    /// <summary>Property - City_Name</summary>
    [DataMember]
    [Column("CITY_NAME")]
    [DataObjectField(false, false, true, 100)]
    public virtual String? City_Name
    {
        get { return _City_Name; }
        set
        {
            _City_Name = value;
            if ((String.IsNullOrEmpty(_City_Name) == false) && (_City_Name.Length > 100)) _City_Name = _City_Name.Substring(0, 100);
        }
    }

    private String? _State_Name;
    /// <summary>Property - State_Name</summary>
    [DataMember]
    [Column("STATE_NAME")]
    [DataObjectField(false, false, true, 100)]
    public virtual String? State_Name
    {
        get { return _State_Name; }
        set
        {
            _State_Name = value;
            if ((String.IsNullOrEmpty(_State_Name) == false) && (_State_Name.Length > 100)) _State_Name = _State_Name.Substring(0, 100);
        }
    }
}
