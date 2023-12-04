using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    internal class Administration : IHire,IFired
    {
        public string HireEmployee() => "We are increasing the composition of the administration for better productivity";
        public string FiredEmployee() => "we are firing temporary managers";
        public void AdministrationFireEvent() => MessageBox.Show(FiredEmployee(), "Administration");

        public void AdministrationEvent() => MessageBox.Show(HireEmployee(), "Administration");
        
    }
}
