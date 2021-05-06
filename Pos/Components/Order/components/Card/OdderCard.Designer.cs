
namespace Pos.Components.Order
{
    partial class OdderCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdderCard));
            this.layout = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.price = new System.Windows.Forms.Label();
            this.gunaPicture = new Guna.UI.WinForms.GunaPictureBox();
            this.name = new System.Windows.Forms.Label();
            this.layout.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.Controls.Add(this.gunaElipsePanel1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.layout.Size = new System.Drawing.Size(304, 370);
            this.layout.TabIndex = 0;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.tableLayoutPanel1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(10, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 8;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(284, 350);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.price, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gunaPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.29642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(9, 319);
            this.price.Name = "price";
            this.price.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.price.Size = new System.Drawing.Size(266, 25);
            this.price.TabIndex = 2;
            this.price.Text = "1000000";
            this.price.MouseEnter += new System.EventHandler(this.name_MouseEnter);
            this.price.MouseLeave += new System.EventHandler(this.gunaPicture_MouseLeave);
            // 
            // gunaPicture
            // 
            this.gunaPicture.BaseColor = System.Drawing.Color.White;
            this.gunaPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPicture.Image = ((System.Drawing.Image)(resources.GetObject("gunaPicture.Image")));
            this.gunaPicture.Location = new System.Drawing.Point(9, 9);
            this.gunaPicture.Name = "gunaPicture";
            this.gunaPicture.Size = new System.Drawing.Size(266, 268);
            this.gunaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPicture.TabIndex = 0;
            this.gunaPicture.TabStop = false;
            this.gunaPicture.MouseEnter += new System.EventHandler(this.name_MouseEnter);
            this.gunaPicture.MouseLeave += new System.EventHandler(this.gunaPicture_MouseLeave);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(9, 280);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.name.Size = new System.Drawing.Size(266, 39);
            this.name.TabIndex = 1;
            this.name.Text = "Trà sữa Matcha";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.MouseEnter += new System.EventHandler(this.name_MouseEnter);
            this.name.MouseLeave += new System.EventHandler(this.gunaPicture_MouseLeave);
            // 
            // OdderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.layout);
            this.Name = "OdderCard";
            this.Size = new System.Drawing.Size(304, 370);
            this.layout.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel layout;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPicture;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label name;
    }
}
