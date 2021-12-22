using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BidirectionalCommunicationCasparCG
{
    public partial class FormPrincipal : Form
    {
        private readonly string fileName = "C:/CASPARCG Server/casparcg.exe";
        private readonly string fileDirectory = "C:/CASPARCG Server/";
        Process process;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_openCaspar_Click(object sender, EventArgs e)
        {
            this.process = new Process();

            this.process.StartInfo.FileName = this.fileName;
            this.process.StartInfo.WorkingDirectory = this.fileDirectory; // Importante en este caso que el directorio de trabajo del proceso que estamos creando sea el mismo donde está el ejecutable carparcg.exe
            this.process.StartInfo.UseShellExecute = false;
            this.process.StartInfo.RedirectStandardOutput = true;
            this.process.StartInfo.RedirectStandardInput = true;
            this.process.OutputDataReceived += (sender_, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                    Console.WriteLine("received output: {0}", args.Data);

                if (args.Data.Contains("**2**"))
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        string data = args.Data.Substring(args.Data.IndexOf("**2**") + 5);
                        this.label_data.Text = data + " €";
                    }
                        ));
                }
            };
            this.process.Start();
            this.process.BeginOutputReadLine();
        }

        private void button_loadTemplate_Click(object sender, EventArgs e)
        {
            // El signo ? a continuación del nombre de la variable hace que se ejecute el método de dicho objeto siempre que no sea nulo
            this.process?.StandardInput.WriteLine("CG 1-1 ADD 1 LINGO_ULTIMA_PALABRA_INCRUSTACION/index 0 ");
        }

        private void button_inGame_Click(object sender, EventArgs e)
        {
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_modo1_in('espantapajaros', 'espantapájaros', 'Cuando te lo pasas genial', '0,7,3,8,9,10,1,4,12', 1000, 500, 0)\"");
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_pista_in(1000)\"");
        }

        private void button_playGame_Click(object sender, EventArgs e)
        {
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_tiempo_init(10, 10, 0)\"");
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_tiempo_play(0)\"");
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_modo1_play(0)\"");
        }

        private static int timeCounter = 10;
        private void button_updateTime_Click(object sender, EventArgs e)
        {
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_tiempo_update(" + timeCounter-- + ", 0)\"");
        }

        private void button_solveGame_Click(object sender, EventArgs e)
        {
            this.process?.StandardInput.WriteLine("CG 1-1 INVOKE 1 \"lingo_ultima_palabra_incrustacion_respuesta_acierto(0)\"");
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.process?.Kill();
        }
    }
}
