namespace Proye_Nano
{
    partial class Servicios
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
            Logo = new PictureBox();
            Boton_CrearProyecto = new Button();
            Boton_GestionarProyecto = new Button();
            Boton_CerrarSesion = new Button();
            label_Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.nanoskillsnombre;
            Logo.Location = new Point(-1, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(150, 50);
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // Boton_CrearProyecto
            // 
            Boton_CrearProyecto.BackColor = SystemColors.MenuHighlight;
            Boton_CrearProyecto.ForeColor = SystemColors.HighlightText;
            Boton_CrearProyecto.Location = new Point(246, 122);
            Boton_CrearProyecto.Name = "Boton_CrearProyecto";
            Boton_CrearProyecto.Size = new Size(316, 60);
            Boton_CrearProyecto.TabIndex = 2;
            Boton_CrearProyecto.Text = "Crear Proyecto";
            Boton_CrearProyecto.UseVisualStyleBackColor = false;
            Boton_CrearProyecto.Click += Boton_CrearProyecto_Click;
            // 
            // Boton_GestionarProyecto
            // 
            Boton_GestionarProyecto.BackColor = SystemColors.MenuHighlight;
            Boton_GestionarProyecto.ForeColor = SystemColors.ButtonHighlight;
            Boton_GestionarProyecto.Location = new Point(246, 188);
            Boton_GestionarProyecto.Name = "Boton_GestionarProyecto";
            Boton_GestionarProyecto.Size = new Size(316, 60);
            Boton_GestionarProyecto.TabIndex = 4;
            Boton_GestionarProyecto.Text = "Gestionar Proyecto";
            Boton_GestionarProyecto.UseVisualStyleBackColor = false;
            // 
            // Boton_CerrarSesion
            // 
            Boton_CerrarSesion.BackColor = Color.Red;
            Boton_CerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            Boton_CerrarSesion.Location = new Point(246, 254);
            Boton_CerrarSesion.Name = "Boton_CerrarSesion";
            Boton_CerrarSesion.Size = new Size(316, 60);
            Boton_CerrarSesion.TabIndex = 5;
            Boton_CerrarSesion.Text = "Cerrar Sesión";
            Boton_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Titulo.Location = new Point(306, 29);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(204, 59);
            label_Titulo.TabIndex = 6;
            label_Titulo.Text = "Servicios";
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Titulo);
            Controls.Add(Boton_CerrarSesion);
            Controls.Add(Boton_GestionarProyecto);
            Controls.Add(Boton_CrearProyecto);
            Controls.Add(Logo);
            Name = "Servicios";
            Text = "Servicios";
            Load += Servicios_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Logo;
        private Button Boton_CrearProyecto;
        private Button Boton_GestionarProyecto;
        private Button Boton_CerrarSesion;
        private Label label_Titulo;
    }
}