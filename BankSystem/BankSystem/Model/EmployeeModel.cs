using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    internal class EmployeeModel : IModel
    {
        private string id;
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.name = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string pw;
        public string Password
        {
            get
            {
                return this.pw;
            }
            set
            {
                this.name = value;
            }
        }
        private string right;
        public string Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.name = value;
            }
        }
        public EmployeeModel()
        {
            id = "";
            name = "";
            pw = "";
            right = "";
        }
        public EmployeeModel(string id, string name, string password, string right)
        {
            this.id = id;
            this.name = name;
            this.pw = password;
            this.right = right;
        }
    }
}
