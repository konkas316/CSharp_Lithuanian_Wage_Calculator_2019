using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlyginimo_Skaiciavimo_Sistema
{
    public partial class Form1 : Form
    {
        private Double atlyginimas;
        private Double NPD;
        private Double IRankas;
        readonly MokesciaiAntPop mok = new MokesciaiAntPop();
        readonly MokesciaiIrankas mok2 = new MokesciaiIrankas();
        public Form1()
        {
            InitializeComponent();

            label3.Text = "Kaupiu pensijai \n papildomai";
            label4.Visible = false;

            Isvedimas.SelectAll();
            Isvedimas.SelectionAlignment = HorizontalAlignment.Right;

            Isvedimas2.SelectAll();
            Isvedimas2.SelectionAlignment = HorizontalAlignment.Right;

            chkKaupPens.Checked = false;

            cmbPensProc.Visible = false;

            txtNPDnur.Visible = false;

            cmbPensProc.Items.Add("1.8 %");
            cmbPensProc.Items.Add("3 %");

            cmbPensProc.SelectedItem = "1.8 %";

            txtAtlyginimoStatusas.Text = "\"Ant popieriaus\"";

            tuscia();
        }
        public void tuscia()
        {
            Isvedimas.Text = "" + "" + "  \n\n" + "" + "  \n\n" + "" + "  \n\n" + "" + "  \n\n" + "" + "" +
                "  \n\n" + "" + "  \n\n" + " \n\n" + "" + "  \n\n" + "" + "  \n\n";

            Isvedimas2.Text = "" + "" + "  \n\n" + "" + "  \n\n" + "" + "  \n\n" + "" + "  \n\n" + "" +
                "  \n\n" + "" + "  \n\n" + " \n\n" + "" + "  \n\n" + "" + "  \n\n";
        }
        private void AtlyginimasTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (rdbPaskSist.Checked)
                {
                    //rdbPats.Checked = false;   

                    //if (chkKaupPens.CheckState == CheckState.Unchecked)
                    {
                        atlyginimas = Double.Parse(AtlyginimasTXT.Text);

                        if (tbpAntPop == AtlAntPopIrank.SelectedTab)
                        {
                            mok.atl = atlyginimas;

                            if (atlyginimas < 300)
                            {
                                mok.maziauNei300();
                            }

                            if (atlyginimas <= 555 && atlyginimas > 300)
                            {
                                mok.maziauLygu555_Daugiau300();
                            }

                            if (atlyginimas > 555)
                            {
                                mok.daugiauNei555();
                            }

                            if (atlyginimas > 2555)
                            {
                                mok.daugiauNei2555();
                            }

                            mok.nekintantysMokesciai();
                            mok.bazinisSPsD();

                            IRankas = atlyginimas - mok.SSD - mok.PM - mok.SPSD;

                            Isvedimas.Text = "" + atlyginimas.ToString("N2") + " € \n\n" + mok.NPD.ToString("N2") +
                                " € \n\n" + mok.PM.ToString("N2") + " € \n\n" + mok.SSD.ToString("N2") +
                                " € \n\n" + mok.SPSD.ToString("N2") + " € \n\n" + IRankas.ToString("N2") +
                                   " € \n\n" + " \n\n" + mok.Sodra.ToString("N2") + " € \n\n" +
                                   mok.DBVK.ToString("N2") + " € \n\n";

                        }

                        if (tbpIrank == AtlAntPopIrank.SelectedTab)
                        {
                            atlyginimas = Double.Parse(AtlyginimasTXT.Text) * 39.5 / 60.5 +
                                Double.Parse(AtlyginimasTXT.Text);

                            mok2.atl = atlyginimas;

                            if (atlyginimas <= 399.1735537190083)
                            {
                                mok2.maziauNei399_17();
                            }

                            if (atlyginimas <= 654.1652892561983 && atlyginimas > 399.1735537190083)
                            {
                                mok2.maziauLygu654_15_Daugiau399_17();
                            }

                            if (atlyginimas > 654.1652892561983)
                            {
                                mok2.daugiauNei654_15();
                            }

                            if (atlyginimas > 2554.99173553719)
                            {
                                mok2.daugiauNei2554_99();
                            }

                            mok2.nekintantysMokesciai2();
                            mok2.bazinisSPsD2();

                            Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                                mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                                mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                                (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") +
                                    " € \n\n" + " \n\n" + mok2.Sodra.ToString("N2") + "€ \n\n" +
                                    mok2.DBVK.ToString("N2") + " € \n\n";
                        }
                    }
                }

                if (chkKaupPens.CheckState == CheckState.Checked)
                {
                    cmbPensProc_SelectedIndexChanged(sender, e);
                }

                if (rdbPats.Checked)
                {
                    rdbPaskSist.Checked = false;

                    txtNPDnur_TextChanged(sender, e);
                }
            }
            catch
            {

            }
        }
        private void AtlAntPopIrank_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtlyginimasTXT_TextChanged(sender, e);

            if (tbpAntPop == AtlAntPopIrank.SelectedTab)
            {
                txtAtlyginimoStatusas.Text = "\"Ant popieriaus\"";

                Isvedimas.Enabled = true;
            }

            if (tbpIrank == AtlAntPopIrank.SelectedTab)
            {
                txtAtlyginimoStatusas.Text = "\"Į rankas\"";

                Isvedimas2.Enabled = true;
            }
        }
        private void txtNPDnur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NPD = Double.Parse(txtNPDnur.Text);

                //if (chkKaupPens.CheckState == CheckState.Unchecked)
                {
                    if (rdbPats.Checked)
                    {
                        rdbPaskSist.Checked = false;

                        if (tbpAntPop == AtlAntPopIrank.SelectedTab)
                        {
                            mok.atl = atlyginimas;
                            mok.NPDnur = NPD;

                            if (atlyginimas <= NPD)
                            {
                                mok.atlyginimasMaziauArLyguNurNPD();
                            }

                            if (atlyginimas > NPD)
                            {
                                mok.atlyginimasDaugiauNurNPD();
                            }

                            IRankas = atlyginimas - mok.SSD - mok.PM - mok.SPSD;

                            Isvedimas.Text = "" + atlyginimas.ToString("N2") + " € \n\n" + mok.NPD.ToString("N2") +
                                " € \n\n" + mok.PM.ToString("N2") + " € \n\n" + mok.SSD.ToString("N2") +
                                " € \n\n" + mok.SPSD.ToString("N2") + " € \n\n" + IRankas.ToString("N2") +
                                  " € \n\n" + " \n\n" + mok.Sodra.ToString("N2") + " € \n\n" +
                                  mok.DBVK.ToString("N2") + " € \n\n";
                        }

                        if (tbpIrank == AtlAntPopIrank.SelectedTab)
                        {
                            mok2.atl = atlyginimas;
                            mok2.NPDnur = NPD;

                            if (Double.Parse(AtlyginimasTXT.Text) < NPD)
                            {
                                mok2.atlyginimasMaziauNurNPD();

                                if (mok2.TikrasAtlyginimas < NPD)
                                {
                                    mok2.TikrasAtlyginimasMaziauNPD();
                                }
                            }

                            if (Double.Parse(AtlyginimasTXT.Text) >= NPD)
                            {
                                mok2.atlyginimasDaugiauNurNPD();

                                if (mok2.TikrasAtlyginimas < NPD)
                                {
                                    mok2.TikrasAtlyginimasMaziauNPD2();
                                }
                            }

                            Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                                mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                                mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                                (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") +
                                     " € \n\n" + " \n\n" + mok2.Sodra.ToString("N2") + "€ \n\n" +
                                     mok2.DBVK.ToString("N2") + " € \n\n";
                        }
                    }
                }

                if (chkKaupPens.CheckState == CheckState.Checked)
                {
                    cmbPensProc_SelectedIndexChanged(sender, e);

                    label4.Visible = true;
                }
            }
            catch
            {

            }
        }
        private void NPDSistNur(object sender, EventArgs e)
        {
            AtlyginimasTXT_TextChanged(sender, e);

            if (rdbPaskSist.Checked)
            {
                rdbPats.Checked = false;

                txtNPDnur.Visible = false;
            }

            if (rdbPats.Checked)
            {
                rdbPaskSist.Checked = false;

                txtNPDnur.Visible = true;

                txtNPDnur.Text = "0";
            }
        }
        private void chkKaupPens_CheckedChanged(object sender, EventArgs e)
        {
            AtlyginimasTXT_TextChanged(sender, e);

            txtNPDnur_TextChanged(sender, e);

            if (string.IsNullOrEmpty(AtlyginimasTXT.Text))
            {
                tuscia();
            }

            if (chkKaupPens.CheckState == CheckState.Unchecked)
            {
                cmbPensProc.Visible = false;

                label4.Visible = false;
            }

            if (chkKaupPens.CheckState == CheckState.Unchecked)
            {
                cmbPensProc.Visible = false;

                label4.Visible = false;

                if (rdbPats.Checked)
                {
                    rdbPaskSist.Checked = false;
                }
            }

            if (chkKaupPens.CheckState == CheckState.Checked)
            {
                cmbPensProc.Visible = true;

                if (rdbPats.Checked)
                {
                    rdbPaskSist.Checked = false;
                }
            }
        }
        private void cmbPensProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    dynamic item = cmbPensProc.SelectedItem;

                    if (tbpAntPop == AtlAntPopIrank.SelectedTab)
                    {
                        {
                            {
                                if (rdbPaskSist.Checked)
                                {
                                    rdbPats.Checked = false;

                                    //if (chkKaupPens.CheckState == CheckState.Unchecked)
                                    {
                                        mok.atl = atlyginimas;

                                        mok.bazinisSPsD();

                                        IRankas = atlyginimas - mok.SSD - mok.PM - mok.SPSD;

                                        Isvedimas.Text = "" + atlyginimas.ToString("N2") + " € \n\n" +
                                            mok.NPD.ToString("N2") + " € \n\n" + mok.PM.ToString("N2") +
                                            " € \n\n" + mok.SSD.ToString("N2") + " € \n\n" +
                                            mok.SPSD.ToString("N2") + " € \n\n" + IRankas.ToString("N2") +
                                       " € \n\n" + " \n\n" + mok.Sodra.ToString("N2") + " € \n\n" +
                                       mok.DBVK.ToString("N2") + " € \n\n";
                                    }
                                }
                            }
                        }

                        if (chkKaupPens.CheckState == CheckState.Checked)
                        {

                            if (item == "1.8 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "1.8 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                mok.viensAstuoni();

                                if (rdbPaskSist.Checked)
                                {
                                    rdbPats.Checked = false;
                                }

                                if (rdbPats.Checked)
                                {
                                    rdbPaskSist.Checked = false;
                                }


                                IRankas = atlyginimas - mok.SSD - mok.PM - mok.SPSD;

                                Isvedimas.Text = "" + atlyginimas.ToString("N2") + " € \n\n" +
                                    mok.NPD.ToString("N2") + " € \n\n" + mok.PM.ToString("N2") + " € \n\n" +
                                    mok.SSD.ToString("N2") + " € \n\n" + mok.SPSD.ToString("N2") + " € \n\n" +
                                    IRankas.ToString("N2") + " € \n\n" + " \n\n" + mok.Sodra.ToString("N2") +
                                    " € \n\n" + mok.DBVK.ToString("N2") + " € \n\n";
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                mok.trys();

                                if (rdbPaskSist.Checked)
                                {
                                    rdbPats.Checked = false;
                                }

                                if (rdbPats.Checked)
                                {
                                    rdbPaskSist.Checked = false;
                                }

                                IRankas = atlyginimas - mok.SSD - mok.PM - mok.SPSD;

                                Isvedimas.Text = "" + atlyginimas.ToString("N2") + " € \n\n" +
                                    mok.NPD.ToString("N2") + " € \n\n" + mok.PM.ToString("N2") + " € \n\n" +
                                    mok.SSD.ToString("N2") + " € \n\n" + mok.SPSD.ToString("N2") + " € \n\n" +
                                    IRankas.ToString("N2") + " € \n\n" + " \n\n" + mok.Sodra.ToString("N2") +
                                    " € \n\n" + mok.DBVK.ToString("N2") + " € \n\n";
                            }
                        }
                    }

                    if (tbpIrank == AtlAntPopIrank.SelectedTab)
                    {
                        if (rdbPaskSist.Checked)
                        {
                            rdbPats.Checked = false;

                            if (item == "1.8 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "1.8 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                if (atlyginimas < 390.2479338842975)
                                {
                                    mok2.maziauNei390_2479338842975();
                                }

                                if (atlyginimas < 637.6528925619835 && atlyginimas >= 390.2479338842975)
                                {
                                    mok2.maziauNei637_6528925619835irDaugiauNei390_2479338842975();
                                }

                                if (atlyginimas < 2478.97520661157 && atlyginimas >= 637.6528925619835)
                                {
                                    mok2.maziausNei2478_97520661157irDaugiauNei637_6528925619835();
                                }

                                if (atlyginimas >= 2478.97520661157)
                                {
                                    mok2.daugiauNei2478_97520661157();
                                }

                                mok2.nekintantysMokesciai2();

                                Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                                    mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                                    mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                                    (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") + " € \n\n" + " \n\n" +
                                    mok2.Sodra.ToString("N2") + "€ \n\n" + mok2.DBVK.ToString("N2") + " € \n\n";
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                if (atlyginimas <= 384.297520661157)
                                {
                                    mok2.maziauNei384_297520661157();
                                }

                                if (atlyginimas <= 626.6528925619835 && atlyginimas > 384.297520661157)
                                {
                                    mok2.maziauNei626_6528925619835irDaugiauNei384_297520661157();
                                }

                                if (atlyginimas <= 2428.314049586777 && atlyginimas > 626.6528925619835)
                                {
                                    mok2.maziauNei2428_314049586777irDaugiauNei626_6528925619835();
                                }

                                if (atlyginimas > 2428.314049586777)
                                {
                                    mok2.daugiauNei2428_314049586777();
                                }
                            }
                        }

                        mok2.nekintantysMokesciai2();

                        Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                            mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                            mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                            (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") + " € \n\n" + " \n\n" +
                            mok2.Sodra.ToString("N2") + "€ \n\n" + mok2.DBVK.ToString("N2") + " € \n\n";

                        if (rdbPats.Checked)
                        {
                            rdbPaskSist.Checked = false;

                            if (item == "1.8 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "1.8 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                if (Double.Parse(AtlyginimasTXT.Text) >= NPD)
                                {
                                    mok2.daugiauArbaLyguNPDnur();
                                }

                                if (Double.Parse(AtlyginimasTXT.Text) < NPD)
                                {
                                    mok2.maziauNPDnur();

                                    if (mok2.TikrasAtlyginimas < NPD)
                                    {
                                        mok2.TikrasAtlyginimasMaziauNeiNPD();
                                    }
                                }

                                Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                                    mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                                    mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                                    (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") + " € \n\n" + " \n\n" +
                                    mok2.Sodra.ToString("N2") + "€ \n\n" + mok2.DBVK.ToString("N2") + " € \n\n";
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text == String.Empty)
                            {
                                tuscia();
                            }

                            if (item == "3 %" && AtlyginimasTXT.Text != String.Empty)
                            {
                                if (Double.Parse(AtlyginimasTXT.Text) >= NPD)
                                {
                                    mok2.maziauArbaLyguNPD();
                                }

                                if (Double.Parse(AtlyginimasTXT.Text) < NPD)
                                {
                                    mok2.AtlyginimasMaziauNeiNPD();

                                    if (mok2.TikrasAtlyginimas < NPD)
                                    {
                                        mok2._TikrasAtlyginimasMaziauNeiNPD();
                                    }
                                }
                            }

                            Isvedimas2.Text = "" + mok2.TikrasAtlyginimas.ToString("N2") + " € \n\n" +
                                mok2.NPD.ToString("N2") + " € \n\n" + mok2.PM.ToString("N2") + " € \n\n" +
                                mok2.SSD.ToString("N2") + " € \n\n" + mok2.SPSD.ToString("N2") + " € \n\n" +
                                (Double.Parse(AtlyginimasTXT.Text)).ToString("N2") + " € \n\n" + " \n\n" +
                                mok2.Sodra.ToString("N2") + "€ \n\n" + mok2.DBVK.ToString("N2") + " € \n\n";
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void AtlyginimasTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtlyginimasTXT.MaxLength = 10;

            if (AtlyginimasTXT.Text == "0")
                AtlyginimasTXT.Clear();
            Isvedimas.Clear();
            Isvedimas2.Clear();

            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false &&
                (e.KeyChar == '.' ? AtlyginimasTXT.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtNPDnur_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNPDnur.MaxLength = 10;

            if (txtNPDnur.Text == "0")
                txtNPDnur.Clear();
            Isvedimas.Clear();
            Isvedimas2.Clear();

            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false &&
                (e.KeyChar == '.' ? txtNPDnur.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label99.Text = " Nurodykite atlyginimą (\"ant popieriaus\" ar \"į rankas\")" +
                " ir įveskite jo sumą. Skaičiuoklė \n automatiškai  paskaičiuos privalomus" +
                " mokėti mokesčius bei atlyginimą prieš ir po \n mokesčių.";
        }

        private void Isvedimas_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Isvedimas_Enter(object sender, EventArgs e)
        {
            label12.Focus();
        }

        private void apvalusMygtukasButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtlAntPopIrank_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            TabPage tp = AtlAntPopIrank.TabPages[e.Index];

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            RectangleF headerRect = new RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2);

            SolidBrush sb = new SolidBrush(Color.LightSteelBlue);

            if (AtlAntPopIrank.SelectedIndex == e.Index)
                sb.Color = Color.LightSteelBlue;

            g.FillRectangle(sb, e.Bounds);

            g.DrawString(tp.Text, AtlAntPopIrank.Font, new SolidBrush(Color.Black), headerRect, sf);

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
