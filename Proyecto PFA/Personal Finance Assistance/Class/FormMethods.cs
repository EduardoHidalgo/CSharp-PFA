using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Personal_Finance_Assistance
{
    public class FormMethods
    {
        public static void DesplazamientoHorizontal(Control Control, string Dirección, int WindowsSize)
        {
            int WindowSizeX = WindowsSize;
            int Yposition = Control.Location.Y;
            int Xposition = Control.Location.X;
            int ControlSize = Control.Size.Width;

            #region SACAR DEL FORM
            if ((Xposition >= 0) && (Xposition <= WindowSizeX)) //SI ESTÁ UBICADO EN EL CENTRO...
            {
                if (Dirección == "Left")
                {
                    int TempPosition = 0 - ControlSize - 10; //LO COLOCA FUERA DEL FORM A LA IZQ
                    for (int x = Xposition; x >= TempPosition; x--)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
                else if ((Dirección == "Right"))
                {
                    int TempPosition = WindowSizeX + ControlSize + 10; //LO COLOCA FUERA DEL FORM A LA DER
                    for (int x = Xposition; x <= TempPosition; x++)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
            }
            #endregion
            #region CENTRAR EN EL FORM
            else //SI ESTÁ UBICADO FUERA DEL FORM
            {
                if (Dirección == "Right")
                {
                    int TempPosition = (WindowSizeX - ControlSize) / 2; //LO COLOCA EN EL CENTRO
                    for (int x = Xposition; x <= TempPosition; x++)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
                else if ((Dirección == "Left"))
                {
                    int TempPosition = (WindowSizeX - ControlSize) / 2; //LO COLOCA EN EL CENTRO
                    for (int x = Xposition; x >= TempPosition; x--)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
            }
            #endregion
        }
        public static void DesplazamientoHorizontalSinCentrar(Control Control, string Dirección, int WindowsSize, int PosiciónOriginal)
        {
            int WindowSizeX = WindowsSize;
            int Yposition = Control.Location.Y;
            int Xposition = Control.Location.X;
            int ControlSize = Control.Size.Width;
            int PositionO = PosiciónOriginal;

            #region SACAR DEL FORM
            if ((Xposition >= 0) && (Xposition <= WindowSizeX)) //SI ESTÁ UBICADO EN EL CENTRO...
            {
                if (Dirección == "Left")
                {
                    int TempPosition = 0 - ControlSize - 10; //LO COLOCA FUERA DEL FORM A LA IZQ
                    for (int x = Xposition; x >= TempPosition; x--)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
                else if ((Dirección == "Right"))
                {
                    int TempPosition = WindowSizeX + ControlSize + 10; //LO COLOCA FUERA DEL FORM A LA DER
                    for (int x = Xposition; x <= TempPosition; x++)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
            }
            #endregion
            #region CENTRAR EN EL FORM
            else //SI ESTÁ UBICADO FUERA DEL FORM
            {
                if (Dirección == "Right")
                {
                    int TempPosition = PositionO; //LO COLOCA EN EL CENTRO
                    for (int x = Xposition; x <= TempPosition; x++)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
                else if ((Dirección == "Left"))
                {
                    int TempPosition = PositionO; //LO COLOCA EN EL CENTRO
                    for (int x = Xposition; x >= TempPosition; x--)
                    {
                        Control.Location = new Point(x, Yposition);
                    }
                }
            }
            #endregion
        }
        public static void DesplazamientoVertical(Control Control, string Dirección, int WSizeY)
        {
            int WindowSizeY = WSizeY;
            int Yposition = Control.Location.Y;
            int Xposition = Control.Location.X;
            int ControlSize = Control.Size.Height;

            #region SACAR DEL FORM
            if ((Yposition >= 0) && (Yposition <= WSizeY)) //SI ESTÁ UBICADO EN EL CENTRO...
            {
                if (Dirección == "Up")
                {
                    int TempPosition = 0 - ControlSize - 10; //LO COLOCA FUERA DEL FORM POR ARRIBA
                    for (int y = Yposition; y >= TempPosition; y--)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
                else if ((Dirección == "Down"))
                {
                    int TempPosition = WSizeY + ControlSize + 10; //LO COLOCA FUERA DEL FORM POR ABAJO
                    for (int y = Yposition; y <= TempPosition; y++)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
            }
            #endregion
            #region CENTRAR EN EL FORM
            else //SI ESTÁ UBICADO FUERA DEL FORM
            {
                if (Dirección == "Up")
                {
                    int TempPosition = (WSizeY - ControlSize) / 2; //LO COLOCA EN EL CENTRO
                    for (int y = Yposition; y <= TempPosition; y++)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
                else if ((Dirección == "Down"))
                {
                    int TempPosition = (WSizeY - ControlSize) / 2; //LO COLOCA EN EL CENTRO
                    for (int y = Yposition; y >= TempPosition; y--)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
            }
            #endregion
        }
        public static void DesplazamientoVerticalSinCentrar(Control Control, string Dirección, int WSizeY, int PosiciónOriginal)
        {
            int WindowSizeY = WSizeY;
            int Yposition = Control.Location.Y;
            int Xposition = Control.Location.X;
            int ControlSize = Control.Size.Height;
            int PositionO = PosiciónOriginal;

            #region SACAR DEL FORM
            if ((Yposition >= 0) && (Yposition <= WSizeY)) //SI ESTÁ UBICADO DENTRO DEL FORM...
            {
                if (Dirección == "Up")
                {
                    int TempPosition = 0 - ControlSize - 10; //LO COLOCA FUERA DEL FORM POR ARRIBA
                    for (int y = Yposition; y >= TempPosition; y--)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
                else if ((Dirección == "Down"))
                {
                    int TempPosition = WSizeY + ControlSize + 10; //LO COLOCA FUERA DEL FORM POR ABAJO
                    for (int y = Yposition; y <= TempPosition; y++)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
            }
            #endregion
            #region CENTRAR EN EL FORM
            else //SI ESTÁ UBICADO FUERA DEL FORM
            {
                if (Dirección == "Up")
                {
                    int TempPosition = PositionO; //LO COLOCA EN SU POSICIÓN ORIGINAL DESDE ABAJO
                    for (int y = Yposition; y <= TempPosition; y--)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
                else if ((Dirección == "Down"))
                {
                    int TempPosition = PositionO; //LO COLOCA EN SU POSICIÓN ORIGINAL DESDE ARRIBA
                    for (int y = Yposition; y <= TempPosition; y++)
                    {
                        Control.Location = new Point(Xposition, y);
                    }
                }
            }
            #endregion
        }
        public static void Centrar(Control Control, int WindowSize)
        {
            int WindowSizeX = WindowSize;
            int Yposition = Control.Location.Y;
            int ControlSize = Control.Size.Width;

            int TempPosition = (WindowSizeX - ControlSize) / 2; //LO COLOCA EN EL CENTRO
            Control.Location = new Point(TempPosition, Yposition);
        }
        public static void CentrarTextos(Control Control, Control Contenedor)
        {
            int SizeX = Contenedor.Size.Width;
            int SizeY = Contenedor.Size.Height;
            int X = Control.Size.Width;
            int Y = Control.Size.Height;
            int NewX = (SizeX - X) / 2;
            int NewY = (SizeY - Y) / 2;
            Control.Location = new Point(NewX, NewY);

        }
    }
}
