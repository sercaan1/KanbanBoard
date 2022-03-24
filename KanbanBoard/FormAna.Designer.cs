
namespace KanbanBoard
{
    partial class FormAna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mspAnaForm = new System.Windows.Forms.MenuStrip();
            this.tsmiCreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMyProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.createCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspAnaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mspAnaForm
            // 
            this.mspAnaForm.BackColor = System.Drawing.SystemColors.Control;
            this.mspAnaForm.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mspAnaForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateProject,
            this.tsmiMyProjects,
            this.createCategoryToolStripMenuItem,
            this.myCategoriesToolStripMenuItem});
            this.mspAnaForm.Location = new System.Drawing.Point(0, 0);
            this.mspAnaForm.Name = "mspAnaForm";
            this.mspAnaForm.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mspAnaForm.Size = new System.Drawing.Size(808, 26);
            this.mspAnaForm.TabIndex = 1;
            this.mspAnaForm.Text = "menuStrip2";
            // 
            // tsmiCreateProject
            // 
            this.tsmiCreateProject.Name = "tsmiCreateProject";
            this.tsmiCreateProject.Size = new System.Drawing.Size(160, 20);
            this.tsmiCreateProject.Text = "Create Project";
            this.tsmiCreateProject.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // tsmiMyProjects
            // 
            this.tsmiMyProjects.Name = "tsmiMyProjects";
            this.tsmiMyProjects.Size = new System.Drawing.Size(130, 20);
            this.tsmiMyProjects.Text = "My Projects";
            this.tsmiMyProjects.Click += new System.EventHandler(this.tsmiMyProjects_Click);
            // 
            // createCategoryToolStripMenuItem
            // 
            this.createCategoryToolStripMenuItem.Name = "createCategoryToolStripMenuItem";
            this.createCategoryToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.createCategoryToolStripMenuItem.Text = "Create Category";
            this.createCategoryToolStripMenuItem.Click += new System.EventHandler(this.createCategoryToolStripMenuItem_Click);
            // 
            // myCategoriesToolStripMenuItem
            // 
            this.myCategoriesToolStripMenuItem.Name = "myCategoriesToolStripMenuItem";
            this.myCategoriesToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.myCategoriesToolStripMenuItem.Text = "My Categories";
            this.myCategoriesToolStripMenuItem.Click += new System.EventHandler(this.myCategoriesToolStripMenuItem_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mspAnaForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.mspAnaForm.ResumeLayout(false);
            this.mspAnaForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip mspAnaForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateProject;
        private System.Windows.Forms.ToolStripMenuItem tsmiMyProjects;
        private System.Windows.Forms.ToolStripMenuItem createCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myCategoriesToolStripMenuItem;
    }
}

