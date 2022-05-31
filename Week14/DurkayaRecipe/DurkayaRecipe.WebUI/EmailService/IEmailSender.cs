using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.EmailService
{
    public interface IEmailSender 
    {
        //Bu interface farklı mail server tekniklerine göre mail gönderme 
        //metotlarımızı yapılandırabilmek için genel olarak tasarlanmıştır.
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
