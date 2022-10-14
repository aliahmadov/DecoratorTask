using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models
{
    public interface IService
    {
        List<Item> GetItem();
    }
}
