using BuggyCarProject.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarProject.Tests
{
    public class SRloginTests
    {
        public SRloginTests() { }

        Slogin login = new Slogin();

        [Test]
        public void Relogin()
        {
            login.SuccessfulLogin("BuggyUser", "Test@1234");
        }
    }
}
