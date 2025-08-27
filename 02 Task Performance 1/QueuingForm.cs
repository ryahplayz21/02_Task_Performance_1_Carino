using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Task_Performance_1
{
    public partial class QueuingForm : Form
    {
        public static int count = 0;
        CashierClass cashier;
        CashierWindowQueueForm cashierWindowQueueForm;
        DisplayCurrentServing displayCurrent;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        public int GetCount
        {
            get { return count; }
            set { count = value; }
        }

        public class CashierClass //Create Cashier Class
        {
            private int x;
            public static string getNumberInQueue = "";
            public static Queue<string> CashierQueue;

            public CashierClass()
            {
                x = 10000;
                CashierQueue = new Queue<string>();
            }

            public string CashierGeneratedNumber(string CashierNumber)
            {
                x++; //10000 + 1
                CashierNumber = CashierNumber + x.ToString(); //This will be string + "10001"
                return CashierNumber;
            }
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            count = count + 1; //to determine the number of clicks
            lblQueue.Text = cashier.CashierGeneratedNumber("P - "); 
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            if(count > 0) //once the button is clicked the lblQueue will become visible
            {
                lblQueue.Visible = true;
            }
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show(); //Show the CashierWindowQueueForm when the QueuingForm is initialized
            displayCurrent = new DisplayCurrentServing();
            displayCurrent.Show(); //Show the other form named DisplayCurrentServing
        }
    }
}
