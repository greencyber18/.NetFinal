using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
   public class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserType { get; set; }

    }
}
