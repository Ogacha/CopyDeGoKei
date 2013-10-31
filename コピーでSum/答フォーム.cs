using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace コピーでGoKei
{
    public partial class 答フォーム : Form
    {
        // プロパティー
        decimal _result;
        public decimal Result
        {
            get { return _result; }
            set
            {
                preResult = _result;
                _result = value;
                var text = (金額表示トグル.Checked) 
                    ? Result.ToString("C", CultureInfo.CurrentCulture)
                    : Result.ToString();
                答欄.AppendText(text+"\r\n");
            }
        }

        // フィールド
        クリップボード監視係 cb;
        bool クリップボード変化を無視=false;
        decimal preResult;

        public 答フォーム()
        {
            InitializeComponent();
            cb = new クリップボード監視係(this);
            cb.ClipboardChanged += クリップボード変化;
            最前面指定トグル.Checked = true;
        }


        void コピーボタン_Click(object sender, EventArgs e)
        {
            var text = Result.ToString();
            // 少数桁が 0 だけなら、小数点以下を削除。
            if (text.Contains('.') && text.Substring(text.IndexOf('.') + 1).All(n => n == '0'))
                text = text.Substring(0, text.IndexOf('.'));
            クリップボード変化を無視 = true;
            Clipboard.SetText(text);
            答欄.AppendText(string.Format("↑{0} としてコピーしました。\r\n",text));
            クリップボード変化を無視 = false;
        }


        void クリップボード変化(object sender, EventArgs e)
        {
            if (クリップボード変化を無視) return;
            var result=加算係.GetSum(Clipboard.GetText());
            if (result.HasValue) Result = result.Value;
        }

        void 最前面指定トグル_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = 最前面指定トグル.Checked;
        }

        void 差額ボタン_Click(object sender, EventArgs e)
        {
            var 追加 = (金額表示トグル.Checked)
                ? (Result - preResult).ToString("C", CultureInfo.CurrentCulture)
                : (Result - preResult).ToString();
            答欄.AppendText(string.Format("{0} ←差額\r\n", 追加));
        }

        void クリアボタン_Click(object sender, EventArgs e)
        {
            答欄.Clear();
        }

        void 横線ボタン_Click(object sender, EventArgs e)
        {
            答欄.AppendText("--------\r\n");
        }

        void 金額表示トグル_CheckedChanged(object sender, EventArgs e)
        {
            var 元 = 答欄.Text;
            var 後 = (金額表示トグル.Checked) ? 表示変換係.金額表示(元) : 表示変換係.金額表示解除(元);
            答欄.Clear();
            答欄.AppendText(後);
        }
    }
}
