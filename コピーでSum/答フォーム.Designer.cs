namespace コピーでGoKei
{
    partial class 答フォーム
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(答フォーム));
            this.答欄 = new System.Windows.Forms.TextBox();
            this.最前面指定トグル = new System.Windows.Forms.CheckBox();
            this.差額ボタン = new System.Windows.Forms.Button();
            this.バルーンヒント = new System.Windows.Forms.ToolTip(this.components);
            this.クリアボタン = new System.Windows.Forms.Button();
            this.横線ボタン = new System.Windows.Forms.Button();
            this.金額表示トグル = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // 答欄
            // 
            this.答欄.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.答欄.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.答欄.Location = new System.Drawing.Point(12, 7);
            this.答欄.Multiline = true;
            this.答欄.Name = "答欄";
            this.答欄.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.答欄.Size = new System.Drawing.Size(238, 108);
            this.答欄.TabIndex = 0;
            // 
            // 最前面指定トグル
            // 
            this.最前面指定トグル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.最前面指定トグル.Appearance = System.Windows.Forms.Appearance.Button;
            this.最前面指定トグル.AutoSize = true;
            this.最前面指定トグル.Font = new System.Drawing.Font("MS UI Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.最前面指定トグル.Location = new System.Drawing.Point(253, 4);
            this.最前面指定トグル.Margin = new System.Windows.Forms.Padding(0);
            this.最前面指定トグル.Name = "最前面指定トグル";
            this.最前面指定トグル.Size = new System.Drawing.Size(42, 19);
            this.最前面指定トグル.TabIndex = 2;
            this.最前面指定トグル.Text = "最前面";
            this.バルーンヒント.SetToolTip(this.最前面指定トグル, "押してオンにすると常時最前面に表示します。\r\nもう一度押すと、オフになります。");
            this.最前面指定トグル.UseVisualStyleBackColor = true;
            this.最前面指定トグル.CheckedChanged += new System.EventHandler(this.最前面指定トグル_CheckedChanged);
            // 
            // 差額ボタン
            // 
            this.差額ボタン.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.差額ボタン.Location = new System.Drawing.Point(253, 48);
            this.差額ボタン.Name = "差額ボタン";
            this.差額ボタン.Size = new System.Drawing.Size(42, 22);
            this.差額ボタン.TabIndex = 3;
            this.差額ボタン.Text = "差額";
            this.バルーンヒント.SetToolTip(this.差額ボタン, "一つ前の数字との差額を計算して表示します。");
            this.差額ボタン.UseVisualStyleBackColor = true;
            this.差額ボタン.Click += new System.EventHandler(this.差額ボタン_Click);
            // 
            // クリアボタン
            // 
            this.クリアボタン.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.クリアボタン.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.クリアボタン.Location = new System.Drawing.Point(253, 23);
            this.クリアボタン.Name = "クリアボタン";
            this.クリアボタン.Size = new System.Drawing.Size(42, 19);
            this.クリアボタン.TabIndex = 3;
            this.クリアボタン.Text = "クリア";
            this.クリアボタン.UseVisualStyleBackColor = true;
            this.クリアボタン.Click += new System.EventHandler(this.クリアボタン_Click);
            // 
            // 横線ボタン
            // 
            this.横線ボタン.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.横線ボタン.Location = new System.Drawing.Point(253, 76);
            this.横線ボタン.Name = "横線ボタン";
            this.横線ボタン.Size = new System.Drawing.Size(42, 17);
            this.横線ボタン.TabIndex = 3;
            this.横線ボタン.Text = "---";
            this.横線ボタン.UseVisualStyleBackColor = true;
            this.横線ボタン.Click += new System.EventHandler(this.横線ボタン_Click);
            // 
            // 金額表示トグル
            // 
            this.金額表示トグル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.金額表示トグル.Appearance = System.Windows.Forms.Appearance.Button;
            this.金額表示トグル.Checked = true;
            this.金額表示トグル.CheckState = System.Windows.Forms.CheckState.Checked;
            this.金額表示トグル.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.金額表示トグル.Location = new System.Drawing.Point(253, 96);
            this.金額表示トグル.Margin = new System.Windows.Forms.Padding(0);
            this.金額表示トグル.Name = "金額表示トグル";
            this.金額表示トグル.Size = new System.Drawing.Size(42, 19);
            this.金額表示トグル.TabIndex = 2;
            this.金額表示トグル.Text = "￥，";
            this.金額表示トグル.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.金額表示トグル.UseVisualStyleBackColor = true;
            this.金額表示トグル.CheckedChanged += new System.EventHandler(this.金額表示トグル_CheckedChanged);
            // 
            // 答フォーム
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 122);
            this.Controls.Add(this.クリアボタン);
            this.Controls.Add(this.横線ボタン);
            this.Controls.Add(this.差額ボタン);
            this.Controls.Add(this.金額表示トグル);
            this.Controls.Add(this.最前面指定トグル);
            this.Controls.Add(this.答欄);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "答フォーム";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "コピーでGoKei";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 答欄;
        private System.Windows.Forms.CheckBox 最前面指定トグル;
        private System.Windows.Forms.Button 差額ボタン;
        private System.Windows.Forms.ToolTip バルーンヒント;
        private System.Windows.Forms.Button クリアボタン;
        private System.Windows.Forms.Button 横線ボタン;
        private System.Windows.Forms.CheckBox 金額表示トグル;
    }
}

