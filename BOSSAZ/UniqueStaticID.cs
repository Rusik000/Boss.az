using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAZ
{
    public abstract class UniqueStaticID
    {
        public static long id = default;

        [Newtonsoft.Json.JsonProperty("Identifier")]
        public long ID { get; set; } = ++id;
    }
}
