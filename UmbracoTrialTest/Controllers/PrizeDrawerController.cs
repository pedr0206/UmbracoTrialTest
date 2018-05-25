using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary;

namespace UmbracoTrial.Controllers
{
    public class PrizeDrawerController : Controller
    {
        [HttpGet]//Metodo Get por defeito pode nao ter esta parte de codigo
        public ActionResult Index()
        {
            return View(DrawEntryRepository.Instance.GetEntryList());
        }
        
        // GET: PrizeDrawer
        public ActionResult NewSubmition()
        {
            return View();
        }



        // POST: PrizeDrawer/Create
        [HttpPost]
        public ActionResult NewSubmition(DrawSubmition drawSubmition)
        {
            DrawEntryRepository.Instance.Add(drawSubmition);
            return View();
            
        }


    }
}