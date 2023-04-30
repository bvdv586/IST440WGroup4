using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Security.Claims;


namespace IST440WGroup4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Credential credential { get; set; }

        public List<String> listUsername = new List<String>();

        public List<String> listPassword = new List<String>();


        public String userName;

        public String password;


        public void OnGet()
        {
               
  

        }

        public async Task<IActionResult> OnPostAsync()
        {

            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=GPHDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Login";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userName = "" + reader.GetInt32(0);
                            listUsername.Add(userName);


                            password = reader.GetString(1);
                            listPassword.Add(password);


                        }
                    }
                }
            }

            if (listUsername?.Where(x => x.Contains(credential.UserName)).Any() == true && listPassword?.Where(x => x.Contains(credential.Password)).Any() == true) 
            { 
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "2036")

                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Dashboard/Index");
            }
            else
            {
                return Page();
            }


        }
    }

    public class Credential
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}