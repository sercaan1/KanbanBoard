
namespace KanbanBoard
{
    partial class FormNot
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.gbxNot = new System.Windows.Forms.GroupBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(370, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(348, 25);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(125, 24);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(257, 93);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(216, 189);
            this.txtNot.TabIndex = 0;
            this.txtNot.TextChanged += new System.EventHandler(this.txtNot_TextChanged);
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemain.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRemain.Location = new System.Drawing.Point(254, 299);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(199, 14);
            this.lblRemain.TabIndex = 4;
            this.lblRemain.Text = "Remaining character: 140";
            // 
            // gbxNot
            // 
            this.gbxNot.Controls.Add(this.pictureBox1);
            this.gbxNot.Controls.Add(this.txtPreview);
            this.gbxNot.Controls.Add(this.lblKategori);
            this.gbxNot.Controls.Add(this.lblTarih);
            this.gbxNot.Location = new System.Drawing.Point(12, 28);
            this.gbxNot.Name = "gbxNot";
            this.gbxNot.Size = new System.Drawing.Size(228, 296);
            this.gbxNot.TabIndex = 5;
            this.gbxNot.TabStop = false;
            this.gbxNot.Text = "Preview";
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.White;
            this.txtPreview.Location = new System.Drawing.Point(3, 65);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(216, 189);
            this.txtPreview.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKategori.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(6, 29);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(2, 16);
            this.lblKategori.TabIndex = 9;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarih.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(6, 271);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(2, 16);
            this.lblTarih.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 31);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KanbanBoard.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(168, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 367);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxNot);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 406);
            this.MinimumSize = new System.Drawing.Size(515, 406);
            this.Name = "FormNot";
            this.Text = "Create Note";
            this.gbxNot.ResumeLayout(false);
            this.gbxNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.GroupBox gbxNot;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}