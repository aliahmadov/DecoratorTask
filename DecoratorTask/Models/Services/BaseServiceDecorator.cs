using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models.Services
{
    public class BaseServiceDecorator : IService
    {
        private IService _service;
        public BaseServiceDecorator(IService service)
        {
            _service = service;
        }

        public virtual List<Item> GetItem()
        {
            return _service.GetItem();
        }
    }
}
