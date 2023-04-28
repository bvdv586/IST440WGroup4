using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient; 

namespace IST440WGroup4.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        public class Clinician
        {

            public List<ClinicianInfo> listClinicians = new List<ClinicianInfo>();



            public void OnGet()
            {
                try
                {
                    String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=GPHDatabase;Integrated Security=True";
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
                                    clinicianInfo.employeeNumber = reader.GetString(1);
                                    clinicianInfo.firstName = reader.GetString(2);
                                    clinicianInfo.lastName = reader.GetString(3);
                                    clinicianInfo.physicianID = reader.GetString(4);
                                    clinicianInfo.email = reader.GetString(5);
                                    clinicianInfo.phoneNumber = reader.GetString(6);

                                    listClinicians.Add(clinicianInfo);
                                }
                            }
                        }
                    }
                }
                catch { }
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

        }
    }

    public class Patients
    {
        public List<PatientInfo> listPatients = new List<PatientInfo>();

        public void OnGet() {
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=GPHDatabase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Patient";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PatientInfo patientInfo = new PatientInfo();
                                patientInfo.PatientID = "" + reader.GetInt32(0);
                                patientInfo.medicalRecordNumber = reader.GetString(1);
                                patientInfo.firstName = reader.GetString(2);
                                patientInfo.lastName = reader.GetString(3);
                                patientInfo.dateOfBirth = reader.GetString(4);
                                patientInfo.dateOfAdmission = reader.GetString(5);
                                patientInfo.location = reader.GetString(7);
                                patientInfo.careTeam = reader.GetString(8);
                                patientInfo.diagnosis = reader.GetString(9);
                                patientInfo.admittingClinicianID = reader.GetString(10);
                                patientInfo.attendingClinicianID = reader.GetString(11);
                                patientInfo.hospitalWing = reader.GetString(12);
                                patientInfo.roomNumber = reader.GetString(13);


                                listPatients.Add(patientInfo);
                            }
                        }
                    }
                }
            }
            catch { }
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
    }
 }


