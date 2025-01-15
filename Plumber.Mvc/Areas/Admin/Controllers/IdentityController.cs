using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Plumber.Bl.Dtos;
using Plumber.Core;

namespace Plumber.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IdentityController : Controller
    {
        private readonly UserManager<AdminUser> _userManager;
        private readonly SignInManager<AdminUser> _signinManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public IdentityController(UserManager<AdminUser> userManager, SignInManager<AdminUser> signinManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _signinManager = signinManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }


        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(CreateAdminUserDto createAdminUserDto)
        {
            if (ModelState.IsValid)
            {
                AdminUser adminUser = _mapper.Map<AdminUser>(createAdminUserDto);

                var result = await _userManager.CreateAsync(adminUser, createAdminUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Register));
                }
                


                return View();

            }
            return View(createAdminUserDto);

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginAdminUser loginAdminUser)
        {
          var user= await _userManager.FindByNameAsync(loginAdminUser.UserName);
        var result= await _signinManager.CheckPasswordSignInAsync(user, loginAdminUser.Password,false);
            if (result.Succeeded)
            {
               await _userManager.AddToRoleAsync(user, "Admin");
                await _signinManager.SignInAsync(user, isPersistent:false);
            }
            return View();
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> AddRole()
        {
            var role = new IdentityRole()
            {
                Name = "Admin"
            };
          await  _roleManager.CreateAsync(role);
            return View();
        }
    }
}
