using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMan
{
    class GenericConnection
    {

        public virtual string Token { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual int Count { get; set; }
        public static void ExecuteQuery() {
            //using (NorthwindEntities con = new NorthwindEntities()) { }
        }

        public virtual JObject ToJson() {
            var obj = new JObject();
            return ToJson();
        }
    }
}
