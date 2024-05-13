using HomeHavenBlazorProject.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace HomeHavenBlazorProject.Services
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(RegisterModel registerModel);
        public Task<LoginResult> Login(LoginModel loginModel);
        public Task Logout();
    }
}