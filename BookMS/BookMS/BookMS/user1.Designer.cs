﻿
namespace BookMS
{
    partial class user1
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
            this.书籍查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍查询ToolStripMenuItem,
            this.借书管理ToolStripMenuItem,
            this.还书管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 书籍查询ToolStripMenuItem
            // 
            this.书籍查询ToolStripMenuItem.Name = "书籍查询ToolStripMenuItem";
            this.书籍查询ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.书籍查询ToolStripMenuItem.Text = "书籍查询";
            this.书籍查询ToolStripMenuItem.Click += new System.EventHandler(this.书籍查询ToolStripMenuItem_Click);
            // 
            // 借书管理ToolStripMenuItem
            // 
            this.借书管理ToolStripMenuItem.Name = "借书管理ToolStripMenuItem";
            this.借书管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.借书管理ToolStripMenuItem.Text = "借书管理";
            this.借书管理ToolStripMenuItem.Click += new System.EventHandler(this.借书管理ToolStripMenuItem_Click);
            // 
            // 还书管理ToolStripMenuItem
            // 
            this.还书管理ToolStripMenuItem.Name = "还书管理ToolStripMenuItem";
            this.还书管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.还书管理ToolStripMenuItem.Text = "还书管理";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正姚体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(258, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户主页面";
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user1";
            this.Text = "用户主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书籍查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}