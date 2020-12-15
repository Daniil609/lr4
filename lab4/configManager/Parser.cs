using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4.configManager
{
    interface IParser
    {
        public T GetOptions<T>();
    }
}
