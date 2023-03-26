using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUC
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public TextBox TextBox1
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }
        public TextBox TextBox2
        {
            get { return textBox2; }
            set { textBox2 = value; }
        }
        public ComboBox ComboBox1
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }
    }
}
