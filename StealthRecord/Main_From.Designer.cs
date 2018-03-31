namespace 隐形记录
{
    partial class Main_From
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.Tim_Watch = new System.Windows.Forms.Timer(this.components);
            this.Tim_Exec = new System.Windows.Forms.Timer(this.components);
            this.btn_exec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 41);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(195, 149);
            this.txt.TabIndex = 2;
            // 
            // Tim_Watch
            // 
            this.Tim_Watch.Tick += new System.EventHandler(this.Tim_Watch_Tick);
            // 
            // Tim_Exec
            // 
            this.Tim_Exec.Tick += new System.EventHandler(this.Tim_Exec_Tick);
            // 
            // btn_exec
            // 
            this.btn_exec.Enabled = false;
            this.btn_exec.Location = new System.Drawing.Point(117, 12);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(90, 23);
            this.btn_exec.TabIndex = 0;
            this.btn_exec.Text = "Exec";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 202);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.btn_start);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TH";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Timer Tim_Watch;
        private System.Windows.Forms.Timer Tim_Exec;
        private System.Windows.Forms.Button btn_exec;
    }
}

