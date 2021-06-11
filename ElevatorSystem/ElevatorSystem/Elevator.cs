using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


             

namespace ElevatorSystem
{
    public partial class Elevator : Form
    {
        int DownLiftY = 381;
        int UpLiftY = 37;

        DataAdapter conn = new DataAdapter();
        Openclose oc = new Openclose();
        Delaytime d = new Delaytime();
        MoveUpDown mov = new MoveUpDown();
        
        public Elevator()
        {
            InitializeComponent();
        }

        private void Downbtn_Click(object sender, EventArgs e)
        {
            Downbtn.Image = Properties.Resources.DownbtnClick;
            Downbtn.Enabled = false;
            Upbtn.Enabled = false;
            AutoUpTimer.Stop();
            AutoDownTimer.Stop();
            Delay.Stop();
            DownCloseTimer.Start();
        }

        private void Upbtn_Click(object sender, EventArgs e)
        {
            Upbtn.Image = Properties.Resources.UpbtnClick;
            Downbtn.Enabled = false;
            Upbtn.Enabled = false;
            AutoUpTimer.Stop();
            AutoDownTimer.Stop();
            Delay.Stop();
            UpCloseTimer.Start();
        }

        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            mov.MovingUp(InsideLift, MoveUpTimer, UpOpenTimer, UpArrowDisplay, FlooroneDisplay, Downbtnimage);
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            mov.MovingDown(InsideLift, MoveDownTimer, DownOpenTimer, DownArrowDisplay, FloorzeroDisplay, Upbtnimage);
        }

        private void FloorOnebtn_Click(object sender, EventArgs e)
        {
            if (InsideLift.Top == DownLiftY)
            {
                DisableButton();
                AutoUpTimer.Stop();
                AutoDownTimer.Stop();
                Delay.Stop();
                DownCloseTimer.Start();
            }
        }

        private void FloorZerobtn_Click(object sender, EventArgs e)
        {
            if (InsideLift.Top == UpLiftY)
            {
                DisableButton();
                AutoUpTimer.Stop();
                AutoDownTimer.Stop();
                Delay.Stop();
                UpCloseTimer.Start();
            }
        }

        private void DownCloseTimer_Tick(object sender, EventArgs e)
        {
            oc.CloseDown(DownLeftLift, DownRightLift, DownCloseTimer, MoveUpTimer);
        }

        private void UpCloseTimer_Tick(object sender, EventArgs e)
        {
            oc.CloseUp(UpLeftLift, UpRightLift, UpCloseTimer, MoveDownTimer);       
        }

        private void UpOpenTimer_Tick(object sender, EventArgs e)
        {
            oc.OpenUp(UpLeftLift, UpRightLift, UpOpenTimer, Delay, EnableButton);
        }

        private void DownOpenTimer_Tick(object sender, EventArgs e)
        {
            oc.OpenDown(DownLeftLift, DownRightLift, DownOpenTimer, Delay, EnableButton);
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            try
            {
                LogBox.Items.Clear();
                DataSet ds = conn.DisplayData();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LogBox.Items.Add(row["Logtime"].ToString() + "\t\t" + row["Logaction"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AutoUpTimer_Tick(object sender, EventArgs e)
        {
            d.Autoup(UpLeftLift, UpRightLift, Delay, AutoUpTimer);
        }

        private void AutoDownTimer_Tick(object sender, EventArgs e)
        {
            d.Autodown(DownLeftLift, DownRightLift, Delay, AutoDownTimer);
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            if (InsideLift.Top == UpLiftY)
            {
                AutoUpTimer.Start();
            }
            else if (InsideLift.Top == DownLiftY)
            {
                AutoDownTimer.Start();
            }

        }
        public void DisableButton()
        {
            Downbtn.Enabled = false;
            Upbtn.Enabled = false;
            FloorOnebtn.Enabled = false;
            FloorZerobtn.Enabled = false;
        }

        public void EnableButton()
        {
            FloorOnebtn.Enabled = true;
            FloorZerobtn.Enabled = true;
            Upbtn.Enabled = true;
            Downbtn.Enabled = true;
        }

        public void FloorzeroDisplay()
        {
            UpDisplay.Image = Properties.Resources.DisplayZero;
            DownDisplay.Image = Properties.Resources.DisplayZero;
            ControlDisplay.Image = Properties.Resources.DisplayZero;
        }

        public void UpArrowDisplay()
        {
            UpDisplay.Image = Properties.Resources.UpArrow;
            DownDisplay.Image = Properties.Resources.UpArrow;
            ControlDisplay.Image = Properties.Resources.UpArrow;
        }

        public void DownArrowDisplay()
        {
            UpDisplay.Image = Properties.Resources.DownArrow;
            DownDisplay.Image = Properties.Resources.DownArrow;
            ControlDisplay.Image = Properties.Resources.DownArrow;
        }

        public void FlooroneDisplay()
        {
            UpDisplay.Image = Properties.Resources.DisplayOne;
            DownDisplay.Image = Properties.Resources.DisplayOne;
            ControlDisplay.Image = Properties.Resources.DisplayOne;
        }

        public void Downbtnimage()
        {
            Downbtn.Image = Properties.Resources.DownBtn;
        }

        public void Upbtnimage()
        {
            Upbtn.Image = Properties.Resources.UpBtn;
        }

        private void InsertLogbtn_Click(object sender, EventArgs e)
        {
            if (!DbBackgroundWorker.IsBusy)
            {
                DbBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Updating Database");
            }
        }

        private void DbBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            conn.UpdateData();
        }

    }
} 
