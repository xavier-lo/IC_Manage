namespace IC_MAN
{
    partial class SetPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CB_COM_PORT = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择端口：";
            // 
            // CB_COM_PORT
            // 
            this.CB_COM_PORT.FormattingEnabled = true;
            this.CB_COM_PORT.Location = new System.Drawing.Point(113, 41);
            this.CB_COM_PORT.Name = "CB_COM_PORT";
            this.CB_COM_PORT.Size = new System.Drawing.Size(78, 20);
            this.CB_COM_PORT.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(49, 82);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(60, 25);
            this.ok.TabIndex = 2;
            this.ok.Text = "确认";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(131, 82);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(60, 25);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SetPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 158);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.CB_COM_PORT);
            this.Controls.Add(this.label1);
            this.Name = "SetPort";
            this.Text = "通信设置";
            this.Load += new System.EventHandler(this.SetPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_COM_PORT;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}