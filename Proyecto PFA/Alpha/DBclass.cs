using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Alpha
{
    public class DBclass : DB_Storer
    {
        //CAMPOS
        private static SQLiteConnection Connection;     //Para abrir y cerrar las conexiones, o hacer pedidos
        private static SQLiteDataReader Reader;       //Para leer la base de datos
        private static SQLiteCommand Command;         //Para ejecutar las solicitudes
        private static SQLiteTransaction Transaction;
        private static string Path = @"C:\Users\Eduardo\Desktop\Personal Finance Assistance\DB_Edrei.db";
        private static bool Existing;
        private static string Query;

        //ENCAPSULADOS
        public static string Set_Path
        {
            get
            {
                return Path;
            }

            set
            {
                Path = value;
            }
        }

        public static bool FileEXist()     //Verifica que exista la base de datos. Retorna booleano
        {
            if (System.IO.File.Exists(Path) == true)
            {
                Existing = true;
                return Existing;
            }
            else
            {
                Existing = false;
                return Existing;
            }
        }
        public static void Connect()       //Crea la conexión a la base de datos
        {
            Connection = new SQLiteConnection("Data Source=" + Path + ";Version=3;New=False;");
            Connection.Open();
        }
        public static void Disconnect()    //Cierra la conexión a la base de datos  
        {
            if (Connection.State.ToString() == "Open")
            {
                Connection.Close();
            }
        }

        //Instancia los contenedores temporales para la base de datos.
        public static void Create_Usuarios()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_USUARIO;
            Command = new SQLiteCommand(Query, Connection);
            object Result = Convert.ToInt32(Command.ExecuteScalar());
            TABLE_USUARIO_iterer = Convert.ToInt32(Result);
            T1_ID_usuario = new int[TABLE_USUARIO_iterer];
            T1_Usuario = new string[TABLE_USUARIO_iterer];
            T1_Contraseña = new string[TABLE_USUARIO_iterer];
            T1_Correo = new string[TABLE_USUARIO_iterer];
            Disconnect();
            Create_Config();
        }
        //Ingresos, Egresos, Tipos y Config solo crean los contenedores del ID de usuario Logeado.
        public static void Create_Tipo_I()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_TIPO_I + " WHERE ID_User_Tipo_I = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            if (Command.ExecuteScalar() != null)
            {
                TABLE_TIPO_I_iterer = Convert.ToInt32(Command.ExecuteScalar());
            }
            {
                TABLE_USUARIO_iterer = 0;
            }
            T2_ID_tipo_I = new int[TABLE_TIPO_I_iterer];
            T2_ID_User_Tipo_I = new int[TABLE_TIPO_I_iterer];
            T2_Tipo_I = new string[TABLE_TIPO_I_iterer];
            T2_Expected_Date_Tipo_I = new string[TABLE_TIPO_I_iterer];
            T2_Expected_Date_Tipo_I_Algorithm = new int[TABLE_TIPO_I_iterer];
            Disconnect();
        }
        public static void Create_Tipo_E()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_TIPO_E + " WHERE " + TABLE_TIPO_E_Where + " = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            TABLE_TIPO_E_iterer = Convert.ToInt32(Command.ExecuteScalar());
            T3_ID_tipo_E = new int[TABLE_TIPO_E_iterer];
            T3_ID_User_Tipo_E = new int[TABLE_TIPO_E_iterer];
            T3_Tipo_E = new string[TABLE_TIPO_E_iterer];
            T3_Expected_Date_Tipo_E = new string[TABLE_TIPO_E_iterer];
            T3_Expected_Date_Tipo_E_Algorithm = new int[TABLE_TIPO_E_iterer];
            Disconnect();
        }
        public static void Create_Ingresos()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_INGRESOS + " WHERE " + TABLE_INGRESOS_Where + " = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            TABLE_INGRESOS_iterer = Convert.ToInt32(Command.ExecuteScalar());
            T4_ID_Ingreso = new int[TABLE_INGRESOS_iterer];
            T4_Ingreso = new double[TABLE_INGRESOS_iterer];
            T4_Tipo_Ingreso = new int[TABLE_INGRESOS_iterer];
            T4_ID_User_I = new int[TABLE_INGRESOS_iterer];
            T4_Date_Ingreso = new string[TABLE_INGRESOS_iterer];
            Disconnect();
        }
        public static void Create_Egresos()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_EGRESOS + " WHERE " + TABLE_EGRESOS_Where + " = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            TABLE_EGRESOS_iterer = Convert.ToInt32(Command.ExecuteScalar());
            T5_ID_Egreso = new int[TABLE_EGRESOS_iterer];
            T5_Egreso = new double[TABLE_EGRESOS_iterer];
            T5_Tipo_Egreso = new int[TABLE_EGRESOS_iterer];
            T5_ID_User_E = new int[TABLE_EGRESOS_iterer];
            T5_Date_Egreso = new string[TABLE_EGRESOS_iterer];
            Disconnect();
        }
        public static void Create_Config()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_CONFIG + " WHERE ID_User_Config = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            TABLE_CONFIG_iterer = Convert.ToInt32(Command.ExecuteScalar());
            T6_Config_ID_User = new int[TABLE_CONFIG_iterer];
            T6_Lenguage = new int[TABLE_CONFIG_iterer];
            T6_Theme = new int[TABLE_CONFIG_iterer];
            T6_Fecha_Evaluo_Actual = new string[TABLE_CONFIG_iterer];
            Disconnect();
        }
        public static void Create_Metas()
        {
            Connect();
            Query = "SELECT COUNT(*) FROM " + TABLE_METAS + " WHERE ID_User_Metas = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            TABLE_METAS_iterer = Convert.ToInt32(Command.ExecuteScalar());
            T7_ID_User_Metas = new int[TABLE_METAS_iterer];
            T7_Metas_Monto = new double[TABLE_METAS_iterer];
            T7_Metas_Fecha_Limite = new string[TABLE_METAS_iterer];
            Disconnect();
        }
        public static void Create_Max_IDs()
        {
            Connect();
            Query = "SELECT MAX(" + TABLE_USUARIO_OrderBy + ") FROM USUARIO";
            Command = new SQLiteCommand(Query, Connection);
            ID_User_Max = Convert.ToInt32(Command.ExecuteScalar());
            Query = "SELECT MAX(" + TABLE_TIPO_I_OrderBy + ") FROM TIPO_I";
            Command = new SQLiteCommand(Query, Connection);
            ID_Tipo_I_Max = Convert.ToInt32(Command.ExecuteScalar());
            Query = "SELECT MAX(" + TABLE_TIPO_E_OrderBy + ") FROM TIPO_E";
            Command = new SQLiteCommand(Query, Connection);
            ID_Tipo_E_Max = Convert.ToInt32(Command.ExecuteScalar());
            Query = "SELECT MAX(" + TABLE_INGRESOS_OrderBy + ") FROM INGRESOS";
            Command = new SQLiteCommand(Query, Connection);
            ID_Ingreso_Max = Convert.ToInt32(Command.ExecuteScalar());
            Query = "SELECT MAX(" + TABLE_EGRESOS_OrderBy + ") FROM EGRESOS";
            Command = new SQLiteCommand(Query, Connection);
            ID_Egreso_Max = Convert.ToInt32(Command.ExecuteScalar());
            Disconnect();

        }

        //Lee la base de datos y almacena cada variable en Contenedores temporales
        public static void Upload_Usuarios()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_USUARIO + " ORDER BY " + TABLE_USUARIO_OrderBy + " ASC;";
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T1_ID_usuario[Counter] = Convert.ToInt32(Reader[0]);
                T1_Usuario[Counter] = Convert.ToString(Reader[1]);
                T1_Contraseña[Counter] = Convert.ToString(Reader[2]);
                T1_Correo[Counter] = Convert.ToString(Reader[3]);
                Counter++;
            }
            Disconnect();
        }
        //Ingresos, Egresos, Tipos y Config solo cargan las filas del ID de usuario Logeado.
        public static void Upload_Tipo_I()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_TIPO_I + " WHERE " + TABLE_TIPO_I_Where + " = " + ID_User + " ORDER BY " + TABLE_TIPO_I_OrderBy + " ASC;";
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T2_ID_tipo_I[Counter] = Convert.ToInt32(Reader[0]);
                T2_ID_User_Tipo_I[Counter] = Convert.ToInt32(Reader[1]);
                T2_Tipo_I[Counter] = Convert.ToString(Reader[2]);
                T2_Expected_Date_Tipo_I[Counter] = Convert.ToString(Reader[3]);
                T2_Expected_Date_Tipo_I_Algorithm[Counter] = Convert.ToInt32(Reader[4]);
                Counter++;
            }
            Disconnect();
        }
        public static void Upload_Tipo_E()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_TIPO_E + " WHERE " + TABLE_TIPO_E_Where + " = " + ID_User + " ORDER BY " + TABLE_TIPO_E_OrderBy + " ASC;";
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T3_ID_tipo_E[Counter] = Convert.ToInt32(Reader[0]);
                T3_ID_User_Tipo_E[Counter] = Convert.ToInt32(Reader[1]);
                T3_Tipo_E[Counter] = Convert.ToString(Reader[2]);
                T3_Expected_Date_Tipo_E[Counter] = Convert.ToString(Reader[3]);
                T3_Expected_Date_Tipo_E_Algorithm[Counter] = Convert.ToInt32(Reader[4]);
                Counter++;
            }
            Disconnect();
        }
        public static void Upload_Ingresos()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_INGRESOS + " WHERE " + TABLE_INGRESOS_Where + " = " + ID_User + " ORDER BY " + TABLE_INGRESOS_OrderBy + " ASC;";
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T4_ID_Ingreso[Counter] = Convert.ToInt32(Reader[0]);
                T4_ID_User_I[Counter] = Convert.ToInt32(Reader[1]);
                T4_Ingreso[Counter] = Convert.ToDouble(Reader[2]);
                T4_Tipo_Ingreso[Counter] = Convert.ToInt32(Reader[3]);
                T4_Date_Ingreso[Counter] = Convert.ToString(Reader[4]);
                Counter++;
            }
            Disconnect();
        }
        public static void Upload_Egresos()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_EGRESOS + " WHERE " + TABLE_EGRESOS_Where + " = " + ID_User + " ORDER BY " + TABLE_EGRESOS_OrderBy + " ASC;";
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T5_ID_Egreso[Counter] = Convert.ToInt32(Reader[0]);
                T5_ID_User_E[Counter] = Convert.ToInt32(Reader[1]);
                T5_Egreso[Counter] = Convert.ToDouble(Reader[2]);
                T5_Tipo_Egreso[Counter] = Convert.ToInt32(Reader[3]);
                T5_Date_Egreso[Counter] = Convert.ToString(Reader[4]);
                Counter++;
            }
            Disconnect();
        }
        public static void Upload_Config()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_CONFIG + " WHERE ID_User_Config = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T6_Config_ID_User[Counter] = Convert.ToInt32(Reader[0]);
                T6_Lenguage[Counter] = Convert.ToInt32(Reader[1]);
                T6_Theme[Counter] = Convert.ToInt32(Reader[2]);
                T6_Fecha_Evaluo_Actual[Counter] = Convert.ToString(Reader[3]);
                Counter++;
            }
            Disconnect();
        }
        public static void Upload_Metas()
        {
            Connect();
            Query = "SELECT * FROM " + TABLE_METAS + " WHERE ID_User_Metas = " + ID_User;
            Command = new SQLiteCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            int Counter = 0;
            while (Reader.Read())
            {
                T7_ID_User_Metas[Counter] = Convert.ToInt32(Reader[0]);
                T7_Metas_Monto[Counter] = Convert.ToDouble(Reader[1]);
                T7_Metas_Fecha_Limite[Counter] = Convert.ToString(Reader[2]);
                Counter++;
            }
            Disconnect();
        }

        public static void Insert_Usuario(string user, string pass, string mail) //ID, User, Pass, Mail  //Inserta al usuario y crea sus configs
        {
            Create_Max_IDs();
            Connect();
            int id = ++ID_User_Max;
            Query = "INSERT INTO " + TABLE_USUARIO + " (ID_Usuario, Usuario, Contraseña, Correo) VALUES ( " + id + ", \'" + user + "\', \'" + pass + "\', \'" + mail + "\')";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Query = "INSERT INTO " + TABLE_CONFIG + " (ID_User_Config, Lenguaje, Tema) VALUES (\'" + id + "\', 1, 1 );";
            command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Usuarios();
            Upload_Usuarios();
            Create_Config();
            Upload_Config();
            Create_Max_IDs();
        }
        public static void Insert_Tipo_I(string tipo, DateTime Fecha, int Alg)     //IDtipo, ID_User, Tipo, Fecha Esperada
        {
            Create_Max_IDs();
            Connect();
            string fecha = Convert.ToString(Fecha);
            int iduser = ID_User;
            int idtipo = ++ID_Tipo_I_Max;
            string Query = "INSERT INTO TIPO_I (ID_Tipo_I, ID_User_Tipo_I, Tipo_I, Fecha_Esperada_Tipo_I, Fecha_Esperada_Tipo_I_Algoritmo) VALUES (" + idtipo + ", " + iduser + ", \'" + tipo + "\', \'" + fecha + "\', \'" + Alg + "\');";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Tipo_I();
            Upload_Tipo_I();
            Create_Max_IDs();
        }
        public static void Insert_Tipo_E(string tipo, DateTime Fecha, int Alg)     //IDtipo, ID_User, Tipo, Fecha Esperada
        {
            Create_Max_IDs();
            Connect();
            string fecha = Convert.ToString(Fecha);
            int iduser = ID_User;
            int idtipo = ++ID_Tipo_E_Max;
            string Query = "INSERT INTO TIPO_E (ID_Tipo_E, ID_User_Tipo_E, Tipo_E, Fecha_Esperada_Tipo_E, Fecha_Esperada_Tipo_E_Algoritmo) VALUES (" + idtipo + ", " + iduser + ", \'" + tipo + "\', \'" + fecha + "\', \'" + Alg + "\');";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Tipo_E();
            Upload_Tipo_E();
            Create_Max_IDs();
        }
        public static void Insert_Ingreso(double ingreso, DateTime Fecha, int tipo)       //ID_I, ID_User, Ingreso, Fecha de inserto, tipo
        {
            Create_Max_IDs();
            Connect();
            string fecha = Convert.ToString(Fecha);
            int iduser = ID_User;
            int idI = ++ID_Ingreso_Max;
            string Query = "INSERT INTO " + TABLE_INGRESOS + " (ID_Ingreso,  ID_User_I, Ingreso, Tipo_Ingreso, Fecha_Ingreso) VALUES (\'" + idI + "\', \'" + iduser + "\', \'" + ingreso + "\', \'" + tipo + "\', \'" + fecha + "\')";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Ingresos();
            Upload_Ingresos();
            Create_Max_IDs();
        }
        public static void Insert_Egreso(double egreso, DateTime Fecha, int tipo)         //ID_E, ID_User, Egreso, Fecha de insert, tipo
        {
            Create_Max_IDs();
            Connect();
            string fecha = Convert.ToString(Fecha);
            int iduser = ID_User;
            int idE = ++ID_Egreso_Max;
            string Query = "INSERT INTO " + TABLE_EGRESOS + " (ID_Egreso, ID_User_E, Egreso, Tipo_Egreso, Fecha_Egreso) VALUES (\'" + idE + "\', \'" + iduser + "\', \'" + egreso + "\', \'" + tipo + "\', \'" + fecha + "\')";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Egresos();
            Upload_Egresos();
            Create_Max_IDs();
        }

        // Borra un usuario y todos los atributos asociados e él.
        public static void Delete_Usuario(int ID) //ID_User
        {
            Create_Usuarios();
            Create_Config();
            Create_Tipo_E();
            Create_Tipo_I();
            Create_Ingresos();
            Create_Egresos();
            Upload_Usuarios();
            Upload_Config();
            Upload_Tipo_I();
            Upload_Tipo_E();
            Upload_Ingresos();
            Upload_Egresos();
            Create_Max_IDs();
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "DELETE FROM " + TABLE_INGRESOS + " WHERE ID_User_I = \'" + ID + "\'";  //Borra todos los Ingresos del Usuario
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_EGRESOS + " WHERE ID_User_E = \'" + ID + "\'";  //Borra todos los Egresos del Usuario
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_TIPO_I + " WHERE ID_User_Tipo_I = \'" + ID + "\'";  //Borra todos los Tipos_I del usuario
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_TIPO_E + " WHERE ID_User_Tipo_E = \'" + ID + "\'";  //Borra todos los Tipos_E del usuario
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_CONFIG + " WHERE ID_User_Config = \'" + ID + "\'";  //Borra sus Configs.
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_USUARIO + " WHERE ID_Usuario = \'" + ID + "\'";  //Borra al Usuario
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Usuarios();
            Create_Config();
            Create_Tipo_E();
            Create_Tipo_I();
            Create_Ingresos();
            Create_Egresos();
            Upload_Usuarios();
            Upload_Config();
            Upload_Tipo_I();
            Upload_Tipo_E();
            Upload_Ingresos();
            Upload_Egresos();
            Create_Max_IDs();
        }
        public static void Delete_Tipo_I(int idtipoI) //ID_Tipo_I    //Borra la clasificación y todos los ingresos asociados a él.
        {
            Create_Tipo_I();
            Create_Ingresos();
            Upload_Tipo_I();
            Upload_Ingresos();
            Create_Max_IDs();
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "DELETE FROM " + TABLE_INGRESOS + " WHERE Tipo_Ingreso = \'" + idtipoI + "\'";  //Borra todos los Ingresos del Tipo.
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_TIPO_I + " WHERE ID_Tipo_I = \'" + idtipoI + "\'";  //Borra el Tipo
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Tipo_I();
            Create_Ingresos();
            Upload_Tipo_I();
            Upload_Ingresos();
            Create_Max_IDs();
        }
        public static void Delete_Tipo_E(int idtipoE) //ID_Tipo_E    //Borra la clasificación y todos los egresos asociados a él.
        {
            Create_Tipo_E();
            Create_Egresos();
            Upload_Tipo_E();
            Upload_Egresos();
            Create_Max_IDs();
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "DELETE FROM " + TABLE_EGRESOS + " WHERE Tipo_Egreso = \'" + idtipoE + "\'";  //Borra todos los Egresos del Tipo.
                    Command.ExecuteNonQuery();
                    Command.CommandText = "DELETE FROM " + TABLE_TIPO_E + " WHERE ID_Tipo_E = \'" + idtipoE + "\'";  //Borra el Tipo
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Tipo_E();
            Create_Egresos();
            Upload_Tipo_E();
            Upload_Egresos();
            Create_Max_IDs();
        }
        public static void Delete_Ingreso(int idI) //ID_Ingreso  //Borra un ingreso.
        {
            Create_Ingresos();
            Upload_Ingresos();
            Create_Max_IDs();
            Connect();
            Query = "DELETE FROM " + TABLE_INGRESOS + " WHERE ID_Ingreso = \'" + idI + "\'";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Ingresos();
            Upload_Ingresos();
            Create_Max_IDs();
        }
        public static void Delete_Egreso(int idE) //ID_Egreso    //Borra un egreso.
        {
            Create_Egresos();
            Upload_Egresos();
            Create_Max_IDs();
            Connect();
            Query = "DELETE FROM " + TABLE_EGRESOS + " WHERE ID_Egreso = \'" + idE + "\'";
            SQLiteCommand command = new SQLiteCommand(Query, Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            Disconnect();
            Create_Egresos();
            Upload_Egresos();
            Create_Max_IDs();
        }

        public static void Modifier_Usuario(string User, string Contraseña, string Correo)
        {
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_USUARIO + " SET Usuario = \'" + User + "\' WHERE ID_Usuario = " + ID_User;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_USUARIO + " SET Contraseña = \'" + Contraseña + "\' WHERE ID_Usuario = " + ID_User; ;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_USUARIO + " SET Correo = \'" + Correo + "\' WHERE ID_Usuario = " + ID_User; ;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Usuarios();
            Upload_Usuarios();
            Create_Max_IDs();
        }
        public static void Modifier_Tipo_I(int ID_TipoI, string Tipo, DateTime fecha, int Alg)
        {
            string Fecha = Convert.ToString(fecha);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_TIPO_I + " SET Tipo_I = \'" + Tipo + "\' WHERE ID_Tipo_I = " + ID_TipoI;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_TIPO_I + " SET Fecha_Esperada_Tipo_I = \'" + Fecha + "\' WHERE ID_Tipo_I = " + ID_TipoI;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_TIPO_I + " SET Fecha_Esperada_Tipo_I_Algoritmo = \'" + Alg + "\' WHERE ID_Tipo_I = " + ID_TipoI;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Tipo_I();
            Upload_Tipo_I();
            Create_Max_IDs();
        }
        public static void Modifier_Tipo_E(int ID_TipoE, string Tipo, DateTime fecha, int Alg)
        {
            string Fecha = Convert.ToString(fecha);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_TIPO_E + " SET Tipo_E = \'" + Tipo + "\' WHERE ID_Tipo_E = " + ID_TipoE;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_TIPO_E + " SET Fecha_Esperada_Tipo_E = \'" + Fecha + "\' WHERE ID_Tipo_E = " + ID_TipoE;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_TIPO_E + " SET Fecha_Esperada_Tipo_E_Algoritmo = \'" + Alg + "\' WHERE ID_Tipo_E = " + ID_TipoE;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Tipo_E();
            Upload_Tipo_E();
            Create_Max_IDs();
        }
        public static void Modifier_Ingreso(int ID_Ingreso, int ID_TipoI, double Ingreso, DateTime fecha)
        {
            string Fecha = Convert.ToString(fecha);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_INGRESOS + " SET Ingreso = \'" + Ingreso + "\' WHERE ID_Ingreso = " + ID_Ingreso;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_INGRESOS + " SET Tipo_Ingreso = \'" + ID_TipoI + "\' WHERE ID_Ingreso = " + ID_Ingreso;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_INGRESOS + " SET Fecha_Ingreso = \'" + Fecha + "\' WHERE ID_Ingreso = " + ID_Ingreso;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Ingresos();
            Upload_Ingresos();
            Create_Max_IDs();
        }
        public static void Modifier_Egreso(int ID_Egreso, int ID_TipoE, double Egreso, DateTime fecha)
        {
            string Fecha = Convert.ToString(fecha);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_EGRESOS + " SET Egreso = \'" + Egreso + "\' WHERE ID_Egreso = " + ID_Egreso;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_EGRESOS + " SET Tipo_Egreso = \'" + ID_TipoE + "\' WHERE ID_Egreso = " + ID_Egreso;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_EGRESOS + " SET Fecha_Egreso = \'" + Fecha + "\' WHERE ID_Egreso = " + ID_Egreso;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Create_Egresos();
            Upload_Egresos();
            Create_Max_IDs();
        }
        public static void Modifier_Config(int Theme, int Leng, string evaluo)
        {
            string Evaluo = Convert.ToString(evaluo);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_CONFIG + " SET Lenguaje = \'" + Leng + "\' WHERE ID_User_Config = " + ID_User;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_CONFIG + " SET Tema = \'" + Theme + "\' WHERE ID_User_Config = " + ID_User;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_CONFIG + " SET Fecha_Evaluo_Actual = \'" + Evaluo + "\' WHERE ID_User_Config = " + ID_User;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Upload_Config();
        }
        public static void Modifier_Metas(double Monto, DateTime fecha_Limite)
        {
            string Fecha_Limite = Convert.ToString(fecha_Limite);
            Connect();
            using (Transaction = Connection.BeginTransaction())
            {
                using (Command = Connection.CreateCommand())
                {
                    Command.Transaction = Transaction;
                    Command.CommandText = "UPDATE " + TABLE_METAS + " SET Metas_Monto = \'" + Monto + "\' WHERE ID_User_Metas = " + ID_User;
                    Command.ExecuteNonQuery();
                    Command.CommandText = "UPDATE " + TABLE_METAS + " SET Metas_Fecha_Limite = \'" + Fecha_Limite + "\' WHERE ID_User_Metas = " + ID_User;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            Disconnect();
            Upload_Config();
        }
    }
}
