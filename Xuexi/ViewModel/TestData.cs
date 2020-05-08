using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xuexi.Models;

namespace Xuexi.ViewModel
{
    class TestData
    {
        private List<ThisModel> datas = new List<ThisModel>();
        public List<ThisModel> Datas
        {
            get { return datas; }
            set { datas = value; }
        }


        public TestData()
        {
            Datas.Add(new ThisModel() { Title = "6、在福建宁德工作期间，习近平总书记曾指出能否有效制止腐败现象关系到党的生死存亡和社会主义事业的成败，这就需要建立各种有效的监督机制，其中____的监督是最经常、公开、广泛的一种监督方式。", ChoiceA = "人大", ChoiceB = "党内", ChoiceC = "新闻媒介", ChoiceD = "", Answer = "答案：C" });
            Datas.Add(new ThisModel() { Title = "37、2014年9月5日，习近平总书记在庆祝全国人民代表大会成立____周年大会上的讲话指出，实践充分证明，人民代表大会制度是符合中国国情和实际、体现社会主义国家性质、保证人民当家做主、保障实现中华民族伟大复兴的好制度。", ChoiceA = "55", ChoiceB = "60", ChoiceC = "65", ChoiceD = "70", Answer = "答案：B" });
        }
    }
}
