using BuggyCarProject.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarProject.Tests
{
    public class SProfileTests
    {
        SProfile profile = new SProfile();
        [Test]
        public void UpdateExistingProfile()
        {
            profile.UpdateProfile("Siya", "22", "02108225846", "Test@123", "Test@1234");

        }
        [Test]
        public void VerifyUpdatedProfile() 
        {
            profile.VerifyUpdatedDetails("Siya");
        }
    }
}
