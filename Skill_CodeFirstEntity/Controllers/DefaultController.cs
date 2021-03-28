using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.Siniflar;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        CONTEXT c = new CONTEXT();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}