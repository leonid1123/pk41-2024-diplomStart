using System.Diagnostics;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Sotrudnik> sotrudnikList = new List<Sotrudnik>();
        MySqlConnection conn;
        void PrintList(List<Sotrudnik> _list)
        {
            listBox1.Items.Clear();
            foreach (var item in _list)
            {
                listBox1.Items.Add(item.getAll());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text.Trim();
            var fname = textBox2.Text.Trim();
            var name = textBox3.Text.Trim();
            var sname = textBox4.Text.Trim();
            var x = email.IndexOf("@");
            if (x > 0 & fname.Length > 1 & name.Length > 1 & sname.Length > 1)
            {
                var y = email.Substring(0, x);
                var z = fname.Substring(0, 1) + fname.Substring(fname.Length - 1, 1)
                    + name.Substring(0, 1) + name.Substring(name.Length - 1, 1)
                    + sname.Substring(0, 1) + sname.Substring(sname.Length - 1, 1);
                label5.Text = $"Логин: {y} \nПароль:{z}";
                var sotrudnik = new Sotrudnik(email, fname, name, sname, y, z);
                //внести в бд
                conn.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO `sotrudniki`(`email`, `name`, `fname`, `sname`, `login`, `password`) VALUES (@email,@name,@fname,@sname,@login,@password)";
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("sname", sname);
                    cmd.Parameters.AddWithValue("login", y);
                    cmd.Parameters.AddWithValue("password", z);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                sotrudnikList.Add(sotrudnik);
                PrintList(sotrudnikList);
            }
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var inp = textBox5.Text.Trim();
            listBox1.Items.Clear();
            foreach (var item in sotrudnikList)
            {
                if (item.getFname().IndexOf(inp) != -1)
                {
                    listBox1.Items.Add(item.getAll());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;User ID=pk41;Password=123456;Database=pk41diplomstart");
            conn.Open();
            using var command = new MySqlCommand("SELECT id, email, name, fname, sname, login, password FROM sotrudniki;", conn);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                sotrudnikList.Add( new Sotrudnik(reader.GetInt32(0),reader.GetString(1), reader.GetString(3),reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6)) );
            }
            conn.Close();  
            PrintList(sotrudnikList);
        }
    }
}
