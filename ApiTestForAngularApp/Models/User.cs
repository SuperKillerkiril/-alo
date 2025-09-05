using Microsoft.AspNetCore.Identity;
using ApiTestForAngularApp.Enum;
using System.ComponentModel.DataAnnotations;
namespace ApiTestForAngularApp.Models
{
    public class User
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; } = RoleEnum.User;
    }
}
