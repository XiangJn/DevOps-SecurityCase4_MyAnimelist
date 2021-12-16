using MyAnimelist.API;
using System.Windows;

namespace MyAnimelist.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void NewAnime(object sender, RoutedEventArgs e)
        {
            AddAnime addAnime = new AddAnime();
            this.Close();
            addAnime.Show();

        }

        private void myList(object sender, RoutedEventArgs e)
        {
            MyAnime myAnime = new MyAnime();
            this.Close();
            myAnime.Show();
        }

    }
}