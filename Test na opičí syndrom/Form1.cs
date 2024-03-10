using System;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace Test_na_opičí_syndrom
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Settings for window start
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            (Otazka).Hide();
            (OdpovedA).Hide();
            (OdpovedB).Hide();
            (OdpovedC).Hide();
            (OdpovedD).Hide();
            (MonkeyImage).Hide();
            (MonkeyImage2).Hide();
            (NejlepsiBlazen).Hide();
            (NejlepsiBlazen2).Hide();
        }
        private void CenterControls()
        {
            foreach (Control control in this.Controls)
            {
                // Nastavení umístění a připojení ovládacího prvku k prostředku formuláře
                control.Anchor = AnchorStyles.None; // Zrušení připojení k okrajům
                control.Left = (this.ClientSize.Width - control.Width) / 2;
                control.Top = (this.ClientSize.Height - control.Height) / 2;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }
        /// <summary>
        /// Settings for form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
            //Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Settings and actions for button which starts test.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            (textAutora).Hide();
            (Test).Hide();
            (ApplicationEnd).Hide();
            (MonkeyImage).Hide();
            (MonkeyImage2).Hide();
            (NejlepsiBlazen).Hide();
            (NejlepsiBlazen2).Hide();
            OtazkyAOdpovedi.beh = true;
            Otazka.Text = "Venku je zima a ty musíš jít ven, co si na sebe vezmeš abys měl co největší jistotu, že ti bude teplo?";
            OdpovedA.Text = "Župan";
            OdpovedB.Text = "Velmi roztrhanou a velmi děravou bundu";
            OdpovedC.Text = "Doktorský plášť";
            OdpovedD.Text = "Pytel od brambor";
            (Otazka).Show();
            (OdpovedA).Show();
            (OdpovedB).Show();
            (OdpovedC).Show();
            (OdpovedD).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Action for close application on button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicationEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Settings and actions for button which is working as answer for question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdpovedA_Click(object sender, EventArgs e)
        {
            OtazkyAOdpovedi.odpovediUzivatele += "a ";
            if (OtazkyAOdpovedi.cisloOtazky == OtazkyAOdpovedi.dotaz.Length - 1)
            {
                OtazkyAOdpovedi.beh = false;
                OtazkyAOdpovedi.VypoctiVysledek();
                (OdpovedA).Hide();
                (OdpovedB).Hide();
                (OdpovedC).Hide();
                (OdpovedD).Hide();
                if (OtazkyAOdpovedi.body != OtazkyAOdpovedi.dotaz.Length)
                {
                    (Otazka).Text = String.Format($"Máte opičí syndrom, nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku.\nOtázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length}");
                    (MonkeyImage).Show();
                    (MonkeyImage2).Show();
                    (textAutora).Show();
                }
                else
                {
                    (Otazka).Text = String.Format($"Nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku, otázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length} .\nNemáte tedy diagnózu opičího syndromu. Můžete se považovat za nejlepšího blázna v dobrém slovasmyslu.");
                    (NejlepsiBlazen).Show();
                    (NejlepsiBlazen2).Show();
                }
                OtazkyAOdpovedi.body = 0;
                OtazkyAOdpovedi.cisloOtazky = 0;
                OtazkyAOdpovedi.odpovediUzivatele = "";
                (Test).Show();
                (textAutora).Show();
                (ApplicationEnd).Show();
            }
            if (OtazkyAOdpovedi.beh && OtazkyAOdpovedi.cisloOtazky < OtazkyAOdpovedi.dotaz.Length)
            {
                ++OtazkyAOdpovedi.cisloOtazky;
                Otazka.Text = OtazkyAOdpovedi.dotaz[OtazkyAOdpovedi.cisloOtazky];
                OdpovedA.Text = OtazkyAOdpovedi.odpovediA[OtazkyAOdpovedi.cisloOtazky];
                OdpovedB.Text = OtazkyAOdpovedi.odpovediB[OtazkyAOdpovedi.cisloOtazky];
                OdpovedC.Text = OtazkyAOdpovedi.odpovediC[OtazkyAOdpovedi.cisloOtazky];
                OdpovedD.Text = OtazkyAOdpovedi.odpovediD[OtazkyAOdpovedi.cisloOtazky];
            }
        }

        /// <summary>
        /// Settings and actions for button which is working as answer for question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdpovedB_Click(object sender, EventArgs e)
        {
            OtazkyAOdpovedi.odpovediUzivatele += "b ";
            if (OtazkyAOdpovedi.cisloOtazky == OtazkyAOdpovedi.dotaz.Length - 1)
            {
                OtazkyAOdpovedi.beh = false;
                OtazkyAOdpovedi.VypoctiVysledek();
                (OdpovedA).Hide();
                (OdpovedB).Hide();
                (OdpovedC).Hide();
                (OdpovedD).Hide();
                if (OtazkyAOdpovedi.body != OtazkyAOdpovedi.dotaz.Length)
                {
                    (Otazka).Text = String.Format($"Máte opičí syndrom, nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku. Otázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length}");
                    (MonkeyImage).Show();
                    (MonkeyImage2).Show();

                }
                else
                {
                    (Otazka).Text = String.Format($"Nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku, otázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length} .\nNemáte tedy diagnózu opičího syndromu. Můžete se považovat za nejlepšího blázna v dobrém slovasmyslu.");
                    (NejlepsiBlazen).Show();
                    (NejlepsiBlazen2).Show();
                }
                OtazkyAOdpovedi.body = 0;
                OtazkyAOdpovedi.cisloOtazky = 0;
                OtazkyAOdpovedi.odpovediUzivatele = "";
                (Test).Show();
                (textAutora).Show();
                (ApplicationEnd).Show();
            }
            if (OtazkyAOdpovedi.beh && OtazkyAOdpovedi.cisloOtazky < OtazkyAOdpovedi.dotaz.Length)
            {
                ++OtazkyAOdpovedi.cisloOtazky;
                Otazka.Text = OtazkyAOdpovedi.dotaz[OtazkyAOdpovedi.cisloOtazky];
                OdpovedA.Text = OtazkyAOdpovedi.odpovediA[OtazkyAOdpovedi.cisloOtazky];
                OdpovedB.Text = OtazkyAOdpovedi.odpovediB[OtazkyAOdpovedi.cisloOtazky];
                OdpovedC.Text = OtazkyAOdpovedi.odpovediC[OtazkyAOdpovedi.cisloOtazky];
                OdpovedD.Text = OtazkyAOdpovedi.odpovediD[OtazkyAOdpovedi.cisloOtazky];
            }
        }

        /// <summary>
        /// Settings and actions for button which is working as answer for question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdpovedC_Click(object sender, EventArgs e)
        {
            OtazkyAOdpovedi.odpovediUzivatele += "c ";
            if (OtazkyAOdpovedi.cisloOtazky == OtazkyAOdpovedi.dotaz.Length - 1)
            {
                OtazkyAOdpovedi.beh = false;
                OtazkyAOdpovedi.VypoctiVysledek();
                (OdpovedA).Hide();
                (OdpovedB).Hide();
                (OdpovedC).Hide();
                (OdpovedD).Hide();
                if (OtazkyAOdpovedi.body != OtazkyAOdpovedi.dotaz.Length)
                {
                    (Otazka).Text = String.Format($"Máte opičí syndrom, nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku.\nOtázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length}");
                    (MonkeyImage).Show();
                    (MonkeyImage2).Show();

                }
                else
                {
                    (Otazka).Text = String.Format($"Nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku, otázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length} .\nNemáte tedy diagnózu opičího syndromu. Můžete se považovat za nejlepšího blázna v dobrém slovasmyslu.");
                    (NejlepsiBlazen).Show();
                    (NejlepsiBlazen2).Show();
                }
                OtazkyAOdpovedi.body = 0;
                OtazkyAOdpovedi.cisloOtazky = 0;
                OtazkyAOdpovedi.odpovediUzivatele = "";
                (Test).Show();
                (textAutora).Show();
                (ApplicationEnd).Show();
            }
            if (OtazkyAOdpovedi.beh && OtazkyAOdpovedi.cisloOtazky < OtazkyAOdpovedi.dotaz.Length)
            {
                ++OtazkyAOdpovedi.cisloOtazky;
                Otazka.Text = OtazkyAOdpovedi.dotaz[OtazkyAOdpovedi.cisloOtazky];
                OdpovedA.Text = OtazkyAOdpovedi.odpovediA[OtazkyAOdpovedi.cisloOtazky];
                OdpovedB.Text = OtazkyAOdpovedi.odpovediB[OtazkyAOdpovedi.cisloOtazky];
                OdpovedC.Text = OtazkyAOdpovedi.odpovediC[OtazkyAOdpovedi.cisloOtazky];
                OdpovedD.Text = OtazkyAOdpovedi.odpovediD[OtazkyAOdpovedi.cisloOtazky];
            }
        }

        /// <summary>
        /// Settings and actions for button which is working as answer for question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OdpovedD_Click(object sender, EventArgs e)
        {
            OtazkyAOdpovedi.odpovediUzivatele += "d ";
            if (OtazkyAOdpovedi.cisloOtazky == OtazkyAOdpovedi.dotaz.Length - 1)
            {
                OtazkyAOdpovedi.beh = false;
                OtazkyAOdpovedi.VypoctiVysledek();
                (OdpovedA).Hide();
                (OdpovedB).Hide();
                (OdpovedC).Hide();
                (OdpovedD).Hide();
                if (OtazkyAOdpovedi.body != OtazkyAOdpovedi.dotaz.Length)
                {
                    (Otazka).Text = String.Format($"Máte opičí syndrom, nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku.\nOtázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length}");
                    (MonkeyImage).Show();
                    (MonkeyImage2).Show();

                }
                else
                {
                    (Otazka).Text = String.Format($"Nasbírál jste {OtazkyAOdpovedi.body} bodů za každou otázku, otázek bylo celkem {OtazkyAOdpovedi.spravneOdpovedi.Length} .\nNemáte tedy diagnózu opičího syndromu. Můžete se považovat za nejlepšího blázna v dobrém slovasmyslu.");
                    (NejlepsiBlazen).Show();
                    (NejlepsiBlazen2).Show();
                }
                OtazkyAOdpovedi.body = 0;
                OtazkyAOdpovedi.cisloOtazky = 0;
                OtazkyAOdpovedi.odpovediUzivatele = "";
                (Test).Show();
                (textAutora).Show();
                (ApplicationEnd).Show();
            }
            if (OtazkyAOdpovedi.beh && OtazkyAOdpovedi.cisloOtazky < OtazkyAOdpovedi.dotaz.Length)
            {
                ++OtazkyAOdpovedi.cisloOtazky;
                Otazka.Text = OtazkyAOdpovedi.dotaz[OtazkyAOdpovedi.cisloOtazky];
                OdpovedA.Text = OtazkyAOdpovedi.odpovediA[OtazkyAOdpovedi.cisloOtazky];
                OdpovedB.Text = OtazkyAOdpovedi.odpovediB[OtazkyAOdpovedi.cisloOtazky];
                OdpovedC.Text = OtazkyAOdpovedi.odpovediC[OtazkyAOdpovedi.cisloOtazky];
                OdpovedD.Text = OtazkyAOdpovedi.odpovediD[OtazkyAOdpovedi.cisloOtazky];
            }
        }

        private void textAutora_Click(object sender, EventArgs e)
        {

        }
    }
}