using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaferTestApp
{
    public partial class Form1 : Form
    {
        // color settings
        Color cSelect = Color.WhiteSmoke;
        Color cUnSelect = Color.DarkGray;
        Color cPass = Color.LightGreen;
        Color cFail = Color.LightSalmon;

        // Wafer Design Infor
        const double dX = 10;
        const double dY = 15;
        const double DX = 70;
        const double DY = 120;

        // other members
        double regX;
        double regY;
        bool m_bRuning;
        SiteInfor[] siteList;

        public Form1()
        {
            InitializeComponent();

            waferCtrl1.Enabled = false;
            waferCtrl1.toggleSelect = toggleSelected;

            InitializeSites();
        }

        #region DetailImpl

        void InitializeSites()
        {
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
                    tb.BackColor = cUnSelect;
                    var s = new SiteInfor()
                    { Name = tb.Text, Id = i, Selected = false, State = STATE.UNTESTED };
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
                        tb.BackColor = cUnSelect;
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
                    tb.BackColor = s.Selected ? cSelect : cUnSelect;
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
            m_bRuning = true;

            buttonRun.Enabled = false;
            buttonAbort.Enabled = true;

            foreach (var g in waferCtrl1.gbWafer.Controls)
            {
                if (m_bRuning)
                {
                    GroupBox gb = g as GroupBox;
                    foreach (var t in gb.Controls)
                    {
                        if (m_bRuning)
                        {
                            TextBox tb = t as TextBox;
                            SiteInfor s = tb.Tag as SiteInfor;
                            if (m_bRuning && s.Selected && s.State == STATE.UNTESTED)
                            {
                                await Task.Run(() => MoveTo(s));
                                tb.BackColor = s.State == STATE.PASS ? cPass : cFail;
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
            m_bRuning = false;
        }

        #endregion

        Random random = new Random();
        private void MoveTo(SiteInfor s)
        {
            Console.WriteLine($" x:{regX + s.X :G4}; y:{regY + s.Y :G4}");
            Thread.Sleep(500);
            s.State = random.NextDouble() > 0.2 ? STATE.PASS : STATE.FAIL;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            // Init Registartion
            regX = 100;
            regY = 200;

            buttonRun.Enabled = true;
        }
    }
}
