using System.Net.Http;
using MyAnimelist.Model;
using System.Windows.Input;
using MyAnimelist.API;
using Newtonsoft.Json;

namespace MyAnimelist.ViewModel
{
    class AddAnimeViewModel : BaseViewModel
    {
        public AddAnimeViewModel()
        {
            ConnectCommands();
        }



        private string searchTitle;
        public string SearchTitle
        {
            get
            {
                return searchTitle;
            }

            set
            {
                searchTitle = value;
                NotifyPropertyChanged();
            }
        }

        private AnimeResults animeTitle;
        public AnimeResults AnimeTitle
        {
            get
            {
                return animeTitle;
            }

            set
            {
                animeTitle = value;
                NotifyPropertyChanged();
            }
        }


        private Anime currentAnime;
        public Anime CurrentAnime
        {
            get
            {
                if (currentAnime == null)
                {
                    currentAnime = new Anime();
                }
                return currentAnime;
            }

            set
            {
                currentAnime = value;
                NotifyPropertyChanged();
            }
        }



        private void ConnectCommands()
        {
            AddCommand = new BaseCommand(AddAnime);
            SearchCommand = new BaseCommand(SearchAnime);
        }

        public ICommand AddCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public void AddAnime()
        {
            AnimeDataService animeDS =
                new AnimeDataService();
            animeDS.InsertAnime(CurrentAnime);
        }


        private async void SearchAnime()
        {

            //Anime = await AnimeProcessor.LoadAnime(SearchTitle);
            string url = $"https://api.jikan.moe/v3/search/anime?q={SearchTitle}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {

                var title = await response.Content.ReadAsStringAsync();
                AnimeTitle = JsonConvert.DeserializeObject<AnimeResults>(title);

            }

        }
    }
}
