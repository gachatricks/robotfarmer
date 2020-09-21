using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RobotFarmer
{
    class MouseEvents
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int FindWindow(string ClassName, string WindowName);


        private const uint WM_LBUTTONDOWN = 0x0201;
        private const uint WM_LBUTTONUP = 0x0202;
        private const uint WM_LDBLCLICK = 0x0203;
        private const uint WM_RBUTTONDOWN = 0x0204;
        private const uint WM_RBUTTONUP = 0x0205;
        private const int MK_LBUTTON = 1;

        public static int MAKELPARAM(int p, int p_2)
        {
            return ((p_2 << 16) | (p & 0xFFFF));
        }


        public static IntPtr hWndC_Final;


        public static void INIT()
        {


            int hWnd = FindWindow(null, "Naruto");

            if (hWnd > 0)
            {
                IntPtr intptr = new IntPtr(hWnd);
                hWndC_Final = intptr;

            }
            else
            {
                MessageBox.Show("NOX not found\nRename your NOX to Naruto", "ERROR");
                Application.Exit();
            }


        }


        public static void CLICKIT(int X,int Y)
        {
            SendMessage((int)hWndC_Final, WM_LBUTTONDOWN, MK_LBUTTON, MAKELPARAM(X, Y));
            SendMessage((int)hWndC_Final, WM_LBUTTONUP, 0, MAKELPARAM(X, Y));
        }




        

    }
}
