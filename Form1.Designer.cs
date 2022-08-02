
namespace TAREA_EJERCICIO_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBOinstrumento = new System.Windows.Forms.ComboBox();
            this.CBOmarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOcolor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNSTOP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLNOTA = new System.Windows.Forms.Label();
            this.BTNMOSTRARLV = new System.Windows.Forms.Button();
            this.BTNAGREGARDGV = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FABRICA DE INSTRUMENTOS MUSICALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de instrumento";
            // 
            // CBOinstrumento
            // 
            this.CBOinstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOinstrumento.FormattingEnabled = true;
            this.CBOinstrumento.Items.AddRange(new object[] {
            "Guitarra",
            "Piano",
            "Bajo"});
            this.CBOinstrumento.Location = new System.Drawing.Point(148, 108);
            this.CBOinstrumento.Name = "CBOinstrumento";
            this.CBOinstrumento.Size = new System.Drawing.Size(88, 21);
            this.CBOinstrumento.TabIndex = 2;
            // 
            // CBOmarca
            // 
            this.CBOmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOmarca.FormattingEnabled = true;
            this.CBOmarca.Items.AddRange(new object[] {
            "Yamaha",
            "Fender",
            "Squier",
            "Pearl River",
            "DW"});
            this.CBOmarca.Location = new System.Drawing.Point(118, 145);
            this.CBOmarca.Name = "CBOmarca";
            this.CBOmarca.Size = new System.Drawing.Size(118, 21);
            this.CBOmarca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // CBOcolor
            // 
            this.CBOcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOcolor.FormattingEnabled = true;
            this.CBOcolor.Items.AddRange(new object[] {
            "Blanco ",
            "Negro",
            "Marron",
            "Rojo"});
            this.CBOcolor.Location = new System.Drawing.Point(118, 182);
            this.CBOcolor.Name = "CBOcolor";
            this.CBOcolor.Size = new System.Drawing.Size(118, 21);
            this.CBOcolor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Location = new System.Drawing.Point(335, 236);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(70, 25);
            this.BTNGUARDAR.TabIndex = 7;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNSTOP
            // 
            this.BTNSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSTOP.Location = new System.Drawing.Point(205, 236);
            this.BTNSTOP.Name = "BTNSTOP";
            this.BTNSTOP.Size = new System.Drawing.Size(106, 25);
            this.BTNSTOP.TabIndex = 8;
            this.BTNSTOP.Text = "Empezar";
            this.BTNSTOP.UseVisualStyleBackColor = true;
            this.BTNSTOP.Click += new System.EventHandler(this.BTNSTOP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nota Aleatoria";
            // 
            // LBLNOTA
            // 
            this.LBLNOTA.AutoSize = true;
            this.LBLNOTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNOTA.Location = new System.Drawing.Point(115, 242);
            this.LBLNOTA.Name = "LBLNOTA";
            this.LBLNOTA.Size = new System.Drawing.Size(0, 13);
            this.LBLNOTA.TabIndex = 10;
            // 
            // BTNMOSTRARLV
            // 
            this.BTNMOSTRARLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMOSTRARLV.Location = new System.Drawing.Point(669, 298);
            this.BTNMOSTRARLV.Name = "BTNMOSTRARLV";
            this.BTNMOSTRARLV.Size = new System.Drawing.Size(93, 47);
            this.BTNMOSTRARLV.TabIndex = 11;
            this.BTNMOSTRARLV.Text = "Mostrar Datos Almacenados";
            this.BTNMOSTRARLV.UseVisualStyleBackColor = true;
            this.BTNMOSTRARLV.Click += new System.EventHandler(this.BTNMOSTRARLV_Click);
            // 
            // BTNAGREGARDGV
            // 
            this.BTNAGREGARDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGARDGV.Location = new System.Drawing.Point(466, 374);
            this.BTNAGREGARDGV.Name = "BTNAGREGARDGV";
            this.BTNAGREGARDGV.Size = new System.Drawing.Size(106, 50);
            this.BTNAGREGARDGV.TabIndex = 13;
            this.BTNAGREGARDGV.Text = "Mostrar Datos recientes";
            this.BTNAGREGARDGV.UseVisualStyleBackColor = true;
            this.BTNAGREGARDGV.Click += new System.EventHandler(this.BTNAGREGARDGV_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(26, 275);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(434, 149);
            this.DGV.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(575, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 218);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.BTNAGREGARDGV);
            this.Controls.Add(this.BTNMOSTRARLV);
            this.Controls.Add(this.LBLNOTA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNSTOP);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.CBOcolor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBOmarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBOinstrumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBOinstrumento;
        private System.Windows.Forms.ComboBox CBOmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBOcolor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNSTOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLNOTA;
        private System.Windows.Forms.Button BTNMOSTRARLV;
        private System.Windows.Forms.Button BTNAGREGARDGV;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

