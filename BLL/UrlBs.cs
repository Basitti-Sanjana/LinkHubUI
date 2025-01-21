using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class UrlBs
    {
        private UrlDb objDb;
        public UrlBs()
        {
            objDb = new UrlDb();
        }
        public IEnumerable<tbl_Url> GetAll()
        {
            return objDb.GetAll();
        }
        public tbl_Url GetById(int Id)
        {
            return objDb.GetById(Id);
        }
        public void Insert(tbl_Url Url)
        {
            objDb.insert(Url);
        }
        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }
        public void Update(tbl_Url Urls)
        {
            objDb.Update(Urls);
        }
    }
}