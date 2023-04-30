using IST440WGroup4.Pages.Dashboard;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static IST440WGroup4.Pages.Dashboard.IndexModel;

namespace IST440WGroup4.Pages.Details
{
    public class IndexModel : PageModel
    {
        public List<PatientInfo> listPatients = new List<PatientInfo>();
        public void OnGet()
        {

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=GPHDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Patient";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientInfo patientInfo = new PatientInfo();
                            patientInfo.PatientID = "" + reader.GetInt32(0);
                            patientInfo.medicalRecordNumber = "" + reader.GetInt32(1);
                            patientInfo.firstName = reader.GetString(2);
                            patientInfo.lastName = reader.GetString(3);
                            patientInfo.dateOfBirth = reader.GetString(4);
                            patientInfo.dateOfAdmission = reader.GetString(5);
                            patientInfo.location = reader.GetString(7);
                            patientInfo.careTeam = "" + reader.GetInt32(8);
                            patientInfo.diagnosis = reader.GetString(9);
                            patientInfo.admittingClinicianID = "" + reader.GetInt32(10);
                            patientInfo.attendingClinicianID = "" + reader.GetInt32(11);
                            patientInfo.hospitalWing = reader.GetString(12);
                            patientInfo.roomNumber = reader.GetString(13);
                            patientInfo.respiratoryRPM = reader.GetInt32(14);
                            patientInfo.heartRate = reader.GetInt32(15);
                            patientInfo.systolicBP = reader.GetInt32(16);
                            patientInfo.apvuScore = reader.GetString(17);
                            patientInfo.temperature = reader.GetInt32(18);

                            listPatients.Add(patientInfo);


                        }
                    }
                }
                
            }

        }

    }
}
