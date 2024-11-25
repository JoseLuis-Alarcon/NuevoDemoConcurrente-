namespace DemoConcurrencia
{
    partial class FrmImpresora
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
            splitContainer1 = new SplitContainer();
            LblEstado = new Label();
            BtnDetener = new Button();
            BtnDoc2 = new Button();
            BtnDoc1 = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(LblEstado);
            splitContainer1.Panel1.Controls.Add(BtnDetener);
            splitContainer1.Panel1.Controls.Add(BtnDoc2);
            splitContainer1.Panel1.Controls.Add(BtnDoc1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(478, 230);
            splitContainer1.SplitterDistance = 158;
            splitContainer1.TabIndex = 0;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Location = new Point(24, 107);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(126, 15);
            LblEstado.TabIndex = 6;
            LblEstado.Text = "Estado de la impresión";
            // 
            // BtnDetener
            // 
            BtnDetener.BackColor = Color.White;
            BtnDetener.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            BtnDetener.ForeColor = Color.Black;
            BtnDetener.Location = new Point(23, 139);
            BtnDetener.Name = "BtnDetener";
            BtnDetener.Size = new Size(117, 32);
            BtnDetener.TabIndex = 5;
            BtnDetener.Text = "Detener";
            BtnDetener.UseVisualStyleBackColor = false;
            BtnDetener.Click += BtnDetener_Click;
            // 
            // BtnDoc2
            // 
            BtnDoc2.BackColor = Color.White;
            BtnDoc2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            BtnDoc2.ForeColor = Color.Black;
            BtnDoc2.Location = new Point(23, 58);
            BtnDoc2.Name = "BtnDoc2";
            BtnDoc2.Size = new Size(117, 32);
            BtnDoc2.TabIndex = 4;
            BtnDoc2.Text = "Imprimir Doc. 02";
            BtnDoc2.UseVisualStyleBackColor = false;
            BtnDoc2.Click += BtnDoc2_Click;
            // 
            // BtnDoc1
            // 
            BtnDoc1.AutoSize = true;
            BtnDoc1.BackColor = Color.White;
            BtnDoc1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            BtnDoc1.ForeColor = Color.Black;
            BtnDoc1.Location = new Point(23, 20);
            BtnDoc1.Name = "BtnDoc1";
            BtnDoc1.Size = new Size(117, 32);
            BtnDoc1.TabIndex = 3;
            BtnDoc1.Text = "Imprimir Doc. 01";
            BtnDoc1.UseVisualStyleBackColor = false;
            BtnDoc1.Click += BtnDoc1_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(316, 230);
            TxtResultado.TabIndex = 2;
            // 
            // FrmImpresora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 230);
            Controls.Add(splitContainer1);
            Name = "FrmImpresora";
            Text = "Gestión de Impresora";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
        private Label LblEstado;
        private Button BtnDetener;
        private Button BtnDoc2;
        private Button BtnDoc1;
    }
}