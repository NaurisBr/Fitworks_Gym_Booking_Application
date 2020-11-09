using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitworksApp
{
    public class AccountInfo
    {
 
        public string Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get ; set; }
        public string password { get; set; }
        public string dateOfBirth { get; set; }
        public string cardType { get; set; }
        public string cardNumber { get; set; }
        public string expiryDate { get; set; }
        public string ccv { get; set; }
        public string duration { get; set; }
        public string idf { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string emailf { get; set; }
        public string membershipStatus { get; set; }
        public string Session1 { get; set; }
        public string email2 { get; set; }



        //public string Id2 { get; set; }
        //public string CardType2 { get; set; }
        //public string CardNumber2 { get; set; }
        //public string ExpiryDate2 { get; set; }
        //public string CCV2 { get; set; }
        //public string Duration2 { get; set; }
        //public string Email2 { get; set; }
        //public string MembershipStatus2 { get; set; }



        public string FullInfo
        {
            get
            {
                email = LoginForm.SetValueForText1;
                return $"({Id}) {name} {surname} ({ email }) ({dateOfBirth}) ({cardType}) ({cardNumber}) ({expiryDate}) ({duration})";
            }
           
        }

    }
}
