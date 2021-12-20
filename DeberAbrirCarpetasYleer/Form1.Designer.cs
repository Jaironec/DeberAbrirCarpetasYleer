
namespace DeberAbrirCarpetasYleer
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
            this.Grupos1 = new System.Windows.Forms.GroupBox();
            this.listAbrirTextos = new System.Windows.Forms.ListBox();
            this.listAbrirArchivos = new System.Windows.Forms.ListBox();
            this.listAbrirCarpetas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.textCargar = new System.Windows.Forms.TextBox();
            this.Grupos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupos1
            // 
            this.Grupos1.Controls.Add(this.listAbrirTextos);
            this.Grupos1.Controls.Add(this.listAbrirArchivos);
            this.Grupos1.Controls.Add(this.listAbrirCarpetas);
            this.Grupos1.Location = new System.Drawing.Point(12, 75);
            this.Grupos1.Name = "Grupos1";
            this.Grupos1.Size = new System.Drawing.Size(776, 363);
            this.Grupos1.TabIndex = 0;
            this.Grupos1.TabStop = false;
            // 
            // listAbrirTextos
            // 
            this.listAbrirTextos.FormattingEnabled = true;
            this.listAbrirTextos.Location = new System.Drawing.Point(528, 18);
            this.listAbrirTextos.Name = "listAbrirTextos";
            this.listAbrirTextos.Size = new System.Drawing.Size(242, 316);
            this.listAbrirTextos.TabIndex = 2;
            // 
            // listAbrirArchivos
            // 
            this.listAbrirArchivos.FormattingEnabled = true;
            this.listAbrirArchivos.Location = new System.Drawing.Point(268, 18);
            this.listAbrirArchivos.Name = "listAbrirArchivos";
            this.listAbrirArchivos.Size = new System.Drawing.Size(242, 316);
            this.listAbrirArchivos.TabIndex = 1;
            this.listAbrirArchivos.DoubleClick += new System.EventHandler(this.listAbrirArchivos_DoubleClick);
            // 
            // listAbrirCarpetas
            // 
            this.listAbrirCarpetas.FormattingEnabled = true;
            this.listAbrirCarpetas.Location = new System.Drawing.Point(6, 19);
            this.listAbrirCarpetas.Name = "listAbrirCarpetas";
            this.listAbrirCarpetas.Size = new System.Drawing.Size(242, 316);
            this.listAbrirCarpetas.TabIndex = 0;
            this.listAbrirCarpetas.DoubleClick += new System.EventHandler(this.listAbrirCarpetas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abrir carpetas.";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(667, 34);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 35);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // textCargar
            // 
            this.textCargar.Location = new System.Drawing.Point(191, 39);
            this.textCargar.Name = "textCargar";
            this.textCargar.Size = new System.Drawing.Size(331, 20);
            this.textCargar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCargar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grupos1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Grupos1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listAbrirTextos;
        private System.Windows.Forms.ListBox listAbrirArchivos;
        private System.Windows.Forms.ListBox listAbrirCarpetas;
        private System.Windows.Forms.TextBox textCargar;
    }
}

