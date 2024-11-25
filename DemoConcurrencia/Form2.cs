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
    public partial class FrmBloqueos : Form
    {
        private int Contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim Semaforo = new SemaphoreSlim(2);
        public FrmBloqueos()
        {
            InitializeComponent();
        }

        private void BtnIncrementar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Semaforo.Wait();

                lock (bloqueo)
                {
                    Contador++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContador.Text = Contador.ToString();
                    });
                    Monitor.Pulse(bloqueo);
                }
                Semaforo.Release();
            });
        }
        private void BtnDisminuir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (Contador  <= 0)
                    {
                        ActualizarResultado("Esperando...");
                        Monitor.Wait(bloqueo);
                    }
                    if (Contador > 0)
                    {
                        Contador--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            LblContador.Text = Contador.ToString();
                        });
                        Monitor.Pulse(bloqueo);
                    }
                    ActualizarResultado("Procesando...");
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
    }
}
