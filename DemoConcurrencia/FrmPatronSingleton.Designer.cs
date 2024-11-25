namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            BtnAsignar = new Button();
            BtnRecuperar = new Button();
            LblCadenaConexion = new Label();
            TxtCadenadeConexion = new TextBox();
            LblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // BtnAsignar
            // 
            BtnAsignar.Location = new Point(12, 85);
            BtnAsignar.Name = "BtnAsignar";
            BtnAsignar.Size = new Size(131, 43);
            BtnAsignar.TabIndex = 0;
            BtnAsignar.Text = "Asignar cadena de conexión";
            BtnAsignar.UseVisualStyleBackColor = true;
            BtnAsignar.Click += BtnAsignar_Click;
            // 
            // BtnRecuperar
            // 
            BtnRecuperar.Location = new Point(12, 152);
            BtnRecuperar.Name = "BtnRecuperar";
            BtnRecuperar.Size = new Size(131, 43);
            BtnRecuperar.TabIndex = 1;
            BtnRecuperar.Text = "Obtener cadena de conexión";
            BtnRecuperar.UseVisualStyleBackColor = true;
            BtnRecuperar.Click += BtnRecuperar_Click;
            // 
            // LblCadenaConexion
            // 
            LblCadenaConexion.AutoSize = true;
            LblCadenaConexion.Location = new Point(12, 9);
            LblCadenaConexion.Name = "LblCadenaConexion";
            LblCadenaConexion.Size = new Size(115, 15);
            LblCadenaConexion.TabIndex = 2;
            LblCadenaConexion.Text = "Cadena de conexión";
            // 
            // TxtCadenadeConexion
            // 
            TxtCadenadeConexion.Location = new Point(12, 36);
            TxtCadenadeConexion.Name = "TxtCadenadeConexion";
            TxtCadenadeConexion.Size = new Size(567, 23);
            TxtCadenadeConexion.TabIndex = 3;
            // 
            // LblCadenaConexionRecuperada
            // 
            LblCadenaConexionRecuperada.AutoSize = true;
            LblCadenaConexionRecuperada.Location = new Point(175, 166);
            LblCadenaConexionRecuperada.Name = "LblCadenaConexionRecuperada";
            LblCadenaConexionRecuperada.Size = new Size(0, 15);
            LblCadenaConexionRecuperada.TabIndex = 4;
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 235);
            Controls.Add(LblCadenaConexionRecuperada);
            Controls.Add(TxtCadenadeConexion);
            Controls.Add(LblCadenaConexion);
            Controls.Add(BtnRecuperar);
            Controls.Add(BtnAsignar);
            Name = "FrmPatronSingleton";
            Text = "FrmPatronSingleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAsignar;
        private Button BtnRecuperar;
        private Label LblCadenaConexion;
        private TextBox TxtCadenadeConexion;
        private Label LblCadenaConexionRecuperada;
    }
}