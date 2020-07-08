using HospitalAPI.Models.Entities;
using Microsoft.Data.SqlClient;

namespace HospitalAPI.Models.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private HospitalDBContext _db;

        public PatientRepository(HospitalDBContext db)
        {
            _db = db;
        }

        public void Truncate()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=185.159.152.62;initial catalog=pmwebsit_HospitalDB;user id=pmwebsit_HospitalAdmin;password=s_J8bl87;multipleactiveresultsets=True;application name=EntityFramework&quot;");
                con.Open();
                string query = "TRUNCATE TABLE " + "pmwebsit_HospitalDB.Patient";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
