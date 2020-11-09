using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitworksApp;

namespace TestGymApp.UnitTests
{
    [TestClass]
    public class MembershipTests
    {
        [TestMethod]
        public void CanBeCancelledViaAccountSettings_UserIsActive_ReturnsString()
        {
                  
            DataAccess db = new DataAccess();
            db.UpdateMembershipStatus("Active");
                    
        }

        [TestMethod]
        public void CanBeCancelledViaAccountSettings_UserIsInactive_ReturnsString()
        {

            DataAccess db = new DataAccess();
            db.UpdateMembershipStatus("Inactive");

        }
        [TestMethod]
        public void InsertSessionsViaClassBooking_UserIsActive_ReturnsString()
        {

            DataAccess db = new DataAccess();
            db.InsertSessions("Swim Lane 1: Pool", LoginForm.SetValueForText1);

        }

        [TestMethod]
        public void InsertSessionsViaClassBooking_UserIsActive_ReturnsGritS3()
        {

            DataAccess db = new DataAccess();
            db.InsertSessions("GRIT Strength: Studio 3", LoginForm.SetValueForText1);

        }
        [TestMethod]
        public void InsertSessionsViaClassBooking_UserIsActive_ReturnsCycleS2()
        {

            DataAccess db = new DataAccess();
            db.InsertSessions("Cycle: Studio 2", LoginForm.SetValueForText1);

        }

        [TestMethod]
        public void InsertSessionsViaClassBooking_GetAccounts_ReturnsAccounts()
        {

            DataAccess db = new DataAccess();
            db.GetAccounts(LoginForm.SetValueForText1); 

        }

        [TestMethod]
        public void InsertSessionsViaClassBooking_GeSessionInfo_ReturnsSession()
        {

            DataAccess db = new DataAccess();
            db.ButtonCheckForeachSession(); 

        }

        [TestMethod]
        public void GetStatusAndSessionInfo_GeSessionInfo_ReturnsSession()
        {

            DataAccess db = new DataAccess();
            db.GetStatusAndSessionInfo(); 

        }

        [TestMethod]
        public void InsertSessionsViaClassBooking_UserIsActive_ReturnsSwimL3()
        {

            DataAccess db = new DataAccess();
            db.InsertSessions("Swim Lane 3: Pool", LoginForm.SetValueForText1);

        }

        [TestMethod]
        public void InsertSessionsViaClassBooking_UserIsActive_ReturnsSwimL2()
        {

            DataAccess db = new DataAccess();
            db.InsertSessions("Swim Lane 2: Pool", LoginForm.SetValueForText1);

        }


    }
}
