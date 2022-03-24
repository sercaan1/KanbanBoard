
namespace KanbanBoard
{
    partial class FormProje
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
            this.flpToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDoin = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDoin = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateNote = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToDo = new System.Windows.Forms.Label();
            this.pbToDo = new System.Windows.Forms.PictureBox();
            this.pbDoin = new System.Windows.Forms.PictureBox();
            this.pbDone = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).BeginInit();
            this.SuspendLayout();
            // 
            // flpToDo
            // 
            this.flpToDo.AllowDrop = true;
            this.flpToDo.AutoScroll = true;
            this.flpToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpToDo.Location = new System.Drawing.Point(12, 100);
            this.flpToDo.Name = "flpToDo";
            this.flpToDo.Size = new System.Drawing.Size(276, 432);
            this.flpToDo.TabIndex = 0;
            this.flpToDo.WrapContents = false;
            this.flpToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragDrop);
            this.flpToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // flpDoin
            // 
            this.flpDoin.AllowDrop = true;
            this.flpDoin.AutoScroll = true;
            this.flpDoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDoin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDoin.Location = new System.Drawing.Point(325, 100);
            this.flpDoin.Name = "flpDoin";
            this.flpDoin.Size = new System.Drawing.Size(261, 432);
            this.flpDoin.TabIndex = 1;
            this.flpDoin.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDoin_DragDrop);
            this.flpDoin.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // lblDoin
            // 
            this.lblDoin.AutoSize = true;
            this.lblDoin.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoin.Location = new System.Drawing.Point(376, 45);
            this.lblDoin.Name = "lblDoin";
            this.lblDoin.Size = new System.Drawing.Size(85, 24);
            this.lblDoin.TabIndex = 3;
            this.lblDoin.Text = "Doing";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDone.Location = new System.Drawing.Point(712, 45);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(70, 24);
            this.lblDone.TabIndex = 4;
            this.lblDone.Text = "Done";
            // 
            // flpDone
            // 
            this.flpDone.AllowDrop = true;
            this.flpDone.AutoScroll = true;
            this.flpDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(617, 100);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(287, 432);
            this.flpDone.TabIndex = 1;
            this.flpDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpDone_DragDrop_1);
            this.flpDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpToDo_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveProject,
            this.tsmiCreateNote});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSaveProject
            // 
            this.tsmiSaveProject.Name = "tsmiSaveProject";
            this.tsmiSaveProject.Size = new System.Drawing.Size(140, 20);
            this.tsmiSaveProject.Text = "Save Project";
            this.tsmiSaveProject.Click += new System.EventHandler(this.tsmiSaveProject_Click);
            // 
            // tsmiCreateNote
            // 
            this.tsmiCreateNote.Name = "tsmiCreateNote";
            this.tsmiCreateNote.Size = new System.Drawing.Size(130, 20);
            this.tsmiCreateNote.Text = "Create Note";
            this.tsmiCreateNote.Click += new System.EventHandler(this.tsmiCreateNote_Click);
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
            this.tsmiCopy.Size = new System.Drawing.Size(102, 22);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToDo.Location = new System.Drawing.Point(105, 54);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(70, 24);
            this.lblToDo.TabIndex = 7;
            this.lblToDo.Text = "ToDo";
            // 
            // pbToDo
            // 
            this.pbToDo.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbToDo.Location = new System.Drawing.Point(256, 45);
            this.pbToDo.Name = "pbToDo";
            this.pbToDo.Size = new System.Drawing.Size(24, 24);
            this.pbToDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbToDo.TabIndex = 8;
            this.pbToDo.TabStop = false;
            this.pbToDo.Visible = false;
            this.pbToDo.Click += new System.EventHandler(this.pbToDo_Click);
            // 
            // pbDoin
            // 
            this.pbDoin.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbDoin.Location = new System.Drawing.Point(553, 45);
            this.pbDoin.Name = "pbDoin";
            this.pbDoin.Size = new System.Drawing.Size(24, 24);
            this.pbDoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDoin.TabIndex = 11;
            this.pbDoin.TabStop = false;
            this.pbDoin.Visible = false;
            this.pbDoin.Click += new System.EventHandler(this.pbDoin_Click);
            // 
            // pbDone
            // 
            this.pbDone.Image = global::KanbanBoard.Properties.Resources.copy;
            this.pbDone.Location = new System.Drawing.Point(864, 45);
            this.pbDone.Name = "pbDone";
            this.pbDone.Size = new System.Drawing.Size(24, 24);
            this.pbDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDone.TabIndex = 12;
            this.pbDone.TabStop = false;
            this.pbDone.Visible = false;
            this.pbDone.Click += new System.EventHandler(this.pbDone_Click);
            // 
            // FormProje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 571);
            this.Controls.Add(this.pbDone);
            this.Controls.Add(this.pbDoin);
            this.Controls.Add(this.pbToDo);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblDoin);
            this.Controls.Add(this.flpDoin);
            this.Controls.Add(this.flpDone);
            this.Controls.Add(this.flpToDo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormProje";
            this.Text = "Create Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProje_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormProje_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpToDo;
        private System.Windows.Forms.FlowLayoutPanel flpDoin;
        private System.Windows.Forms.Label lblDoin;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.PictureBox pbToDo;
        private System.Windows.Forms.PictureBox pbDoin;
        private System.Windows.Forms.PictureBox pbDone;
    }
}