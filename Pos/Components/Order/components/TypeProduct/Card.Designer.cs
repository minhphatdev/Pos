
namespace Pos.Components.Order
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.Layout = new System.Windows.Forms.Panel();
            this.DsCard = new Guna.UI.WinForms.GunaElipsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Number = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Label();
            this.Layout.SuspendLayout();
            this.DsCard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.Transparent;
            this.Layout.Controls.Add(this.DsCard);
            resources.ApplyResources(this.Layout, "Layout");
            this.Layout.Name = "Layout";
            // 
            // DsCard
            // 
            this.DsCard.BackColor = System.Drawing.Color.Transparent;
            this.DsCard.BaseColor = System.Drawing.Color.White;
            this.DsCard.Controls.Add(this.tableLayoutPanel1);
            this.DsCard.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DsCard, "DsCard");
            this.DsCard.Name = "DsCard";
            this.DsCard.Radius = 10;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Content, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Number
            // 
            resources.ApplyResources(this.Number, "Number");
            this.Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.Number.Name = "Number";
            this.Number.MouseEnter += new System.EventHandler(this.Number_MouseEnter);
            this.Number.MouseLeave += new System.EventHandler(this.Number_MouseLeave);
            // 
            // Content
            // 
            resources.ApplyResources(this.Content, "Content");
            this.Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.Content.Name = "Content";
            this.Content.MouseEnter += new System.EventHandler(this.Content_MouseEnter);
            this.Content.MouseLeave += new System.EventHandler(this.Content_MouseLeave);
            // 
            // Card
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Layout);
            this.Name = "Card";
            this.Layout.ResumeLayout(false);
            this.DsCard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Layout;
        private Guna.UI.WinForms.GunaElipsePanel DsCard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Content;
    }
}
