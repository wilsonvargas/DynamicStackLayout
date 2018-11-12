using DynamicStackLayout.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DynamicStackLayout.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item()
            {
                Name = "Item 1",
                Image = new Uri("https://picsum.photos/200/?image=0")
            });
            Items.Add(new Item()
            {
                Name = "Item 2",
                Image = new Uri("https://picsum.photos/200/?image=1")
            });
            Items.Add(new Item()
            {
                Name = "Item 3",
                Image = new Uri("https://picsum.photos/200/?image=2")
            });
            Items.Add(new Item()
            {
                Name = "Item 4",
                Image = new Uri("https://picsum.photos/200/?image=3")
            });
            Items.Add(new Item()
            {
                Name = "Item 5",
                Image = new Uri("https://picsum.photos/200/?image=4")
            });
            Items.Add(new Item()
            {
                Name = "Item 6",
                Image = new Uri("https://picsum.photos/200/?image=5")
            }); Items.Add(new Item()
            {
                Name = "Item 7",
                Image = new Uri("https://picsum.photos/200/?image=6")
            });
            Items.Add(new Item()
            {
                Name = "Item 8",
                Image = new Uri("https://picsum.photos/200/?image=7")
            }); Items.Add(new Item()
            {
                Name = "Item 9",
                Image = new Uri("https://picsum.photos/200/?image=8")
            }); Items.Add(new Item()
            {
                Name = "Item 10",
                Image = new Uri("https://picsum.photos/200/?image=9")
            }); Items.Add(new Item()
            {
                Name = "Item 11",
                Image = new Uri("https://picsum.photos/200/?image=10")
            }); Items.Add(new Item()
            {
                Name = "Item 12",
                Image = new Uri("https://picsum.photos/200/?image=11")
            });
        }

        public ObservableCollection<Item> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        private ObservableCollection<Item> items;
    }
}
