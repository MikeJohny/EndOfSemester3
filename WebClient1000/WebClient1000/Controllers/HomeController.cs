using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient1000.Models;

namespace WebClient1000.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Verify(string username, string password, string submitButton)
        {
            if (submitButton != null)
            {
                if (submitButton.Equals("Login"))
                {
                    var caller = new Caller.RestSharpCaller("https://localhost:44358/api/");
                    if (caller.LogIn(username, password) == true)
                    {

                        var listSales = caller.GetSales();

                        return View("MainPage", listSales);
                    }
                    else
                    {
                        return View("~/Views/Home/Login.cshtml");
                    }
                }
                else
                {
                    return View("~/Views/Home/CreateUser.cshtml");
                }
            }
            else

                return View("~/Views/Home/Login.cshtml");

        }
        public ActionResult MainPage(List<Products> list)
        {
            var caller = new Caller.RestSharpCaller("https://localhost:44358/api/");
             list = caller.GetProducts();

            return View(list);
        }
        public ActionResult CreateUser(string createUser, Users model)
        {
            if (createUser != null)
            {
                Users user = new Users(model.name, model.password, model.name, model.email, model.address);
                var caller = new Caller.RestSharpCaller("https://localhost:44358/api/");
                caller.CreateUser(user);
                return View("~/Views/Home/Login.cshtml");
            }
            else
                return View();

        }
        public ActionResult CreateSaleButton(string submitButtonP)
        {
            if (submitButtonP != null)
            {
                return View("~/Views/Home/CreateSale.cshtml");
            }
            else
            {
                return View();
            }
        }
        public ActionResult CreateSale (string createButtonP, Sale model)
        {
            if (createButtonP != null)
            {

                var caller = new Caller.RestSharpCaller("https://localhost:44358/api/");
                var productID = caller.CreateProduct(model.Name, model.CurrentPrice, model.Location, model.ProductTypes_id);
                var check=caller.CreateSale(model.UsersId,productID,model.Description,model.CurrentPrice,model.TimeRemaining);
                var list = caller.GetSales();
                return View("~/Views/Home/MainPage.cshtml", list);
            }
            else
                return View();
        }
    }
}