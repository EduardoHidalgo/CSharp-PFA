﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Assistance
{
    public class DB_Storer  //Clase contenedora temporal
    {
        // Iteradores
        public static int TABLE_USUARIO_iterer;
        public static int TABLE_INGRESOS_iterer;
        public static int TABLE_EGRESOS_iterer;
        public static int TABLE_TIPO_I_iterer;
        public static int TABLE_TIPO_E_iterer;
        public static int TABLE_CONFIG_iterer;
        public static int TABLE_METAS_iterer;
        public static int TABLE_EVALUOS_iterer;

        //TABLA USUARIO
        public static string TABLE_USUARIO = "USUARIO";
        public static string TABLE_USUARIO_OrderBy = "ID_Usuario";
        public static int[] T1_ID_usuario;   //Llave primaria. ID
        public static string[] T1_Usuario;
        public static string[] T1_Contraseña;
        public static string[] T1_Correo;
        public static int ID_User;
        public static int ID_User_Max;

        //TABLA TIPO DE INGRESOS
        public static string TABLE_TIPO_I = "TIPO_I";
        public static string TABLE_TIPO_I_OrderBy = "ID_Tipo_I";
        public static string TABLE_TIPO_I_Where = "ID_User_Tipo_I";
        public static int[] T2_ID_tipo_I;  //Llave Primaria. ID
        public static int[] T2_ID_User_Tipo_I;   //Llave Foránea a - USUARIO
        public static string[] T2_Tipo_I;
        public static DateTime[] T2_Expected_Date_Tipo_I;
        public static int[] T2_Expected_Date_Tipo_I_Algorithm; //Nuevo
        public static int ID_Tipo_I_Max;

        //TABLA TIPO DE EGRESOS
        public static string TABLE_TIPO_E = "TIPO_E";
        public static string TABLE_TIPO_E_OrderBy = "ID_Tipo_E";
        public static string TABLE_TIPO_E_Where = "ID_User_Tipo_E";
        public static int[] T3_ID_tipo_E;  //Llave Primaria. ID
        public static int[] T3_ID_User_Tipo_E;   //Llave Foránea a - USUARIO
        public static string[] T3_Tipo_E;
        public static DateTime[] T3_Expected_Date_Tipo_E;
        public static int[] T3_Expected_Date_Tipo_E_Algorithm; //Nuevo
        public static int ID_Tipo_E_Max;

        //TABLA INGRESOS
        public static string TABLE_INGRESOS = "INGRESOS";
        public static string TABLE_INGRESOS_OrderBy = "ID_Ingreso";
        public static string TABLE_INGRESOS_Where = "ID_User_I";
        public static int[] T4_ID_Ingreso;  //Llave Primaria. ID
        public static int[] T4_ID_User_I;   //Llave Foránea a - USUARIO
        public static double[] T4_Ingreso;
        public static DateTime[] T4_Date_Ingreso;
        public static int[] T4_Tipo_Ingreso; //Llave Foránea a - Tipo_Ingreso
        public static int ID_Ingreso_Max;

        //TABLA EGRESOS
        public static string TABLE_EGRESOS = "EGRESOS";
        public static string TABLE_EGRESOS_OrderBy = "ID_Egreso";
        public static string TABLE_EGRESOS_Where = "ID_User_E";
        public static int[] T5_ID_Egreso;  //Llave Primaria. ID
        public static int[] T5_ID_User_E;   //Llave Foránea a - USUARIO
        public static double[] T5_Egreso;
        public static DateTime[] T5_Date_Egreso;
        public static int[] T5_Tipo_Egreso; //Llave Foránea a - Tipo_Egreso
        public static int ID_Egreso_Max;

        //TABLA CONFIG
        public static string TABLE_CONFIG = "CONFIG";
        public static int[] T6_Config_ID_User;   //Llave Primaria & Foránea a - USUARIO
        public static int[] T6_Lenguage;
        public static int[] T6_Theme;

        //TABLA METAS
        public static string TABLE_METAS = "METAS";
        public static int[] T7_ID_User_Metas;
        public static double[] T7_Metas_Monto;
        public static DateTime[] T7_Metas_Fecha_Limite;

        //TABLA EVALUOS
        public static string TABLE_EVALUOS = "EVALUOS";
        public static int[] T8_ID_User_Evaluo;
        public static DateTime[] T8_Fecha_Evaluo_Actual;
        public static int[] T8_Total_Evaluos;
        public static DateTime[] T8_Primer_Evaluo;

        public static string[] Expected_Date;

        public static void Expected_Date_Instances()  //Variables para las fechas Expectadas de los ingresos y egresos
        {
            Expected_Date = new string[12];
            Expected_Date[0] = "Diario";
            Expected_Date[1] = "Cada 2 días";
            Expected_Date[2] = "Cada 3 días";
            Expected_Date[3] = "Cada 4 días";
            Expected_Date[4] = "Entre Semana";
            Expected_Date[5] = "Cada fin de Semana";
            Expected_Date[6] = "Sábados";
            Expected_Date[7] = "Domingos";
            Expected_Date[8] = "Semanal";
            Expected_Date[9] = "Quincenal";
            Expected_Date[10] = "Mensual";
            Expected_Date[11] = "Indefinido";
        }
    }
}
