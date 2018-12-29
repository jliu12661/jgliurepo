using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaferTestApp
{
    public partial class Form1 : Form
    {
        bool bRun;
        SiteInfor[] siteList;

        Color cSelect = Color.WhiteSmoke;
        Color cUnSel = Color.DarkGray;
        Color cPass = Color.LightGreen;
        Color cFial = Color.LightSalmon;

        Random random = new Random();

        double regX;
        double regY;

        // Wafer Design Infor
        const double dX = 10;
        const double dY = 15;
        const double DX = 70;
        const double DY = 120;

        public Form1()
        {
            InitializeComponent();

            waferCtrl1.Enabled = false;
            waferCtrl1.toggleSelect = toggleSelected;
            buttonAbort.Enabled = false;

            // Init Registartion
            regX = 100;
            regY = 200;

            // Init Sites and GUI
            siteList = new SiteInfor[132];
            int i = 0;
            foreach (var g in waferCtrl1.gbWafer.Controls)
            {
                var gP = GetGroupPosition(i);
                GroupBox gb = g as GroupBox;
                foreach (var t in gb.Controls)
                {
                    var sP = GetSitePosition(i);
                    TextBox tb = t as TextBox;
                    tb.BackColor = cUnSel;
                    var s = new SiteInfor()
                    { Name = tb.Text, Id = i, Selected = false, State = STATE.UNTESTED};
                    s.X = gP.X + sP.X;
                    s.Y = gP.Y + sP.Y;

                    tb.Tag = s;
                    siteList[i++] = s;
                }
            }
        }

        (double X, double Y) GetGroupPosition(int i)
        {
            double xG, yG;
            if (i < 36)
            {
                int k = i / 12;

                xG = k * DX;
                yG = 0;
            }
            else if (i < 96)
            {
                int k = (i - 36) / 12;

                xG = (k - 1) * DX;
                yG = DY;
            }
            else
            {
                int k = (i - 96) / 12;

                xG = k * DX;
                yG = 2 * DY;
            }

            return (xG, yG);
        }

        (double X, double Y) GetSitePosition(int i)
        {
            int L = i % 12;
            int R = L / 3;
            int C = L % 3;

            return (C * dX, R * dY);
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var g in waferCtrl1.gbWafer.Controls)
            {
                GroupBox gb = g as GroupBox;
                foreach (var t in gb.Controls)
                {
                    TextBox tb = t as TextBox;
                    SiteInfor s = tb.Tag as SiteInfor;
                    if (s.State == STATE.UNTESTED)
                    {
                        s.Selected = true;
                        tb.BackColor = cSelect;
                    }
                }
            }
        }

        private void buttonUnSelect_Click(object sender, EventArgs e)
        {
            foreach (var g in waferCtrl1.gbWafer.Controls)
            {
                GroupBox gb = g as GroupBox;
                foreach (var t in gb.Controls)
                {
                    TextBox tb = t as TextBox;
                    SiteInfor s = tb.Tag as SiteInfor;
                    if (s.State == STATE.UNTESTED)
                    {
                        s.Selected = false;
                        tb.BackColor = cUnSel;
                    }
                }
            }
        }

        private void toggleSelected(TextBox tb)
        {
            if (tb != null)
            {
                SiteInfor s = tb.Tag as SiteInfor;
                if (s.State == STATE.UNTESTED)
                {
                    s.Selected = !s.Selected;
                    tb.BackColor = s.Selected ? cSelect : cUnSel;
                }
            }
        }

        private void cbEnableSelect_CheckedChanged(object sender, EventArgs e)
        {
            waferCtrl1.Enabled = cbEnableSelect.Checked;
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            cbEnableSelect.Checked = false;
            bRun = true;

            buttonRun.Enabled = false;
            buttonAbort.Enabled = true;

            foreach (var g in waferCtrl1.gbWafer.Controls)
            {
                if (bRun)
                {
                    GroupBox gb = g as GroupBox;
                    foreach (var t in gb.Controls)
                    {
                        if (bRun)
                        {
                            TextBox tb = t as TextBox;
                            SiteInfor s = tb.Tag as SiteInfor;
                            if (bRun && s.Selected && s.State == STATE.UNTESTED)
                            {
                                await Task.Run(() => MoveTo(s.X, s.Y));

                                if (random.NextDouble() > 0.1)
                                {
                                    s.State = STATE.PASS;
                                    tb.BackColor = cPass;
                                }
                                else
                                {
                                    s.State = STATE.FAIL;
                                    tb.BackColor = cFial;
                                }

                            }
                        }
                    }
                }
            }

            buttonRun.Enabled = true;
            buttonAbort.Enabled = false;
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            bRun = false;
        }

        private void MoveTo(double x, double y)
        {
            Console.WriteLine($" x:{regX + x :G4}; y:{regY + y :G4}");
            Thread.Sleep(500);
        }
    }
}
