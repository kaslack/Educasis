using Educasis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Web;

namespace Educasis.Controllers
{

    public class HomeController : Controller
    {
        private readonly educasisContext _context;

        public HomeController(educasisContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Phisics()
        {
            return View();
        }

        public IActionResult Integrals()
        {
            return View();
        }        
        
        public IActionResult ED()
        {
            return View();
        }

        public IActionResult CalculadoraIntegrales()
        {
            return View();
        }

        public IActionResult Electronic()
        {
            return View();
        }

        public IActionResult Limits()
        {
            return View();
        }

        public IActionResult LimitsPractice()
        {
            return View();
        }

        public IActionResult Reto()
        {
            return View();
        }

        public IActionResult Reto1()
        {
            return View();
        }
        public IActionResult Reto2()
        {
            return View();
        }
        public IActionResult Reto3()
        {
            return View();
        }
        public IActionResult Reto4()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Id,Users,Password")] User user)
        {
            //user1 => user1.Password == user.Password
            if (ModelState.IsValid)
            {
                var UserFind = _context.Users.Where(user1 => user1.Users == user.Users).ToList();
                var PasswordFind = _context.Users.Where(user2 => user2.Password == user.Password).ToList();

                var usersRegisters = UserFind.Count;
                var passwordRegisters = PasswordFind.Count;

                if (usersRegisters > 0 && passwordRegisters > 0)
                {
                    ViewData["logeo"] = true;
                    return RedirectToAction(nameof(Index));
                }

            }
            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Users,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                //RegistrarIp();
                return Redirect("http://www.educasis.somee.com/api/Api1/" + user.Users);
            }
            return View(user);
        }

        public IActionResult Vote()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vote([Bind("Id,Appreciation")] Vote vote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vote);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vote);
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Contacts([Bind("Id,Name,Mail,Phone,Message,Contact1,Date")] Contact contacts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contacts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contacts);
        }

        public async void RegistrarIp()
        {
            string Host = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(Host);
            string IpUsuario = ip[1].ToString();

            Ip IpUser = new Ip();
            IpUser.Ip1 = IpUsuario;

            _context.Add(IpUsuario);
            await _context.SaveChangesAsync();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}