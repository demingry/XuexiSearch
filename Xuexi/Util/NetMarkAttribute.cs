using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuexi.Util
{
    /// <summary>
    /// NetMarkAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Field|AttributeTargets.Property)]
    class NetMarkAttribute : Attribute
    {
    }
}
