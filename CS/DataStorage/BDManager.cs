using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataStorage{
    public class BDManager
    {
        private static BDManager dataBase;
        private static MySqlCommand comando;
        private static MySqlConnection con;
        private static string cadena;
        private static List<String> parameterNames;

        public BDManager()
        {
            cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g3;" + "database=inf282g3;" + "port=3306;password=H9u1oC;SslMode=none;" + "";
            con = new MySqlConnection(cadena);
            comando = new MySqlCommand();
            comando.Connection = con;
            parameterNames = new List<string>();
        }

        public static BDManager getInstance()
        {
            if (dataBase == null)
            {
                dataBase = new BDManager();
            }
            return dataBase;
        }

        private void getParameterNames(string procedureName) {
            con.Open();
            parameterNames.Clear();
            comando.CommandText = "getParameterNames";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("procedureName", MySqlDbType.String).Value = procedureName;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                String s = reader.GetString("PARAMETER_NAME");
                parameterNames.Add(s);
            }
            con.Close();
        }

        private void setProcedure(string procedureName)
        {
            Console.WriteLine("Setting procedure " + procedureName + "...");
            con.Open();
            comando.CommandText = procedureName;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }

        private void setParameters(List<Object> parameters)
        {
            int pos = 0;
            foreach (Object parameter in parameters)
            {
                Console.WriteLine("Setting parameter " + parameter.ToString() + "...");
                if (parameter is int) comando.Parameters.Add(parameterNames[pos], MySqlDbType.Int32).Value = Int32.Parse(parameter.ToString());
                else if (parameter is double) comando.Parameters.Add(parameterNames[pos], MySqlDbType.Double).Value = Double.Parse(parameter.ToString());
                else comando.Parameters.Add(parameterNames[pos], MySqlDbType.String).Value = parameter.ToString();
                Console.WriteLine(parameterNames[pos] + parameter.ToString());
                pos++;
            }
        }

        private List<Object> executeProcedure()
        {
            Console.WriteLine("Executing...");
            comando.ExecuteNonQuery();
            con.Close();
            return null;
        }

        public string passwordVerify(string us)
        {
            string aux;
            con.Open();
            comando.CommandText = "SELECT Password FROM User WHERE Dni = " + us;
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            aux = reader.GetString("Password");
            return aux;        
        }

        public void listarClientes()
        {
            con.Open();
            comando.CommandText = "SELECT * FROM Client";
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //Client c = new Client();
                string name = reader.GetString("Name");
                string surname = reader.GetString("Surname");
                string dni = reader.GetString("Dni");
                string district = reader.GetString("District");
                string phone = reader.GetString("PhoneNumber");
                string email = reader.GetString("Email");
            }
        }

        public void AddUpdate(string procedureName, List<Object> parameters) {
            getParameterNames(procedureName);
            setProcedure(procedureName);
            setParameters(parameters);
            executeProcedure();
        }
    }
}
