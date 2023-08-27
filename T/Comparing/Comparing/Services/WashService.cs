using Comparing.Entities;
using Comparing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing.Services
{
    internal class WashService : IWash
    {
        public bool CleanCar(Car car)
        {
            if(car.Clean != true)
            {
                car.Clean = true;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public string SayWithClientNo()
        {
            return "Is not ok";
        }
          public string SayWithClientYes(int a)
        {
            if(a == 5)
            {
                return "Yes";
            }
            else
            {
                return "";
            }
           
        }
        public bool WashGlasses(Car car, bool result, string reviewClient)
        {
            if(reviewClient == "Ok")
            {
                car.Glasses = true;
            }
            while(car.Glasses = false){

                Console.WriteLine("Is not ok!");
            }
            
            

        }
    }
}
