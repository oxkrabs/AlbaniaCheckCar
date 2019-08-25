using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace AlbaniaCheckCar.EmailSender
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}