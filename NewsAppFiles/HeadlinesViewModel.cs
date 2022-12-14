using System;
using System.Collections.Generic;
using System.Text;
using News.ViewModel;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using News.Models;
using News.Services;
using Xamarin.Forms;

namespace News.ViewModel
{
    public class HeadlinesViewModel : ViewModel
    {
        private readonly NewsService newsService;
        public NewsResult CurrentNews { get; set; }

        public HeadlinesViewModel(NewsService newsService)
        {
            this.newsService = newsService;
        }

        public async Task Initialize(string scope)
        {
            var resolvedScope = scope.ToLower() switch
            {
                "local" => NewsScope.Local,
                "global" => NewsScope.Global,
                "headlines" => NewsScope.Headlines,
                _ => NewsScope.Headlines
            };

            await Initialize(resolvedScope);
        }

        public async Task Initialize(NewsScope scope)
        {
            CurrentNews = await newsService.GetNews(scope);
        }

        public ICommand ItemSelected =>
            new Command((selectedItem) =>
            {
                var selectedArticle = selectedItem as Article;
                var url = HttpUtility.UrlEncode(selectedArticle.Url);

            });
    }
}

