namespace GUI_Step_motor_ESP32
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
            this.imagenoff = new System.Windows.Forms.PictureBox();
            this.imagenon = new System.Windows.Forms.PictureBox();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.imagenantihorario = new System.Windows.Forms.PictureBox();
            this.imagenhorario = new System.Windows.Forms.PictureBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRUN = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(119, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "André Raymundo Arévalo Acevedo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSTOP);
            this.groupBox2.Controls.Add(this.btnRUN);
            this.groupBox2.Controls.Add(this.imagenoff);
            this.groupBox2.Controls.Add(this.imagenon);
            this.groupBox2.Controls.Add(this.btnOFF);
            this.groupBox2.Controls.Add(this.btnON);
            this.groupBox2.Controls.Add(this.imagenantihorario);
            this.groupBox2.Controls.Add(this.imagenhorario);
            this.groupBox2.Controls.Add(this.circularProgressBar1);
            this.groupBox2.Location = new System.Drawing.Point(246, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

