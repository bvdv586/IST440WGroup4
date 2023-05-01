using Azure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection;

namespace IST440WGroup4.Pages.Dashboard
{
    public class IndexModel : PageModel
    {

        public List<ClinicianInfo> listClinicians = new List<ClinicianInfo>();
        public List<PatientInfo> listPatients = new List<PatientInfo>();


        public void OnGet()
        {

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=GPHDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM Clinicians";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClinicianInfo clinicianInfo = new ClinicianInfo();
                            clinicianInfo.clinicianID = "" + reader.GetInt32(0);
                            clinicianInfo.employeeNumber = "" + reader.GetInt32(1);
                            clinicianInfo.firstName = reader.GetString(2);
                            clinicianInfo.lastName = reader.GetString(3);
                            clinicianInfo.physicianID = "" + reader.GetInt32(4);
                            clinicianInfo.email = reader.GetString(5);
                            clinicianInfo.phoneNumber = reader.GetString(6);

                            listClinicians.Add(clinicianInfo);
                        }
                    }
                }
            }

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
                            patientInfo.PatientID = reader.GetInt32(0);
                            patientInfo.medicalRecordNumber = reader.GetInt32(1);
                            patientInfo.firstName = reader.GetString(2);
                            patientInfo.lastName = reader.GetString(3);
                            patientInfo.dateOfBirth = reader.GetString(4);
                            patientInfo.dateOfAdmission = reader.GetString(5);
                            patientInfo.location = reader.GetString(7);
                            patientInfo.careTeam = reader.GetInt32(8);
                            patientInfo.diagnosis = reader.GetString(9);
                            patientInfo.admittingClinicianID = reader.GetInt32(10);
                            patientInfo.attendingClinicianID = reader.GetInt32(11);
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

            foreach (var patient in listPatients)
            {
                if (patient.respiratoryRPM < 9)
                {
                    patient.mewsScore += 2;
                }
                else if (patient.respiratoryRPM >= 9 && patient.respiratoryRPM <= 14)
                {
                    patient.mewsScore += 0;
                }
                else if (patient.respiratoryRPM >= 15 && patient.respiratoryRPM <= 20)
                {
                    patient.mewsScore += 1;
                }
                else if (patient.respiratoryRPM >= 21 && patient.respiratoryRPM <= 29)
                {
                    patient.mewsScore += 2;
                }
                else if (patient.respiratoryRPM >= 30)
                {
                    patient.mewsScore += 3;
                }
                if (patient.heartRate <= 40)
                {
                    patient.mewsScore += 2;
                }
                else if (patient.heartRate >= 41 && patient.heartRate <= 50)
                {
                    patient.mewsScore += 1;
                }
                else if (patient.heartRate >= 51 && patient.heartRate <= 100)
                {
                    patient.mewsScore += 0;
                }
                else if (patient.heartRate >= 101 && patient.heartRate <= 110)
                {
                    patient.mewsScore += 1;
                }
                else if (patient.heartRate >= 111 && patient.heartRate <= 129)
                {
                    patient.mewsScore += 2;
                }
                else if (patient.heartRate >= 130)
                {
                    patient.mewsScore += 3;
                }
                if (patient.systolicBP <= 70)
                {
                    patient.mewsScore += 3;
                }
                else if (patient.systolicBP >= 71 && patient.systolicBP <= 80)
                {
                    patient.mewsScore += 2;
                }
                else if (patient.systolicBP >= 81 && patient.systolicBP <= 100)
                {
                    patient.mewsScore += 1;
                }
                else if (patient.systolicBP >= 101 && patient.systolicBP <= 199)
                {
                    patient.mewsScore += 0;
                }
                else if (patient.systolicBP >= 200)
                {
                    patient.mewsScore += 2;
                }
                if (patient.apvuScore.Contains("ALERT"))
                {
                    patient.mewsScore += 0;
                }
                else if (patient.apvuScore.Contains("PAIN"))
                {
                    patient.mewsScore += 2;
                }
                else if (patient.apvuScore.Contains("VOICE"))
                {
                    patient.mewsScore += 1;
                }
                else if (patient.apvuScore.Contains("UNRESPONSIVE"))
                {
                    patient.mewsScore += 3;
                }
                else if (patient.apvuScore.Contains("AGITATED"))
                {
                    patient.mewsScore += 1;
                }
                if (patient.temperature == 35)
                {
                    patient.mewsScore += 0;
                }
                if (patient.mewsScore <= 1)
                {
                    patient.status = "Normal";
                }
                else if (patient.mewsScore > 1 && patient.mewsScore <= 4)
                {
                    patient.status = "Cautious";
                }
                else if (patient.mewsScore > 4)
                {
                    patient.status = "Urgent";
                }

                }
            }
            

            public class ClinicianInfo
            {
                public String clinicianID;
                public String employeeNumber;
                public String firstName;
                public String lastName;
                public String physicianID;
                public String email;
                public String phoneNumber;
            }

            public class PatientInfo
            {
                public Int32 PatientID;
                public Int32 medicalRecordNumber;
                public String firstName;
                public String lastName;
                public String dateOfBirth;
                public String dateOfAdmission;
                public String location;
                public Int32 careTeam;
                public String diagnosis;
                public Int32 admittingClinicianID;
                public Int32 attendingClinicianID;
                public String hospitalWing;
                public String roomNumber;
                public Int32 vitalID;
                public Int32 respiratoryRPM;
                public Int32 heartRate;
                public Int32 systolicBP;
                public String apvuScore;
                public Int32 temperature;
                //public String urine;
                public Int32 mewsScore;
                public String status;

            }
           
          

    }


      
}
 


