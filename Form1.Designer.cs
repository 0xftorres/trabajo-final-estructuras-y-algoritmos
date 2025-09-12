

namespace tpfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            barra = new Panel();
            btnclose = new PictureBox();
            controles = new Panel();
            txtDist = new TextBox();
            trackBar1 = new TrackBar();
            textBox1 = new TextBox();
            panel6 = new Panel();
            btn_consulta3 = new Button();
            panel5 = new Panel();
            btn_consulta2 = new Button();
            panel3 = new Panel();
            btn_consulta1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            txtPregunta = new TextBox();
            panel4 = new Panel();
            btnNo = new Button();
            panel2 = new Panel();
            button1 = new Button();
            caras = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            caras.SuspendLayout();
            SuspendLayout();
            // 
            // barra
            // 
            barra.BackColor = Color.FromArgb(0, 80, 200);
            barra.Controls.Add(btnclose);
            barra.Dock = DockStyle.Top;
            barra.Location = new Point(0, 0);
            barra.Name = "barra";
            barra.Size = new Size(1166, 35);
            barra.TabIndex = 0;
            barra.MouseDown += barra_MouseDown;
            // 
            // btnclose
            // 
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.Location = new Point(1134, 6);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(25, 25);
            btnclose.SizeMode = PictureBoxSizeMode.Zoom;
            btnclose.TabIndex = 0;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // controles
            // 
            controles.BackColor = Color.FromArgb(26, 32, 40);
            controles.Controls.Add(txtDist);
            controles.Controls.Add(trackBar1);
            controles.Controls.Add(textBox1);
            controles.Controls.Add(panel6);
            controles.Controls.Add(btn_consulta3);
            controles.Controls.Add(panel5);
            controles.Controls.Add(btn_consulta2);
            controles.Controls.Add(panel3);
            controles.Controls.Add(btn_consulta1);
            controles.Controls.Add(panel1);
            controles.Controls.Add(button2);
            controles.Controls.Add(txtPregunta);
            controles.Controls.Add(panel4);
            controles.Controls.Add(btnNo);
            controles.Controls.Add(panel2);
            controles.Controls.Add(button1);
            controles.Dock = DockStyle.Left;
            controles.Location = new Point(0, 35);
            controles.Name = "controles";
            controles.Size = new Size(316, 617);
            controles.TabIndex = 4;
            // 
            // txtDist
            // 
            txtDist.BackColor = Color.FromArgb(26, 32, 40);
            txtDist.BorderStyle = BorderStyle.None;
            txtDist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDist.ForeColor = Color.White;
            txtDist.Location = new Point(25, 102);
            txtDist.Name = "txtDist";
            txtDist.ReadOnly = true;
            txtDist.Size = new Size(87, 22);
            txtDist.TabIndex = 22;
            txtDist.Text = "Distancia: 0";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(126, 102);
            trackBar1.Maximum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(164, 45);
            trackBar1.TabIndex = 21;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(24, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 29);
            textBox1.TabIndex = 20;
            textBox1.KeyPress += teclaPressed;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(113, 557);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 30);
            panel6.TabIndex = 19;
            // 
            // btn_consulta3
            // 
            btn_consulta3.BackColor = Color.FromArgb(26, 32, 40);
            btn_consulta3.FlatAppearance.BorderSize = 0;
            btn_consulta3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_consulta3.FlatStyle = FlatStyle.Flat;
            btn_consulta3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_consulta3.ForeColor = Color.White;
            btn_consulta3.Image = (Image)resources.GetObject("btn_consulta3.Image");
            btn_consulta3.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consulta3.Location = new Point(117, 557);
            btn_consulta3.Name = "btn_consulta3";
            btn_consulta3.Size = new Size(197, 30);
            btn_consulta3.TabIndex = 18;
            btn_consulta3.Text = "    Consulta 3 (Niveles)";
            btn_consulta3.UseVisualStyleBackColor = false;
            btn_consulta3.Click += btn_consulta3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(113, 495);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 30);
            panel5.TabIndex = 17;
            // 
            // btn_consulta2
            // 
            btn_consulta2.BackColor = Color.FromArgb(26, 32, 40);
            btn_consulta2.FlatAppearance.BorderSize = 0;
            btn_consulta2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_consulta2.FlatStyle = FlatStyle.Flat;
            btn_consulta2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_consulta2.ForeColor = Color.White;
            btn_consulta2.Image = (Image)resources.GetObject("btn_consulta2.Image");
            btn_consulta2.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consulta2.Location = new Point(117, 495);
            btn_consulta2.Name = "btn_consulta2";
            btn_consulta2.Size = new Size(197, 30);
            btn_consulta2.TabIndex = 16;
            btn_consulta2.Text = "      Consulta 2 (Caminos)";
            btn_consulta2.UseVisualStyleBackColor = false;
            btn_consulta2.Click += btn_consulta2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(113, 431);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 30);
            panel3.TabIndex = 15;
            // 
            // btn_consulta1
            // 
            btn_consulta1.BackColor = Color.FromArgb(26, 32, 40);
            btn_consulta1.FlatAppearance.BorderSize = 0;
            btn_consulta1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_consulta1.FlatStyle = FlatStyle.Flat;
            btn_consulta1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_consulta1.ForeColor = Color.White;
            btn_consulta1.Image = (Image)resources.GetObject("btn_consulta1.Image");
            btn_consulta1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_consulta1.Location = new Point(117, 431);
            btn_consulta1.Name = "btn_consulta1";
            btn_consulta1.Size = new Size(197, 30);
            btn_consulta1.TabIndex = 14;
            btn_consulta1.Text = "  Consulta 1 (Hojas)";
            btn_consulta1.UseVisualStyleBackColor = false;
            btn_consulta1.Click += btn_consulta1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(75, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 30);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(79, 373);
            button2.Name = "button2";
            button2.Size = new Size(197, 30);
            button2.TabIndex = 12;
            button2.Text = "Consultas";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtPregunta
            // 
            txtPregunta.BackColor = Color.FromArgb(26, 32, 40);
            txtPregunta.BorderStyle = BorderStyle.None;
            txtPregunta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPregunta.ForeColor = Color.White;
            txtPregunta.Location = new Point(24, 22);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.ReadOnly = true;
            txtPregunta.Size = new Size(264, 22);
            txtPregunta.TabIndex = 10;
            txtPregunta.Text = "Buscar:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(75, 249);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 30);
            panel4.TabIndex = 8;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(26, 32, 40);
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.ForeColor = Color.White;
            btnNo.Image = (Image)resources.GetObject("btnNo.Image");
            btnNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNo.Location = new Point(79, 249);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(197, 30);
            btnNo.TabIndex = 9;
            btnNo.Text = "Limpiar";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(75, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 30);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(79, 182);
            button1.Name = "button1";
            button1.Size = new Size(197, 30);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // caras
            // 
            caras.AutoScroll = true;
            caras.BackColor = Color.FromArgb(49, 66, 82);
            caras.Controls.Add(flowLayoutPanel1);
            caras.Dock = DockStyle.Fill;
            caras.Location = new Point(316, 35);
            caras.Name = "caras";
            caras.Size = new Size(850, 617);
            caras.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(850, 617);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 652);
            Controls.Add(caras);
            Controls.Add(controles);
            Controls.Add(barra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¿Quien es?";
            barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            controles.ResumeLayout(false);
            controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            caras.ResumeLayout(false);
            ResumeLayout(false);

        }



        #endregion

        private Panel barra;
        private PictureBox btnclose;
        private Panel controles;
        private TextBox txtPregunta;
        private Panel panel4;
        private Button btnNo;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Button btn_consulta1;
        private Panel panel6;
        private Button btn_consulta3;
        private Panel panel5;
        private Button btn_consulta2;
        private TextBox textBox1;
        private Panel caras;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDist;
        private TrackBar trackBar1;
    }
}