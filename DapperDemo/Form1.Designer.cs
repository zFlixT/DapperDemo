﻿namespace DapperDemo
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(776, 207);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerTodos.Location = new System.Drawing.Point(25, 463);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(95, 34);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Cliente";
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(79, 249);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(100, 20);
            this.tboxObtenerID.TabIndex = 3;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerId.Location = new System.Drawing.Point(199, 247);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(92, 23);
            this.btnObtenerId.TabIndex = 4;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Location = new System.Drawing.Point(662, 243);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "CustomersID";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(662, 280);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txbCompanyName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "CompanyName";
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.Location = new System.Drawing.Point(662, 356);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxContactTitle.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "ContactName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(662, 318);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(100, 20);
            this.txbContactName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact title ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(662, 387);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 20);
            this.txbAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(567, 438);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(95, 34);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar cliente ";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(693, 438);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 34);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(633, 481);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 34);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 527);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.TextBox txbCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

