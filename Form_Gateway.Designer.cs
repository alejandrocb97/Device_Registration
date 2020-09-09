namespace Device_Registration
{
    partial class Gateway
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.model = new System.Windows.Forms.ComboBox();
            this.trademark = new System.Windows.Forms.ComboBox();
            this.serialn = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back1 = new System.Windows.Forms.Button();
            this.Ok1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.ip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.trademark);
            this.panel1.Controls.Add(this.serialn);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 214);
            this.panel1.TabIndex = 0;
            this.panel1.Validating += new System.ComponentModel.CancelEventHandler(this.panel1_Validating);
            // 
            // model
            // 
            this.model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(133, 103);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 21);
            this.model.TabIndex = 7;
            // 
            // trademark
            // 
            this.trademark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trademark.FormattingEnabled = true;
            this.trademark.Location = new System.Drawing.Point(133, 76);
            this.trademark.Name = "trademark";
            this.trademark.Size = new System.Drawing.Size(100, 21);
            this.trademark.TabIndex = 6;
            // 
            // serialn
            // 
            this.serialn.Location = new System.Drawing.Point(133, 50);
            this.serialn.Name = "serialn";
            this.serialn.Size = new System.Drawing.Size(100, 20);
            this.serialn.TabIndex = 5;
            this.serialn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serialn_KeyPress);
            this.serialn.Validating += new System.ComponentModel.CancelEventHandler(this.serialn_Validating);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(133, 24);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 4;
            this.id.Validating += new System.ComponentModel.CancelEventHandler(this.id_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "trademark:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "serial number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Back1
            // 
            this.Back1.Location = new System.Drawing.Point(75, 232);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(75, 23);
            this.Back1.TabIndex = 1;
            this.Back1.Text = "Back";
            this.Back1.UseVisualStyleBackColor = true;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // Ok1
            // 
            this.Ok1.Location = new System.Drawing.Point(199, 232);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(75, 23);
            this.Ok1.TabIndex = 2;
            this.Ok1.Text = "Ok";
            this.Ok1.UseVisualStyleBackColor = true;
            this.Ok1.Click += new System.EventHandler(this.Ok1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ip:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(133, 130);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 20);
            this.ip.TabIndex = 9;
            this.ip.Validating += new System.ComponentModel.CancelEventHandler(this.ip_Validating);
            // 
            // port
            // 
            this.port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(133, 156);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 21);
            this.port.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "port:";
            // 
            // Gateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.Ok1);
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Gateway";
            this.Text = "Gateway";
            this.Load += new System.EventHandler(this.Water_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialn;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button Ok1;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox trademark;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox port;
    }
}