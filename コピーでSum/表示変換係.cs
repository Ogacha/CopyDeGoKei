using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace コピーでGoKei
{
    class 表示変換係
    {
        public static string 金額表示(string s)
        {
            var rows = s.Split(new[]{"\r\n"}, StringSplitOptions.None);
            var text = from row in rows
                       select row.より前(" ", false, 該当なしの場合.全文字列).FormatYenAndComma() 
                            + row.より後(" ", true, 該当なしの場合.空文字列);
            return string.Join("\r\n", text.ToArray());
        }

        public static string 金額表示解除(string s)
        {
            return s.RemoveYenAndComma();
        }


    }
}
