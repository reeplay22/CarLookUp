using Postal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CarLookUp.ViewModels
{
    public class DetailsEmailVM : Email
    {
        public DetailsEmailVM(string viewName) : base(viewName)
        {
        }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Student number")]
        public int Id { get; set; }

        [DisplayName("LastName")]
        public string LastName { get; set; }

        public string Subject { get; set; }
        public string ToAddress { get; set; }
    }
}
