
namespace Laboratorio12_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSemi = new System.Windows.Forms.Button();
            this.BtnArea = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSalida = new System.Windows.Forms.Button();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtSemi = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la longitud del lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la longitud del lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la longitud del lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calculo Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area del Triangulo";
            // 
            // BtnSemi
            // 
            this.BtnSemi.Location = new System.Drawing.Point(49, 197);
            this.BtnSemi.Name = "BtnSemi";
            this.BtnSemi.Size = new System.Drawing.Size(96, 38);
            this.BtnSemi.TabIndex = 5;
            this.BtnSemi.Text = "Semiperimetro";
            this.BtnSemi.UseVisualStyleBackColor = true;
            this.BtnSemi.Click += new System.EventHandler(this.BtnSemi_Click);
            // 
            // BtnArea
            // 
            this.BtnArea.Location = new System.Drawing.Point(190, 197);
            this.BtnArea.Name = "BtnArea";
            this.BtnArea.Size = new System.Drawing.Size(96, 38);
            this.BtnArea.TabIndex = 6;
            this.BtnArea.Text = "Area";
            this.BtnArea.UseVisualStyleBackColor = true;
            this.BtnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(332, 197);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(96, 38);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSalida
            // 
            this.BtnSalida.Location = new System.Drawing.Point(449, 197);
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.Size = new System.Drawing.Size(96, 38);
            this.BtnSalida.TabIndex = 8;
            this.BtnSalida.Text = "Salida";
            this.BtnSalida.UseVisualStyleBackColor = true;
            this.BtnSalida.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(277, 29);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(151, 23);
            this.txtLadoA.TabIndex = 9;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(277, 84);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(151, 23);
            this.txtLadoB.TabIndex = 10;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(277, 149);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(151, 23);
            this.txtLadoC.TabIndex = 11;
            // 
            // txtSemi
            // 
            this.txtSemi.Location = new System.Drawing.Point(277, 277);
            this.txtSemi.Name = "txtSemi";
            this.txtSemi.Size = new System.Drawing.Size(151, 23);
            this.txtSemi.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(277, 323);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(151, 23);
            this.txtArea.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 392);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSemi);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.BtnSalida);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnArea);
            this.Controls.Add(this.BtnSemi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSemi;
        private System.Windows.Forms.Button BtnArea;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSalida;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtSemi;
        private System.Windows.Forms.TextBox txtArea;
    }
}

