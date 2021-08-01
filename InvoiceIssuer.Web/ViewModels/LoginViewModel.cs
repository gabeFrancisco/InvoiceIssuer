using System.ComponentModel.DataAnnotations;

namespace InvoiceIssuer.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(7)]
        public string CI { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}