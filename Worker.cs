using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    internal class Worker : IConstructed
    {
        public void ConstructedCar(uint count) => MessageBox.Show($"Worker creates {count} cars based on an engineer's design", "Worker");
        
    }
}
