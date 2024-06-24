using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial;
public class User {

    public int Id { get; set; } 
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; } 
    public string? Email { get; set; } 
    public bool IsReviewer { get; set; } 
    public bool IsAdmin { get; set; } 
}
