using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using odeToFood.Core;
using OdeToFood.Data;

namespace training_ode_to_food.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IConfiguration config { get; set; }
        public IRestaurantData restaurantData { get; }
        public IEnumerable<Restaurant> Restaurants{ get; set; }
         
        public ListModel (IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            this.Restaurants = restaurantData.GetAll();
            this.config = config;
            this.Message = config["AllowedHosts"];
            Console.WriteLine(this.Restaurants.ToString());
            Debug.WriteLine("On browser console please!");
            
        }
    }
}
