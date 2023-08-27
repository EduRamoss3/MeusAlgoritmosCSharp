using Comparing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing.Interfaces
{
    public interface IWash
    {
        bool CleanCar(Car car);
        bool WashGlasses(Car car);
    }
}
