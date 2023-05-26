using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyProject.Repository
{
    interface IContactsRepository
    {
        DataTable selectAll();
        DataTable selectRow(int contactId);
        DataTable search(string parameter);
        bool Insert(string name, string family, string mobile, string email, int age, string address);
        bool Update(int contactId, string name, string family, string mobile, string email, int age, string address);
        bool Delete(int contactId);
    }
}
