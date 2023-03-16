namespace Template
{
    partial class Form_NumericUpDown
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
            this.num_nrodia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.lb_mostrarDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_nrodia)).BeginInit();
            this.SuspendLayout();
            // 
            // num_nrodia
            // 
            this.num_nrodia.Location = new System.Drawing.Point(74, 116);
            this.num_nrodia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_nrodia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_nrodia.Name = "num_nrodia";
            this.num_nrodia.ReadOnly = true;
            this.num_nrodia.Size = new System.Drawing.Size(138, 22);
            this.num_nrodia.TabIndex = 0;
            this.num_nrodia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_nrodia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro. Día de la semana";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(74, 156);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(138, 35);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar día en texto";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // lb_mostrarDia
            // 
            this.lb_mostrarDia.AutoSize = true;
            this.lb_mostrarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostrarDia.Location = new System.Drawing.Point(286, 99);
            this.lb_mostrarDia.Name = "lb_mostrarDia";
            this.lb_mostrarDia.Size = new System.Drawing.Size(0, 58);
            this.lb_mostrarDia.TabIndex = 3;
            // 
            // Form_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 337);
            this.Controls.Add(this.lb_mostrarDia);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_nrodia);
            this.Name = "Form_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.num_nrodia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_nrodia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label lb_mostrarDia;
    }
}