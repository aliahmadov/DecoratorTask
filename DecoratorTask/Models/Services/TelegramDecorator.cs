using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Models.Services
{
    public class TelegramDecorator : BaseServiceDecorator
    {


        public TelegramDecorator(IService service):base(service)
        {

        }

        public Item GetSingleItem()
        {
            return new Item { ImagePath = "/Images/telegramIcon.png", Message = "Telegram Message" };
        }
        public override List<Item> GetItem()
        {
            var items = base.GetItem();
            items.Add(GetSingleItem());
            return items;
        }
    }
}
