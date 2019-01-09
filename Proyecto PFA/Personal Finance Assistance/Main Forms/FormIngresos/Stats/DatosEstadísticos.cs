using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance_Assistance
{
    public partial class DatosEstadísticos : UserControl
    {
        FormIngresos Ingresos;
        public DatosEstadísticos(FormIngresos ingresos)
        {
            Ingresos = ingresos;
            Ingresos.SetDatosEstadisticos = this;
            InitializeComponent();
            Combobox3.BackColor = ColorClass.ColorDecorativo;
            Combobox4.BackColor = ColorClass.ColorDecorativo;
            Combobox5.BackColor = ColorClass.ColorDecorativo;
            Combobox6.BackColor = ColorClass.ColorDecorativo;
            Combobox7.BackColor = ColorClass.ColorDecorativo;
            Combobox8.BackColor = ColorClass.ColorDecorativo;
            LabelError.Visible = false;
            LabelAnswer1.Text = "";
            LabelAnswer2.Text = "";
            LabelAnswer3.Text = "";
            LabelAnswer4.Text = "";
            LabelAnswer5.Text = "";
            LabelAnswer6.Text = "";
            LabelAnswer7.Text = "";
            LabelAnswer8.Text = "";
            CreateComboboxs();
            CreateAnswers();
        }

        public void RefreshDB()
        {
            DBclass.Create_Tipo_I();
            DBclass.Create_Tipo_E();
            DBclass.Create_Ingresos();
            DBclass.Create_Egresos();
            DBclass.Upload_Tipo_I();
            DBclass.Upload_Tipo_E();
            DBclass.Upload_Ingresos();
            DBclass.Upload_Egresos();
        }

        public void CreateComboboxs()
        {
            RefreshDB();
            Combobox3.Items.Clear();
            Combobox3.Items.Add("TODOS");
            for(int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++)
            {
                Combobox3.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
            Combobox4.Items.Clear();
            Combobox4.Items.Add("TODOS");
            for (int I = 0; I <= DB_Storer.T3_Tipo_E.Length - 1; I++)
            {
                Combobox4.Items.Add(DB_Storer.T3_Tipo_E[I]);
            }
            Combobox5.Items.Clear();
            Combobox5.Items.Add("TODOS");
            for (int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++)
            {
                Combobox5.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
            Combobox6.Items.Clear();
            Combobox6.Items.Add("TODOS");
            for (int I = 0; I <= DB_Storer.T3_Tipo_E.Length - 1; I++)
            {
                Combobox6.Items.Add(DB_Storer.T3_Tipo_E[I]);
            }
            Combobox7.Items.Clear();
            Combobox7.Items.Add("TODOS");
            for (int I = 0; I <= DB_Storer.T2_Tipo_I.Length - 1; I++)
            {
                Combobox7.Items.Add(DB_Storer.T2_Tipo_I[I]);
            }
            Combobox8.Items.Clear();
            Combobox8.Items.Add("TODOS");
            for (int I = 0; I <= DB_Storer.T3_Tipo_E.Length - 1; I++)
            {
                Combobox8.Items.Add(DB_Storer.T3_Tipo_E[I]);
            }
            Combobox3.SelectedIndex = 0;
            Combobox4.SelectedIndex = 0;
            Combobox5.SelectedIndex = 0;
            Combobox6.SelectedIndex = 0;
            Combobox7.SelectedIndex = 0;
            Combobox8.SelectedIndex = 0;
        }
        public void CreateAnswers()
        {
            RefreshDB();
            TotalClasificaciones();
            Combobox3.SelectedIndex = 0;
            Combobox4.SelectedIndex = 0;
            Combobox5.SelectedIndex = 0;
            Combobox6.SelectedIndex = 0;
            Combobox7.SelectedIndex = 0;
            Combobox8.SelectedIndex = 0;
            ActualizarComboboxs();
        }
        public void ActualizarComboboxs()
        {
            TotalClasificaciones();
            UpdateCombo3();
            UpdateCombo4();
            UpdateCombo5();
            UpdateCombo6();
            UpdateCombo7();
            UpdateCombo8();
            CreateComboboxs();
        }

        //Métodos
        private void TotalClasificaciones()
        {
            int TypeI = DB_Storer.T2_Tipo_I.Length;
            int TypeE = DB_Storer.T3_Tipo_E.Length;
            LabelAnswer1.Text = Convert.ToString(TypeI);
            LabelAnswer2.Text = Convert.ToString(TypeE);
        }
        private int TotalIngresos(int ComboboxIndex)
        {
            int Count = 0;
            int Type = ComboboxIndex - 1;
            int Index = DB_Storer.T2_ID_tipo_I[Type];
            foreach (var x in DB_Storer.T4_Tipo_Ingreso)
            {
                if (x == Index)
                {
                    Count++;
                }
            }
            return Count;
        }
        private int IngresosFaltantes()
        {
            int TypeIndex = Combobox5.SelectedIndex - 1;
            int IngresosFaltantes = 0;
            DateTime Date;
            int Algorithm;
            Date = DB_Storer.T2_Expected_Date_Tipo_I[TypeIndex];
            Algorithm = DB_Storer.T2_Expected_Date_Tipo_I_Algorithm[TypeIndex];
            while (Date < DB_Storer.T8_Fecha_Evaluo_Actual[0])
            {
                Date = DatetimeAlgorithms.GetNextDate(Algorithm, Date);
                IngresosFaltantes++;
                if (IngresosFaltantes > 1000) break;
            }
            return IngresosFaltantes;
        }
        private int TotalEgresos(int ComboboxIndex)
        {
            int Count = 0;
            int Type = ComboboxIndex - 1;
            int Index = DB_Storer.T3_ID_tipo_E[Type];
            foreach (var x in DB_Storer.T5_Tipo_Egreso)
            {
                if (x == Index)
                {
                    Count++;
                }
            }
            return Count;
        }
        private int EgresosFaltantes()
        {
            int TypeIndex = Combobox6.SelectedIndex - 1;
            int EgresosFaltantes = 0;
            DateTime Date;
            int Algorithm;
            Date = DB_Storer.T3_Expected_Date_Tipo_E[TypeIndex];
            Algorithm = DB_Storer.T3_Expected_Date_Tipo_E_Algorithm[TypeIndex];
            while (Date < DB_Storer.T8_Fecha_Evaluo_Actual[0])
            {
                Date = DatetimeAlgorithms.GetNextDate(Algorithm, Date);
                EgresosFaltantes++;
                if (EgresosFaltantes > 1000) break;
            }
            return EgresosFaltantes;
        }
        private double MontoIngresos(int ComboboxIndex)
        {
            double Monto = 0;
            int Type = ComboboxIndex - 1;
            int Index = DB_Storer.T2_ID_tipo_I[Type];
            for (int x = 0; x <= DB_Storer.T4_Tipo_Ingreso.Length - 1; x++)
            {
                if (DB_Storer.T4_Tipo_Ingreso[x] == Index)
                {
                    Monto += DB_Storer.T4_Ingreso[x];
                }
            }
            return Monto;
        }
        private double MontoEgresos(int ComboboxIndex)
        {
            double Monto = 0;
            int Type = ComboboxIndex - 1;
            int Index = DB_Storer.T3_ID_tipo_E[Type];
            for (int x = 0; x <= DB_Storer.T5_Tipo_Egreso.Length - 1; x++)
            {
                if (DB_Storer.T5_Tipo_Egreso[x] == Index)
                {
                    Monto += DB_Storer.T5_Egreso[x];
                }
            }
            return Monto;
        }

        public void UpdateCombo3()
        {
            RefreshDB();
            if (Combobox3.SelectedIndex == 0)
            {
                LabelAnswer3.Text = Convert.ToString(DB_Storer.T4_Ingreso.Length);
            }
            else
            {
                    int Value = TotalIngresos(Combobox3.SelectedIndex);
                    LabelAnswer3.Text = Convert.ToString(Value);
            }
        }
        public void UpdateCombo4()
        {
            RefreshDB();
            if (Combobox4.SelectedIndex == 0)
            {
                LabelAnswer4.Text = Convert.ToString(DB_Storer.T5_Egreso.Length);
            }
            else
            {
                int Value = TotalEgresos(Combobox4.SelectedIndex);
                LabelAnswer4.Text = Convert.ToString(Value);
            }
        }
        public void UpdateCombo5()
        {
            RefreshDB();
            try
            {
                if (Combobox5.SelectedIndex == 0)
                {
                    int Total = DatetimeAlgorithms.IngresosFaltantes() - DB_Storer.T4_Ingreso.Length;
                    if (Total <= 0)
                    {
                        LabelAnswer5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        LabelAnswer5.Text = Convert.ToString(Total);
                    }
                }
                else
                {
                    int temp1 = IngresosFaltantes();
                    int temp2 = TotalIngresos(Combobox5.SelectedIndex);
                    int Value = temp1 - temp2;
                    if (Value <= 0)
                    {
                        LabelAnswer5.Text = Convert.ToString(0);
                    }
                    else
                    {
                        LabelAnswer5.Text = Convert.ToString(Value);
                    }
                }
            }
            catch
            {
                LabelError.Text = "Error en el cálculo de los ingresos faltantes";
                LabelError.Visible = true;
            }

        }
        public void UpdateCombo6()
        {
            RefreshDB();
            try
            {
                if (Combobox6.SelectedIndex == 0)
                {
                    int Total = DatetimeAlgorithms.EgresosFaltantes() - DB_Storer.T5_Egreso.Length;
                    if (Total <= 0)
                    {
                        LabelAnswer6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        LabelAnswer6.Text = Convert.ToString(Total);
                    }
                }
                else
                {
                    int temp1 = EgresosFaltantes();
                    int temp2 = TotalEgresos(Combobox6.SelectedIndex);
                    int Value = temp1 - temp2;
                    if (Value <= 0)
                    {
                        LabelAnswer6.Text = Convert.ToString(0);
                    }
                    else
                    {
                        LabelAnswer6.Text = Convert.ToString(Value);
                    }
                }
            }
            catch
            {
                LabelError.Text = "Error en el cálculo de los egresos faltantes";
                LabelError.Visible = true;
            }
        }
        public void UpdateCombo7()
        {
            RefreshDB();
            double Monto = 0;
            if (Combobox7.SelectedIndex == 0)
            {
                foreach (double x in DB_Storer.T4_Ingreso)
                {
                    Monto += x;
                }
                LabelAnswer7.Text = Convert.ToString(Monto) + " $";
            }
            else
            {
                Monto = MontoIngresos(Combobox7.SelectedIndex);
                LabelAnswer7.Text = Convert.ToString(Monto) + " $";
            }
        }
        public void UpdateCombo8()
        {
            RefreshDB();
            double Monto = 0;
            if (Combobox8.SelectedIndex == 0)
            {
                foreach (double x in DB_Storer.T5_Egreso)
                {
                    Monto += x;
                }
                LabelAnswer8.Text = Convert.ToString(Monto) + " $";
            }
            else
            {
                Monto = MontoEgresos(Combobox8.SelectedIndex);
                LabelAnswer8.Text = Convert.ToString(Monto) + " $";
            }
        }

        private void Combobox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo3();
        }
        private void Combobox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo4();
        }
        private void Combobox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo5();
        }
        private void Combobox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo6();
        }
        private void Combobox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo7();
        }
        private void Combobox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            UpdateCombo8();
        }
    }
}
