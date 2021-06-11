using System;
using System.Windows.Forms;
using ElevatorSystem.Properties;

namespace ElevatorSystem
{
    class Openclose
    {
        DataAdapter conn = new DataAdapter();
        
        public void CloseDown(PictureBox DownLeftLift, PictureBox DownRightLift, Timer downclosetimer, Timer moveuptimer)
        {
            if (DownLeftLift.Left == 78)
            {
                downclosetimer.Stop();
                conn.StoreData("Floor 0 Lift Closing");
                moveuptimer.Start();

            }
            else if (DownLeftLift.Left >= 9)
            {
                DownLeftLift.Left += 1;
                DownRightLift.Left -= 1;
            }
        }

        public void CloseUp(PictureBox UpLeftLift, PictureBox UpRightLift, Timer upclosetimer, Timer movedowntimer)
        {
            if (UpLeftLift.Left == 78)
            {
                upclosetimer.Stop();
                conn.StoreData("Floor 1 Lift Closing");
                movedowntimer.Start();
            }
            else if (UpLeftLift.Left >= 9)
            {
                UpLeftLift.Left += 1;
                UpRightLift.Left -= 1;
            }
        }

        public void OpenUp(PictureBox UpLeftLift, PictureBox UpRightLift, Timer upopentimer, Timer delaytimer, Action enablebutton)
        {
            if (UpLeftLift.Left == 9)
            {
                upopentimer.Stop();
                enablebutton();
                conn.StoreData("Floor 1 Lift Opening");
                delaytimer.Start();
            }
            else if (UpLeftLift.Left <= 103)
            {
                UpLeftLift.Left -= 1;
                UpRightLift.Left += 1;
            }
        }

        public void OpenDown(PictureBox DownLeftLift, PictureBox DownRightLift, Timer downopentimer, Timer delaytimer, Action enablebutton)
        {
            if (DownLeftLift.Left == 9)
            {
                downopentimer.Stop();
                enablebutton();
                conn.StoreData("Floor 0 Lift Opening");
                delaytimer.Start();

            }
            else if (DownLeftLift.Left <= 103)
            {
                DownLeftLift.Left -= 1;
                DownRightLift.Left += 1;
            }
        }
    }
}