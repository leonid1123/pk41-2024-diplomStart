namespace WinFormsApp1
{
    internal class Sotrudnik
    {
        string email = "";
        string fname = "";
        string name = "";
        string sname = "";
        string login = "";
        string password = "";
        int id;

        public Sotrudnik(string _email, string _fname, string _name, string _sname, string _login, string _password)
        {
            email = _email;
            fname = _fname;
            name = _name;
            sname = _sname;
            login = _login;
            password = _password;
        }
        public Sotrudnik(int _id, string _email, string _fname, string _name, string _sname, string _login, string _password)
        {
            id = _id;
            email = _email;
            fname = _fname;
            name = _name;
            sname = _sname;
            login = _login;
            password = _password;
        }
        public string getFname()
        {
            return fname;
        }
        public string getAll()
        {
            return $"{fname} {name} {sname} {email} {login} {password}";
        }
    }
}
