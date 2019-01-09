using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Personal_Finance_Assistance
{
    public static class ColorClass
    {
        /* 
         * 5 COLORES DISPONIBLES
         
         * 1) color de FONDO 1
         * 2) color de FONDO 2
         * 3) color de BOTON
         * 4) color de CURSOR SOBRE BOTON
         * 5) color de DECORATIVO
        */
        public static Color ColorFondo1;
        public static Color ColorFondo2;
        public static Color ColorBoton;
        public static Color ColorBotonCursado;
        public static Color ColorDecorativo;

        public static Color PreviewColorFondo1;
        public static Color PreviewColorFondo2;
        public static Color PreviewColorBoton;
        public static Color PreviewColorBotonCursado;
        public static Color PreviewColorDecorativo;

        public static Color[] FlatUI = new Color[5]; //COLOR 1
        public static Color[] WarmFlatRock = new Color[5];
        public static Color[] FlatGreen = new Color[5];
        public static Color[] SkyBackground = new Color[5];
        public static Color[] FlatOnYourBack = new Color[5];

        public static string[] ArrayThemes = new string[5];
        public static int Themes = 5;

        public static void InicializateArrayThemes()
        {
            ArrayThemes[0] = "Flat UI";
            ArrayThemes[1] = "Warm Flat Rock";
            ArrayThemes[2] = "Flat Green";
            ArrayThemes[3] = "Sky Background";
            ArrayThemes[4] = "Flat On Your Back";
        }
        public static void InicializateColors()
        {
            FlatUI[0] = Color.FromArgb(0, 88, 122);
            FlatUI[1] = Color.FromArgb(0, 136, 145);
            FlatUI[2] = Color.FromArgb(15, 48, 87);
            FlatUI[3] = Color.FromArgb(231, 231, 222);
            FlatUI[4] = Color.FromArgb(205, 203, 166);

            WarmFlatRock[0] = Color.FromArgb(255, 139, 85);
            WarmFlatRock[1] = Color.FromArgb(250, 218, 163);
            WarmFlatRock[2] = Color.FromArgb(255, 159, 85);
            WarmFlatRock[3] = Color.FromArgb(255, 137, 46);
            WarmFlatRock[4] = Color.FromArgb(255, 126, 85);

            FlatGreen[0] = Color.FromArgb(27, 188, 155);
            FlatGreen[1] = Color.FromArgb(22, 160, 134);
            FlatGreen[2] = Color.FromArgb(27, 163, 156);
            FlatGreen[3] = Color.FromArgb(11, 131, 137);
            FlatGreen[4] = Color.FromArgb(15, 97, 119);

            SkyBackground[0] = Color.FromArgb(186, 222, 178);
            SkyBackground[1] = Color.FromArgb(135, 232, 198);
            SkyBackground[2] = Color.FromArgb(139, 203, 222);
            SkyBackground[3] = Color.FromArgb(143, 168, 246);
            SkyBackground[4] = Color.FromArgb(176, 164, 190);

            FlatOnYourBack[0] = Color.FromArgb(238, 116, 105);
            FlatOnYourBack[1] = Color.FromArgb(255, 240, 214);
            FlatOnYourBack[2] = Color.FromArgb(184, 149, 155);
            FlatOnYourBack[3] = Color.FromArgb(131, 109, 111);
            FlatOnYourBack[4] = Color.FromArgb(56, 55, 50);
        }
        public static void SelectColor(int Color)
        {
            InicializateColors();
            if (Color == 1)
            {
                ColorFondo1 = FlatUI[0];
                ColorFondo2 = FlatUI[1];
                ColorBoton = FlatUI[2];
                ColorBotonCursado = FlatUI[3];
                ColorDecorativo = FlatUI[4];
            }
            else if (Color == 2)
            {
                ColorFondo1 = WarmFlatRock[0];
                ColorFondo2 = WarmFlatRock[1];
                ColorBoton = WarmFlatRock[2];
                ColorBotonCursado = WarmFlatRock[3];
                ColorDecorativo = WarmFlatRock[4];
            }
            else if (Color == 3)
            {
                ColorFondo1 = FlatGreen[0];
                ColorFondo2 = FlatGreen[1];
                ColorBoton = FlatGreen[2];
                ColorBotonCursado = FlatGreen[3];
                ColorDecorativo = FlatGreen[4];
            }
            else if (Color == 4)
            {
                ColorFondo1 = SkyBackground[0];
                ColorFondo2 = SkyBackground[1];
                ColorBoton = SkyBackground[2];
                ColorBotonCursado = SkyBackground[3];
                ColorDecorativo = SkyBackground[4];
            }
            else if (Color == 5)
            {
                ColorFondo1 = FlatOnYourBack[0];
                ColorFondo2 = FlatOnYourBack[1];
                ColorBoton = FlatOnYourBack[2];
                ColorBotonCursado = FlatOnYourBack[3];
                ColorDecorativo = FlatOnYourBack[4];
            }
        }
        public static void PreviewSelectColor(int Color)
        {
            if (Color == 1)
            {
                PreviewColorFondo1 = FlatUI[0];
                PreviewColorFondo2 = FlatUI[1];
                PreviewColorBoton = FlatUI[2];
                PreviewColorBotonCursado = FlatUI[3];
                PreviewColorDecorativo = FlatUI[4];
            }
            else if (Color == 2)
            {
                PreviewColorFondo1 = WarmFlatRock[0];
                PreviewColorFondo2 = WarmFlatRock[1];
                PreviewColorBoton = WarmFlatRock[2];
                PreviewColorBotonCursado = WarmFlatRock[3];
                PreviewColorDecorativo = WarmFlatRock[4];
            }
            else if (Color == 3)
            {
                PreviewColorFondo1 = FlatGreen[0];
                PreviewColorFondo2 = FlatGreen[1];
                PreviewColorBoton = FlatGreen[2];
                PreviewColorBotonCursado = FlatGreen[3];
                PreviewColorDecorativo = FlatGreen[4];
            }
            else if (Color == 4)
            {
                PreviewColorFondo1 = SkyBackground[0];
                PreviewColorFondo2 = SkyBackground[1];
                PreviewColorBoton = SkyBackground[2];
                PreviewColorBotonCursado = SkyBackground[3];
                PreviewColorDecorativo = SkyBackground[4];
            }
            else if (Color == 5)
            {
                PreviewColorFondo1 = FlatOnYourBack[0];
                PreviewColorFondo2 = FlatOnYourBack[1];
                PreviewColorBoton = FlatOnYourBack[2];
                PreviewColorBotonCursado = FlatOnYourBack[3];
                PreviewColorDecorativo = FlatOnYourBack[4];
            }
        }
    }
}
