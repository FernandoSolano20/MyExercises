using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsyncAwait.Models;
using AsyncAwait.NewsServiceReference;
using AsyncAwait.WeatherServiceReference;

namespace AsyncAwait.Controllers
{
    public class HomeController : AsyncController
    {
        public void IndexAsync()
        {
            var model = new HomePageViewModel();
            var newsClient = new NewsServiceClient();
            var weatherClient = new WeatherServiceClient();

            AsyncManager.Parameters["model"] = model;
            
            AsyncManager.OutstandingOperations.Increment();
            newsClient.BeginGetHeadline(ar =>
            {
                model.Headline = newsClient.EndGetHeadline(ar);
                AsyncManager.OutstandingOperations.Decrement();
            }, null);

            AsyncManager.OutstandingOperations.Increment();
            weatherClient.BeginGetCurrentTemperature(ar =>
            {
                model.Temperature = weatherClient.EndGetCurrentTemperature(ar);
                AsyncManager.OutstandingOperations.Decrement();
            }, null);

        }       

        public ViewResult IndexCompleted(HomePageViewModel model)
        {
            return View(model);
        }

    }
}
