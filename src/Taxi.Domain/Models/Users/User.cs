using System.Diagnostics.Contracts;

namespace Taxi.Domain.Models.Users;

public class User : BaseModel
{
    public string FisrtName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
