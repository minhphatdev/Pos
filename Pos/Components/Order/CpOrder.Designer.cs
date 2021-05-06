
namespace Pos.Components
{
    partial class CpOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Layout = new Guna.UI.WinForms.GunaPanel();
            this.panelTop = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.panelMain = new Guna.UI.WinForms.GunaPanel();
            this.gunaScroll = new Guna.UI.WinForms.GunaVScrollBar();
            this.Layout.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.Controls.Add(this.gunaPanel1);
            this.Layout.Controls.Add(this.panelTop);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Margin = new System.Windows.Forms.Padding(0);
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(1476, 1061);
            this.Layout.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1476, 142);
            this.panelTop.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaScroll);
            this.gunaPanel1.Controls.Add(this.panelMain);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 142);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gunaPanel1.Size = new System.Drawing.Size(1476, 919);
            this.gunaPanel1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 10);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1476, 899);
            this.panelMain.TabIndex = 0;
            // 
            // gunaScroll
            // 
            this.gunaScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaScroll.BackColor = System.Drawing.Color.Transparent;
            this.gunaScroll.LargeChange = 10;
            this.gunaScroll.Location = new System.Drawing.Point(1102, 207);
            this.gunaScroll.Margin = new System.Windows.Forms.Padding(8);
            this.gunaScroll.Maximum = 100;
            this.gunaScroll.Name = "gunaScroll";
            this.gunaScroll.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.gunaScroll.Size = new System.Drawing.Size(10, 180);
            this.gunaScroll.TabIndex = 1;
            this.gunaScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaScroll.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.gunaScroll.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            // 
            // CpOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.Layout);
            this.Name = "CpOrder";
            this.Size = new System.Drawing.Size(1476, 1061);
            this.Layout.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Layout;
        private Guna.UI.WinForms.GunaPanel panelTop;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaVScrollBar gunaScroll;
        private Guna.UI.WinForms.GunaPanel panelMain;
    }
}
