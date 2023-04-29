using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient; 

namespace IST440WGroup4.Pages.Dashboard
{
    public class IndexModel : PageModel
    {

        public List<ClinicianInfo> listClinicians = new List<ClinicianInfo>();
        public List<PatientInfo> listPatients = new List<PatientInfo>();
        public List<VitalInfo> listVitals = new List<VitalInfo>();


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


                                    listPatients.Add(patientInfo);

                                }
                            }
                        }
                    }
       
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "SELECT * FROM Vitals";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    VitalInfo vitalInfo = new VitalInfo();
                                    vitalInfo.vitalID = "" + reader.GetInt32(0);
                                    vitalInfo.patientID = "" + reader.GetInt32(1);
                                    vitalInfo.respiratoryRPM = "" + reader.GetInt32(2);
                                    vitalInfo.heartRate = "" + reader.GetInt32(3);
                                    vitalInfo.systolicBP = "" + reader.GetInt32(4);
                                    vitalInfo.apvuScore = reader.GetString(5);
                                    vitalInfo.temperature = "" + reader.GetInt32(6);
                                    //vitalInfo.urine = reader.GetString(7);

                                    listVitals.Add(vitalInfo);
                                    

                                }
                            }
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
                public String PatientID;
                public String medicalRecordNumber;
                public String firstName;
                public String lastName;
                public String dateOfBirth;
                public String dateOfAdmission;
                public String location;
                public String careTeam;
                public String diagnosis;
                public String admittingClinicianID;
                public String attendingClinicianID;
                public String hospitalWing;
                public String roomNumber;
            }

            public class VitalInfo {
                public String vitalID;
                public String patientID;
                public String respiratoryRPM;
                public String heartRate;
                public String systolicBP;
                public String apvuScore;
                public String temperature;
                public String urine;

            }


    }


      
}
 


