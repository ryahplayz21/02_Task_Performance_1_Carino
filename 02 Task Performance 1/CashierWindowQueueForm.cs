using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static _02_Task_Performance_1.QueuingForm;

namespace _02_Task_Performance_1
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            AutoRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(QueuingForm.CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void AutoRefresh()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); //1 sec
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //After the interval, this method will be called
        {
            DisplayCashierQueue(QueuingForm.CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                CashierClass.CashierQueue.Dequeue();
            }
            catch (System.InvalidOperationException)
            {
                //This will ignore that the system will throw when dequeue was executed but the queue is empty
            }
        }

        private void announcementLabel_Click(object sender, EventArgs e)
        {

        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
