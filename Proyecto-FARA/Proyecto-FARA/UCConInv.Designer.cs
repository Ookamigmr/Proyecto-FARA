﻿namespace Proyecto_FARA
{
    partial class UCConInv
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbProd = new System.Windows.Forms.GroupBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.txtMarProd = new System.Windows.Forms.TextBox();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCNETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmULT_ACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbProd
            // 
            this.gpbProd.Controls.Add(this.button1);
            this.gpbProd.Controls.Add(this.dgvProd);
            this.gpbProd.Controls.Add(this.btnBuscarP);
            this.gpbProd.Controls.Add(this.txtMarProd);
            this.gpbProd.Controls.Add(this.lblMarcaP);
            this.gpbProd.Controls.Add(this.lblNombreP);
            this.gpbProd.Controls.Add(this.txtNomProd);
            this.gpbProd.Location = new System.Drawing.Point(221, 13);
            this.gpbProd.Name = "gpbProd";
            this.gpbProd.Size = new System.Drawing.Size(603, 425);
            this.gpbProd.TabIndex = 3;
            this.gpbProd.TabStop = false;
            this.gpbProd.Text = "Producto";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNom,
            this.clmMARCA,
            this.clm,
            this.clmCNETO,
            this.clmULT_ACT});
            this.dgvProd.Location = new System.Drawing.Point(19, 68);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.Size = new System.Drawing.Size(562, 304);
            this.dgvProd.TabIndex = 5;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(468, 42);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarP.TabIndex = 4;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // txtMarProd
            // 
            this.txtMarProd.Location = new System.Drawing.Point(203, 42);
            this.txtMarProd.Name = "txtMarProd";
            this.txtMarProd.Size = new System.Drawing.Size(121, 20);
            this.txtMarProd.TabIndex = 3;
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Location = new System.Drawing.Point(186, 27);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaP.TabIndex = 2;
            this.lblMarcaP.Text = "Marca";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(56, 28);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(106, 13);
            this.lblNombreP.TabIndex = 1;
            this.lblNombreP.Text = "Nombre del producto";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Location = new System.Drawing.Point(74, 44);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(100, 20);
            this.txtNomProd.TabIndex = 0;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmNom
            // 
            this.clmNom.HeaderText = "NOMBRE";
            this.clmNom.Name = "clmNom";
            this.clmNom.ReadOnly = true;
            // 
            // clmMARCA
            // 
            this.clmMARCA.HeaderText = "MARCA";
            this.clmMARCA.Name = "clmMARCA";
            this.clmMARCA.ReadOnly = true;
            // 
            // clm
            // 
            this.clm.HeaderText = "CANTIDAD";
            this.clm.Name = "clm";
            this.clm.ReadOnly = true;
            // 
            // clmCNETO
            // 
            this.clmCNETO.HeaderText = "CONTENIDO NETO";
            this.clmCNETO.Name = "clmCNETO";
            this.clmCNETO.ReadOnly = true;
            // 
            // clmULT_ACT
            // 
            this.clmULT_ACT.HeaderText = "ULTIMA ACTUALIZACION";
            this.clmULT_ACT.Name = "clmULT_ACT";
            this.clmULT_ACT.ReadOnly = true;
            this.clmULT_ACT.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Importar inventario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCConInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbProd);
            this.Name = "UCConInv";
            this.Size = new System.Drawing.Size(1043, 453);
            this.gpbProd.ResumeLayout(false);
            this.gpbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCNETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmULT_ACT;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtMarProd;
        private System.Windows.Forms.Label lblMarcaP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtNomProd;
    }
}
