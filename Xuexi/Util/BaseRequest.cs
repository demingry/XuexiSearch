using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuexi.Util
{
    public class BaseRequest
    {
        public virtual string RequestUrl { get; set; } = string.Empty;
        public virtual bool IsGetRequest { get; set; } = true;  //True's Get false's Post
        public virtual string ContentType { get; set; } = "application/x-www-form-urlencoded";
        public virtual string Content { get; set; } = string.Empty;
    }
}
