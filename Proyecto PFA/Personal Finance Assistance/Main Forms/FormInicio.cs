using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Personal_Finance_Assistance
{
    public partial class FormInicio : Form
    {
        int FinalPosition = 0;
        int Start = 0;
        ArrayList StringArray = new ArrayList();
        Panel[] Panels = new Panel[3];


        public FormInicio()
        {
            InitializeComponent();
            DBclass.Create_Evaluos();
            DBclass.Upload_Evaluos();
            LabelBanner.Text = "";
            int dias = DatetimeAlgorithms.DíasFaltantesDeEvaluo(DB_Storer.T8_Fecha_Evaluo_Actual[0]);
            LabelDays.Text = Convert.ToString(dias);
            FormMethods.CentrarTextos(LabelDays, PanelText5);
            ColorMethod();
            PanelsText();
            BannerConstruct();
            BannerLoop(StringArray);
            PanelsTimer.Start();
        }
        public void BannerConstruct()
        {
            int ingresos = 0;
            int egresos = 0;
            ingresos = DatetimeAlgorithms.IngresosFaltantes();
            egresos = DatetimeAlgorithms.EgresosFaltantes();
            int dias = DatetimeAlgorithms.DíasFaltantesDeEvaluo(DB_Storer.T8_Fecha_Evaluo_Actual[0]);
            StringArray.Clear();

            if (DB_Storer.T6_Lenguage[0] == 0) //ESPAÑOL
            {
                //AÑADE LA BIENVENIDA AL PROGRAMA
                StringArray.Add("Bienvenido al programa \"EDREI - ASISTENTE PERSONAL FINANCIERO\"  " + DB_Storer.T1_Usuario[DB_Storer.ID_User - 1]);
                //AÑADE LOS DÍAS FALTANTES DE SU EVALUACIÓN
                StringArray.Add("Te quedan " + dias + " Días Para finalizar tu evaluo mensual");
                //AÑADE LA CANTIDAD DE INGRESOS SIN REALIZAR
                StringArray.Add("Tienes " + ingresos + " Ingresos Sin realizar");
                //AÑADE LA CANTIDAD DE EGRESOS SIN REALIZAR
                StringArray.Add("Tienes " + egresos + " Egresos Sin realizar");
            }
            else if (DB_Storer.T6_Lenguage[0] == 1) //INGLES
            {
                //AÑADE LA BIENVENIDA AL PROGRAMA
                StringArray.Add("Welcome to the program \"EDREI - PERSONAL FINANCE ASSISTANT\"  " + DB_Storer.T1_Usuario[DB_Storer.ID_User - 1]);
                //AÑADE LOS DÍAS FALTANTES DE SU EVALUACIÓN
                StringArray.Add("You Have " + dias + " Days to end the monthly evaluation");
                //AÑADE LA CANTIDAD DE INGRESOS SIN REALIZAR
                StringArray.Add("You have " + ingresos + " Incomes undone");
                //AÑADE LA CANTIDAD DE EGRESOS SIN REALIZAR
                StringArray.Add("You have " + egresos + " Expenditures undone");
            }

        }
        public void BannerLoop(ArrayList Labels)
        {
            foreach(string S in Labels)
            {
                LabelBanner.Text += S + " - ";
            }
            FinalPosition = 0 - 10 - LabelBanner.Size.Width;
            Start = Banner.Size.Width + 10;
            LabelBanner.Location = new Point(Start, LabelBanner.Location.Y);
            LabelBanner.Visible = true;
            BannerTimerLoop.Start();
        }

        public void ColorMethod()
        {
            BackColor = ColorClass.ColorFondo1;
            PanelLeft.BackColor = ColorClass.ColorFondo2;
            PanelMid.BackColor = ColorClass.ColorFondo2;
            PanelRight.BackColor = ColorClass.ColorFondo2;
            Banner.BackColor = ColorClass.ColorFondo1;
        }
        public void LenguajeMethod()
        {

        }

        public void PanelsText()
        {
            PanelText1.Visible = false;
            PanelText2.Visible = false;
            PanelText3.Visible = false;
            PanelText4.Visible = false;
            PanelText5.Visible = false;
            PanelText6.Visible = false;
            PanelText7.Visible = false;
            PanelText8.Visible = false;
            PanelText1.BackColor = ColorClass.ColorDecorativo;
            PanelText2.BackColor = ColorClass.ColorDecorativo;
            PanelText3.BackColor = ColorClass.ColorDecorativo;
            PanelText4.BackColor = ColorClass.ColorDecorativo;
            PanelText5.BackColor = ColorClass.ColorDecorativo;
            PanelText6.BackColor = ColorClass.ColorDecorativo;
            PanelText7.BackColor = ColorClass.ColorDecorativo;
            PanelText8.BackColor = ColorClass.ColorDecorativo;

        }

        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            if(FinalPosition != Start)
            {
                --Start;
                LabelBanner.Location = new Point(Start, LabelBanner.Location.Y);
            }
            else
            {
                Start = Banner.Size.Width + 10;
                BannerTimer.Stop();
                LabelBanner.Location = new Point(Start, LabelBanner.Location.Y);
            }
        }
        private void BannerTimerLoop_Tick(object sender, EventArgs e)
        {
            BannerTimer.Start();
        }

        private void PanelsTimer_Tick(object sender, EventArgs e)
        {
            Panels[0] = PanelText1;
            Panels[1] = PanelText5;
            Panels[2] = PanelText7;

            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[0], "Left", 392, 10);
            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[1], "Left", 392, 10);
            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[2], "Left", 392, 10);
            PanelText1.Visible = true;
            PanelText5.Visible = true;
            PanelText7.Visible = true;
            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[0], "Right", 392, 10);
            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[1], "Right", 392, 10);
            FormMethods.DesplazamientoHorizontalSinCentrar(Panels[2], "Right", 392, 10);
            PanelsTimer.Stop();
        }
    }
}
