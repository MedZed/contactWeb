using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace contactWeb.Models
{
    public class Contact
    {
       public int Id { get; set; }
       public Guid UserId { get; set; }
       public string FirstName { get; set; }
       public string LasttName { get; set; }
       public string Email { get; set; }
       public string PhonePrimary { get; set; }
       public string PhoneSecondary { get; set; }
       public DateTime Birthdate { get; set; }
       public string StreetAdress1 { get; set; }
       public string StreetAdress2 { get; set; }
       public string City { get; set; }
       public string State { get; set; }
       public string ZipCode { get; set; }
    }
}