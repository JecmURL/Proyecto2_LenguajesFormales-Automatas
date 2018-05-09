namespace LFYA_Maquinas_Turing_v1
{
    partial class frmMainUI
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
            this.lblContadorPasos = new System.Windows.Forms.Label();
            this.lblCounterSteps = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbMT = new System.Windows.Forms.ComboBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContadorPasos
            // 
            this.lblContadorPasos.AutoSize = true;
            this.lblContadorPasos.Location = new System.Drawing.Point(509, 332);
            this.lblContadorPasos.Name = "lblContadorPasos";
            this.lblContadorPasos.Size = new System.Drawing.Size(100, 13);
            this.lblContadorPasos.TabIndex = 0;
            this.lblContadorPasos.Text = "Contador de Pasos:";
            // 
            // lblCounterSteps
            // 
            this.lblCounterSteps.AutoSize = true;
            this.lblCounterSteps.Location = new System.Drawing.Point(615, 332);
            this.lblCounterSteps.Name = "lblCounterSteps";
            this.lblCounterSteps.Size = new System.Drawing.Size(13, 13);
            this.lblCounterSteps.TabIndex = 1;
            this.lblCounterSteps.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(181, 55);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbMT
            // 
            this.cmbMT.FormattingEnabled = true;
            this.cmbMT.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Palindromos",
            "Copia de Patron"});
            this.cmbMT.Location = new System.Drawing.Point(54, 57);
            this.cmbMT.Name = "cmbMT";
            this.cmbMT.Size = new System.Drawing.Size(121, 21);
            this.cmbMT.TabIndex = 3;
            this.cmbMT.Text = "- Seleccione MT -";
            this.cmbMT.SelectedIndexChanged += new System.EventHandler(this.cmbMT_SelectedIndexChanged);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeColumns = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(12, 168);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.Size = new System.Drawing.Size(646, 150);
            this.dgvOutput.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(156, 131);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(472, 20);
            this.txtInput.TabIndex = 5;
            this.txtInput.Visible = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(54, 134);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(101, 13);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Cadena de entrada:";
            this.lblText.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(54, 94);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(46, 16);
            this.lblWarning.TabIndex = 7;
            this.lblWarning.Text = "label1";
            this.lblWarning.Visible = false;
            // 
            // frmMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 370);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.cmbMT);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCounterSteps);
            this.Controls.Add(this.lblContadorPasos);
            this.Name = "frmMainUI";
            this.Text = "Proyecto Lenguajes Formales y Automatas - Maquinas de Turing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContadorPasos;
        private System.Windows.Forms.Label lblCounterSteps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbMT;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblWarning;
    }
}

