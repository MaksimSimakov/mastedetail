using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterdetail
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("sandy.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

         public List<mastermenuitems> GetMenuList()
        {
            var list = new List<mastermenuitems>();
            list.Add(new mastermenuitems()
            {
                Text = "Minust",
                Detail = "Lühike Info",
                ImagePath = "info.png",
                TargetPage = typeof(Views.AboutPage)

            });
            list.Add(new mastermenuitems()
            {
                Text = "Minu kogemus",
                Detail = "Natuke rohkem minu kogemusest",
                ImagePath = "book.png",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new mastermenuitems()
            {
                Text = "Minu oskused",
                Detail = "Natuke rohkem minu oskusest",
                ImagePath = "skate.png",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new mastermenuitems()
            {
                Text = "Minu Võidud",
                Detail = "Ma olen uhke",
                ImagePath = "cat.png",
                TargetPage = typeof(Views.AchievemnetsPage)
            });

            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (mastermenuitems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
