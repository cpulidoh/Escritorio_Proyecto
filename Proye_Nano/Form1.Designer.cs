namespace Proye_Nano
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
            button_Inicio_Sesion = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            linkRegistro = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button_Inicio_Sesion
            // 
            button_Inicio_Sesion.BackColor = Color.DeepSkyBlue;
            button_Inicio_Sesion.FlatStyle = FlatStyle.Flat;
            button_Inicio_Sesion.ForeColor = SystemColors.ButtonHighlight;
            button_Inicio_Sesion.Location = new Point(336, 355);
            button_Inicio_Sesion.Name = "button_Inicio_Sesion";
            button_Inicio_Sesion.Size = new Size(156, 41);
            button_Inicio_Sesion.TabIndex = 2;
            button_Inicio_Sesion.Text = "Iniciar Sesion";
            button_Inicio_Sesion.UseVisualStyleBackColor = false;
            button_Inicio_Sesion.Click += button_Inicio_Sesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Nano_Logo_removebg_preview;
            pictureBox1.Location = new Point(347, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 121);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 23);
            textBox2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Captura_de_pantalla_2025_10_20_190627;
            pictureBox2.Location = new Point(514, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Captura_de_pantalla_2025_10_20_190643;
            pictureBox3.Location = new Point(513, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(311, 320);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 9;
            label1.Text = "¿No tienes cuenta todavia?";
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(455, 320);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(59, 15);
            linkRegistro.TabIndex = 10;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Registrate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(300, 153);
            label2.Name = "label2";
            label2.Size = new Size(252, 54);
            label2.TabIndex = 11;
            label2.Text = "Inicia Sesion ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(linkRegistro);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button_Inicio_Sesion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Inicio_Sesion;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private LinkLabel linkRegistro;
        private Label label2;
    }
}
