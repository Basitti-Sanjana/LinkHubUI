using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BaseBs
    {
        public UserBs userBs;
        public UrlBs urlBs;
        public CategoryBs categoryBs;
        public BaseBs()
        {
            userBs = new UserBs();
            urlBs = new UrlBs();
            categoryBs = new CategoryBs();
        }
    }
}
