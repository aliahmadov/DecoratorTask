using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models.Services
{
    public class FacebookDecorator : BaseServiceDecorator
    {

        public FacebookDecorator(IService service) : base(service)
        {

        }
        public Item GetSingleItem()
        {
            return new Item { ImagePath = "/Images/facebook.png", Message = "Facebook Message" };
        }
        public override List<Item> GetItem()
        {
            var items=base.GetItem();
            items.Add(GetSingleItem());
            return items;
        }
    }
}
