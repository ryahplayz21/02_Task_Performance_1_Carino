using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _02_Task_Performance_1.QueuingForm;

namespace _02_Task_Performance_1
{
    public partial class DisplayCurrentServing : Form
    {
        QueuingForm qf;
        public DisplayCurrentServing()
        {
            InitializeComponent();
            AutoRefresh();
            qf = new QueuingForm();
        }

        private void AutoRefresh()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); //1 sec
            timer.Tick += new EventHandler(RefreshTimer_Tick);
            timer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (qf.GetCount > 0)
            {
                QueueNumber.Visible = true;
                try
                {
                    if (CashierClass.CashierQueue.Contains(CashierClass.CashierQueue.Peek()))
                    {
                        QueueNumber.Text = CashierClass.CashierQueue.Peek();
                    }
                }
                catch (System.InvalidOperationException)
                {
                    //This will ignore the exception thrown by the system if the queue was empty
                }
            }
        }

        private void QueueNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
