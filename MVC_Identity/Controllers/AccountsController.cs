using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using MVC_Identity.Data;
using MVC_Identity.Models.ViewModel;

namespace MVC_Identity.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountsController(ApplicationDbContext context , UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Register(RegisterViewModel  model)
        {
            IdentityUser user = new IdentityUser()
            {
                Email = model.Email,
                UserName = model.UserName,
                PhoneNumber = model.PhoneNumber,
           
            };

           var result = await userManager.CreateAsync(user,model.Password);

            if (result.Succeeded) 
            {
                return RedirectToAction("Login");

            }

            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        
        
        }

        [HttpPost]
        public async Task <IActionResult> Login(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.UserName,model.Password,model.Rememberme,false);
           
            if (result.Succeeded) {

                return RedirectToAction("Index", "Home");
            }
            
            return View(model);


        }
    }
}
