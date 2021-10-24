
namespace Salary.Forms
{
    partial class RolesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RolesPanel = new System.Windows.Forms.Panel();
            this.bindingSourceRoles = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rolesDataGrid = new System.Windows.Forms.DataGridView();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RolesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RolesPanel
            // 
            this.RolesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.RolesPanel.Controls.Add(this.panel1);
            this.RolesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesPanel.Location = new System.Drawing.Point(0, 0);
            this.RolesPanel.Name = "RolesPanel";
            this.RolesPanel.Size = new System.Drawing.Size(800, 450);
            this.RolesPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должности компании";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rolesDataGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // rolesDataGrid
            // 
            this.rolesDataGrid.AllowUserToAddRows = false;
            this.rolesDataGrid.AllowUserToDeleteRows = false;
            this.rolesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rolesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rolesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rolesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.rolesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesDataGrid.ColumnHeadersHeight = 30;
            this.rolesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.rolesDataGrid.EnableHeadersVisualStyles = false;
            this.rolesDataGrid.GridColor = System.Drawing.Color.MediumPurple;
            this.rolesDataGrid.Location = new System.Drawing.Point(236, 43);
            this.rolesDataGrid.Name = "rolesDataGrid";
            this.rolesDataGrid.ReadOnly = true;
            this.rolesDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.rolesDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.rolesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesDataGrid.Size = new System.Drawing.Size(375, 280);
            this.rolesDataGrid.TabIndex = 1;
            this.rolesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDataGrid_CellContentClick);
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.AddRoleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoleBtn.FlatAppearance.BorderSize = 0;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRoleBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoleBtn.Location = new System.Drawing.Point(21, 37);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(181, 35);
            this.AddRoleBtn.TabIndex = 6;
            this.AddRoleBtn.Text = "ДОБАВИТЬ ДОЛЖНОСТЬ";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.AddRoleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 7;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RolesPanel);
            this.Name = "RolesForm";
            this.ShowIcon = false;
            this.Text = "Управление ролями";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.RolesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RolesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView rolesDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddRoleBtn;
    }
}