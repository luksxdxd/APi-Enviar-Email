using SendEmail.Model;
using System.Threading.Tasks;

namespace SendEmail.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
