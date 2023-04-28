using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Security.Claims;
using static IST440WGroup4.Pages.Dashboard.IndexModel.Clinician;

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

        public List<LoginInfo> listLogins = new List<LoginInfo>();

        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=GPHDatabase;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Login";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginInfo loginInfo = new LoginInfo();
                                loginInfo.loginID = "" + reader.GetInt32(0);
                                loginInfo.password = reader.GetString(1);

                                listLogins.Add(loginInfo);
                            }
                        }
                    }
                }
            }
            catch { }

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

                if (credential.UserName == "2063" && credential.Password == "password") 
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

            return Page();
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

    public class LoginInfo
    {
        [Required]
        public String loginID;
        [Required]
        public String password;

    }
}