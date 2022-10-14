using DecoratorTask.Commands;
using DecoratorTask.Models;
using DecoratorTask.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DecoratorTask.ViewModels
{
    public class AppViewModel : BaseViewModel
    {

        public StackPanel ChecBoxStackPanel { get; set; }
        public StackPanel StackPanel { get; set; }
        public RelayCommand SendCommand { get; set; }

        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value;OnPropertyChanged(); }
        }


        private List<string> GetServices(StackPanel stackPanel)
        {

            List<string> services = new List<string>();
            foreach (var item in stackPanel.Children)
            {
                if (item is CheckBox cB)
                {
                    if (cB.IsChecked is true)
                    {
                        services.Add(cB.Content.ToString().Split(' ')[0].ToLower());
                    }
                }
            }
            return services;
        }
        private List<Item> DisplayServices(List<string> services)
        {

            IService service = new Service();
            BaseServiceDecorator decorator = new BaseServiceDecorator(service);
            IService dynamicService = new Service();
            foreach (var item in services)
            {
                if (item is "instagram")
                {
                    IService instagramService = new InstagramDecorator(dynamicService);
                    dynamicService = instagramService;
                }
                if (item is "twitter")
                {
                    IService twitterService = new TwitterDecorator(dynamicService);
                    dynamicService = twitterService;
                }

                if (item is "telegram")
                {
                    IService telegramService = new TelegramDecorator(dynamicService);
                    dynamicService = telegramService;
                }
                if (item is "facebook")
                {
                    IService facebookService = new FacebookDecorator(dynamicService);
                    dynamicService = facebookService;

                }
            }
            var items = dynamicService.GetItem();
            return dynamicService.GetItem();

        }
        public AppViewModel()
        {

            SendCommand = new RelayCommand(c =>
            {
                var services = GetServices(ChecBoxStackPanel);
                var items = DisplayServices(services);
                Items = items;
               
            });

        }
    }
}
