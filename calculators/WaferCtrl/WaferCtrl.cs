using System;
using System.Drawing;
using System.Windows.Forms;

namespace WaferCtrl
{
    public partial class WaferCtrl: UserControl
    {
        public Action<TextBox> toggleSelect;
        public WaferCtrl()
        {
            InitializeComponent();
            foreach (var g in gbWafer.Controls)
            {
                GroupBox gb = g as GroupBox;
                foreach (var t in gb.Controls)
                {
                    TextBox tb = t as TextBox;
                    tb.Click += textBox_Click;
                    tb.Text = gb.Text + tb.Text;
                    tb.ReadOnly = true;
                }
            }
        }

        private void textBox_Click(object sender, System.EventArgs e)
        {
            toggleSelect?.Invoke(sender as TextBox);
        }
    }
}
