using channelAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace channelAplication.Controllers
{
    public class channelController : Controller
    {
        private DefaultConnection db = new DefaultConnection();
        // GET: channel
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult channel()
        {
            return View(db.Channels.ToList());
        }


        [HttpPost]
        public ActionResult channel(string searchterm)
        {
            using (DefaultConnection db = new DefaultConnection())
            {
                if (string.IsNullOrEmpty(searchterm))
                    return View(db.Channels.ToList());
                else
                    return View(db.Channels.Where(x => x.chanName_En.ToLower().Contains(searchterm.ToLower())).ToList());
            }

        }

        public JsonResult searchchannel(string term)
        {
            List<string> channel = new List<string>();
            using (DefaultConnection db = new DefaultConnection())
            {

                channel=db.Channels.Where(x => x.chanName_En.ToLower().Contains(term.ToLower())).Select(y=>y.chanName_En).ToList();

            }
            return Json(channel, JsonRequestBehavior.AllowGet);
        }




        public ActionResult category()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Satellite()
        {
            return View(db.Satellites_.ToList());
        }

    }
}