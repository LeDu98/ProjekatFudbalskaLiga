﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private ServerKlasa server;

        public FrmServer()
        {
            InitializeComponent();
        }

        

        private void FrmServer_Load(object sender, EventArgs e)
        {
            
            btnZaustavi.Enabled = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                server = new ServerKlasa();
                server.Pokreni();
                Thread nit = new Thread(server.OsluskujMrezu);
                nit.IsBackground = true;
                nit.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                pictureBox1.Visible = true;
                label2.Visible = true;
            }
            catch (SocketException ex)
            {

                Console.WriteLine(ex);
                MessageBox.Show("Greska prilikom rada servera");
            }

        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.ZaustaviServer();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            pictureBox1.Visible = false;
            label2.Visible = false;

        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            
        }
    }
}
