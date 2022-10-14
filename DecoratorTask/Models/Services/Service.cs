using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models.Services
{
    public class Service : IService
    {
        public List<Item> GetItem()
        {
            return new List<Item>();
        }
    }
}
