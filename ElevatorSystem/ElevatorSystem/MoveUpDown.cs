using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElevatorSystem
{
    class MoveUpDown
    {
        DataAdapter conn = new DataAdapter();
        public void MovingUp(PictureBox insidelift, Timer moveuptimer, Timer upopentimer, Action uparrowdisplay, Action flooronedisplay, Action downbtnimage)
        {
            if (insidelift.Top == 37) // i.e 37
            {
                moveuptimer.Stop();
                conn.StoreData("Lift Moving Up");
                flooronedisplay();
                downbtnimage();
                upopentimer.Start();
            }
            else if (insidelift.Top <= 381) // i.e 381
            {
                uparrowdisplay();
                insidelift.Top -= 1;
            }
        }

        public void MovingDown(PictureBox insidelift, Timer movedowntimer, Timer downopentimer, Action downarrowdisplay, Action floorzerodisplay, Action upbtnimage)
        {
            if (insidelift.Top == 381) // i.e 381
            {
                movedowntimer.Stop();
                conn.StoreData("Lift Moving Down");
                floorzerodisplay();
                upbtnimage();
                downopentimer.Start();
            }
            else if (insidelift.Top >= 37) // i.e 37
            {
                downarrowdisplay();
                insidelift.Top += 1;
            }
        }
    }
}