using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PPCRental.Controllers;

namespace PPCRental.Appceptance.Test.Driver.Login
{
    public class Login
    {
        private ActionResult _result;
        public void LoginUser(string email, string password)
        {
            using (var controller = new HomeController())
            {
                _result = controller.Login();
            }
        }
    }
}
