namespace Practica_auto
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CbBuscar = new System.Windows.Forms.ComboBox();
            this.DgvBuscar = new System.Windows.Forms.DataGridView();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar auto por Marca";
            // 
            // CbBuscar
            // 
            this.CbBuscar.FormattingEnabled = true;
            this.CbBuscar.Items.AddRange(new object[] {
            "Todos",
            "Nissan",
            "Toyota",
            "Hyundai",
            "Kia",
            "Honda"});
            this.CbBuscar.Location = new System.Drawing.Point(62, 37);
            this.CbBuscar.Name = "CbBuscar";
            this.CbBuscar.Size = new System.Drawing.Size(121, 21);
            this.CbBuscar.TabIndex = 1;
            this.CbBuscar.SelectedIndexChanged += new System.EventHandler(this.CbBuscar_SelectedIndexChanged);
            // 
            // DgvBuscar
            // 
            this.DgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBuscar.Location = new System.Drawing.Point(31, 76);
            this.DgvBuscar.Name = "DgvBuscar";
            this.DgvBuscar.Size = new System.Drawing.Size(628, 272);
            this.DgvBuscar.TabIndex = 2;
            this.DgvBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuscar_CellContentClick);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(676, 76);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 3;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.DgvBuscar);
            this.Controls.Add(this.CbBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbBuscar;
        private System.Windows.Forms.DataGridView DgvBuscar;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}