using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmImpresora : Form
    {
        private object bloqueo = new();
        private SemaphoreSlim Semaforo = new SemaphoreSlim(2);
        private bool impresoraOcupada = false;
        private bool detenerImpresion = false;

        public FrmImpresora()
        {
            InitializeComponent();
        }
        private void ImprimirDocumento(string documento)
        {
            lock (bloqueo)
            {
                impresoraOcupada = true;
                ActualizarResultado($"Iniciando impresión de Documento {documento}...");
                for (int i = 0; i < 5; i++)
                {
                    if (detenerImpresion) 
                    {
                        ActualizarResultado("Impresión detenida.");
                        break;
                    }
                    Thread.Sleep(1000);
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblEstado.Text = $"Imprimiendo página {i + 1} de Documento {documento}";
                    });
                }
                if (!detenerImpresion)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblEstado.Text = $"Documento {documento} impreso";
                    });
                }

                impresoraOcupada = false;
                Monitor.Pulse(bloqueo);
            }
        }


        // Botón para imprimir Documento 1
        private void BtnDoc1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Semaforo.Wait(); 
                try
                {
                    lock (bloqueo)
                    {
                        while (impresoraOcupada)
                        {
                            ActualizarResultado("Esperando que la impresora esté disponible...");
                            Monitor.Wait(bloqueo);
                        }
                        ImprimirDocumento("1");
                    }
                }
                finally
                {
                    Semaforo.Release();
                }
            });
        }
        // Botón para imprimir Documento 2
        private void BtnDoc2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Semaforo.Wait();
                try
                {
                    lock (bloqueo)
                    {
                        while (impresoraOcupada)
                        {
                            ActualizarResultado("Esperando que la impresora esté disponible...");
                            Monitor.Wait(bloqueo);
                        }
                        ImprimirDocumento("2");
                    }
                }
                finally
                {
                    Semaforo.Release();
                }
            });
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje} {Environment.NewLine}");
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            detenerImpresion = true;
            ActualizarResultado("Cancelando impresión...");
        }
    }
}

       
   

