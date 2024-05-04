using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic
{
    public class Filter
    {
        public string Field { get; set; }
        public string? Value { get; set; }
        public string Operator { get; set; }
        public string? Logic { get; set; }

        public IEnumerable<Filter>? Filters { get; set; }

        public Filter()
        {
            Field = string.Empty;
            Operator = string.Empty;
        }


        /*@operator ifadesi, C# dilinde geçerli olan bir özel durumdur. Bazı durumlarda, C# dilinde özel anahtar kelimeler olarak kullanılan kelimeleri değişken veya parametre ismi olarak kullanmak istediğimizde, bu kelimelerin başına @ işareti ekleyerek kullanabiliriz.*/
        public Filter(string field, string @operator)
        {
            Field = field;
            Operator = @operator;
        }

    }
}
