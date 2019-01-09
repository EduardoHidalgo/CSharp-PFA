using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Assistance
{
    public static class DatetimeAlgorithms
    {
        public static DateTime GetEvaluoActual()
        {
            DateTime Date = DateTime.Today;
            var DaysInMonth = DateTime.DaysInMonth(Date.Year, Date.Month);
            var lastDay = new DateTime(Date.Year, Date.Month, DaysInMonth);
            Date = lastDay;
            return (Date);
        }

        public static DateTime GetNextEvalue()
        {
            DateTime Date = DateTime.Today;
            Date = Date.AddMonths(1);
            var DaysInMonth = DateTime.DaysInMonth(Date.Year, Date.Month);
            var lastDay = new DateTime(Date.Year, Date.Month, DaysInMonth);
            Date = lastDay;
            return (Date);
        }

        public static int DíasFaltantesDeEvaluo(DateTime Evaluo)
        {
            return (Evaluo - DateTime.Today).Days;
        }

        public static DateTime GetNextDate(int I, DateTime Fecha)
        {
            DB_Storer.Expected_Date_Instances();
            DateTime LastDate = Fecha;
            DateTime ExpectedDate = DateTime.Today;

            if (I == 0) //Diario
            {
                ExpectedDate = LastDate.AddDays(1);
            }
            else if (I == 1)   //Cada 2 días
            {
                ExpectedDate = LastDate.AddDays(2);
            }
            else if (I == 2)   //Cada 3 días
            {
                ExpectedDate = LastDate.AddDays(3);
            }
            else if (I == 3)  //Cada 4 días
            {
                ExpectedDate = LastDate.AddDays(4);
            }
            else if (I == 4)  //Cada día de entre semana
            {
                if (LastDate.DayOfWeek == DayOfWeek.Friday)
                {
                    ExpectedDate = LastDate.AddDays(3);
                }
                else if (LastDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    ExpectedDate = LastDate.AddDays(2);
                }
                else
                {
                    ExpectedDate = LastDate.AddDays(1);
                }
            }
            else if (I == 5)  //Cada día del fin de semana
            {
                if (LastDate.DayOfWeek == DayOfWeek.Monday)
                {
                    ExpectedDate = LastDate.AddDays(5);
                }
                else if (LastDate.DayOfWeek == DayOfWeek.Tuesday)
                {
                    ExpectedDate = LastDate.AddDays(4);
                }
                else if (LastDate.DayOfWeek == DayOfWeek.Wednesday)
                {
                    ExpectedDate = LastDate.AddDays(3);
                }
                else if (LastDate.DayOfWeek == DayOfWeek.Thursday)
                {
                    ExpectedDate = LastDate.AddDays(2);
                }
                else if (LastDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    ExpectedDate = LastDate.AddDays(6);
                }
                else
                {
                    ExpectedDate = LastDate.AddDays(1);
                }
            }
            else if (I == 6)  //Cada sábado
            {
                if (LastDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    if (LastDate.DayOfWeek == DayOfWeek.Monday)
                    {
                        ExpectedDate = LastDate.AddDays(5);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        ExpectedDate = LastDate.AddDays(4);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        ExpectedDate = LastDate.AddDays(3);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Thursday)
                    {
                        ExpectedDate = LastDate.AddDays(2);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Friday)
                    {
                        ExpectedDate = LastDate.AddDays(1);
                    }
                    else
                    {
                        ExpectedDate = LastDate.AddDays(6);
                    }
                }
                else
                {
                    ExpectedDate = LastDate.AddDays(7);
                }
            }
            else if (I == 7)  //Cada Domingo
            {
                if (LastDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (LastDate.DayOfWeek == DayOfWeek.Monday)
                    {
                        ExpectedDate = LastDate.AddDays(6);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        ExpectedDate = LastDate.AddDays(5);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        ExpectedDate = LastDate.AddDays(4);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Thursday)
                    {
                        ExpectedDate = LastDate.AddDays(3);
                    }
                    else if (LastDate.DayOfWeek == DayOfWeek.Friday)
                    {
                        ExpectedDate = LastDate.AddDays(2);
                    }
                    else
                    {
                        ExpectedDate = LastDate.AddDays(1);
                    }
                }
                else
                {
                    ExpectedDate = LastDate.AddDays(7);
                }

            }
            else if (I == 8)  //Cada semana ( empezando lunes)
            {
                if(LastDate.DayOfWeek != DayOfWeek.Monday)
                {
                    while (LastDate.DayOfWeek != DayOfWeek.Monday)
                    {
                        ExpectedDate = LastDate.AddDays(1);
                    }
                }
                else
                {
                    ExpectedDate = LastDate.AddDays(7);
                }
            }
            else if (I == 9)  //Cada 15 días (Empezando día 15 y el último día del mes)
            {
                ExpectedDate = LastDate.AddDays(15);
            }
            else if (I == 10)  //Cada mes (Empezando cada último día del mes)
            {
                ExpectedDate = LastDate.AddDays(30);
            }
            else //Rango de fechas indefinido.
            {
                ExpectedDate = LastDate.AddDays(7);
            }
            return (ExpectedDate);
        }

        public static int IngresosFaltantes()
        {
            int IngresosFaltantes = 0;
            DateTime Date;
            int Algorithm;
            DBclass.Create_Tipo_I();
            DBclass.Upload_Tipo_I();
            DBclass.Create_Config();
            DBclass.Upload_Config();
            DBclass.Create_Evaluos();
            DBclass.Upload_Evaluos();
            if (DB_Storer.T2_Expected_Date_Tipo_I.Length != 0)
            {
                for (int I = 0; I <= DB_Storer.T2_Expected_Date_Tipo_I.Length - 1; I++)
                {
                    Date = DB_Storer.T2_Expected_Date_Tipo_I[I];
                    Algorithm = DB_Storer.T2_Expected_Date_Tipo_I_Algorithm[I];
                    while (Date < DB_Storer.T8_Fecha_Evaluo_Actual[0])
                    {
                        Date = GetNextDate(Algorithm, Date);
                        IngresosFaltantes++;
                        if (IngresosFaltantes > 1000) break;
                    }
                }
            }
            return IngresosFaltantes;
        }
        public static int EgresosFaltantes()
        {
            int EgresosFaltantes = 0;
            DateTime Date;
            int Algorithm;
            DBclass.Create_Tipo_E();
            DBclass.Upload_Tipo_E();
            DBclass.Create_Config();
            DBclass.Upload_Config();
            DBclass.Create_Evaluos();
            DBclass.Upload_Evaluos();
            if (DB_Storer.T3_Expected_Date_Tipo_E.Length != 0)
            {
                for (int I = 0; I <= DB_Storer.T3_Expected_Date_Tipo_E.Length - 1; I++)
                {
                    Date = DB_Storer.T3_Expected_Date_Tipo_E[I];
                    Algorithm = DB_Storer.T3_Expected_Date_Tipo_E_Algorithm[I];
                    while (Date < DB_Storer.T8_Fecha_Evaluo_Actual[0])
                    {
                        Date = GetNextDate(Algorithm, Date);
                        EgresosFaltantes++;
                        if (EgresosFaltantes > 1000) break;
                    }
                }
            }
            return EgresosFaltantes;
        }

    }
}
