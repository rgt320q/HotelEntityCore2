using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelEntityCore2.Data.EntityFramework;
using HotelEntityCore2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelEntityCore2.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;

        public HomeController(DataContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            Rezervation rv = new Rezervation();
            Guest ge = new Guest();
            Payment py = new Payment();

            //rv.Id = 1;
            //rv.DepartureDate = DateTime.Today.Date;
            //rv.Arrivaldate = DateTime.Today.Date.AddDays(1);
            //rv.RoomNo = "102";
            //rv.TatolDays = 1;
            //ge.Name = "Ömer";
            //ge.SurName = "Çetin";


            var model = context.Rezervations
                .Include(i=>i.Guests)
                .Include(i=>i.Payments)                
                .ToList();

            return View(model);
        }
    }
}