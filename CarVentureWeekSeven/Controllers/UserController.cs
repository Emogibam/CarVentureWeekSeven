using CarVentureCore.Interface;
using CarVentureCore.Model;
using CarVentureWeekSeven.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CarVentureWeekSeven.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly IAuthRepository _authRepository;

        public UserController(IUserRepository userRepo, IAuthRepository authRepo)
        {
            _userRepository = userRepo;
            _authRepository = authRepo;
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignInAsync(SignInModel model)
        {
            var auth = await _authRepository.Login(model.Email, model.Password);
            if (auth)
            {
                ViewData["message"] = "Successful";
                return Redirect("~/Home/Index");
            }
            return RedirectToAction("Error");
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUpAsyn(SignUpModel model)
        {
            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Age = model.Age,
                FullName = model.FullName,
                Phone = model.Phone,
                Email = model.Email,
                Password = model.Password,
            };
            bool successful = await _userRepository.AddUser(user);
            if (successful)
            {
                ViewData["message"] = "Successful";
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("Error");
        }
    }
}
