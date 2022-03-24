
namespace KanbanBoard
{
    partial class FormProje2
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
            this.lblDone = new System.Windows.Forms.Label();
            this.lblDoin = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.flpDoin = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.flpToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateNote = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDone = new System.Windows.Forms.PictureBox();
            this.pbDoin = new System.Windows.Forms.PictureBox();
            this.pbToDo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToDo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDone.Location = new System.Drawing.Point(712, 56);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(70, 24);
            this.lblDone.TabIndex = 11;
            this.lblDone.Text = "Done";
            // 
            // lblDoin
            // 
            this.lblDoin.AutoSize = true;
            this.lblDoin.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoin.Location = new System.Drawing.Point(376, 56);
            this.lblDoin.Name = "lblDoin";
            this.lblDoin.Size = new System.Drawing.Size(85, 24);
            this.lblDoin.TabIndex = 10;
            this.lblDoin.Text = "Doing";
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToDo.Location = new System.Drawing.Point(132, 56);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(70, 24);
            this.lblToDo.TabIndex = 9;
            this.lblToDo.Text = "ToDo";
            // 
            // flpDoin
            // 
            this.flpDoin.AllowDrop = true;
            this.flpDoin.AutoScroll = true;
            this.flpDoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDoin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDoin.Location = new System.Drawing.Point(325, 111);
            this.flpDoin.Name = "flpDoin";
            this.flpDoin.Size = new System.Drawing.Size(261, 432);
            this.flpDoin.TabIndex = 7;
            this.flpDoin.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDoin_DragDrop);
            this.flpDoin.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // flpDone
            // 
            this.flpDone.AllowDrop = true;
            this.flpDone.AutoScroll = true;
            this.flpDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(617, 111);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(287, 432);
            this.flpDone.TabIndex = 8;
            this.flpDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDone_DragDrop);
            this.flpDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // flpToDo
            // 
            this.flpToDo.AllowDrop = true;
            this.flpToDo.AutoScroll = true;
            this.flpToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpToDo.Location = new System.Drawing.Point(12, 111);
            this.flpToDo.Name = "flpToDo";
            this.flpToDo.Size = new System.Drawing.Size(276, 432);
            this.flpToDo.TabIndex = 6;
            this.flpToDo.WrapContents = false;
            this.flpToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragDrop);
            this.flpToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveProject,
            this.deleteProjectToolStripMenuItem,
            this.tsmiCreateNote});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSaveProject
            // 
            this.tsmiSaveProject.Name = "tsmiSaveProject";
            this.tsmiSaveProject.Size = new System.Drawing.Size(140, 20);
            this.tsmiSaveProject.Text = "Save Project";
            this.tsmiSaveProject.Click += new System.EventHandler(this.tsmiSaveProject_Click);
            // 
            // deleteProjectToolStripMenuItem
            // 
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.deleteProjectToolStripMenuItem.Text = "Delete Project";
            this.deleteProjectToolStripMenuItem.Click += new System.EventHandler(this.deleteProjectToolStripMenuItem_Click);
            // 
            // tsmiCreateNote
            // 
            this.tsmiCreateNote.Name = "tsmiCreateNote";
            this.tsmiCreateNote.Size = new System.Drawing.Size(130, 20);
            this.tsmiCreateNote.Text = "Create Note";
            this.tsmiCreateNote.Click += new System.EventHandler(this.tsmiCreateNote_Click);
            // 
            // pbDone
            // 
            this.pbDone.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbDone.Location = new System.Drawing.Point(872, 56);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(24, 24);
            this.pbDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDone.TabIndex = 15;
            this.pbDone.TabStop = false;
            this.pbDone.Visible = false;
            this.pbDone.Click += new System.EventHandler(this.pbDone_Click_1);
            // 
            // pbDoin
            // 
            this.pbDoin.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbDoin.Location = new System.Drawing.Point(561, 56);
            this.pbDoin.Name = "pbDoin";
            this.pbDoin.Size = new System.Drawing.Size(24, 24);
            this.pbDoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDoin.TabIndex = 14;
            this.pbDoin.TabStop = false;
            this.pbDoin.Visible = false;
            this.pbDoin.Click += new System.EventHandler(this.pbDoin_Click_1);
            // 
            // pbToDo
            // 
            this.pbToDo.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbToDo.Location = new System.Drawing.Point(264, 56);
            this.pbToDo.Name = "pbToDo";
            this.pbToDo.Size = new System.Drawing.Size(24, 24);
            this.pbToDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbToDo.TabIndex = 13;
            this.pbToDo.TabStop = false;
            this.pbToDo.Visible = false;
            this.pbToDo.Click += new System.EventHandler(this.pbToDo_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click_1);
            // 
            // FormProje2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 555);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.pbDoin);
            this.Controls.Add(this.pbToDo);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblDoin);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.flpDoin);
            this.Controls.Add(this.flpDone);
            this.Controls.Add(this.flpToDo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormProje2";
            this.Text = "My Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProje2_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormProje2_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToDo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblDoin;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.FlowLayoutPanel flpDoin;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.FlowLayoutPanel flpToDo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveProject;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateNote;
        private System.Windows.Forms.PictureBox pbDone;
        private System.Windows.Forms.PictureBox pbDoin;
        private System.Windows.Forms.PictureBox pbToDo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    }
}