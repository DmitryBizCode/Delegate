using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Delegate
{
    public partial class Form1 : Form
    {
        private EventNotifier delegatwork = new EventNotifier();
        public Form1()
        {
            InitializeComponent();

            delegatwork.Activate += EventAdmin_Activate;
            delegatwork.Activate += EventHR_Activate;
            delegatwork.Activate += EventEngeen_Activate;
            delegatwork.Activate += EventWorker_Activate;
            delegatwork.Activate += EventHRFire_Activate;
            

            delegatwork.NewOrderEvent += EventNotifier_NewOrderEvent;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (UInt32.TryParse(Cars.Text, out uint carCount))
            {
                if (carCount < 1)
                {
                    MessageBox.Show("Invalid enter data");
                }
                else
                {                    
                    delegatwork.TriggerNewOrderEvent();
                    delegatwork.TriggerEvent();                    
                }
            }
            else
            {
                MessageBox.Show("Invalid enter data");
            }
                
        }
        private void EventAdmin_Activate()
        {
            try {
                if (UInt32.TryParse(Cars.Text, out uint carCount))
                {
                    Administration admin = new Administration();
                    if (carCount > 20)                   
                        admin.AdministrationEvent();                   
                }
                else                
                    throw new Exception();                
            }
            catch { }
        }
        private void EventWorker_Activate()
        {
            try
            {
                if (UInt32.TryParse(Cars.Text, out uint carCount))
                {
                    Worker worker = new Worker();
                    if (carCount > 0)
                        worker.ConstructedCar(carCount);
                }
                else
                    throw new Exception();
            }
            catch { }
        }
        private void EventEngeen_Activate()
        {
            try
            {
                if (UInt32.TryParse(Cars.Text, out uint carCount))
                {
                    Engineer engineer = new Engineer();
                    if (carCount > 0)
                        engineer.EngineerEvent();
                }
                else
                    throw new Exception();
            }
            catch { }
        }
        private void EventHR_Activate()
        {
            try
            {
                if (UInt32.TryParse(Cars.Text, out uint carCount))
                {                      
                    HR hr = new HR();
                    if (carCount > 3)                    
                        hr.HREvent();                     
                }
                else                
                    throw new Exception();                
            }
            catch
            {
                MessageBox.Show("Invalid enter data");
            }
        }
        private void EventHRFire_Activate()
        {
            try
            {
                if (UInt32.TryParse(Cars.Text, out uint carCount))
                {
                    
                    if (carCount > 3)
                    {
                        HR hr = new HR();
                        hr.HRFireEvent();
                    }
                    if (carCount > 20)
                    {
                        Administration admin = new Administration();
                        admin.AdministrationFireEvent();
                    }
                }
                else
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Invalid enter data");
            }
        }
        private void EventNotifier_NewOrderEvent(object sender, EventArgs e)
        {
            MessageBox.Show("New order", "WARNING");
        }
    }
}
