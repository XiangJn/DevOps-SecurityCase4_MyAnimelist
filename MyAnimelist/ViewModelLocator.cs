using MyAnimelist.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAnimelist
{
    class ViewModelLocator
    {
        private static AddAnimeViewModel addAnimeViewModel = new AddAnimeViewModel();

        public static AddAnimeViewModel AddAnimeViewModel
        {
            get
            {
                return addAnimeViewModel;
            }
        }
    }
}
