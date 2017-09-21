using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookUp.ViewModels
{
    public class CarClassVM
    {
        public Guid _Id { get; set; }
        public String _maker { get; set; }
        public String _model { get; set; }
        public String _Year { get; set; }
    }
}
