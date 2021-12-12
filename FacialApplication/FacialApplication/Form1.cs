using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FacialApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run();
        }

        private void run()
        {
            string filename = @"C:/Users/jayso/PycharmProjects/pythonProject/main.py";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe", filename)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
