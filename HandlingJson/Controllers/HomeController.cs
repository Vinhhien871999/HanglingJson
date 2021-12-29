using HandlingJson.Commons;
using HandlingJson.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HandlingJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> GetAllJson()
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                var response = await client.GetAsync(CommonConstants.baseAddress + "Products");
                var _resultMessage = response.Content.ReadAsStringAsync().Result;
                Products[] body = JsonConvert.DeserializeObject<Products[]>(_resultMessage.ToString());
                ViewBag.RecordDonVi = body;
                return Json(body);
            }
            catch
            {

            }
            return View();
        }
    }
}