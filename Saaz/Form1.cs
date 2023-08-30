using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaz{
    public partial class Saaz : Form{
        static Boolean a = false, b = false, c = false, d = false, f = false;
        bool[] vec = new bool[] { a, b, c, d, f };
        System.IO.Ports.SerialPort ArduinoPort;
        public Saaz(){
            InitializeComponent();
            //Puerto
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM11";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
            // Eventos
            this.FormClosing += Saaz_FormClosing;
            this.btnOff1.Click += btnOff1_Click;
            this.btnOn1.Click += btnOn1_Click;
            this.btnOff2.Click += btnOff2_Click;
            this.btnOn2.Click += btnOn2_Click;
            this.btnOff3.Click += btnOff3_Click;
            this.btnOn3.Click += btnOn3_Click;
            this.btnOff4.Click += btnOff4_Click;
            this.btnOn4.Click += btnOn4_Click;
            this.btnOff5.Click += btnOff5_Click;
            this.btnOn5.Click += btnOn5_Click;
            this.btnOffAll.Click += btnOffAll_Click;
        }
        private void Saaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
        private void Saaz_Load(object sender, EventArgs e)
        {
            Maqueta mq = new Maqueta();
            mq.Location = new Point(650, 107);
            this.Location = new Point(100, 107);
            mq.Show();

            a = vec[0];
            b = vec[1];
            c = vec[2];
            d = vec[3];
            f = vec[4];

            if (a == false || b == false || c == false || d == false || f == false)
            {
                //a
                btnOff1.Enabled = false;
                btnOn1.Enabled = true;
                btnOff1.Visible = false;
                btnOn1.Visible = true;

                PbOff1.Visible = true;
                PbOn1.Visible = false;

                //b
                btnOff4.Enabled = false;
                btnOn4.Enabled = true;
                btnOff4.Visible = false;
                btnOn4.Visible = true;
                PbOff4.Visible = true;
                PbOn4.Visible = false;

                //c
                btnOff2.Enabled = false;
                btnOn2.Enabled = true;
                btnOff2.Visible = false;
                btnOn2.Visible = true;

                PbOff2.Visible = true;
                PbOn2.Visible = false;

                //d
                btnOff5.Enabled = false;
                btnOn5.Enabled = true;
                btnOff5.Visible = false;
                btnOn5.Visible = true;

                PbOff5.Visible = true;
                PbOn5.Visible = false;

                //f
                btnOff3.Enabled = false;
                btnOn3.Enabled = true;
                btnOff3.Visible = false;
                btnOn3.Visible = true;

                PbOff3.Visible = true;
                PbOn3.Visible = false;

                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }//fin if
        }

        private void btnOn1_Click(object sender, EventArgs e){
            ArduinoPort.Write("a");
            a = true;
            btnOn1.Enabled = false;
            btnOff1.Enabled = true;
            btnOn1.Visible = false;
            btnOff1.Visible = true;

            PbOff1.Visible = false;
            PbOn1.Visible = true;
            vec[0] = a;
        }

        private void btnOff1_Click(object sender, EventArgs e){
            ArduinoPort.Write("b");
            a = false;
            btnOn1.Visible = true;
            btnOff1.Visible = false;
            btnOn1.Enabled = true;
            btnOff1.Enabled = false;

            PbOff1.Visible = true;
            PbOn1.Visible = false;

            if (PbOnAll.Visible == true){
                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }
            vec[0] = a;
        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("f");
            b = false;
            btnOn2.Visible = true;
            btnOff2.Visible = false;
            btnOn2.Enabled = true;
            btnOff2.Enabled = false;

            PbOff2.Visible = true;
            PbOn2.Visible = false;

            if (PbOnAll.Visible == true)
            {

                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }
            vec[0] = b;
        }

        private void btnOn2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("e");
            b = true;
            btnOn2.Enabled = false;
            btnOff2.Enabled = true;
            btnOn2.Visible = false;
            btnOff2.Visible = true;
            PbOff2.Visible = false;
            PbOn2.Visible = true;
            vec[0] = b;
        }

        private void btnOn3_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("i");
            c = true;
            btnOn3.Enabled = false;
            btnOff3.Enabled = true;
            btnOn3.Visible = false;
            btnOff3.Visible = true;

            PbOff3.Visible = false;
            PbOn3.Visible = true;
            vec[0] = c;
        }

        private void btnOff3_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("j");
            c = false;
            btnOn3.Visible = true;
            btnOff3.Visible = false;
            btnOn3.Enabled = true;
            btnOff3.Enabled = false;

            PbOff3.Visible = true;
            PbOn3.Visible = false;

            if (PbOnAll.Visible == true)
            {

                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }
            vec[0] = c;
        }

        private void btnOn4_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("c");
            d = true;
            btnOn4.Enabled = false;
            btnOff4.Enabled = true;
            btnOn4.Visible = false;
            btnOff4.Visible = true;

            PbOff4.Visible = false;
            PbOn4.Visible = true;
            vec[0] = d;
        }

        private void btnOff4_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("d");
            d = false;
            btnOn4.Visible = true;
            btnOff4.Visible = false;
            btnOn4.Enabled = true;
            btnOff4.Enabled = false;

            PbOff4.Visible = true;
            PbOn4.Visible = false;

            if (PbOnAll.Visible == true)
            {
                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }
            vec[0] = d;
        }

        private void btnOn5_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("g");
            f = true;
            btnOn5.Enabled = false;
            btnOff5.Enabled = true;
            btnOn5.Visible = false;
            btnOff5.Visible = true;

            PbOff5.Visible = false;
            PbOn5.Visible = true;
            vec[0] = f;
        }

        private void btnOff5_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("h");
            f = false;
            btnOn5.Visible = true;
            btnOff5.Visible = false;
            btnOn5.Enabled = true;
            btnOff5.Enabled = false;

            PbOff5.Visible = true;
            PbOn5.Visible = false;

            if (PbOnAll.Visible == true)
            {

                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
            }
            vec[0] = f;
        }

        private void btnOffAll_Click(object sender, EventArgs e)
        {
            if (vec[0] == false && vec[1] == false && vec[2] == false && vec[3] == false && vec[4] == false)
            {
                DialogResult res = MessageBox.Show("Lo sentimos no hay nada que apagar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PbOffAll.Visible = true;
                PbOnAll.Visible = false;
                do
                {
                    if (vec[0] == true || vec[1] == true || vec[2] == true || vec[3] == true || vec[4] == true)
                    {
                        //1
                        ArduinoPort.Write("b");
                        a = false;
                        btnOn1.Visible = true;
                        btnOff1.Visible = false;
                        btnOn1.Enabled = true;
                        btnOff1.Enabled = false;

                        PbOff1.Visible = true;
                        PbOn1.Visible = false;
                        vec[0] = a;

                        //2
                        ArduinoPort.Write("d");
                        b = false;
                        btnOn2.Enabled = true;
                        btnOff2.Enabled = false;
                        btnOn2.Visible = true;
                        btnOff2.Visible = false;

                        PbOff2.Visible = true;
                        PbOn2.Visible = false;
                        vec[1] = b;

                        //3
                        ArduinoPort.Write("f");
                        c = false;
                        btnOn3.Enabled = true;
                        btnOff3.Enabled = false;
                        btnOn3.Visible = true;
                        btnOff3.Visible = false;

                        PbOff3.Visible = true;
                        PbOn3.Visible = false;
                        vec[2] = c;

                        //4
                        ArduinoPort.Write("h");
                        d = false;
                        btnOn4.Enabled = true;
                        btnOff4.Enabled = false;
                        btnOn4.Visible = true;
                        btnOff4.Visible = false;

                        PbOff4.Visible = true;
                        PbOn4.Visible = false;
                        vec[3] = d;
                        //5
                        ArduinoPort.Write("j");
                        f = false;
                        btnOn5.Enabled = true;
                        btnOff5.Enabled = false;
                        btnOn5.Visible = true;
                        btnOff5.Visible = false;

                        PbOff5.Visible = true;
                        PbOn5.Visible = false;
                        vec[4] = f;
                    }
                    else if (vec[0] == false || vec[1] == false || vec[2] == false || vec[3] == false || vec[4] == false) { }
                } while (a == true || b == true || c == true || d == true || f == true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Realmente desea salir ?\nSi cierra la aplicación se apagarán todas las luces", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                ArduinoPort.Write("h"+"d"+"j"+"f"+"b");
                if (ArduinoPort.IsOpen) ArduinoPort.Close();
                Application.Exit();
                
            }else { }
        }
    }
}