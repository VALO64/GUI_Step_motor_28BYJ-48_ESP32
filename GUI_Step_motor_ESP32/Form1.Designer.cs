﻿namespace GUI_Step_motor_ESP32
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudshow = new System.Windows.Forms.ComboBox();
            this.comshow = new System.Windows.Forms.ComboBox();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnmenos360 = new System.Windows.Forms.Button();
            this.btnmenos180 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn360 = new System.Windows.Forms.Button();
            this.btn180 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarRPM = new System.Windows.Forms.TrackBar();
            this.btnCOUNTERCLOCKWISE = new System.Windows.Forms.Button();
            this.btnCLOCKWISE = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.btnRUN = new System.Windows.Forms.Button();
            this.imagenoff = new System.Windows.Forms.PictureBox();
            this.imagenon = new System.Windows.Forms.PictureBox();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.imagenantihorario = new System.Windows.Forms.PictureBox();
            this.imagenhorario = new System.Windows.Forms.PictureBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenantihorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenhorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baudshow);
            this.groupBox1.Controls.Add(this.comshow);
            this.groupBox1.Controls.Add(this.Desconectar);
            this.groupBox1.Controls.Add(this.Conectar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puerto:";
            // 
            // baudshow
            // 
            this.baudshow.FormattingEnabled = true;
            this.baudshow.Location = new System.Drawing.Point(25, 117);
            this.baudshow.Name = "baudshow";
            this.baudshow.Size = new System.Drawing.Size(149, 27);
            this.baudshow.TabIndex = 3;
            // 
            // comshow
            // 
            this.comshow.FormattingEnabled = true;
            this.comshow.Location = new System.Drawing.Point(25, 57);
            this.comshow.Name = "comshow";
            this.comshow.Size = new System.Drawing.Size(149, 27);
            this.comshow.TabIndex = 2;
            // 
            // Desconectar
            // 
            this.Desconectar.BackColor = System.Drawing.Color.DarkRed;
            this.Desconectar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Desconectar.Location = new System.Drawing.Point(25, 206);
            this.Desconectar.Margin = new System.Windows.Forms.Padding(0);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(149, 28);
            this.Desconectar.TabIndex = 1;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Desconectar.UseVisualStyleBackColor = false;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Conectar
            // 
            this.Conectar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Conectar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.Conectar.ForeColor = System.Drawing.Color.Transparent;
            this.Conectar.Location = new System.Drawing.Point(25, 172);
            this.Conectar.Margin = new System.Windows.Forms.Padding(0);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(149, 28);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(119, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Oscar Alberto Valles Limas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(119, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "André Raymundo Arévalo Acevedo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnmenos360);
            this.groupBox2.Controls.Add(this.btnmenos180);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn360);
            this.groupBox2.Controls.Add(this.btn180);
            this.groupBox2.Controls.Add(this.btn90);
            this.groupBox2.Controls.Add(this.btn45);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trackBarRPM);
            this.groupBox2.Controls.Add(this.btnCOUNTERCLOCKWISE);
            this.groupBox2.Controls.Add(this.btnCLOCKWISE);
            this.groupBox2.Controls.Add(this.btnSTOP);
            this.groupBox2.Controls.Add(this.btnRUN);
            this.groupBox2.Controls.Add(this.imagenoff);
            this.groupBox2.Controls.Add(this.imagenon);
            this.groupBox2.Controls.Add(this.btnOFF);
            this.groupBox2.Controls.Add(this.btnON);
            this.groupBox2.Controls.Add(this.imagenantihorario);
            this.groupBox2.Controls.Add(this.imagenhorario);
            this.groupBox2.Controls.Add(this.circularProgressBar1);
            this.groupBox2.Location = new System.Drawing.Point(234, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 347);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnmenos360
            // 
            this.btnmenos360.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnmenos360.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos360.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnmenos360.Location = new System.Drawing.Point(537, 299);
            this.btnmenos360.Name = "btnmenos360";
            this.btnmenos360.Size = new System.Drawing.Size(88, 23);
            this.btnmenos360.TabIndex = 23;
            this.btnmenos360.Text = "-360°";
            this.btnmenos360.UseVisualStyleBackColor = false;
            this.btnmenos360.Click += new System.EventHandler(this.btnmenos360_Click);
            // 
            // btnmenos180
            // 
            this.btnmenos180.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnmenos180.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos180.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnmenos180.Location = new System.Drawing.Point(537, 270);
            this.btnmenos180.Name = "btnmenos180";
            this.btnmenos180.Size = new System.Drawing.Size(88, 23);
            this.btnmenos180.TabIndex = 22;
            this.btnmenos180.Text = "-180°";
            this.btnmenos180.UseVisualStyleBackColor = false;
            this.btnmenos180.Click += new System.EventHandler(this.btnmenos180_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(537, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "-90°";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(537, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "-45°";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn360
            // 
            this.btn360.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn360.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn360.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn360.Location = new System.Drawing.Point(537, 157);
            this.btn360.Name = "btn360";
            this.btn360.Size = new System.Drawing.Size(88, 23);
            this.btn360.TabIndex = 19;
            this.btn360.Text = "360°";
            this.btn360.UseVisualStyleBackColor = false;
            this.btn360.Click += new System.EventHandler(this.btn360_Click);
            // 
            // btn180
            // 
            this.btn180.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn180.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn180.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn180.Location = new System.Drawing.Point(537, 128);
            this.btn180.Name = "btn180";
            this.btn180.Size = new System.Drawing.Size(88, 23);
            this.btn180.TabIndex = 19;
            this.btn180.Text = "180°";
            this.btn180.UseVisualStyleBackColor = false;
            this.btn180.Click += new System.EventHandler(this.btn180_Click);
            // 
            // btn90
            // 
            this.btn90.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn90.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn90.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn90.Location = new System.Drawing.Point(537, 99);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(88, 23);
            this.btn90.TabIndex = 18;
            this.btn90.Text = "90°";
            this.btn90.UseVisualStyleBackColor = false;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btn45
            // 
            this.btn45.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn45.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn45.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn45.Location = new System.Drawing.Point(537, 70);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(88, 23);
            this.btn45.TabIndex = 17;
            this.btn45.Text = "45°";
            this.btn45.UseVisualStyleBackColor = false;
            this.btn45.Click += new System.EventHandler(this.btn45_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(522, 38);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grados positivos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(522, 189);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grados negativos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(287, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "RPM Control";
            // 
            // trackBarRPM
            // 
            this.trackBarRPM.Location = new System.Drawing.Point(218, 296);
            this.trackBarRPM.Minimum = 3;
            this.trackBarRPM.Name = "trackBarRPM";
            this.trackBarRPM.Size = new System.Drawing.Size(236, 45);
            this.trackBarRPM.TabIndex = 11;
            this.trackBarRPM.Value = 10;
            this.trackBarRPM.Scroll += new System.EventHandler(this.trackBarRPM_Scroll);
            // 
            // btnCOUNTERCLOCKWISE
            // 
            this.btnCOUNTERCLOCKWISE.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCOUNTERCLOCKWISE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOUNTERCLOCKWISE.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCOUNTERCLOCKWISE.Location = new System.Drawing.Point(312, 238);
            this.btnCOUNTERCLOCKWISE.Name = "btnCOUNTERCLOCKWISE";
            this.btnCOUNTERCLOCKWISE.Size = new System.Drawing.Size(142, 23);
            this.btnCOUNTERCLOCKWISE.TabIndex = 10;
            this.btnCOUNTERCLOCKWISE.Text = "COUNTERCLOCKWISE";
            this.btnCOUNTERCLOCKWISE.UseVisualStyleBackColor = false;
            this.btnCOUNTERCLOCKWISE.Click += new System.EventHandler(this.btnCOUNTERCLOCKWISE_Click);
            // 
            // btnCLOCKWISE
            // 
            this.btnCLOCKWISE.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCLOCKWISE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOCKWISE.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCLOCKWISE.Location = new System.Drawing.Point(218, 238);
            this.btnCLOCKWISE.Name = "btnCLOCKWISE";
            this.btnCLOCKWISE.Size = new System.Drawing.Size(88, 23);
            this.btnCLOCKWISE.TabIndex = 9;
            this.btnCLOCKWISE.Text = "CLOCKWISE";
            this.btnCLOCKWISE.UseVisualStyleBackColor = false;
            this.btnCLOCKWISE.Click += new System.EventHandler(this.btnCLOCKWISE_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.BackColor = System.Drawing.Color.Crimson;
            this.btnSTOP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSTOP.Location = new System.Drawing.Point(118, 270);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSTOP.Size = new System.Drawing.Size(75, 23);
            this.btnSTOP.TabIndex = 8;
            this.btnSTOP.Text = "STOP";
            this.btnSTOP.UseVisualStyleBackColor = false;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // btnRUN
            // 
            this.btnRUN.BackColor = System.Drawing.Color.Teal;
            this.btnRUN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRUN.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRUN.Location = new System.Drawing.Point(119, 239);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(75, 23);
            this.btnRUN.TabIndex = 7;
            this.btnRUN.Text = "RUN";
            this.btnRUN.UseVisualStyleBackColor = false;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // imagenoff
            // 
            this.imagenoff.Image = ((System.Drawing.Image)(resources.GetObject("imagenoff.Image")));
            this.imagenoff.Location = new System.Drawing.Point(381, 67);
            this.imagenoff.Name = "imagenoff";
            this.imagenoff.Size = new System.Drawing.Size(115, 115);
            this.imagenoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenoff.TabIndex = 6;
            this.imagenoff.TabStop = false;
            this.imagenoff.Visible = false;
            // 
            // imagenon
            // 
            this.imagenon.Image = ((System.Drawing.Image)(resources.GetObject("imagenon.Image")));
            this.imagenon.Location = new System.Drawing.Point(381, 67);
            this.imagenon.Name = "imagenon";
            this.imagenon.Size = new System.Drawing.Size(115, 115);
            this.imagenon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenon.TabIndex = 5;
            this.imagenon.TabStop = false;
            this.imagenon.Visible = false;
            // 
            // btnOFF
            // 
            this.btnOFF.BackColor = System.Drawing.Color.DarkRed;
            this.btnOFF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOFF.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOFF.Location = new System.Drawing.Point(23, 269);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(75, 23);
            this.btnOFF.TabIndex = 4;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            // 
            // btnON
            // 
            this.btnON.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnON.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnON.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnON.Location = new System.Drawing.Point(23, 239);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 23);
            this.btnON.TabIndex = 3;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // imagenantihorario
            // 
            this.imagenantihorario.Image = ((System.Drawing.Image)(resources.GetObject("imagenantihorario.Image")));
            this.imagenantihorario.Location = new System.Drawing.Point(218, 54);
            this.imagenantihorario.Name = "imagenantihorario";
            this.imagenantihorario.Size = new System.Drawing.Size(144, 141);
            this.imagenantihorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenantihorario.TabIndex = 2;
            this.imagenantihorario.TabStop = false;
            this.imagenantihorario.Visible = false;
            // 
            // imagenhorario
            // 
            this.imagenhorario.Image = ((System.Drawing.Image)(resources.GetObject("imagenhorario.Image")));
            this.imagenhorario.Location = new System.Drawing.Point(199, 45);
            this.imagenhorario.Name = "imagenhorario";
            this.imagenhorario.Size = new System.Drawing.Size(167, 155);
            this.imagenhorario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenhorario.TabIndex = 1;
            this.imagenhorario.TabStop = false;
            this.imagenhorario.Visible = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(23, 32);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 10;
            this.circularProgressBar1.Minimum = 3;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.ControlDarkDark;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(170, 170);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "RPM";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(119, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raul Alejandro Rodriguez Morales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(950, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenantihorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenhorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.ComboBox baudshow;
        private System.Windows.Forms.ComboBox comshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagenantihorario;
        private System.Windows.Forms.PictureBox imagenhorario;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.PictureBox imagenon;
        private System.Windows.Forms.PictureBox imagenoff;
        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnCOUNTERCLOCKWISE;
        private System.Windows.Forms.Button btnCLOCKWISE;
        private System.Windows.Forms.TrackBar trackBarRPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn360;
        private System.Windows.Forms.Button btn180;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btnmenos180;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmenos360;
        private System.Windows.Forms.Label label8;
    }
}

