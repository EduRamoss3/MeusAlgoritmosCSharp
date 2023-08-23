using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgenerics.Entities
{
    internal class CalculationService
    {
        public CalculationService()
        {

        }
        public T Max<T>(List<T> list) where T : IComparable<T>
        {
            T Max = list[0];
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(Max) > 0)
                {
                    Max = list[i];
                }
            }
            return Max;
        }
        
    }
}
