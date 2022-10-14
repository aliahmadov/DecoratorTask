using DecoratorTask.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models
{
    public class InstagramDecorator : BaseServiceDecorator
    {

        public InstagramDecorator(IService service):base(service)
        { 

        }

        public Item GetSingleItem()
        {
            return new Item { ImagePath = "/Images/instagram.png", Message = "Instagram Message" };
        }
        public override List<Item> GetItem()
        {
            var items = base.GetItem();
            items.Add(GetSingleItem());
            return items;
        }
    }
}
