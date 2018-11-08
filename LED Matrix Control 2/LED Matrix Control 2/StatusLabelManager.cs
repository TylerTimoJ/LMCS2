using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Matrix_Control_2
{
    public class StatusLabelManager
    {
        MainForm form;

        int?[] previousFPS = new int?[60];


        public StatusLabelManager()
        {
            form = (MainForm)Application.OpenForms[0];
            for (int i = 0; i < 60; i++)
            {
                previousFPS[i] = 30;
            }
        }


        

    }
}
