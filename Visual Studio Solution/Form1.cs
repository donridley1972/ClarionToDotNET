using System;
using System.Runtime.InteropServices;

namespace ClarionToDotNet
{
    public partial class Form1 : Form
    {
        [DllImport(@"ClaRUN.dll")]
        public static extern void AttachThreadToClarion(bool pAllocate);

        [DllImport(@"ClarionToDotNetDLL.dll")]
        public static extern void HelloFromClarion();

        [DllImport(@"ClarionToDotNetDLL.dll")]
        public static extern void BrowseClasses();

        [DllImport(@"ClarionToDotNetDLL.dll")]
        public static extern void BrowseStudents();

        public Form1()
        {
            InitializeComponent();
            AttachThreadToClarion(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelloFromClarion();
            //CallHelloFromClarion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BrowseClasses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BrowseStudents();
        }
    }
}