using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_login
{
    class User
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string tajnoPitanje { get; set; }
        
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public string unikatniSalt { get; set; }

        _16038_DBDataSet dataset = new _16038_DBDataSet();
        _16038_DBDataSet.sis_dk_userDataTable userDataTable = new _16038_DBDataSet.sis_dk_userDataTable();
        _16038_DBDataSetTableAdapters.sis_dk_userTableAdapter taUser = new _16038_DBDataSetTableAdapters.sis_dk_userTableAdapter();

        public User() 
        {
        
        }

        public User login(string username, string password)
        {
            taUser.FillByUsername(userDataTable, username);
            foreach (DataRow dr in userDataTable)
            {
                this.unikatniSalt = dr["unikatniSalt"].ToString();
            }
            string realPassword = this.unikatniSalt + password + crypto.globalSalt;
            string passwordHash = crypto.sha256_convert(realPassword);
            taUser.FillByCredentials(userDataTable, username, passwordHash);
            if (userDataTable.Rows.Count > 0)
            {
                return this;
            }
            return null;
        }

        public bool exists(string username) {
            taUser.FillByUsername(userDataTable, username);
            if (userDataTable.Rows.Count > 0) {
                return true;
            }
            return false;
        }

        public void register() {
            this.unikatniSalt = (crypto.createUserSalt(15)).ToString();
            this.lozinka = crypto.sha256_convert(this.unikatniSalt + this.lozinka + crypto.globalSalt);
            taUser.Insert(this.korisnickoIme, this.lozinka, this.ime, this.prezime, this.email, this.tajnoPitanje, this.unikatniSalt);
        }

        public string retrieve(string username, string email, string sq) {
            taUser.FillBySQandEmail(userDataTable, username, email, sq);
            if (userDataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in userDataTable)
                {
                    this.id = int.Parse(dr["id"].ToString());
                    this.ime = dr["ime"].ToString();
                    this.prezime = dr["prezime"].ToString();
                    this.email = dr["email"].ToString();
                    this.tajnoPitanje = dr["tajnoPitanje"].ToString();
                    this.korisnickoIme = dr["korisnickoIme"].ToString();
                    this.lozinka = dr["lozinka"].ToString();
                    this.unikatniSalt = dr["unikatniSalt"].ToString();
                }
                string oldPassword = this.lozinka;
                string newPassword = crypto.createUserSalt(5);
                string realNewPassword = this.unikatniSalt + newPassword + crypto.globalSalt;
                string passwordHash = crypto.sha256_convert(realNewPassword);

                taUser.Update(this.korisnickoIme, passwordHash, this.ime, this.prezime, 
                    this.email, this.tajnoPitanje, this.unikatniSalt, this.id, this.korisnickoIme, 
                    oldPassword, this.ime, this.prezime, this.email, this.tajnoPitanje, this.unikatniSalt);
                return newPassword;
            }
            return "";
        }

    }
}
