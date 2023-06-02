using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsProj.classes
{
    public class User
    {
       public String userName { get; set; }
       public String password { get; set; }
        public String id { get; set; }
        
        public User(String userName, String pass, String id)
        {
            this.userName = userName;
            this.password = pass;
            this.id = id;
        }

    }
}
