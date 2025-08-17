using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;



namespace Segway.EF.SegwayCntxt;

[Table("Manufacturing_Components")]
public partial class Manufacturing_Components
{
    /// <summary>Property - ID</summary>
    [DataMember]
    [Column("ID")]
    [DataObjectField(true, false, false)]
    public virtual Guid ID { get; set; }

    private String? _Component;
    /// <summary>Property - Serial_Number</summary>
    [DataMember]
    [Column("SERIAL_NUMBER")]
    [DataObjectField(false, false, false, 20)]
    public virtual String? Component
    {
        get { return _Component; }
        set
        {
            _Component = value;
            if ((String.IsNullOrEmpty(_Component) == false) && (_Component.Length > 20)) _Component = _Component.Substring(0, 20);
        }
    }
}