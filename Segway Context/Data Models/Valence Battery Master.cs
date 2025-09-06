namespace SpenSoft.EF.Segway
{
    /// <summary>Public Class - Valence_Battery_Master</summary>
    public partial class Valence_Battery_Master //: NHibernateBase
    {
        //public static ToStringOverrideDelegate ToStringHandler = null;


        public Valence_Battery_Master() { }

        public Valence_Battery_Master(Valence_Battery_Master db)
        {
            Copy(db);
        }


		public override String ToString()
		{
            //if (ToStringHandler != null) return ToStringHandler(this);

			return String.Format("{0}", Rec_ID);
		}


    }
}

