using System.Collections.Generic;

namespace FiguresRunning
{
    partial class FiguresRunning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresRunning));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewFigures = new System.Windows.Forms.TreeView();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panelCreating = new System.Windows.Forms.Panel();
            this.labelNothing = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.btStopGoFigure = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelCreating.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.treeViewFigures);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxMain);
            // 
            // treeViewFigures
            // 
            resources.ApplyResources(this.treeViewFigures, "treeViewFigures");
            this.treeViewFigures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewFigures.Name = "treeViewFigures";
            this.treeViewFigures.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFigures_NodeMouseClick);
            // 
            // pictureBoxMain
            // 
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            // 
            // panelCreating
            // 
            resources.ApplyResources(this.panelCreating, "panelCreating");
            this.panelCreating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreating.Controls.Add(this.labelNothing);
            this.panelCreating.Controls.Add(this.labelY);
            this.panelCreating.Controls.Add(this.labelX);
            this.panelCreating.Controls.Add(this.buttonMinus);
            this.panelCreating.Controls.Add(this.buttonPlus);
            this.panelCreating.Controls.Add(this.comboBoxLanguage);
            this.panelCreating.Controls.Add(this.btStopGoFigure);
            this.panelCreating.Controls.Add(this.buttonCircle);
            this.panelCreating.Controls.Add(this.buttonRectangle);
            this.panelCreating.Controls.Add(this.buttonTriangle);
            this.panelCreating.Controls.Add(this.menuStrip1);
            this.panelCreating.Name = "panelCreating";
            // 
            // labelNothing
            // 
            resources.ApplyResources(this.labelNothing, "labelNothing");
            this.labelNothing.Name = "labelNothing";
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            // 
            // buttonMinus
            // 
            resources.ApplyResources(this.buttonMinus, "buttonMinus");
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            resources.ApplyResources(this.buttonPlus, "buttonPlus");
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // btStopGoFigure
            // 
            resources.ApplyResources(this.btStopGoFigure, "btStopGoFigure");
            this.btStopGoFigure.Name = "btStopGoFigure";
            this.btStopGoFigure.UseVisualStyleBackColor = true;
            this.btStopGoFigure.Click += new System.EventHandler(this.btStopGoFigure_Click);
            // 
            // buttonCircle
            // 
            resources.ApplyResources(this.buttonCircle, "buttonCircle");
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRectangle
            // 
            resources.ApplyResources(this.buttonRectangle, "buttonRectangle");
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonTriangle
            // 
            resources.ApplyResources(this.buttonTriangle, "buttonTriangle");
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = MyStrings.File;
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInBinToolStripMenuItem,
            this.saveInxmlToolStripMenuItem,
            this.saveInToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Text = MyStrings.Save;
            // 
            // saveInBinToolStripMenuItem
            // 
            resources.ApplyResources(this.saveInBinToolStripMenuItem, "saveInBinToolStripMenuItem");
            this.saveInBinToolStripMenuItem.Name = "saveInBinToolStripMenuItem";
            this.saveInBinToolStripMenuItem.Text = MyStrings.SaveBIN;
            this.saveInBinToolStripMenuItem.Click += new System.EventHandler(this.saveInBinToolStripMenuItem_Click);
            // 
            // saveInxmlToolStripMenuItem
            // 
            resources.ApplyResources(this.saveInxmlToolStripMenuItem, "saveInxmlToolStripMenuItem");
            this.saveInxmlToolStripMenuItem.Name = "saveInxmlToolStripMenuItem";
            this.saveInxmlToolStripMenuItem.Text = MyStrings.SaveXML;
            this.saveInxmlToolStripMenuItem.Click += new System.EventHandler(this.saveInxmlToolStripMenuItem_Click);
            // 
            // saveInToolStripMenuItem
            // 
            resources.ApplyResources(this.saveInToolStripMenuItem, "saveInToolStripMenuItem");
            this.saveInToolStripMenuItem.Name = "saveInToolStripMenuItem";
            this.saveInToolStripMenuItem.Text = MyStrings.SaveJSON;
            this.saveInToolStripMenuItem.Click += new System.EventHandler(this.saveJSONToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openbinToolStripMenuItem,
            this.openxmlToolStripMenuItem,
            this.openjsonToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Text = MyStrings.Open;
            // 
            // openbinToolStripMenuItem
            // 
            resources.ApplyResources(this.openbinToolStripMenuItem, "openbinToolStripMenuItem");
            this.openbinToolStripMenuItem.Name = "openbinToolStripMenuItem";
            this.openbinToolStripMenuItem.Text = MyStrings.OpenBIN;
            this.openbinToolStripMenuItem.Click += new System.EventHandler(this.openbinToolStripMenuItem_Click);
            // 
            // openxmlToolStripMenuItem
            // 
            resources.ApplyResources(this.openxmlToolStripMenuItem, "openxmlToolStripMenuItem");
            this.openxmlToolStripMenuItem.Name = "openxmlToolStripMenuItem";
            this.openxmlToolStripMenuItem.Text = MyStrings.OpenXML;
            this.openxmlToolStripMenuItem.Click += new System.EventHandler(this.openxmlToolStripMenuItem_Click);
            // 
            // openjsonToolStripMenuItem
            // 
            resources.ApplyResources(this.openjsonToolStripMenuItem, "openjsonToolStripMenuItem");
            this.openjsonToolStripMenuItem.Name = "openjsonToolStripMenuItem";
            this.openjsonToolStripMenuItem.Text = MyStrings.OpenJSON;
            this.openjsonToolStripMenuItem.Click += new System.EventHandler(this.openjsonToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // FiguresRunning
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelCreating);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FiguresRunning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiguresRunning_FormClosing);
            this.Load += new System.EventHandler(this.FiguresRunning_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelCreating.ResumeLayout(false);
            this.panelCreating.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreating;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewFigures;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btStopGoFigure;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openbinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openjsonToolStripMenuItem;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelNothing;
    }
}

