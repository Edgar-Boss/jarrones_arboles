namespace arboles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.xI = new System.Windows.Forms.TextBox();
            this.yI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xF = new System.Windows.Forms.TextBox();
            this.yF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonAncho = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupData.SuspendLayout();
            this.SuspendLayout();
            // 
            // xI
            // 
            this.xI.Location = new System.Drawing.Point(152, 35);
            this.xI.Name = "xI";
            this.xI.Size = new System.Drawing.Size(30, 20);
            this.xI.TabIndex = 2;
            this.xI.Text = "0";
            // 
            // yI
            // 
            this.yI.Location = new System.Drawing.Point(188, 35);
            this.yI.Name = "yI";
            this.yI.Size = new System.Drawing.Size(34, 20);
            this.yI.TabIndex = 3;
            this.yI.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // xF
            // 
            this.xF.Location = new System.Drawing.Point(152, 68);
            this.xF.Name = "xF";
            this.xF.Size = new System.Drawing.Size(30, 20);
            this.xF.TabIndex = 9;
            this.xF.Text = "*";
            // 
            // yF
            // 
            this.yF.Location = new System.Drawing.Point(188, 68);
            this.yF.Name = "yF";
            this.yF.Size = new System.Drawing.Size(34, 20);
            this.yF.TabIndex = 10;
            this.yF.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonAncho
            // 
            this.radioButtonAncho.AutoSize = true;
            this.radioButtonAncho.Location = new System.Drawing.Point(63, 110);
            this.radioButtonAncho.Name = "radioButtonAncho";
            this.radioButtonAncho.Size = new System.Drawing.Size(56, 17);
            this.radioButtonAncho.TabIndex = 14;
            this.radioButtonAncho.Text = "Ancho";
            this.radioButtonAncho.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Profundo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salida";
            // 
            // groupData
            // 
            this.groupData.Controls.Add(this.label6);
            this.groupData.Controls.Add(this.label5);
            this.groupData.Controls.Add(this.label4);
            this.groupData.Controls.Add(this.label1);
            this.groupData.Controls.Add(this.radioButton2);
            this.groupData.Controls.Add(this.radioButtonAncho);
            this.groupData.Controls.Add(this.button1);
            this.groupData.Controls.Add(this.yF);
            this.groupData.Controls.Add(this.xF);
            this.groupData.Controls.Add(this.label3);
            this.groupData.Controls.Add(this.label2);
            this.groupData.Controls.Add(this.yI);
            this.groupData.Controls.Add(this.xI);
            this.groupData.Location = new System.Drawing.Point(17, 12);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(234, 670);
            this.groupData.TabIndex = 18;
            this.groupData.TabStop = false;
            this.groupData.Text = "Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "incpila";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "inpila";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(393, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 650);
            this.panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(393, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 650);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(128, 392);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 432);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 461);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(793, 498);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arboles";
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.TextBox xI;
        private System.Windows.Forms.TextBox yI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xF;
        private System.Windows.Forms.TextBox yF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonAncho;
        
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
    }
}

