namespace _EDD_Practica1
{
    partial class ColaMensaje
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
            this.LabelCola = new System.Windows.Forms.Label();
            this.Operar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInorden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPostorden = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCola
            // 
            this.LabelCola.AutoSize = true;
            this.LabelCola.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCola.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelCola.Location = new System.Drawing.Point(170, 20);
            this.LabelCola.Name = "LabelCola";
            this.LabelCola.Size = new System.Drawing.Size(240, 23);
            this.LabelCola.TabIndex = 0;
            this.LabelCola.Text = "Operaciones en cola: 17";
            this.LabelCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Operar
            // 
            this.Operar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Operar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operar.Location = new System.Drawing.Point(240, 60);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(100, 30);
            this.Operar.TabIndex = 1;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPostorden);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxInorden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxResultado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCarnet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensaje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(279, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consola de ejecución";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet que hizo el mensaje";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.BackColor = System.Drawing.Color.DimGray;
            this.textBoxCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCarnet.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxCarnet.Location = new System.Drawing.Point(40, 50);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(200, 16);
            this.textBoxCarnet.TabIndex = 2;
            this.textBoxCarnet.Text = "201503836";
            this.textBoxCarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip que hizo el mensaje";
            // 
            // textBoxIp
            // 
            this.textBoxIp.BackColor = System.Drawing.Color.DimGray;
            this.textBoxIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIp.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxIp.Location = new System.Drawing.Point(40, 100);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(200, 16);
            this.textBoxIp.TabIndex = 4;
            this.textBoxIp.Text = "201503836";
            this.textBoxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado de la operación";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.Color.DimGray;
            this.textBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxResultado.Location = new System.Drawing.Point(43, 150);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(200, 16);
            this.textBoxResultado.TabIndex = 6;
            this.textBoxResultado.Text = "201503836";
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operación en inorden";
            // 
            // textBoxInorden
            // 
            this.textBoxInorden.BackColor = System.Drawing.Color.DimGray;
            this.textBoxInorden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInorden.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxInorden.Location = new System.Drawing.Point(40, 200);
            this.textBoxInorden.Name = "textBoxInorden";
            this.textBoxInorden.Size = new System.Drawing.Size(200, 16);
            this.textBoxInorden.TabIndex = 8;
            this.textBoxInorden.Text = "201503836";
            this.textBoxInorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operación en postorden";
            // 
            // textBoxPostorden
            // 
            this.textBoxPostorden.BackColor = System.Drawing.Color.DimGray;
            this.textBoxPostorden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPostorden.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxPostorden.Location = new System.Drawing.Point(43, 250);
            this.textBoxPostorden.Name = "textBoxPostorden";
            this.textBoxPostorden.Size = new System.Drawing.Size(200, 16);
            this.textBoxPostorden.TabIndex = 10;
            this.textBoxPostorden.Text = "201503836";
            this.textBoxPostorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(6, 22);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(263, 297);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // ColaMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.LabelCola);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColaMensaje";
            this.Opacity = 0.9D;
            this.Text = "Cola de mensajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCola;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPostorden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInorden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}