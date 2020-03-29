using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace ProyectoFinalAplicada2.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            //[Required]
            //[EmailAddress]
            //[Display(Name = "Email")]
            //public string Email { get; set; }

            //[Required]
            //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            //[DataType(DataType.Password)]
            //[Display(Name = "Password")]
            //public string Password { get; set; }

            //[DataType(DataType.Password)]
            //[Display(Name = "Confirm password")]
            //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            //public string ConfirmPassword { get; set; }



            [Key]
            public int UsuarioId { get; set; }
            public DateTime FechaIngreso { get; set; }
            [Required(ErrorMessage = "El Nombre es obligatorio.")]
            [MinLength(3, ErrorMessage = "Este nombre es muy corto, debe elegir un nombre más largo.")]
            [MaxLength(20, ErrorMessage = "Este nombre es muy largo, debe elegir un nombre más corto.")]
            public string Nombres { get; set; }
            [Required(ErrorMessage = "El Apellido es obligatorio.")]
            [MinLength(3, ErrorMessage = "El o los apellidos son muy cortos.")]
            [MaxLength(20, ErrorMessage = "El o los apellidos son muy largos.")]
            public string Apellidos { get; set; }
            [Required(ErrorMessage = "El Email es obligatorio")]
            [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
            [MaxLength(40, ErrorMessage = "Este correo es muy largo.")]
            public string Email { get; set; }
            [Required(ErrorMessage = "El Usuario es obligatorio.")]
            [MinLength(3, ErrorMessage = "El usuario es muy corto, bebe contener al menos 3 caracteres.")]
            [MaxLength(20, ErrorMessage = "El Usuario es muy largo.")]
            public string Usuario { get; set; }
            //[Required(ErrorMessage = "Debe elegir un nivel de usuario.")]
            //[MinLength(5, ErrorMessage = "Debe elegir un nivel de usuario.")]
            public string NivelUsuario { get; set; }
            [Required(ErrorMessage = "Debe ingresar una contraseña")]
            [MinLength(5, ErrorMessage = "La contraseña debe contener al menos 5 caracteres.")]
            [MaxLength(30, ErrorMessage = "La contraseña es muy larga.")]
            public string Contrasena { get; set; }


        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Contrasena);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
