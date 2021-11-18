using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmail.Model;
using SendEmail.Services;
using System.Threading.Tasks;

namespace SendEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailService _mailService;
        public EmailController(IMailService mailService)
        {
            _mailService = mailService;
        }
        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await _mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
