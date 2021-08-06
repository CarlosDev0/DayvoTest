using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayvo.Negocio.Interfaz
{
    interface ICollectionSorter
    {
        IEnumerable<string> SortAscending(int[] numbers);
        IEnumerable<string> SortDescending(int[] numbers);

    }
}
