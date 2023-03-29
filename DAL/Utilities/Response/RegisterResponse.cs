using DAL.Utilities.Request;
using System.ComponentModel.DataAnnotations;

namespace DAL.Utilities.Response
{
    public class RegisterResponse
    {
        public RegisterRequest? user { get; set; }
        public string? message { get; set; }
    }
}
