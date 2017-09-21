using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookUp.Core
{
    public class CarClass
    {
        public CarClass()
        {
        }

        public Guid _Id { get; set; }
        public String _maker { get; set; }
        public String _model { get; set; }
        public String _Year { get; set; }
    }
}
