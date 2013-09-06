using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace コピーでGoKei
{
    class 加算係
    {
        public static decimal? GetSum(string text)
        {
            var elements = text.Split(new[] { '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var result = elements.Sum(el => el.ToDecimal());
            //var resultText = result.ToString();
            // 少数桁が 0 だけなら、小数点以下を削除。
            //if(resultText.Contains('.') && resultText.Substring(resultText.IndexOf('.')+1).All(n=>n=='0')) 
            //    resultText=resultText.Substring(0,resultText.IndexOf('.'));
            return (elements.Any(el => el.IsNumeric())) ? result : (decimal?)null;
        }
    }
}
