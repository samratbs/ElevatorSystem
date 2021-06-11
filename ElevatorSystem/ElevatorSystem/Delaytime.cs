using System.Windows.Forms;

namespace ElevatorSystem
{
    class Delaytime
    {
        DataAdapter conn = new DataAdapter();
        public void Autoup(PictureBox UpLeftLift, PictureBox UpRightLift, Timer delay, Timer autoup)
        {
            if (UpLeftLift.Left == 78)
            {
                conn.StoreData("Floor 1 Lift Closing");
                autoup.Stop();
                delay.Stop();
            }
            else if (UpLeftLift.Left >= 9)
            {
                UpLeftLift.Left += 1;
                UpRightLift.Left -= 1;
            }
        }

        public void Autodown(PictureBox DownLeftLift, PictureBox DownRightLift, Timer delay, Timer autodown)
        {
            if (DownLeftLift.Left == 78)
            {
                autodown.Stop();
                delay.Stop();
                conn.StoreData("Floor 0 Lift Closing");
            }
            else if (DownLeftLift.Left >= 9)
            {
                DownLeftLift.Left += 1;
                DownRightLift.Left -= 1;
            }
        }
    }
}