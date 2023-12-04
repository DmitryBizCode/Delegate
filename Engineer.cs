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
        public string StartProject() => "Started to design a new car";
        

        public string TakingAMean() => "Listened to the customer's opinion";
        

        public void EngineerEvent()
        {
            MessageBox.Show(TakingAMean(), "Engineer");
            MessageBox.Show(StartProject(), "Engineer");
        }
    }
}
