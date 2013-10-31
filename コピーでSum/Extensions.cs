using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace コピーでGoKei
{
    public static class Extensions
    {
        public static decimal ToDecimal(this string s)
        {
            var res=0m;
            decimal.TryParse(s.RemoveYenAndComma(), out res);
            return res;
        }

        public static bool IsNumeric(this string s)
        {
            var _=0m;
            return decimal.TryParse(s.RemoveYenAndComma(), out _);
        }

        public static string RemoveYenAndComma(this string s)
        {
            return s.Replace("\u00A5", "").Replace(@"¥", "").Replace(",", "");
        }

        public static string FormatYenAndComma(this string s)
        {
            if (!s.IsNumeric()) return s;
            return s.ToDecimal().ToString("C", CultureInfo.CurrentCulture);
        }


        public static string より前(this string 対象, string 指定文字列, bool 結果に含む, 該当なしの場合 ない場合)
        {
            var index = 対象.IndexOf(指定文字列);
            if (index == -1) return (ない場合 == 該当なしの場合.空文字列) ? "" : 対象;
            var 文字数 = (結果に含む) ? index += 指定文字列.Length : index;
            return 対象.Substring(0, 文字数);
        }

        public static string より後(this string 対象, string 指定文字列, bool 結果に含む, 該当なしの場合 ない場合)
        {
            var index = 対象.IndexOf(指定文字列);
            if (index == -1) return (ない場合 == 該当なしの場合.空文字列) ? "" : 対象;
            var 開始位置 = (結果に含む) ? index : index + 指定文字列.Length;
            var 文字数 = 対象.Length - 開始位置;
            return 対象.Substring(開始位置,文字数);
        }


    } 
    public enum 該当なしの場合
    {
        空文字列, 全文字列
    }
}
