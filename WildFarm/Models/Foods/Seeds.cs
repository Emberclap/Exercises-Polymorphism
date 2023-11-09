using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Foods
{
    public class Seeds : Food
    {
        public Seeds(int quantity) 
            : base(quantity)
        {

        }

        public int Quantity {  get; set; }
    }
}
