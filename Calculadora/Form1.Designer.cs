namespace Calculadora
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
            PaneSpecial = new Panel();
            lb_historial = new Label();
            btnEspecial = new RJboton();
            btnCero = new RJboton();
            BtnPoint = new RJboton();
            BtnRest = new RJboton();
            BtnPlus = new RJboton();
            btnEquals = new RJboton();
            BtnMult = new RJboton();
            BtnDiv = new RJboton();
            BtnEspecial2 = new RJboton();
            Erase = new RJboton();
            BtnEraseAll = new RJboton();
            txtDisplay = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            PaneSpecial.SuspendLayout();
            SuspendLayout();
            // 
            // PaneSpecial
            // 
            PaneSpecial.BackColor = Color.Black;
            PaneSpecial.Controls.Add(lb_historial);
            PaneSpecial.Controls.Add(btnEspecial);
            PaneSpecial.Controls.Add(btnCero);
            PaneSpecial.Controls.Add(BtnPoint);
            PaneSpecial.Controls.Add(BtnRest);
            PaneSpecial.Controls.Add(BtnPlus);
            PaneSpecial.Controls.Add(btnEquals);
            PaneSpecial.Controls.Add(BtnMult);
            PaneSpecial.Controls.Add(BtnDiv);
            PaneSpecial.Controls.Add(BtnEspecial2);
            PaneSpecial.Controls.Add(Erase);
            PaneSpecial.Controls.Add(BtnEraseAll);
            PaneSpecial.Controls.Add(txtDisplay);
            PaneSpecial.Location = new Point(7, 7);
            PaneSpecial.Name = "PaneSpecial";
            PaneSpecial.Size = new Size(313, 464);
            PaneSpecial.TabIndex = 1025;
            // 
            // lb_historial
            // 
            lb_historial.AutoSize = true;
            lb_historial.FlatStyle = FlatStyle.System;
            lb_historial.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_historial.ForeColor = SystemColors.ControlLight;
            lb_historial.Location = new Point(270, 9);
            lb_historial.Margin = new Padding(0);
            lb_historial.Name = "lb_historial";
            lb_historial.Padding = new Padding(0, 0, 0, 10);
            lb_historial.Size = new Size(31, 40);
            lb_historial.TabIndex = 1035;
            lb_historial.Text = "...";
            lb_historial.TextAlign = ContentAlignment.MiddleCenter;
            lb_historial.Click += lb_historial_Click;
            // 
            // btnEspecial
            // 
            btnEspecial.BackColor = Color.FromArgb(34, 34, 34);
            btnEspecial.BackgroundColor = Color.FromArgb(34, 34, 34);
            btnEspecial.BorderColor = Color.FromArgb(0, 0, 0, 30);
            btnEspecial.BorderRadius = 20;
            btnEspecial.BorderSize = 0;
            btnEspecial.FlatAppearance.BorderColor = Color.Red;
            btnEspecial.FlatAppearance.BorderSize = 0;
            btnEspecial.FlatStyle = FlatStyle.Flat;
            btnEspecial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEspecial.ForeColor = Color.FromArgb(181, 98, 15);
            btnEspecial.Location = new Point(11, 408);
            btnEspecial.Name = "btnEspecial";
            btnEspecial.Size = new Size(68, 54);
            btnEspecial.TabIndex = 1033;
            btnEspecial.Text = "√";
            btnEspecial.TextColor = Color.FromArgb(181, 98, 15);
            btnEspecial.UseVisualStyleBackColor = false;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.FromArgb(34, 34, 34);
            btnCero.BackgroundColor = Color.FromArgb(34, 34, 34);
            btnCero.BorderColor = Color.FromArgb(0, 0, 0, 30);
            btnCero.BorderRadius = 20;
            btnCero.BorderSize = 0;
            btnCero.FlatAppearance.BorderColor = Color.Red;
            btnCero.FlatAppearance.BorderSize = 0;
            btnCero.FlatStyle = FlatStyle.Flat;
            btnCero.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCero.ForeColor = Color.FromArgb(224, 224, 224);
            btnCero.Location = new Point(85, 408);
            btnCero.Name = "btnCero";
            btnCero.Padding = new Padding(3, 5, 0, 0);
            btnCero.Size = new Size(68, 54);
            btnCero.TabIndex = 1032;
            btnCero.Text = "0";
            btnCero.TextColor = Color.FromArgb(224, 224, 224);
            btnCero.UseVisualStyleBackColor = false;
            // 
            // BtnPoint
            // 
            BtnPoint.BackColor = Color.FromArgb(34, 34, 34);
            BtnPoint.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnPoint.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnPoint.BorderRadius = 20;
            BtnPoint.BorderSize = 0;
            BtnPoint.FlatAppearance.BorderColor = Color.Red;
            BtnPoint.FlatAppearance.BorderSize = 0;
            BtnPoint.FlatStyle = FlatStyle.Flat;
            BtnPoint.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPoint.ForeColor = Color.FromArgb(181, 98, 15);
            BtnPoint.Location = new Point(159, 408);
            BtnPoint.Name = "BtnPoint";
            BtnPoint.Padding = new Padding(0, 0, 0, 15);
            BtnPoint.Size = new Size(68, 54);
            BtnPoint.TabIndex = 1031;
            BtnPoint.Text = ".";
            BtnPoint.TextColor = Color.FromArgb(181, 98, 15);
            BtnPoint.UseVisualStyleBackColor = false;
            BtnPoint.Click += BtnPoint_Click;
            // 
            // BtnRest
            // 
            BtnRest.BackColor = Color.FromArgb(34, 34, 34);
            BtnRest.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnRest.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnRest.BorderRadius = 20;
            BtnRest.BorderSize = 0;
            BtnRest.FlatAppearance.BorderColor = Color.Red;
            BtnRest.FlatAppearance.BorderSize = 0;
            BtnRest.FlatStyle = FlatStyle.Flat;
            BtnRest.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRest.ForeColor = Color.FromArgb(181, 98, 15);
            BtnRest.Location = new Point(233, 288);
            BtnRest.Name = "BtnRest";
            BtnRest.Padding = new Padding(5, 0, 0, 0);
            BtnRest.Size = new Size(68, 55);
            BtnRest.TabIndex = 1030;
            BtnRest.Text = "-";
            BtnRest.TextColor = Color.FromArgb(181, 98, 15);
            BtnRest.UseVisualStyleBackColor = false;
            BtnRest.Click += BtnRest_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(34, 34, 34);
            BtnPlus.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnPlus.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnPlus.BorderRadius = 20;
            BtnPlus.BorderSize = 0;
            BtnPlus.FlatAppearance.BorderColor = Color.Red;
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BtnPlus.ForeColor = Color.FromArgb(181, 98, 15);
            BtnPlus.Location = new Point(233, 348);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Padding = new Padding(5, 0, 0, 0);
            BtnPlus.Size = new Size(68, 55);
            BtnPlus.TabIndex = 1029;
            BtnPlus.Text = "+";
            BtnPlus.TextColor = Color.FromArgb(181, 98, 15);
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(34, 34, 34);
            btnEquals.BackgroundColor = Color.FromArgb(34, 34, 34);
            btnEquals.BorderColor = Color.FromArgb(0, 0, 0, 30);
            btnEquals.BorderRadius = 20;
            btnEquals.BorderSize = 0;
            btnEquals.FlatAppearance.BorderColor = Color.Red;
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.ForeColor = Color.FromArgb(181, 98, 15);
            btnEquals.Location = new Point(233, 408);
            btnEquals.Name = "btnEquals";
            btnEquals.Padding = new Padding(5, 0, 0, 5);
            btnEquals.Size = new Size(68, 55);
            btnEquals.TabIndex = 1028;
            btnEquals.Text = "=";
            btnEquals.TextColor = Color.FromArgb(181, 98, 15);
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += BtnEquals_Click;
            // 
            // BtnMult
            // 
            BtnMult.BackColor = Color.FromArgb(34, 34, 34);
            BtnMult.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnMult.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnMult.BorderRadius = 20;
            BtnMult.BorderSize = 0;
            BtnMult.FlatAppearance.BorderColor = Color.Red;
            BtnMult.FlatAppearance.BorderSize = 0;
            BtnMult.FlatStyle = FlatStyle.Flat;
            BtnMult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMult.ForeColor = Color.FromArgb(181, 98, 15);
            BtnMult.Location = new Point(233, 228);
            BtnMult.Name = "BtnMult";
            BtnMult.Padding = new Padding(10, 5, 5, 5);
            BtnMult.Size = new Size(68, 55);
            BtnMult.TabIndex = 1027;
            BtnMult.Text = "x";
            BtnMult.TextColor = Color.FromArgb(181, 98, 15);
            BtnMult.UseVisualStyleBackColor = false;
            BtnMult.Click += BtnMult_Click;
            // 
            // BtnDiv
            // 
            BtnDiv.BackColor = Color.FromArgb(34, 34, 34);
            BtnDiv.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnDiv.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnDiv.BorderRadius = 20;
            BtnDiv.BorderSize = 0;
            BtnDiv.FlatAppearance.BorderColor = Color.Red;
            BtnDiv.FlatAppearance.BorderSize = 0;
            BtnDiv.FlatStyle = FlatStyle.Flat;
            BtnDiv.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDiv.ForeColor = Color.FromArgb(181, 98, 15);
            BtnDiv.Location = new Point(233, 168);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Padding = new Padding(5, 0, 0, 0);
            BtnDiv.Size = new Size(68, 55);
            BtnDiv.TabIndex = 1026;
            BtnDiv.Text = "÷";
            BtnDiv.TextColor = Color.FromArgb(181, 98, 15);
            BtnDiv.UseVisualStyleBackColor = false;
            BtnDiv.Click += BtnDiv_Click;
            // 
            // BtnEspecial2
            // 
            BtnEspecial2.BackColor = Color.FromArgb(34, 34, 34);
            BtnEspecial2.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnEspecial2.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnEspecial2.BorderRadius = 20;
            BtnEspecial2.BorderSize = 0;
            BtnEspecial2.FlatAppearance.BorderColor = Color.Red;
            BtnEspecial2.FlatAppearance.BorderSize = 0;
            BtnEspecial2.FlatStyle = FlatStyle.Flat;
            BtnEspecial2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            BtnEspecial2.ForeColor = Color.FromArgb(181, 98, 15);
            BtnEspecial2.Location = new Point(159, 168);
            BtnEspecial2.Name = "BtnEspecial2";
            BtnEspecial2.Size = new Size(68, 55);
            BtnEspecial2.TabIndex = 1025;
            BtnEspecial2.Text = "^";
            BtnEspecial2.TextColor = Color.FromArgb(181, 98, 15);
            BtnEspecial2.UseVisualStyleBackColor = false;
            // 
            // Erase
            // 
            Erase.BackColor = Color.FromArgb(34, 34, 34);
            Erase.BackgroundColor = Color.FromArgb(34, 34, 34);
            Erase.BorderColor = Color.FromArgb(0, 0, 0, 30);
            Erase.BorderRadius = 20;
            Erase.BorderSize = 0;
            Erase.FlatAppearance.BorderColor = Color.Red;
            Erase.FlatAppearance.BorderSize = 0;
            Erase.FlatStyle = FlatStyle.Flat;
            Erase.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Erase.ForeColor = Color.FromArgb(181, 98, 15);
            Erase.Location = new Point(85, 168);
            Erase.Name = "Erase";
            Erase.Size = new Size(68, 55);
            Erase.TabIndex = 1024;
            Erase.Text = "C";
            Erase.TextColor = Color.FromArgb(181, 98, 15);
            Erase.UseVisualStyleBackColor = false;
            Erase.Click += Erase_Click;
            // 
            // BtnEraseAll
            // 
            BtnEraseAll.BackColor = Color.FromArgb(34, 34, 34);
            BtnEraseAll.BackgroundColor = Color.FromArgb(34, 34, 34);
            BtnEraseAll.BorderColor = Color.FromArgb(0, 0, 0, 30);
            BtnEraseAll.BorderRadius = 20;
            BtnEraseAll.BorderSize = 0;
            BtnEraseAll.FlatAppearance.BorderColor = Color.Red;
            BtnEraseAll.FlatAppearance.BorderSize = 0;
            BtnEraseAll.FlatStyle = FlatStyle.Flat;
            BtnEraseAll.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            BtnEraseAll.ForeColor = Color.FromArgb(181, 98, 15);
            BtnEraseAll.Location = new Point(11, 168);
            BtnEraseAll.Name = "BtnEraseAll";
            BtnEraseAll.Size = new Size(68, 55);
            BtnEraseAll.TabIndex = 1023;
            BtnEraseAll.Text = "AC";
            BtnEraseAll.TextColor = Color.FromArgb(181, 98, 15);
            BtnEraseAll.UseVisualStyleBackColor = false;
            BtnEraseAll.Click += BtnEraseAll_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.None;
            txtDisplay.BackColor = SystemColors.ControlText;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.FromArgb(224, 224, 224);
            txtDisplay.Location = new Point(11, 85);
            txtDisplay.Margin = new Padding(1);
            txtDisplay.MaxLength = 14;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(290, 40);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.WordWrap = false;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            txtDisplay.KeyPress += txtDisplay_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1034;
            label1.Text = "Calculadora";
            // 
            // panel2
            // 
            panel2.ForeColor = SystemColors.ButtonFace;
            panel2.Location = new Point(7, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 464);
            panel2.TabIndex = 1023;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(326, 478);
            Controls.Add(panel2);
            Controls.Add(PaneSpecial);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.98D;
            Padding = new Padding(4);
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            PaneSpecial.ResumeLayout(false);
            PaneSpecial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneSpecial;
        private Label lb_historial;
        private Label label1;
        private RJboton btnEspecial;
        private RJboton btnCero;
        private RJboton BtnPoint;
        private RJboton BtnRest;
        private RJboton BtnPlus;
        private RJboton btnEquals;
        private RJboton BtnMult;
        private RJboton BtnDiv;
        private RJboton BtnEspecial2;
        private RJboton Erase;
        private RJboton BtnEraseAll;
        private TextBox txtDisplay;
        private Panel panel2;
    }
}
