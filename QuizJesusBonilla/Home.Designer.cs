
namespace QuizJesusBonilla
{
    partial class Home
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lstClase = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.radGeneroH = new System.Windows.Forms.RadioButton();
            this.radGeneroM = new System.Windows.Forms.RadioButton();
            this.chePasaje = new System.Windows.Forms.CheckBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.radGeneroO = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPasaje = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(220, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese los datos de su pasaje en avion";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(155, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del pasajero";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(42, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(39, 168);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(164, 20);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Seleccione su destino";
            this.lblDestino.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(43, 191);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(181, 21);
            this.cmbDestino.TabIndex = 4;
            // 
            // lstClase
            // 
            this.lstClase.FormattingEnabled = true;
            this.lstClase.Items.AddRange(new object[] {
            "",
            "Clase Economica",
            "Clase Intermedia",
            "Clase Ejecutiva",
            "Primera clase"});
            this.lstClase.Location = new System.Drawing.Point(43, 250);
            this.lstClase.Name = "lstClase";
            this.lstClase.Size = new System.Drawing.Size(120, 56);
            this.lstClase.TabIndex = 5;
            this.lstClase.SelectedIndexChanged += new System.EventHandler(this.lstAparatos_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(468, 64);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 20);
            this.numEdad.TabIndex = 7;
            this.numEdad.ValueChanged += new System.EventHandler(this.numEdad_ValueChanged);
            // 
            // radGeneroH
            // 
            this.radGeneroH.AutoSize = true;
            this.radGeneroH.Location = new System.Drawing.Point(42, 130);
            this.radGeneroH.Name = "radGeneroH";
            this.radGeneroH.Size = new System.Drawing.Size(62, 17);
            this.radGeneroH.TabIndex = 8;
            this.radGeneroH.TabStop = true;
            this.radGeneroH.Text = "Hombre";
            this.radGeneroH.UseVisualStyleBackColor = true;
            // 
            // radGeneroM
            // 
            this.radGeneroM.AutoSize = true;
            this.radGeneroM.Location = new System.Drawing.Point(132, 130);
            this.radGeneroM.Name = "radGeneroM";
            this.radGeneroM.Size = new System.Drawing.Size(51, 17);
            this.radGeneroM.TabIndex = 9;
            this.radGeneroM.TabStop = true;
            this.radGeneroM.Text = "Mujer";
            this.radGeneroM.UseVisualStyleBackColor = true;
            // 
            // chePasaje
            // 
            this.chePasaje.AutoSize = true;
            this.chePasaje.Location = new System.Drawing.Point(484, 206);
            this.chePasaje.Name = "chePasaje";
            this.chePasaje.Size = new System.Drawing.Size(129, 17);
            this.chePasaje.TabIndex = 10;
            this.chePasaje.Text = "pasaje de ida y vuelta";
            this.chePasaje.UseVisualStyleBackColor = true;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Location = new System.Drawing.Point(36, 227);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(214, 20);
            this.lblClase.TabIndex = 11;
            this.lblClase.Text = "Selecione su clase de pasaje";
            // 
            // radGeneroO
            // 
            this.radGeneroO.AutoSize = true;
            this.radGeneroO.Location = new System.Drawing.Point(205, 130);
            this.radGeneroO.Name = "radGeneroO";
            this.radGeneroO.Size = new System.Drawing.Size(45, 17);
            this.radGeneroO.TabIndex = 12;
            this.radGeneroO.TabStop = true;
            this.radGeneroO.Text = "Otro";
            this.radGeneroO.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(39, 91);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(154, 20);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Selecione su genero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(464, 41);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(140, 20);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Selecione su edad";
            // 
            // lblPasaje
            // 
            this.lblPasaje.AutoSize = true;
            this.lblPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaje.Location = new System.Drawing.Point(387, 171);
            this.lblPasaje.Name = "lblPasaje";
            this.lblPasaje.Size = new System.Drawing.Size(363, 15);
            this.lblPasaje.TabIndex = 15;
            this.lblPasaje.Text = "En caso de que su pasaje sea de ida y vuelta marque esta opcion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(464, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 20);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "fecha del viaje";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPasaje);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.radGeneroO);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.chePasaje);
            this.Controls.Add(this.radGeneroM);
            this.Controls.Add(this.radGeneroH);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstClase);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ListBox lstClase;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.RadioButton radGeneroH;
        private System.Windows.Forms.RadioButton radGeneroM;
        private System.Windows.Forms.CheckBox chePasaje;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.RadioButton radGeneroO;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPasaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnSave;
    }
}