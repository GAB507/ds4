namespace Laboratorio13
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
            BtnConnection = new Button();
            lb_container = new ListBox();
            BtnDesplegar = new Button();
            SuspendLayout();
            // 
            // BtnConnection
            // 
            BtnConnection.Location = new Point(47, 26);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(150, 53);
            BtnConnection.TabIndex = 0;
            BtnConnection.Text = "conectar y desconectar de SQL Server";
            BtnConnection.UseVisualStyleBackColor = true;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // lb_container
            // 
            lb_container.FormattingEnabled = true;
            lb_container.ItemHeight = 15;
            lb_container.Items.AddRange(new object[] { " " });
            lb_container.Location = new Point(47, 111);
            lb_container.Name = "lb_container";
            lb_container.Size = new Size(500, 199);
            lb_container.TabIndex = 1;
            // 
            // BtnDesplegar
            // 
            BtnDesplegar.Location = new Point(330, 26);
            BtnDesplegar.Name = "BtnDesplegar";
            BtnDesplegar.Size = new Size(150, 53);
            BtnDesplegar.TabIndex = 2;
            BtnDesplegar.Text = "Desplegar Productos";
            BtnDesplegar.UseVisualStyleBackColor = true;
            BtnDesplegar.Click += BtnDesplegar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 356);
            Controls.Add(BtnDesplegar);
            Controls.Add(lb_container);
            Controls.Add(BtnConnection);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConnection;
        private ListBox lb_container;
        private Button BtnDesplegar;
    }
}
