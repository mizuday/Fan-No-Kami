﻿
namespace Fan_No_Kami {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_box_isi_file = new System.Windows.Forms.RichTextBox();
            this.dfs_opt = new System.Windows.Forms.RadioButton();
            this.bfs_opt = new System.Windows.Forms.RadioButton();
            this.btn_pilih_file = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_box_namafile = new System.Windows.Forms.RichTextBox();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.txtbox_src = new System.Windows.Forms.TextBox();
            this.txtbox_dest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.Location = new System.Drawing.Point(13, 13);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(280, 73);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "団扇の神";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(421, 135);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(98, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "mulai";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_box_isi_file
            // 
            this.txt_box_isi_file.Location = new System.Drawing.Point(26, 178);
            this.txt_box_isi_file.Name = "txt_box_isi_file";
            this.txt_box_isi_file.Size = new System.Drawing.Size(81, 357);
            this.txt_box_isi_file.TabIndex = 4;
            this.txt_box_isi_file.Text = "";
            // 
            // dfs_opt
            // 
            this.dfs_opt.AutoSize = true;
            this.dfs_opt.Location = new System.Drawing.Point(428, 88);
            this.dfs_opt.Name = "dfs_opt";
            this.dfs_opt.Size = new System.Drawing.Size(46, 17);
            this.dfs_opt.TabIndex = 5;
            this.dfs_opt.TabStop = true;
            this.dfs_opt.Text = "DFS";
            this.dfs_opt.UseVisualStyleBackColor = true;
            // 
            // bfs_opt
            // 
            this.bfs_opt.AutoSize = true;
            this.bfs_opt.Location = new System.Drawing.Point(480, 87);
            this.bfs_opt.Name = "bfs_opt";
            this.bfs_opt.Size = new System.Drawing.Size(45, 17);
            this.bfs_opt.TabIndex = 6;
            this.bfs_opt.TabStop = true;
            this.bfs_opt.Text = "BFS";
            this.bfs_opt.UseVisualStyleBackColor = true;
            // 
            // btn_pilih_file
            // 
            this.btn_pilih_file.Location = new System.Drawing.Point(26, 135);
            this.btn_pilih_file.Name = "btn_pilih_file";
            this.btn_pilih_file.Size = new System.Drawing.Size(96, 26);
            this.btn_pilih_file.TabIndex = 7;
            this.btn_pilih_file.Text = "Pilih File";
            this.btn_pilih_file.UseVisualStyleBackColor = true;
            this.btn_pilih_file.Click += new System.EventHandler(this.btn_pilih_file_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(26, 577);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(81, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_box_namafile
            // 
            this.txt_box_namafile.BackColor = System.Drawing.SystemColors.Control;
            this.txt_box_namafile.Location = new System.Drawing.Point(26, 104);
            this.txt_box_namafile.Multiline = false;
            this.txt_box_namafile.Name = "txt_box_namafile";
            this.txt_box_namafile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txt_box_namafile.Size = new System.Drawing.Size(232, 25);
            this.txt_box_namafile.TabIndex = 9;
            this.txt_box_namafile.Text = "";
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = false;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = false;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(558, 51);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(287, 549);
            this.gViewer1.TabIndex = 10;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            this.gViewer1.Load += new System.EventHandler(this.gViewer1_Load);
            // 
            // txtbox_src
            // 
            this.txtbox_src.Location = new System.Drawing.Point(302, 87);
            this.txtbox_src.Name = "txtbox_src";
            this.txtbox_src.Size = new System.Drawing.Size(94, 20);
            this.txtbox_src.TabIndex = 12;
            // 
            // txtbox_dest
            // 
            this.txtbox_dest.Location = new System.Drawing.Point(303, 135);
            this.txtbox_dest.Name = "txtbox_dest";
            this.txtbox_dest.Size = new System.Drawing.Size(93, 20);
            this.txtbox_dest.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Asal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tujuan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 421);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(26, 548);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(81, 23);
            this.btn_refresh.TabIndex = 20;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 629);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_dest);
            this.Controls.Add(this.txtbox_src);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.txt_box_namafile);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_pilih_file);
            this.Controls.Add(this.bfs_opt);
            this.Controls.Add(this.dfs_opt);
            this.Controls.Add(this.txt_box_isi_file);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_logo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txt_box_isi_file;
        private System.Windows.Forms.RadioButton dfs_opt;
        private System.Windows.Forms.RadioButton bfs_opt;
        private System.Windows.Forms.Button btn_pilih_file;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.RichTextBox txt_box_namafile;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        public System.Windows.Forms.TextBox txtbox_src;
        public System.Windows.Forms.TextBox txtbox_dest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_refresh;
    }
}

