namespace Proye_Nano
{
    partial class CrearProyecto
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
            label1 = new Label();
            label_NombreProyecto = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_Nombre = new TextBox();
            textBox_Descripcion = new TextBox();
            comboBox_Estado = new ComboBox();
            textBox_Compartir = new TextBox();
            Boton_Anadir = new Button();
            dateTimePicker_Inicio = new DateTimePicker();
            dateTimePicker_Final = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 36);
            label1.Name = "label1";
            label1.Size = new Size(323, 59);
            label1.TabIndex = 0;
            label1.Text = "Crear Proyecto";
            // 
            // label_NombreProyecto
            // 
            label_NombreProyecto.AutoSize = true;
            label_NombreProyecto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NombreProyecto.Location = new Point(80, 126);
            label_NombreProyecto.Name = "label_NombreProyecto";
            label_NombreProyecto.Size = new Size(116, 17);
            label_NombreProyecto.TabIndex = 1;
            label_NombreProyecto.Text = "Nombre Proyecto";
            label_NombreProyecto.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 201);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 2;
            label2.Text = "Descripción ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 285);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 3;
            label3.Text = "Estado";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 126);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 4;
            label4.Text = "Compartir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(465, 201);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 6;
            label5.Text = "Fecha Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(468, 285);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 7;
            label6.Text = "Fecha Fin";
            label6.Click += label6_Click;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(80, 154);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(269, 23);
            textBox_Nombre.TabIndex = 8;
            textBox_Nombre.TextChanged += textBox1_TextChanged;
            // 
            // textBox_Descripcion
            // 
            textBox_Descripcion.Location = new Point(80, 240);
            textBox_Descripcion.Name = "textBox_Descripcion";
            textBox_Descripcion.Size = new Size(269, 23);
            textBox_Descripcion.TabIndex = 9;
            textBox_Descripcion.TextChanged += textBox2_TextChanged;
            // 
            // comboBox_Estado
            // 
            comboBox_Estado.FormattingEnabled = true;
            comboBox_Estado.Location = new Point(80, 314);
            comboBox_Estado.Name = "comboBox_Estado";
            comboBox_Estado.Size = new Size(195, 23);
            comboBox_Estado.TabIndex = 10;
            comboBox_Estado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox_Compartir
            // 
            textBox_Compartir.Location = new Point(461, 153);
            textBox_Compartir.Name = "textBox_Compartir";
            textBox_Compartir.Size = new Size(192, 23);
            textBox_Compartir.TabIndex = 11;
            // 
            // Boton_Anadir
            // 
            Boton_Anadir.Location = new Point(668, 153);
            Boton_Anadir.Name = "Boton_Anadir";
            Boton_Anadir.Size = new Size(75, 23);
            Boton_Anadir.TabIndex = 12;
            Boton_Anadir.Text = "Añadir";
            Boton_Anadir.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Inicio
            // 
            dateTimePicker_Inicio.Location = new Point(468, 237);
            dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            dateTimePicker_Inicio.Size = new Size(248, 23);
            dateTimePicker_Inicio.TabIndex = 13;
            // 
            // dateTimePicker_Final
            // 
            dateTimePicker_Final.Location = new Point(468, 314);
            dateTimePicker_Final.Name = "dateTimePicker_Final";
            dateTimePicker_Final.Size = new Size(248, 23);
            dateTimePicker_Final.TabIndex = 14;
            // 
            // CrearProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker_Final);
            Controls.Add(dateTimePicker_Inicio);
            Controls.Add(Boton_Anadir);
            Controls.Add(textBox_Compartir);
            Controls.Add(comboBox_Estado);
            Controls.Add(textBox_Descripcion);
            Controls.Add(textBox_Nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_NombreProyecto);
            Controls.Add(label1);
            Name = "CrearProyecto";
            Text = "CrearProyecto";
            Load += CrearProyecto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_NombreProyecto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox_Nombre;
        private TextBox textBox_Descripcion;
        private ComboBox comboBox_Estado;
        private TextBox textBox_Compartir;
        private Button Boton_Anadir;
        private DateTimePicker dateTimePicker_Inicio;
        private DateTimePicker dateTimePicker_Final;
    }
}