using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models.Services
{
    public class TwitterDecorator:BaseServiceDecorator
    {

        public TwitterDecorator(IService service):base(service)
        {
        
        }

        public Item GetSingleItem()
        {
            return new Item { ImagePath = "/Images/twitter.png", Message = "Twitter Message" };
        }
        public override List<Item> GetItem()
        {
            var items = base.GetItem();
            items.Add(GetSingleItem());
            return items;
        }
    }
}
