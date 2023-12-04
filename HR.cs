using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{    
    internal class HR : IHire,IFired
    {
        public string HireEmployee() => "We are hiring a new employee for a limited time as we do not have enough employees to complete this project";
        public string FiredEmployee() => "we are laying off temporary employees";
        public void HREvent() => MessageBox.Show(HireEmployee(), "HR");
        public void HRFireEvent() => MessageBox.Show(FiredEmployee(), "HR");

    }
}

