using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignLib
{
    public class Design : GunaAdvenceTileButton
    {
       
        public Design(string text, ComponentResourceManager resources)
        {
            this.AnimationHoverSpeed = 0.07F;
            this.AnimationSpeed = 0.03F;
            this.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(130)))), ((int)(((byte)(195)))));
            this.BorderColor = System.Drawing.Color.Black;
            this.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CheckedBorderColor = System.Drawing.Color.Black;
            this.CheckedForeColor = System.Drawing.Color.White;
            this.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.CheckedImage")));
            this.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.FocusedColor = System.Drawing.Color.Empty;
            this.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.ImageSize = new System.Drawing.Size(40, 40);
            this.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "btnMenu";
            this.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OnHoverForeColor = System.Drawing.Color.White;
            this.OnHoverImage = null;
            this.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.OnPressedColor = System.Drawing.Color.Black;
            this.Size = new System.Drawing.Size(76, 68);
            this.TabIndex = 12;
            this.Text = "ddepj trai";
        }
    }


}
