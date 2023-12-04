using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    internal class Administration : IHire
    {
        public string HireEmployee()
        {
            return "Наймаєм нового працівника в адміністрацію.";
        }

        public void AdministrationEvent()
        {
            MessageBox.Show(HireEmployee(), "Адміністрація");
        }
    }
}
