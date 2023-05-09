using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo3.Models;

namespace demo3.Models
{
    public partial class Product
    {
        public string ManufName { get { return Productmanuf.Manufname; } }
    }
}
