namespace DemoConcurrencia
{
    partial class FrmBloqueos
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
            LblContador = new Label();
            BtnIncrementar = new Button();
            BtnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.BackColor = Color.Transparent;
            LblContador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblContador.ForeColor = Color.Black;
            LblContador.Location = new Point(64, 173);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(23, 25);
            LblContador.TabIndex = 0;
            LblContador.Text = "0";
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.AutoSize = true;
            BtnIncrementar.BackColor = Color.Green;
            BtnIncrementar.FlatStyle = FlatStyle.Flat;
            BtnIncrementar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            BtnIncrementar.ForeColor = Color.White;
            BtnIncrementar.Location = new Point(13, 13);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(117, 32);
            BtnIncrementar.TabIndex = 1;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = false;
            BtnIncrementar.Click += BtnIncrementar_Click;
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.BackColor = Color.Red;
            BtnDisminuir.FlatStyle = FlatStyle.Flat;
            BtnDisminuir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            BtnDisminuir.ForeColor = Color.White;
            BtnDisminuir.Location = new Point(13, 62);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(117, 32);
            BtnDisminuir.TabIndex = 2;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = false;
            BtnDisminuir.Click += BtnDisminuir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnDisminuir);
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(539, 224);
            splitContainer1.SplitterDistance = 145;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(390, 224);
            TxtResultado.TabIndex = 1;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(539, 224);
            Controls.Add(splitContainer1);
            Name = "FrmBloqueos";
            Text = "Gestión de bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LblContador;
        private Button BtnIncrementar;
        private Button BtnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}