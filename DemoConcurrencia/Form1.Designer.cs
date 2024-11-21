namespace DemoConcurrencia
{
    partial class FrmConcurrencia
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
            BtnSecuencial = new Button();
            BtnIniciarHilos = new Button();
            BtnIniciarTarea = new Button();
            splitContainer1 = new SplitContainer();
            BtnCancelarProceso = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSecuencial
            // 
            BtnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSecuencial.BackColor = SystemColors.ActiveCaption;
            BtnSecuencial.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnSecuencial.Location = new Point(59, 51);
            BtnSecuencial.Name = "BtnSecuencial";
            BtnSecuencial.Size = new Size(137, 37);
            BtnSecuencial.TabIndex = 0;
            BtnSecuencial.Text = "Iniciar Secuencial ";
            BtnSecuencial.UseVisualStyleBackColor = false;
            BtnSecuencial.Click += BtnSecuencial_Click;
            // 
            // BtnIniciarHilos
            // 
            BtnIniciarHilos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilos.BackColor = Color.Gray;
            BtnIniciarHilos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnIniciarHilos.Location = new Point(59, 110);
            BtnIniciarHilos.Name = "BtnIniciarHilos";
            BtnIniciarHilos.Size = new Size(137, 34);
            BtnIniciarHilos.TabIndex = 1;
            BtnIniciarHilos.Text = "Iniciar Hilo";
            BtnIniciarHilos.UseVisualStyleBackColor = false;
            BtnIniciarHilos.Click += BtnIniciarHilos_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.BackColor = Color.FromArgb(0, 192, 0);
            BtnIniciarTarea.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnIniciarTarea.Location = new Point(59, 177);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(137, 34);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = false;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarProceso);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnSecuencial);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(776, 413);
            splitContainer1.SplitterDistance = 258;
            splitContainer1.TabIndex = 2;
            // 
            // BtnCancelarProceso
            // 
            BtnCancelarProceso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnCancelarProceso.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelarProceso.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            BtnCancelarProceso.ForeColor = Color.White;
            BtnCancelarProceso.Location = new Point(59, 280);
            BtnCancelarProceso.Name = "BtnCancelarProceso";
            BtnCancelarProceso.Size = new Size(137, 37);
            BtnCancelarProceso.TabIndex = 3;
            BtnCancelarProceso.Text = "Cancelar Proceso";
            BtnCancelarProceso.UseVisualStyleBackColor = false;
            BtnCancelarProceso.Click += BtnCancelarProceso_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(514, 413);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 438);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desmostración de Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSecuencial;
        private Button BtnIniciarHilos;
        private Button BtnIniciarTarea;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
        private Button BtnCancelarProceso;
    }
}
