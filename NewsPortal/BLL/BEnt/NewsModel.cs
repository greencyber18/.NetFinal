using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
   public class NewsModel
    {
        public int ID { get; set; }
        public string PublishedDate { get; set; }
        public string Headline { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Body { get; set; }
        public Nullable<int> AuthId { get; set; }
        public Nullable<int> ReID { get; set; }
        public Nullable<int> CmID { get; set; }

        public virtual CategoryModel Category { get; set; }
        public virtual CommentModel Comment { get; set; }
       
        public virtual ReactModel React { get; set; }
        public virtual UserModel User { get; set; }
    }
}
