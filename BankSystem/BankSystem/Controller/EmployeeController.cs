using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controller
{
    internal class EmployeeController : IController
    {
        private List<IModel> items;
        public List<IModel> Items
        {
            get
            {
                return this.items;
            }

        }

        public bool Create(IModel model)
        {
            return true;
        }

        public bool Delete(IModel model)
        {
            return true;
        }

        public bool Delete(object id)
        {
            return true;
        }

        public bool Load()
        {
            return true;
        }

        public bool Load(object id)
        {
            return true;
        }

        public IModel Read(object id)
        {
            return null;
        }

        public bool Update(IModel model)
        {
            return true;
        }
        public bool IsExist(Object id)
        {
            return true;
        }
        public bool IsExist(IModel model)
        {
            return true;
        }
    }
}
