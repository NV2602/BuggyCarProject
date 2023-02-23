using BuggyCarProject.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarProject.Tests
{
    public class SloginTests
    {
        Slogin login = new Slogin();

        [Test]
        public void IncorrectName()
        {
            login.BuggyFailedLogin("LpsTes", "Test@123");
        }
        [Test]
        public void IncorrectPassword()
        {
            Thread.Sleep(3000);
            login.BuggyFailedLogin("LpsTest12", "Test@12");
        }
        [Test]
        public void SucessfulLogin()
        {
            LogintoApp("LpsNew1", "Test@123");
        }
        public void LogintoApp(string strLogin , string strPass)
        {
            Thread.Sleep(3000);
            login.SuccessfulLogin(strLogin, strPass);
        }

    }
}
