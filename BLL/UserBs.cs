using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBs
    {
        private UserDb ObjDb;
        public UserBs()
        {
            ObjDb = new UserDb();
        }
        public IEnumerable<tbl_User> GetAll()
        {
            return ObjDb.GetAll();
        }
        public tbl_User GetById(int Id)
        {
            return ObjDb.GetById(Id);
        }
        public void Insert(tbl_User user)
        {
            ObjDb.Insert(user);
        }
        public void Delete(int Id)
        {
            ObjDb.Delete(Id);
        }
        public void Update(tbl_User user)
        {
            ObjDb.Update(user);
        }
    }
}