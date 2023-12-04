using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    internal class Engineer : ICreateCar, ITake
    {
        public void StartProject()
        {
            MessageBox.Show("Started to design a new car");
        }

        public string Run()
        {
            return "Інженер виїхав на об'єкт.";
        }

        public void EngineerEvent()
        {
            MessageBox.Show(Run(), "Інженер");
        }
    }
}
