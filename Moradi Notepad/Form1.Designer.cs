﻿using System;
using System.Windows.Forms;


namespace Moradi_Notepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.lockDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Clocklabel = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TextSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moradiNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moradiHintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ubuntuControlBox1 = new Ubuntu_Theme.UbuntuControlBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindText = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.infolabel = new System.Windows.Forms.Label();
            this.lines = new System.Windows.Forms.Label();
            this.ubuntuTheme1 = new Ubuntu_Theme.UbuntuTheme();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoradiHint = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.WelcomeBack = new System.Windows.Forms.Label();
            this.OpacityControl = new System.Windows.Forms.Label();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.FontTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageBoxPerMin = new System.Windows.Forms.Timer(this.components);
            this.Opacity = new System.Windows.Forms.Timer(this.components);
            this.dancingpencil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Font_style = new System.Windows.Forms.ToolStripDropDownButton();
            this.arielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algerianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRCHRISTYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRDELANEYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRDESTINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castellarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalReadoutUprightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.georgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jokermanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lucidaHandwritingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modernNo20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallFontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.LockDoc = new System.Windows.Forms.ToolStripButton();
            this.UnlockDoc = new System.Windows.Forms.ToolStripButton();
            this.MicOn = new System.Windows.Forms.ToolStripButton();
            this.MicOff = new System.Windows.Forms.ToolStripButton();
            this.NewDoc = new System.Windows.Forms.ToolStripButton();
            this.OpenDoc = new System.Windows.Forms.ToolStripButton();
            this.SaveDoc = new System.Windows.Forms.ToolStripButton();
            this.PrintDoc = new System.Windows.Forms.ToolStripButton();
            this.InsertImage = new System.Windows.Forms.ToolStripButton();
            this.Bold1 = new System.Windows.Forms.ToolStripButton();
            this.Italic1 = new System.Windows.Forms.ToolStripButton();
            this.Underline1 = new System.Windows.Forms.ToolStripButton();
            this.StrikeThrough1 = new System.Windows.Forms.ToolStripButton();
            this.CaseCap = new System.Windows.Forms.ToolStripButton();
            this.CaseLowercase = new System.Windows.Forms.ToolStripButton();
            this.Fontincrease = new System.Windows.Forms.ToolStripButton();
            this.Fontdecrease = new System.Windows.Forms.ToolStripButton();
            this.BackColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navyBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Forcolor = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Highlighter = new System.Windows.Forms.ToolStripDropDownButton();
            this.transeparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nONEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumbLine = new System.Windows.Forms.ToolStripButton();
            this.HideNumbline = new System.Windows.Forms.ToolStripButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSignaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thankYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincerelyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradiDevelopmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashingColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronounceThatWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readCurrentDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halloweenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsNotepadThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineNumbers_For_RichTextBox2 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.CopyPaste.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.ubuntuTheme1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dancingpencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.selectAllToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.lockDocumentToolStripMenuItem,
            this.unlockDocumentToolStripMenuItem,
            this.readSelectedTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 186);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem1.Text = "Copy";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem2.Text = "Paste";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(168, 6);
            // 
            // lockDocumentToolStripMenuItem
            // 
            this.lockDocumentToolStripMenuItem.Name = "lockDocumentToolStripMenuItem";
            this.lockDocumentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.lockDocumentToolStripMenuItem.Text = "Lock Document";
            this.lockDocumentToolStripMenuItem.Click += new System.EventHandler(this.lockDocumentToolStripMenuItem_Click);
            // 
            // unlockDocumentToolStripMenuItem
            // 
            this.unlockDocumentToolStripMenuItem.Enabled = false;
            this.unlockDocumentToolStripMenuItem.Name = "unlockDocumentToolStripMenuItem";
            this.unlockDocumentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.unlockDocumentToolStripMenuItem.Text = "Unlock Document";
            this.unlockDocumentToolStripMenuItem.Click += new System.EventHandler(this.unlockDocumentToolStripMenuItem_Click);
            // 
            // readSelectedTextToolStripMenuItem
            // 
            this.readSelectedTextToolStripMenuItem.Name = "readSelectedTextToolStripMenuItem";
            this.readSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.readSelectedTextToolStripMenuItem.Text = "Read Selected Text";
            this.readSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.readSelectedTextToolStripMenuItem_Click);
            // 
            // CopyPaste
            // 
            this.CopyPaste.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.cutToolStripMenuItem1});
            this.CopyPaste.Name = "CopyPaste";
            this.CopyPaste.Size = new System.Drawing.Size(103, 70);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // Clocklabel
            // 
            this.Clocklabel.Enabled = true;
            this.Clocklabel.Interval = 1;
            this.Clocklabel.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextSaveTimer
            // 
            this.TextSaveTimer.Enabled = true;
            this.TextSaveTimer.Interval = 1000;
            this.TextSaveTimer.Tick += new System.EventHandler(this.TextSaveTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.NotifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Moradi Notepad";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moradiNotepadToolStripMenuItem,
            this.toolStripMenuItem27,
            this.toolsToolStripMenuItem2,
            this.sizeToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.githubToolStripMenuItem1,
            this.helpToolStripMenuItem1,
            this.closeNotepadToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(189, 178);
            this.NotifyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.NotifyMenu_Opening);
            // 
            // moradiNotepadToolStripMenuItem
            // 
            this.moradiNotepadToolStripMenuItem.Enabled = false;
            this.moradiNotepadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.moradiNotepadToolStripMenuItem.Name = "moradiNotepadToolStripMenuItem";
            this.moradiNotepadToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.moradiNotepadToolStripMenuItem.Text = "Moradi Notepad";
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(185, 6);
            // 
            // toolsToolStripMenuItem2
            // 
            this.toolsToolStripMenuItem2.Enabled = false;
            this.toolsToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.toolsToolStripMenuItem2.Name = "toolsToolStripMenuItem2";
            this.toolsToolStripMenuItem2.Size = new System.Drawing.Size(188, 24);
            this.toolsToolStripMenuItem2.Text = "Tools";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.sizeToolStripMenuItem.Text = "&Size";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.minimizeToolStripMenuItem.Text = "&Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.maximizeToolStripMenuItem.Text = "&Maximize";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem1,
            this.offToolStripMenuItem1});
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.lockToolStripMenuItem.Text = "&Lock Document";
            // 
            // onToolStripMenuItem1
            // 
            this.onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            this.onToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem1.Text = "On";
            this.onToolStripMenuItem1.Click += new System.EventHandler(this.onToolStripMenuItem1_Click);
            // 
            // offToolStripMenuItem1
            // 
            this.offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            this.offToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem1.Text = "Off";
            this.offToolStripMenuItem1.Click += new System.EventHandler(this.offToolStripMenuItem1_Click);
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            this.githubToolStripMenuItem1.Size = new System.Drawing.Size(188, 24);
            this.githubToolStripMenuItem1.Text = "&Github";
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.githubToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(188, 24);
            this.helpToolStripMenuItem1.Text = "&Credits";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // closeNotepadToolStripMenuItem
            // 
            this.closeNotepadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.closeNotepadToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.closeNotepadToolStripMenuItem.Name = "closeNotepadToolStripMenuItem";
            this.closeNotepadToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.closeNotepadToolStripMenuItem.Text = "&Close Notepad";
            this.closeNotepadToolStripMenuItem.Click += new System.EventHandler(this.closeNotepadToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.themesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newTabToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.restartSoftwareToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.addSignaturesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.insertToolStripMenuItem,
            this.toolStripMenuItem3,
            this.clockToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.toolsToolStripMenuItem.Text = "&Format";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(155, 6);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pronounceThatWordToolStripMenuItem,
            this.readCurrentDocumentToolStripMenuItem,
            this.moradiHintsToolStripMenuItem,
            this.toolStripMenuItem7});
            this.toolsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // moradiHintsToolStripMenuItem
            // 
            this.moradiHintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem2,
            this.offToolStripMenuItem2});
            this.moradiHintsToolStripMenuItem.Name = "moradiHintsToolStripMenuItem";
            this.moradiHintsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.moradiHintsToolStripMenuItem.Text = "Moradi Hints";
            // 
            // onToolStripMenuItem2
            // 
            this.onToolStripMenuItem2.Name = "onToolStripMenuItem2";
            this.onToolStripMenuItem2.Size = new System.Drawing.Size(93, 22);
            this.onToolStripMenuItem2.Text = "On";
            this.onToolStripMenuItem2.Click += new System.EventHandler(this.onToolStripMenuItem2_Click);
            // 
            // offToolStripMenuItem2
            // 
            this.offToolStripMenuItem2.Name = "offToolStripMenuItem2";
            this.offToolStripMenuItem2.Size = new System.Drawing.Size(93, 22);
            this.offToolStripMenuItem2.Text = "Off";
            this.offToolStripMenuItem2.Click += new System.EventHandler(this.offToolStripMenuItem2_Click);
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.halloweenToolStripMenuItem,
            this.windowsNotepadThemeToolStripMenuItem});
            this.themesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.themesToolStripMenuItem.Text = "&Themes";
            this.themesToolStripMenuItem.MouseHover += new System.EventHandler(this.themesToolStripMenuItem_MouseHover);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.gitHubToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(125, 6);
            // 
            // ubuntuControlBox1
            // 
            this.ubuntuControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubuntuControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ubuntuControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.ubuntuControlBox1.Location = new System.Drawing.Point(1130, 2);
            this.ubuntuControlBox1.Name = "ubuntuControlBox1";
            this.ubuntuControlBox1.Size = new System.Drawing.Size(75, 23);
            this.ubuntuControlBox1.TabIndex = 0;
            this.ubuntuControlBox1.Text = "ubuntuControlBox1";
            this.ubuntuControlBox1.Click += new System.EventHandler(this.ubuntuControlBox1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold1,
            this.Italic1,
            this.Underline1,
            this.StrikeThrough1,
            this.toolStripSeparator6,
            this.CaseCap,
            this.CaseLowercase,
            this.toolStripSeparator7,
            this.Fontincrease,
            this.Fontdecrease,
            this.toolStripSeparator8,
            this.BackColor,
            this.Forcolor,
            this.Highlighter,
            this.toolStripSeparator9,
            this.NumbLine,
            this.HideNumbline});
            this.toolStrip1.Location = new System.Drawing.Point(472, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(372, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDoc,
            this.OpenDoc,
            this.SaveDoc,
            this.PrintDoc,
            this.InsertImage});
            this.toolStrip2.Location = new System.Drawing.Point(303, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(132, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(1024, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "00:00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(998, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FindText
            // 
            this.FindText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindText.BackColor = System.Drawing.Color.Black;
            this.FindText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindText.Font = new System.Drawing.Font("Arial Narrow", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindText.ForeColor = System.Drawing.Color.Red;
            this.FindText.Location = new System.Drawing.Point(1155, 51);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(42, 24);
            this.FindText.TabIndex = 11;
            this.FindText.Text = "Find";
            this.FindText.UseVisualStyleBackColor = false;
            this.FindText.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Navy;
            this.output.Location = new System.Drawing.Point(135, 714);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(41, 15);
            this.output.TabIndex = 12;
            this.output.Text = "Char:";
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator10,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator11,
            this.helpToolStripButton,
            this.toolStripSeparator12,
            this.Font_style,
            this.FontSize,
            this.toolStripSeparator13,
            this.undo,
            this.redo,
            this.toolStripSeparator14,
            this.LockDoc,
            this.UnlockDoc,
            this.toolStripSeparator15,
            this.MicOn,
            this.MicOff});
            this.toolStrip3.Location = new System.Drawing.Point(1, 51);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(437, 27);
            this.toolStrip3.TabIndex = 13;
            this.toolStrip3.Text = "Lock Document";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // FontSize
            // 
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(92, 27);
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged_1);
            this.FontSize.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 27);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(1078, 711);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(119, 19);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // infolabel
            // 
            this.infolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.White;
            this.infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.Color.Navy;
            this.infolabel.Location = new System.Drawing.Point(3, 714);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(43, 13);
            this.infolabel.TabIndex = 15;
            this.infolabel.Text = "Ready";
            // 
            // lines
            // 
            this.lines.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lines.AutoSize = true;
            this.lines.BackColor = System.Drawing.Color.Transparent;
            this.lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lines.ForeColor = System.Drawing.Color.Navy;
            this.lines.Location = new System.Drawing.Point(248, 716);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(41, 13);
            this.lines.TabIndex = 17;
            this.lines.Text = "Lines:";
            this.lines.Click += new System.EventHandler(this.lines_Click);
            // 
            // ubuntuTheme1
            // 
            this.ubuntuTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ubuntuTheme1.Controls.Add(this.tabControl1);
            this.ubuntuTheme1.Controls.Add(this.WelcomeBack);
            this.ubuntuTheme1.Controls.Add(this.OpacityControl);
            this.ubuntuTheme1.Controls.Add(this.metroTrackBar1);
            this.ubuntuTheme1.Controls.Add(this.lines);
            this.ubuntuTheme1.Controls.Add(this.pictureBox1);
            this.ubuntuTheme1.Controls.Add(this.infolabel);
            this.ubuntuTheme1.Controls.Add(this.trackBar1);
            this.ubuntuTheme1.Controls.Add(this.toolStrip3);
            this.ubuntuTheme1.Controls.Add(this.output);
            this.ubuntuTheme1.Controls.Add(this.FindText);
            this.ubuntuTheme1.Controls.Add(this.textBox1);
            this.ubuntuTheme1.Controls.Add(this.label1);
            this.ubuntuTheme1.Controls.Add(this.lineNumbers_For_RichTextBox2);
            this.ubuntuTheme1.Controls.Add(this.toolStrip2);
            this.ubuntuTheme1.Controls.Add(this.toolStrip1);
            this.ubuntuTheme1.Controls.Add(this.ubuntuControlBox1);
            this.ubuntuTheme1.Controls.Add(this.menuStrip1);
            this.ubuntuTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ubuntuTheme1.Location = new System.Drawing.Point(0, 0);
            this.ubuntuTheme1.Name = "ubuntuTheme1";
            this.ubuntuTheme1.Size = new System.Drawing.Size(1200, 731);
            this.ubuntuTheme1.TabIndex = 0;
            this.ubuntuTheme1.Text = "Moradi Notepad | Moradi OS Development";
            this.ubuntuTheme1.Click += new System.EventHandler(this.ubuntuTheme1_Click);
            this.ubuntuTheme1.Enter += new System.EventHandler(this.ubuntuTheme1_Enter);
            this.ubuntuTheme1.Resize += new System.EventHandler(this.ubuntuTheme1_Resize);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 625);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.MoradiHint);
            this.tabPage1.Controls.Add(this.dancingpencil);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // MoradiHint
            // 
            this.MoradiHint.AutoSize = true;
            this.MoradiHint.BackColor = System.Drawing.Color.Black;
            this.MoradiHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoradiHint.ForeColor = System.Drawing.Color.Lime;
            this.MoradiHint.Location = new System.Drawing.Point(693, 302);
            this.MoradiHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoradiHint.Name = "MoradiHint";
            this.MoradiHint.Size = new System.Drawing.Size(295, 34);
            this.MoradiHint.TabIndex = 20;
            this.MoradiHint.Text = "HEY! Im Moradi Pencil, Try Our New Feature: \r\nVoice To Text, Its Truley Awesome";
            this.MoradiHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoradiHint.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(0, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1183, 598);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Start Typing Here . . .";
            this.richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.richTextBox1.SizeChanged += new System.EventHandler(this.richTextBox1_SizeChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // WelcomeBack
            // 
            this.WelcomeBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WelcomeBack.AutoSize = true;
            this.WelcomeBack.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeBack.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBack.ForeColor = System.Drawing.Color.Red;
            this.WelcomeBack.Location = new System.Drawing.Point(445, 714);
            this.WelcomeBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBack.Name = "WelcomeBack";
            this.WelcomeBack.Size = new System.Drawing.Size(100, 15);
            this.WelcomeBack.TabIndex = 23;
            this.WelcomeBack.Text = "Welcome Back:";
            // 
            // OpacityControl
            // 
            this.OpacityControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpacityControl.AutoSize = true;
            this.OpacityControl.BackColor = System.Drawing.Color.Transparent;
            this.OpacityControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpacityControl.ForeColor = System.Drawing.Color.Navy;
            this.OpacityControl.Location = new System.Drawing.Point(815, 714);
            this.OpacityControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OpacityControl.Name = "OpacityControl";
            this.OpacityControl.Size = new System.Drawing.Size(50, 13);
            this.OpacityControl.TabIndex = 22;
            this.OpacityControl.Text = "Opacity";
            this.OpacityControl.Click += new System.EventHandler(this.OpacityControl_Click);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(875, 711);
            this.metroTrackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTrackBar1.Minimum = 40;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(159, 19);
            this.metroTrackBar1.TabIndex = 21;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar1.Value = 100;
            // 
            // FontTimer
            // 
            this.FontTimer.Enabled = true;
            this.FontTimer.Interval = 1000;
            this.FontTimer.Tick += new System.EventHandler(this.FontTimer_Tick);
            // 
            // MessageBoxPerMin
            // 
            this.MessageBoxPerMin.Enabled = true;
            this.MessageBoxPerMin.Interval = 1000;
            this.MessageBoxPerMin.Tick += new System.EventHandler(this.MessageBoxPerMin_Tick);
            // 
            // Opacity
            // 
            this.Opacity.Enabled = true;
            this.Opacity.Interval = 500;
            this.Opacity.Tick += new System.EventHandler(this.Opacity_Tick);
            // 
            // dancingpencil
            // 
            this.dancingpencil.BackColor = System.Drawing.Color.Black;
            this.dancingpencil.Image = global::Moradi_Notepad.Properties.Resources.danicingpencil;
            this.dancingpencil.Location = new System.Drawing.Point(765, 83);
            this.dancingpencil.Margin = new System.Windows.Forms.Padding(2);
            this.dancingpencil.Name = "dancingpencil";
            this.dancingpencil.Size = new System.Drawing.Size(100, 200);
            this.dancingpencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dancingpencil.TabIndex = 18;
            this.dancingpencil.TabStop = false;
            this.dancingpencil.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Moradi_Notepad.Properties.Resources.sound;
            this.pictureBox1.Location = new System.Drawing.Point(934, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = global::Moradi_Notepad.Properties.Resources.icon_left_text_theme_action_alignment_align;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton13.Text = "Left";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click_1);
            this.toolStripButton13.MouseLeave += new System.EventHandler(this.toolStripButton13_MouseLeave);
            this.toolStripButton13.MouseHover += new System.EventHandler(this.toolStripButton13_MouseHover);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = global::Moradi_Notepad.Properties.Resources.center;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton14.Text = "Center";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            this.toolStripButton14.MouseLeave += new System.EventHandler(this.toolStripButton14_MouseLeave);
            this.toolStripButton14.MouseHover += new System.EventHandler(this.toolStripButton14_MouseHover);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = global::Moradi_Notepad.Properties.Resources.text_27924_960_720;
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton15.Text = "Right";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            this.toolStripButton15.MouseLeave += new System.EventHandler(this.toolStripButton15_MouseLeave);
            this.toolStripButton15.MouseHover += new System.EventHandler(this.toolStripButton15_MouseHover);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kToolStripMenuItem});
            this.helpToolStripButton.Image = global::Moradi_Notepad.Properties.Resources.bullets;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(33, 24);
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            this.helpToolStripButton.MouseLeave += new System.EventHandler(this.helpToolStripButton_MouseLeave);
            this.helpToolStripButton.MouseHover += new System.EventHandler(this.helpToolStripButton_MouseHover);
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.black_dot_md1;
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.ShowShortcutKeys = false;
            this.kToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.kToolStripMenuItem.Text = "Dot";
            this.kToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // Font_style
            // 
            this.Font_style.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Font_style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arielToolStripMenuItem,
            this.algerianToolStripMenuItem,
            this.aRCHRISTYToolStripMenuItem,
            this.aRDELANEYToolStripMenuItem,
            this.aRDESTINEToolStripMenuItem,
            this.castellarToolStripMenuItem,
            this.digitalReadoutUprightToolStripMenuItem,
            this.georgiaToolStripMenuItem,
            this.jokermanToolStripMenuItem,
            this.lucidaHandwritingToolStripMenuItem,
            this.microsoftSansSerifToolStripMenuItem,
            this.modernNo20ToolStripMenuItem,
            this.smallFontsToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem});
            this.Font_style.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Font_style.Image = ((System.Drawing.Image)(resources.GetObject("Font_style.Image")));
            this.Font_style.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Font_style.Name = "Font_style";
            this.Font_style.Size = new System.Drawing.Size(46, 24);
            this.Font_style.Text = "Ariel";
            this.Font_style.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // arielToolStripMenuItem
            // 
            this.arielToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.arielToolStripMenuItem.Name = "arielToolStripMenuItem";
            this.arielToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.arielToolStripMenuItem.Text = "Ariel";
            this.arielToolStripMenuItem.Click += new System.EventHandler(this.arielToolStripMenuItem_Click);
            // 
            // algerianToolStripMenuItem
            // 
            this.algerianToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold);
            this.algerianToolStripMenuItem.Name = "algerianToolStripMenuItem";
            this.algerianToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.algerianToolStripMenuItem.Text = "Algerian";
            this.algerianToolStripMenuItem.Click += new System.EventHandler(this.algerianToolStripMenuItem_Click);
            // 
            // aRCHRISTYToolStripMenuItem
            // 
            this.aRCHRISTYToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.aRCHRISTYToolStripMenuItem.Name = "aRCHRISTYToolStripMenuItem";
            this.aRCHRISTYToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aRCHRISTYToolStripMenuItem.Text = "AR CHRISTY";
            this.aRCHRISTYToolStripMenuItem.Click += new System.EventHandler(this.aRCHRISTYToolStripMenuItem_Click);
            // 
            // aRDELANEYToolStripMenuItem
            // 
            this.aRDELANEYToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.aRDELANEYToolStripMenuItem.Name = "aRDELANEYToolStripMenuItem";
            this.aRDELANEYToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aRDELANEYToolStripMenuItem.Text = "AR DELANEY";
            this.aRDELANEYToolStripMenuItem.Click += new System.EventHandler(this.aRDELANEYToolStripMenuItem_Click);
            // 
            // aRDESTINEToolStripMenuItem
            // 
            this.aRDESTINEToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.aRDESTINEToolStripMenuItem.Name = "aRDESTINEToolStripMenuItem";
            this.aRDESTINEToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aRDESTINEToolStripMenuItem.Text = "AR DESTINE";
            this.aRDESTINEToolStripMenuItem.Click += new System.EventHandler(this.aRDESTINEToolStripMenuItem_Click);
            // 
            // castellarToolStripMenuItem
            // 
            this.castellarToolStripMenuItem.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold);
            this.castellarToolStripMenuItem.Name = "castellarToolStripMenuItem";
            this.castellarToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.castellarToolStripMenuItem.Text = "Castellar";
            this.castellarToolStripMenuItem.Click += new System.EventHandler(this.castellarToolStripMenuItem_Click);
            // 
            // digitalReadoutUprightToolStripMenuItem
            // 
            this.digitalReadoutUprightToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.digitalReadoutUprightToolStripMenuItem.Name = "digitalReadoutUprightToolStripMenuItem";
            this.digitalReadoutUprightToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.digitalReadoutUprightToolStripMenuItem.Text = "Digital Readout Upright";
            this.digitalReadoutUprightToolStripMenuItem.Click += new System.EventHandler(this.digitalReadoutUprightToolStripMenuItem_Click);
            // 
            // georgiaToolStripMenuItem
            // 
            this.georgiaToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
            this.georgiaToolStripMenuItem.Name = "georgiaToolStripMenuItem";
            this.georgiaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.georgiaToolStripMenuItem.Text = "Georgia";
            this.georgiaToolStripMenuItem.Click += new System.EventHandler(this.georgiaToolStripMenuItem_Click);
            // 
            // jokermanToolStripMenuItem
            // 
            this.jokermanToolStripMenuItem.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold);
            this.jokermanToolStripMenuItem.Name = "jokermanToolStripMenuItem";
            this.jokermanToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.jokermanToolStripMenuItem.Text = "Jokerman";
            this.jokermanToolStripMenuItem.Click += new System.EventHandler(this.jokermanToolStripMenuItem_Click);
            // 
            // lucidaHandwritingToolStripMenuItem
            // 
            this.lucidaHandwritingToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lucidaHandwritingToolStripMenuItem.Name = "lucidaHandwritingToolStripMenuItem";
            this.lucidaHandwritingToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.lucidaHandwritingToolStripMenuItem.Text = "Lucida Handwriting";
            this.lucidaHandwritingToolStripMenuItem.Click += new System.EventHandler(this.lucidaHandwritingToolStripMenuItem_Click);
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            this.microsoftSansSerifToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            this.microsoftSansSerifToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.microsoftSansSerifToolStripMenuItem.Text = "Microsoft Sans Serif";
            this.microsoftSansSerifToolStripMenuItem.Click += new System.EventHandler(this.microsoftSansSerifToolStripMenuItem_Click);
            // 
            // modernNo20ToolStripMenuItem
            // 
            this.modernNo20ToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.modernNo20ToolStripMenuItem.Name = "modernNo20ToolStripMenuItem";
            this.modernNo20ToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.modernNo20ToolStripMenuItem.Text = "Modern No. 20";
            this.modernNo20ToolStripMenuItem.Click += new System.EventHandler(this.modernNo20ToolStripMenuItem_Click);
            // 
            // smallFontsToolStripMenuItem
            // 
            this.smallFontsToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold);
            this.smallFontsToolStripMenuItem.Name = "smallFontsToolStripMenuItem";
            this.smallFontsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.smallFontsToolStripMenuItem.Text = "Stencil";
            this.smallFontsToolStripMenuItem.Click += new System.EventHandler(this.smallFontsToolStripMenuItem_Click);
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // undo
            // 
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Enabled = false;
            this.undo.Image = global::Moradi_Notepad.Properties.Resources.undo;
            this.undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(24, 24);
            this.undo.Text = "Undo";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            this.undo.MouseLeave += new System.EventHandler(this.undo_MouseLeave);
            this.undo.MouseHover += new System.EventHandler(this.undo_MouseHover);
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Enabled = false;
            this.redo.Image = global::Moradi_Notepad.Properties.Resources.redo;
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(24, 24);
            this.redo.Text = "redo";
            this.redo.ToolTipText = "Redo";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            this.redo.MouseLeave += new System.EventHandler(this.redo_MouseLeave);
            this.redo.MouseHover += new System.EventHandler(this.redo_MouseHover);
            // 
            // LockDoc
            // 
            this.LockDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LockDoc.Image = global::Moradi_Notepad.Properties.Resources.locked;
            this.LockDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LockDoc.Name = "LockDoc";
            this.LockDoc.Size = new System.Drawing.Size(24, 24);
            this.LockDoc.Text = "Lock";
            this.LockDoc.ToolTipText = "Lock Document";
            this.LockDoc.Click += new System.EventHandler(this.toolStripButton16_Click);
            this.LockDoc.MouseLeave += new System.EventHandler(this.toolStripButton16_MouseLeave);
            this.LockDoc.MouseHover += new System.EventHandler(this.toolStripButton16_MouseHover);
            // 
            // UnlockDoc
            // 
            this.UnlockDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnlockDoc.Enabled = false;
            this.UnlockDoc.Image = global::Moradi_Notepad.Properties.Resources.unlocked;
            this.UnlockDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnlockDoc.Name = "UnlockDoc";
            this.UnlockDoc.Size = new System.Drawing.Size(24, 24);
            this.UnlockDoc.Text = "Unlock Document";
            this.UnlockDoc.Click += new System.EventHandler(this.toolStripButton17_Click);
            this.UnlockDoc.MouseLeave += new System.EventHandler(this.toolStripButton17_MouseLeave);
            this.UnlockDoc.MouseHover += new System.EventHandler(this.toolStripButton17_MouseHover);
            // 
            // MicOn
            // 
            this.MicOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MicOn.ForeColor = System.Drawing.Color.Black;
            this.MicOn.Image = global::Moradi_Notepad.Properties.Resources.microphone1;
            this.MicOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MicOn.Name = "MicOn";
            this.MicOn.Size = new System.Drawing.Size(24, 24);
            this.MicOn.Text = "Mic On";
            this.MicOn.ToolTipText = "Voice Enabled";
            this.MicOn.Click += new System.EventHandler(this.toolStripButton18_Click_2);
            this.MicOn.MouseLeave += new System.EventHandler(this.toolStripButton18_MouseLeave);
            this.MicOn.MouseHover += new System.EventHandler(this.toolStripButton18_MouseHover);
            // 
            // MicOff
            // 
            this.MicOff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MicOff.Enabled = false;
            this.MicOff.Image = global::Moradi_Notepad.Properties.Resources.no_microphone;
            this.MicOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MicOff.Name = "MicOff";
            this.MicOff.Size = new System.Drawing.Size(24, 24);
            this.MicOff.Text = "Mic Off";
            this.MicOff.ToolTipText = "Voice Disabled";
            this.MicOff.Click += new System.EventHandler(this.toolStripButton20_Click_1);
            this.MicOff.MouseLeave += new System.EventHandler(this.toolStripButton20_MouseLeave);
            this.MicOff.MouseHover += new System.EventHandler(this.toolStripButton20_MouseHover);
            // 
            // NewDoc
            // 
            this.NewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewDoc.Image = ((System.Drawing.Image)(resources.GetObject("NewDoc.Image")));
            this.NewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewDoc.Name = "NewDoc";
            this.NewDoc.Size = new System.Drawing.Size(24, 24);
            this.NewDoc.Text = "toolStripButton1";
            this.NewDoc.ToolTipText = "New File";
            this.NewDoc.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            this.NewDoc.MouseLeave += new System.EventHandler(this.toolStripButton1_MouseLeave);
            this.NewDoc.MouseHover += new System.EventHandler(this.toolStripButton1_MouseHover);
            // 
            // OpenDoc
            // 
            this.OpenDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("OpenDoc.Image")));
            this.OpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenDoc.Name = "OpenDoc";
            this.OpenDoc.Size = new System.Drawing.Size(24, 24);
            this.OpenDoc.Text = "toolStripButton10";
            this.OpenDoc.ToolTipText = "Open File";
            this.OpenDoc.Click += new System.EventHandler(this.toolStripButton10_Click);
            this.OpenDoc.MouseLeave += new System.EventHandler(this.toolStripButton10_MouseLeave);
            this.OpenDoc.MouseHover += new System.EventHandler(this.toolStripButton10_MouseHover);
            // 
            // SaveDoc
            // 
            this.SaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveDoc.Image = global::Moradi_Notepad.Properties.Resources.save;
            this.SaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveDoc.Name = "SaveDoc";
            this.SaveDoc.Size = new System.Drawing.Size(24, 24);
            this.SaveDoc.Text = "Save";
            this.SaveDoc.Click += new System.EventHandler(this.toolStripButton21_Click);
            // 
            // PrintDoc
            // 
            this.PrintDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintDoc.Image = global::Moradi_Notepad.Properties.Resources.printer;
            this.PrintDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintDoc.Name = "PrintDoc";
            this.PrintDoc.Size = new System.Drawing.Size(24, 24);
            this.PrintDoc.Text = "Print";
            this.PrintDoc.Click += new System.EventHandler(this.toolStripButton22_Click_1);
            // 
            // InsertImage
            // 
            this.InsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertImage.Image = global::Moradi_Notepad.Properties.Resources.images;
            this.InsertImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(24, 24);
            this.InsertImage.Text = "Import Image";
            this.InsertImage.Click += new System.EventHandler(this.toolStripButton19_Click);
            // 
            // Bold1
            // 
            this.Bold1.CheckOnClick = true;
            this.Bold1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bold1.DoubleClickEnabled = true;
            this.Bold1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Bold1.Image = ((System.Drawing.Image)(resources.GetObject("Bold1.Image")));
            this.Bold1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold1.Name = "Bold1";
            this.Bold1.Size = new System.Drawing.Size(23, 24);
            this.Bold1.Text = "B";
            this.Bold1.ToolTipText = "Bold";
            this.Bold1.Click += new System.EventHandler(this.B_Click);
            this.Bold1.MouseLeave += new System.EventHandler(this.B_MouseLeave);
            this.Bold1.MouseHover += new System.EventHandler(this.B_MouseHover);
            // 
            // Italic1
            // 
            this.Italic1.CheckOnClick = true;
            this.Italic1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Italic1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Italic1.Image = ((System.Drawing.Image)(resources.GetObject("Italic1.Image")));
            this.Italic1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic1.Name = "Italic1";
            this.Italic1.Size = new System.Drawing.Size(23, 24);
            this.Italic1.Text = "I";
            this.Italic1.ToolTipText = "Italic";
            this.Italic1.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.Italic1.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);
            this.Italic1.MouseHover += new System.EventHandler(this.toolStripButton2_MouseHover);
            // 
            // Underline1
            // 
            this.Underline1.CheckOnClick = true;
            this.Underline1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Underline1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Underline1.Image = ((System.Drawing.Image)(resources.GetObject("Underline1.Image")));
            this.Underline1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline1.Name = "Underline1";
            this.Underline1.Size = new System.Drawing.Size(23, 24);
            this.Underline1.Text = "U";
            this.Underline1.ToolTipText = "Underline";
            this.Underline1.Click += new System.EventHandler(this.toolStripButton3_Click);
            this.Underline1.MouseLeave += new System.EventHandler(this.toolStripButton3_MouseLeave);
            this.Underline1.MouseHover += new System.EventHandler(this.toolStripButton3_MouseHover);
            // 
            // StrikeThrough1
            // 
            this.StrikeThrough1.CheckOnClick = true;
            this.StrikeThrough1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StrikeThrough1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.StrikeThrough1.Image = ((System.Drawing.Image)(resources.GetObject("StrikeThrough1.Image")));
            this.StrikeThrough1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StrikeThrough1.Name = "StrikeThrough1";
            this.StrikeThrough1.Size = new System.Drawing.Size(23, 24);
            this.StrikeThrough1.Text = "S";
            this.StrikeThrough1.ToolTipText = "Strikethrough";
            this.StrikeThrough1.Click += new System.EventHandler(this.toolStripButton4_Click);
            this.StrikeThrough1.MouseLeave += new System.EventHandler(this.toolStripButton4_MouseLeave);
            this.StrikeThrough1.MouseHover += new System.EventHandler(this.toolStripButton4_MouseHover);
            // 
            // CaseCap
            // 
            this.CaseCap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CaseCap.Image = ((System.Drawing.Image)(resources.GetObject("CaseCap.Image")));
            this.CaseCap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CaseCap.Name = "CaseCap";
            this.CaseCap.Size = new System.Drawing.Size(23, 24);
            this.CaseCap.Text = "A";
            this.CaseCap.ToolTipText = "Case CAP";
            this.CaseCap.Click += new System.EventHandler(this.toolStripButton5_Click);
            this.CaseCap.MouseLeave += new System.EventHandler(this.toolStripButton5_MouseLeave);
            this.CaseCap.MouseHover += new System.EventHandler(this.toolStripButton5_MouseHover);
            // 
            // CaseLowercase
            // 
            this.CaseLowercase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CaseLowercase.Image = ((System.Drawing.Image)(resources.GetObject("CaseLowercase.Image")));
            this.CaseLowercase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CaseLowercase.Name = "CaseLowercase";
            this.CaseLowercase.Size = new System.Drawing.Size(23, 24);
            this.CaseLowercase.Text = "a";
            this.CaseLowercase.ToolTipText = "Case Lowercase";
            this.CaseLowercase.Click += new System.EventHandler(this.toolStripButton6_Click);
            this.CaseLowercase.MouseLeave += new System.EventHandler(this.toolStripButton6_MouseLeave);
            this.CaseLowercase.MouseHover += new System.EventHandler(this.toolStripButton6_MouseHover);
            // 
            // Fontincrease
            // 
            this.Fontincrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Fontincrease.Image = ((System.Drawing.Image)(resources.GetObject("Fontincrease.Image")));
            this.Fontincrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fontincrease.Name = "Fontincrease";
            this.Fontincrease.Size = new System.Drawing.Size(27, 24);
            this.Fontincrease.Text = "A+";
            this.Fontincrease.ToolTipText = "Increase Text Size";
            this.Fontincrease.Click += new System.EventHandler(this.toolStripButton7_Click);
            this.Fontincrease.MouseLeave += new System.EventHandler(this.toolStripButton7_MouseLeave);
            this.Fontincrease.MouseHover += new System.EventHandler(this.toolStripButton7_MouseHover);
            // 
            // Fontdecrease
            // 
            this.Fontdecrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Fontdecrease.Image = ((System.Drawing.Image)(resources.GetObject("Fontdecrease.Image")));
            this.Fontdecrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fontdecrease.Name = "Fontdecrease";
            this.Fontdecrease.Size = new System.Drawing.Size(24, 24);
            this.Fontdecrease.Text = "A-";
            this.Fontdecrease.ToolTipText = "Decrease Text Size";
            this.Fontdecrease.Click += new System.EventHandler(this.toolStripButton8_Click);
            this.Fontdecrease.MouseLeave += new System.EventHandler(this.toolStripButton8_MouseLeave);
            this.Fontdecrease.MouseHover += new System.EventHandler(this.toolStripButton8_MouseHover);
            // 
            // BackColor
            // 
            this.BackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blackThemeToolStripMenuItem,
            this.navyBackgroundToolStripMenuItem,
            this.limeBackgroundToolStripMenuItem,
            this.otherColorToolStripMenuItem});
            this.BackColor.Image = ((System.Drawing.Image)(resources.GetObject("BackColor.Image")));
            this.BackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(33, 24);
            this.BackColor.Text = "Background Color";
            this.BackColor.Click += new System.EventHandler(this.toolStripButton9_Click);
            this.BackColor.MouseLeave += new System.EventHandler(this.toolStripButton9_MouseLeave);
            this.BackColor.MouseHover += new System.EventHandler(this.toolStripButton9_MouseHover);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.redToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.redToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.imageedit_24_8334251899;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.redToolStripMenuItem.Text = "Red Background";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blackThemeToolStripMenuItem
            // 
            this.blackThemeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.blackThemeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.blackThemeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.blackThemeToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.black_dot_md;
            this.blackThemeToolStripMenuItem.Name = "blackThemeToolStripMenuItem";
            this.blackThemeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.blackThemeToolStripMenuItem.Text = "Black Background";
            this.blackThemeToolStripMenuItem.Click += new System.EventHandler(this.blackThemeToolStripMenuItem_Click);
            // 
            // navyBackgroundToolStripMenuItem
            // 
            this.navyBackgroundToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.navyBackgroundToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.navyBackgroundToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.navyBackgroundToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.blue_dot_md;
            this.navyBackgroundToolStripMenuItem.Name = "navyBackgroundToolStripMenuItem";
            this.navyBackgroundToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.navyBackgroundToolStripMenuItem.Text = "Navy Background";
            this.navyBackgroundToolStripMenuItem.Click += new System.EventHandler(this.navyBackgroundToolStripMenuItem_Click);
            // 
            // limeBackgroundToolStripMenuItem
            // 
            this.limeBackgroundToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.limeBackgroundToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.limeBackgroundToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.limeBackgroundToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.neon_green_dot_hi;
            this.limeBackgroundToolStripMenuItem.Name = "limeBackgroundToolStripMenuItem";
            this.limeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.limeBackgroundToolStripMenuItem.Text = "Lime Background";
            this.limeBackgroundToolStripMenuItem.Click += new System.EventHandler(this.limeBackgroundToolStripMenuItem_Click);
            // 
            // otherColorToolStripMenuItem
            // 
            this.otherColorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.otherColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.otherColorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.otherColorToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.Color_wheel;
            this.otherColorToolStripMenuItem.Name = "otherColorToolStripMenuItem";
            this.otherColorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.otherColorToolStripMenuItem.Text = "Other Color";
            this.otherColorToolStripMenuItem.Click += new System.EventHandler(this.otherColorToolStripMenuItem_Click);
            // 
            // Forcolor
            // 
            this.Forcolor.BackColor = System.Drawing.Color.White;
            this.Forcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Forcolor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.blueTextToolStripMenuItem,
            this.limeTextToolStripMenuItem,
            this.yellowTextToolStripMenuItem,
            this.purpleTextToolStripMenuItem,
            this.otherColorToolStripMenuItem1});
            this.Forcolor.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forcolor.Image = global::Moradi_Notepad.Properties.Resources.Hopstarter_Scrap_Pen;
            this.Forcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forcolor.Name = "Forcolor";
            this.Forcolor.Size = new System.Drawing.Size(33, 24);
            this.Forcolor.Text = "Text Color";
            this.Forcolor.ToolTipText = "Text Color";
            this.Forcolor.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            this.Forcolor.MouseLeave += new System.EventHandler(this.toolStripDropDownButton1_MouseLeave);
            this.Forcolor.MouseHover += new System.EventHandler(this.toolStripDropDownButton1_MouseHover);
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.redToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem1.Image = global::Moradi_Notepad.Properties.Resources.imageedit_24_8334251899;
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.redToolStripMenuItem1.Text = "Red | Text";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // blueTextToolStripMenuItem
            // 
            this.blueTextToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.blueTextToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueTextToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.blueTextToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.blue_dot_md;
            this.blueTextToolStripMenuItem.Name = "blueTextToolStripMenuItem";
            this.blueTextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.blueTextToolStripMenuItem.Text = "Blue | Text";
            this.blueTextToolStripMenuItem.Click += new System.EventHandler(this.blueTextToolStripMenuItem_Click);
            // 
            // limeTextToolStripMenuItem
            // 
            this.limeTextToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.limeTextToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limeTextToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.limeTextToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.neon_green_dot_hi;
            this.limeTextToolStripMenuItem.Name = "limeTextToolStripMenuItem";
            this.limeTextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.limeTextToolStripMenuItem.Text = "Lime | Text";
            this.limeTextToolStripMenuItem.Click += new System.EventHandler(this.limeTextToolStripMenuItem_Click);
            // 
            // yellowTextToolStripMenuItem
            // 
            this.yellowTextToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.yellowTextToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowTextToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.yellowTextToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.yellow_dot_md;
            this.yellowTextToolStripMenuItem.Name = "yellowTextToolStripMenuItem";
            this.yellowTextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.yellowTextToolStripMenuItem.Text = "Yellow | Text";
            this.yellowTextToolStripMenuItem.Click += new System.EventHandler(this.yellowTextToolStripMenuItem_Click);
            // 
            // purpleTextToolStripMenuItem
            // 
            this.purpleTextToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.purpleTextToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpleTextToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.purpleTextToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.Location_dot_purple_svg;
            this.purpleTextToolStripMenuItem.Name = "purpleTextToolStripMenuItem";
            this.purpleTextToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.purpleTextToolStripMenuItem.Text = "Purple | Text";
            this.purpleTextToolStripMenuItem.Click += new System.EventHandler(this.purpleTextToolStripMenuItem_Click);
            // 
            // otherColorToolStripMenuItem1
            // 
            this.otherColorToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.otherColorToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherColorToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.otherColorToolStripMenuItem1.Image = global::Moradi_Notepad.Properties.Resources.Color_wheel;
            this.otherColorToolStripMenuItem1.Name = "otherColorToolStripMenuItem1";
            this.otherColorToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.otherColorToolStripMenuItem1.Text = "Other Color";
            this.otherColorToolStripMenuItem1.Click += new System.EventHandler(this.otherColorToolStripMenuItem1_Click);
            // 
            // Highlighter
            // 
            this.Highlighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Highlighter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transeparentToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.limeToolStripMenuItem1,
            this.lightBlueToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.nONEToolStripMenuItem});
            this.Highlighter.ForeColor = System.Drawing.Color.White;
            this.Highlighter.Image = global::Moradi_Notepad.Properties.Resources.Text_x_generic_highlight_yellow_pen;
            this.Highlighter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Highlighter.Name = "Highlighter";
            this.Highlighter.Size = new System.Drawing.Size(33, 24);
            this.Highlighter.Text = "HighLighter";
            this.Highlighter.ToolTipText = "Highlight Text";
            this.Highlighter.Click += new System.EventHandler(this.Highlighter_Click);
            // 
            // transeparentToolStripMenuItem
            // 
            this.transeparentToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.transeparentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.transeparentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transeparentToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.black_dot_md;
            this.transeparentToolStripMenuItem.Name = "transeparentToolStripMenuItem";
            this.transeparentToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.transeparentToolStripMenuItem.Text = "Black";
            this.transeparentToolStripMenuItem.Click += new System.EventHandler(this.transeparentToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.yellowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.yellowToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.yellowToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.yellow_dot_md;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // limeToolStripMenuItem1
            // 
            this.limeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.limeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.limeToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.limeToolStripMenuItem1.Image = global::Moradi_Notepad.Properties.Resources.neon_green_dot_hi;
            this.limeToolStripMenuItem1.Name = "limeToolStripMenuItem1";
            this.limeToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.limeToolStripMenuItem1.Text = "Lime";
            this.limeToolStripMenuItem1.Click += new System.EventHandler(this.limeToolStripMenuItem1_Click);
            // 
            // lightBlueToolStripMenuItem
            // 
            this.lightBlueToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.lightBlueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lightBlueToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.lightBlueToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.blue_dot_md;
            this.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
            this.lightBlueToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.lightBlueToolStripMenuItem.Text = "Light Blue";
            this.lightBlueToolStripMenuItem.Click += new System.EventHandler(this.lightBlueToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.whiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.whiteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.whiteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("whiteToolStripMenuItem.Image")));
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.otherToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.otherToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.Color_wheel;
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.otherToolStripMenuItem.Text = "Other Color";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // nONEToolStripMenuItem
            // 
            this.nONEToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.nONEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nONEToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.nONEToolStripMenuItem.Name = "nONEToolStripMenuItem";
            this.nONEToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.nONEToolStripMenuItem.Text = "CLEAR HIGHLIGHT";
            this.nONEToolStripMenuItem.Click += new System.EventHandler(this.nONEToolStripMenuItem_Click);
            // 
            // NumbLine
            // 
            this.NumbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NumbLine.Enabled = false;
            this.NumbLine.Image = ((System.Drawing.Image)(resources.GetObject("NumbLine.Image")));
            this.NumbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NumbLine.Name = "NumbLine";
            this.NumbLine.Size = new System.Drawing.Size(24, 24);
            this.NumbLine.Text = "Show Line Number";
            this.NumbLine.Click += new System.EventHandler(this.toolStripButton11_Click);
            this.NumbLine.MouseLeave += new System.EventHandler(this.toolStripButton11_MouseLeave);
            this.NumbLine.MouseHover += new System.EventHandler(this.toolStripButton11_MouseHover);
            // 
            // HideNumbline
            // 
            this.HideNumbline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HideNumbline.Enabled = false;
            this.HideNumbline.Image = ((System.Drawing.Image)(resources.GetObject("HideNumbline.Image")));
            this.HideNumbline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HideNumbline.Name = "HideNumbline";
            this.HideNumbline.Size = new System.Drawing.Size(24, 24);
            this.HideNumbline.Text = "Hide Line Number";
            this.HideNumbline.Click += new System.EventHandler(this.toolStripButton12_Click);
            this.HideNumbline.MouseLeave += new System.EventHandler(this.toolStripButton12_MouseLeave);
            this.HideNumbline.MouseHover += new System.EventHandler(this.toolStripButton12_MouseHover);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            this.newToolStripMenuItem.MouseLeave += new System.EventHandler(this.newToolStripMenuItem_MouseLeave);
            this.newToolStripMenuItem.MouseHover += new System.EventHandler(this.newToolStripMenuItem_MouseHover);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.openToolStripMenuItem.MouseLeave += new System.EventHandler(this.openToolStripMenuItem_MouseLeave);
            this.openToolStripMenuItem.MouseHover += new System.EventHandler(this.openToolStripMenuItem_MouseHover);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::Moradi_Notepad.Properties.Resources.Treetog_I_Floppy_Small;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.saveToolStripMenuItem.Text = "&Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.saveToolStripMenuItem.MouseLeave += new System.EventHandler(this.saveToolStripMenuItem_MouseLeave);
            this.saveToolStripMenuItem.MouseHover += new System.EventHandler(this.saveToolStripMenuItem_MouseHover);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            this.printToolStripMenuItem.MouseLeave += new System.EventHandler(this.printToolStripMenuItem_MouseLeave);
            this.printToolStripMenuItem.MouseHover += new System.EventHandler(this.printToolStripMenuItem_MouseHover);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.printPreviewToolStripMenuItem.Text = "&Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            this.printPreviewToolStripMenuItem.MouseLeave += new System.EventHandler(this.printPreviewToolStripMenuItem_MouseLeave);
            this.printPreviewToolStripMenuItem.MouseHover += new System.EventHandler(this.printPreviewToolStripMenuItem_MouseHover);
            // 
            // restartSoftwareToolStripMenuItem
            // 
            this.restartSoftwareToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.Recycle001_svg;
            this.restartSoftwareToolStripMenuItem.Name = "restartSoftwareToolStripMenuItem";
            this.restartSoftwareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.restartSoftwareToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.restartSoftwareToolStripMenuItem.Text = "&Restart Software";
            this.restartSoftwareToolStripMenuItem.Click += new System.EventHandler(this.restartSoftwareToolStripMenuItem_Click);
            this.restartSoftwareToolStripMenuItem.MouseLeave += new System.EventHandler(this.restartSoftwareToolStripMenuItem_MouseLeave);
            this.restartSoftwareToolStripMenuItem.MouseHover += new System.EventHandler(this.restartSoftwareToolStripMenuItem_MouseHover);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.mexit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.undoToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            this.undoToolStripMenuItem.MouseLeave += new System.EventHandler(this.undoToolStripMenuItem_MouseLeave);
            this.undoToolStripMenuItem.MouseHover += new System.EventHandler(this.undoToolStripMenuItem_MouseHover);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            this.redoToolStripMenuItem.MouseLeave += new System.EventHandler(this.redoToolStripMenuItem_MouseLeave);
            this.redoToolStripMenuItem.MouseHover += new System.EventHandler(this.redoToolStripMenuItem_MouseHover);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            this.cutToolStripMenuItem.MouseLeave += new System.EventHandler(this.cutToolStripMenuItem_MouseLeave);
            this.cutToolStripMenuItem.MouseHover += new System.EventHandler(this.cutToolStripMenuItem_MouseHover);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            this.copyToolStripMenuItem.MouseLeave += new System.EventHandler(this.copyToolStripMenuItem_MouseLeave);
            this.copyToolStripMenuItem.MouseHover += new System.EventHandler(this.copyToolStripMenuItem_MouseHover);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.MouseLeave += new System.EventHandler(this.pasteToolStripMenuItem_MouseLeave);
            this.pasteToolStripMenuItem.MouseHover += new System.EventHandler(this.pasteToolStripMenuItem_MouseHover);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.select_all;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            this.selectAllToolStripMenuItem.MouseHover += new System.EventHandler(this.selectAllToolStripMenuItem_MouseHover);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.customizeToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.read;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.customizeToolStripMenuItem.Text = "&Font";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            this.customizeToolStripMenuItem.MouseLeave += new System.EventHandler(this.customizeToolStripMenuItem_MouseLeave);
            this.customizeToolStripMenuItem.MouseHover += new System.EventHandler(this.customizeToolStripMenuItem_MouseHover);
            // 
            // addSignaturesToolStripMenuItem
            // 
            this.addSignaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thankYouToolStripMenuItem,
            this.sincerelyToolStripMenuItem,
            this.moradiDevelopmentToolStripMenuItem});
            this.addSignaturesToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources._15_512;
            this.addSignaturesToolStripMenuItem.Name = "addSignaturesToolStripMenuItem";
            this.addSignaturesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addSignaturesToolStripMenuItem.Text = "&Add Signatures";
            this.addSignaturesToolStripMenuItem.Click += new System.EventHandler(this.addSignaturesToolStripMenuItem_Click);
            this.addSignaturesToolStripMenuItem.MouseLeave += new System.EventHandler(this.addSignaturesToolStripMenuItem_MouseLeave);
            this.addSignaturesToolStripMenuItem.MouseHover += new System.EventHandler(this.addSignaturesToolStripMenuItem_MouseHover);
            // 
            // thankYouToolStripMenuItem
            // 
            this.thankYouToolStripMenuItem.Name = "thankYouToolStripMenuItem";
            this.thankYouToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thankYouToolStripMenuItem.Text = "Thank You";
            this.thankYouToolStripMenuItem.Click += new System.EventHandler(this.thankYouToolStripMenuItem_Click);
            // 
            // sincerelyToolStripMenuItem
            // 
            this.sincerelyToolStripMenuItem.Name = "sincerelyToolStripMenuItem";
            this.sincerelyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sincerelyToolStripMenuItem.Text = "Sincerely";
            this.sincerelyToolStripMenuItem.Click += new System.EventHandler(this.sincerelyToolStripMenuItem_Click);
            // 
            // moradiDevelopmentToolStripMenuItem
            // 
            this.moradiDevelopmentToolStripMenuItem.Name = "moradiDevelopmentToolStripMenuItem";
            this.moradiDevelopmentToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.moradiDevelopmentToolStripMenuItem.Text = "Using Moradi Notepad";
            this.moradiDevelopmentToolStripMenuItem.Click += new System.EventHandler(this.moradiDevelopmentToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.insertToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.add_icon___colorful_stickers_set_insert_green_plus_15;
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.insertToolStripMenuItem.Text = "&Insert";
            this.insertToolStripMenuItem.MouseLeave += new System.EventHandler(this.insertToolStripMenuItem_MouseLeave);
            this.insertToolStripMenuItem.MouseHover += new System.EventHandler(this.insertToolStripMenuItem_MouseHover);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dateTimeToolStripMenuItem.Text = "Date/Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // clockToolStripMenuItem
            // 
            this.clockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeColorToolStripMenuItem,
            this.flashingColorsToolStripMenuItem});
            this.clockToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources._4665_200;
            this.clockToolStripMenuItem.Name = "clockToolStripMenuItem";
            this.clockToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clockToolStripMenuItem.Text = "&Clock ";
            this.clockToolStripMenuItem.MouseLeave += new System.EventHandler(this.clockToolStripMenuItem_MouseLeave);
            this.clockToolStripMenuItem.MouseHover += new System.EventHandler(this.clockToolStripMenuItem_MouseHover);
            // 
            // timeColorToolStripMenuItem
            // 
            this.timeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.limeToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem});
            this.timeColorToolStripMenuItem.Name = "timeColorToolStripMenuItem";
            this.timeColorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.timeColorToolStripMenuItem.Text = "Time Color";
            // 
            // redToolStripMenuItem2
            // 
            this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            this.redToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.redToolStripMenuItem2.Text = "Red";
            this.redToolStripMenuItem2.Click += new System.EventHandler(this.redToolStripMenuItem2_Click);
            // 
            // limeToolStripMenuItem
            // 
            this.limeToolStripMenuItem.Name = "limeToolStripMenuItem";
            this.limeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.limeToolStripMenuItem.Text = "Green";
            this.limeToolStripMenuItem.Click += new System.EventHandler(this.limeToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // flashingColorsToolStripMenuItem
            // 
            this.flashingColorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.flashingColorsToolStripMenuItem.Name = "flashingColorsToolStripMenuItem";
            this.flashingColorsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.flashingColorsToolStripMenuItem.Text = "Flashing Colors";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // pronounceThatWordToolStripMenuItem
            // 
            this.pronounceThatWordToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.auto_speaker_1042642_960_720;
            this.pronounceThatWordToolStripMenuItem.Name = "pronounceThatWordToolStripMenuItem";
            this.pronounceThatWordToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.pronounceThatWordToolStripMenuItem.Text = "Word &Pronouncer";
            this.pronounceThatWordToolStripMenuItem.Click += new System.EventHandler(this.pronounceThatWordToolStripMenuItem_Click_1);
            this.pronounceThatWordToolStripMenuItem.MouseLeave += new System.EventHandler(this.pronounceThatWordToolStripMenuItem_MouseLeave);
            this.pronounceThatWordToolStripMenuItem.MouseHover += new System.EventHandler(this.pronounceThatWordToolStripMenuItem_MouseHover);
            // 
            // readCurrentDocumentToolStripMenuItem
            // 
            this.readCurrentDocumentToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.speaknew;
            this.readCurrentDocumentToolStripMenuItem.Name = "readCurrentDocumentToolStripMenuItem";
            this.readCurrentDocumentToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.readCurrentDocumentToolStripMenuItem.Text = "Read &Selected Text";
            this.readCurrentDocumentToolStripMenuItem.Click += new System.EventHandler(this.readCurrentDocumentToolStripMenuItem_Click);
            this.readCurrentDocumentToolStripMenuItem.MouseLeave += new System.EventHandler(this.readCurrentDocumentToolStripMenuItem_MouseLeave);
            this.readCurrentDocumentToolStripMenuItem.MouseHover += new System.EventHandler(this.readCurrentDocumentToolStripMenuItem_MouseHover);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.defaultToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.ABOUT;
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.defaultToolStripMenuItem.Text = "&Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            this.defaultToolStripMenuItem.MouseLeave += new System.EventHandler(this.defaultToolStripMenuItem_MouseLeave);
            this.defaultToolStripMenuItem.MouseHover += new System.EventHandler(this.defaultToolStripMenuItem_MouseHover);
            // 
            // halloweenToolStripMenuItem
            // 
            this.halloweenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.halloweenToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.christmas;
            this.halloweenToolStripMenuItem.Name = "halloweenToolStripMenuItem";
            this.halloweenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.halloweenToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.halloweenToolStripMenuItem.Text = "&Christmas";
            this.halloweenToolStripMenuItem.Click += new System.EventHandler(this.halloweenToolStripMenuItem_Click);
            this.halloweenToolStripMenuItem.MouseLeave += new System.EventHandler(this.halloweenToolStripMenuItem_MouseLeave);
            this.halloweenToolStripMenuItem.MouseHover += new System.EventHandler(this.halloweenToolStripMenuItem_MouseHover);
            // 
            // windowsNotepadThemeToolStripMenuItem
            // 
            this.windowsNotepadThemeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.windowsNotepadThemeToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.notepad_logo;
            this.windowsNotepadThemeToolStripMenuItem.Name = "windowsNotepadThemeToolStripMenuItem";
            this.windowsNotepadThemeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.windowsNotepadThemeToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.windowsNotepadThemeToolStripMenuItem.Text = "&Windows Notepad Theme ";
            this.windowsNotepadThemeToolStripMenuItem.Click += new System.EventHandler(this.windowsNotepadThemeToolStripMenuItem_Click);
            this.windowsNotepadThemeToolStripMenuItem.MouseLeave += new System.EventHandler(this.windowsNotepadThemeToolStripMenuItem_MouseLeave);
            this.windowsNotepadThemeToolStripMenuItem.MouseHover += new System.EventHandler(this.windowsNotepadThemeToolStripMenuItem_MouseHover);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contentsToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.info;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.contentsToolStripMenuItem.Text = "&About";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            this.contentsToolStripMenuItem.MouseLeave += new System.EventHandler(this.contentsToolStripMenuItem_MouseLeave);
            this.contentsToolStripMenuItem.MouseHover += new System.EventHandler(this.contentsToolStripMenuItem_MouseHover);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.Octocat;
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.msn_web_2;
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.creditsToolStripMenuItem.Image = global::Moradi_Notepad.Properties.Resources.credits1;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.creditsToolStripMenuItem.Text = "&Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            this.creditsToolStripMenuItem.MouseLeave += new System.EventHandler(this.creditsToolStripMenuItem_MouseLeave);
            this.creditsToolStripMenuItem.MouseHover += new System.EventHandler(this.creditsToolStripMenuItem_MouseHover);
            // 
            // lineNumbers_For_RichTextBox2
            // 
            this.lineNumbers_For_RichTextBox2._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox2.AutoSizing = true;
            this.lineNumbers_For_RichTextBox2.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox2.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox2.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox2.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox2.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineNumbers_For_RichTextBox2.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox2.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox2.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox2.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox2.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox2.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox2.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox2.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox2.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox2.LineNrs_LeadingZeroes = true;
            this.lineNumbers_For_RichTextBox2.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox2.Location = new System.Drawing.Point(-19, 1);
            this.lineNumbers_For_RichTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox2.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox2.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox2.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox2.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox2.Name = "lineNumbers_For_RichTextBox2";
            this.lineNumbers_For_RichTextBox2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_RichTextBox2.ParentRichTextBox = this.richTextBox1;
            this.lineNumbers_For_RichTextBox2.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox2.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox2.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox2.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox2.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox2.Size = new System.Drawing.Size(18, 598);
            this.lineNumbers_For_RichTextBox2.TabIndex = 7;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(186, 26);
            this.toolStripMenuItem7.Text = "123";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.ubuntuTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moradi Notepad";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FontChanged += new System.EventHandler(this.Form1_FontChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.CopyPaste.ResumeLayout(false);
            this.NotifyMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ubuntuTheme1.ResumeLayout(false);
            this.ubuntuTheme1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dancingpencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer Clocklabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip CopyPaste;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private Timer clock;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem lockDocumentToolStripMenuItem;
        private ToolStripMenuItem unlockDocumentToolStripMenuItem;
        private ToolStripMenuItem readSelectedTextToolStripMenuItem;
        private Timer TextSaveTimer;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip NotifyMenu;
        private ToolStripMenuItem moradiNotepadToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem27;
        private ToolStripMenuItem toolsToolStripMenuItem2;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem lockToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem1;
        private ToolStripMenuItem offToolStripMenuItem1;
        private ToolStripMenuItem githubToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem closeNotepadToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem restartSoftwareToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem addSignaturesToolStripMenuItem;
        private ToolStripMenuItem thankYouToolStripMenuItem;
        private ToolStripMenuItem sincerelyToolStripMenuItem;
        private ToolStripMenuItem moradiDevelopmentToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem clockToolStripMenuItem;
        private ToolStripMenuItem timeColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem2;
        private ToolStripMenuItem limeToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem pinkToolStripMenuItem;
        private ToolStripMenuItem flashingColorsToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem1;
        private ToolStripMenuItem pronounceThatWordToolStripMenuItem;
        private ToolStripMenuItem readCurrentDocumentToolStripMenuItem;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem halloweenToolStripMenuItem;
        private ToolStripMenuItem windowsNotepadThemeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem websiteToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private Ubuntu_Theme.UbuntuControlBox ubuntuControlBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton Bold1;
        private ToolStripButton Italic1;
        private ToolStripButton Underline1;
        private ToolStripButton StrikeThrough1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton CaseCap;
        private ToolStripButton CaseLowercase;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton Fontincrease;
        private ToolStripButton Fontdecrease;
        private ToolStripSeparator toolStripSeparator8;
        private new ToolStripDropDownButton BackColor;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blackThemeToolStripMenuItem;
        private ToolStripMenuItem navyBackgroundToolStripMenuItem;
        private ToolStripMenuItem limeBackgroundToolStripMenuItem;
        private ToolStripMenuItem otherColorToolStripMenuItem;
        private ToolStripDropDownButton Forcolor;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem blueTextToolStripMenuItem;
        private ToolStripMenuItem limeTextToolStripMenuItem;
        private ToolStripMenuItem yellowTextToolStripMenuItem;
        private ToolStripMenuItem purpleTextToolStripMenuItem;
        private ToolStripMenuItem otherColorToolStripMenuItem1;
        private ToolStripDropDownButton Highlighter;
        private ToolStripMenuItem transeparentToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private ToolStripMenuItem limeToolStripMenuItem1;
        private ToolStripMenuItem lightBlueToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem nONEToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton NumbLine;
        private ToolStripButton HideNumbline;
        private ToolStrip toolStrip2;
        private ToolStripButton NewDoc;
        private ToolStripButton OpenDoc;
        private ToolStripButton SaveDoc;
        private ToolStripButton PrintDoc;
        private ToolStripButton InsertImage;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox2;
        private Label label1;
        private TextBox textBox1;
        private Button FindText;
        private Label output;
        private ToolStrip toolStrip3;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton toolStripButton13;
        private ToolStripButton toolStripButton14;
        private ToolStripButton toolStripButton15;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripDropDownButton helpToolStripButton;
        private ToolStripMenuItem kToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripDropDownButton Font_style;
        private ToolStripMenuItem arielToolStripMenuItem;
        private ToolStripMenuItem algerianToolStripMenuItem;
        private ToolStripMenuItem aRCHRISTYToolStripMenuItem;
        private ToolStripMenuItem aRDELANEYToolStripMenuItem;
        private ToolStripMenuItem aRDESTINEToolStripMenuItem;
        private ToolStripMenuItem castellarToolStripMenuItem;
        private ToolStripMenuItem digitalReadoutUprightToolStripMenuItem;
        private ToolStripMenuItem georgiaToolStripMenuItem;
        private ToolStripMenuItem jokermanToolStripMenuItem;
        private ToolStripMenuItem lucidaHandwritingToolStripMenuItem;
        private ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private ToolStripMenuItem modernNo20ToolStripMenuItem;
        private ToolStripMenuItem smallFontsToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton undo;
        private ToolStripButton redo;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton LockDoc;
        private ToolStripButton UnlockDoc;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton MicOn;
        private ToolStripButton MicOff;
        private TrackBar trackBar1;
        private Label infolabel;
        private PictureBox pictureBox1;
        private Label lines;
        public Ubuntu_Theme.UbuntuTheme ubuntuTheme1;
        private Timer FontTimer;
        public ToolStripComboBox FontSize;
        private ToolStripMenuItem moradiHintsToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem2;
        private ToolStripMenuItem offToolStripMenuItem2;
        private Timer MessageBoxPerMin;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
       new private Timer Opacity;
        private Label OpacityControl;
        private Label WelcomeBack;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label MoradiHint;
        private PictureBox dancingpencil;
        public RichTextBox richTextBox1;
        private ToolStripMenuItem toolStripMenuItem7;
    }
}

