
namespace BRANCH_CAR_MANAGER
{
    partial class BRANCH
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRANCH));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonCars = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonCars);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 510);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonCars
            // 
            this.buttonCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCars.FlatAppearance.BorderSize = 0;
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCars.Image = ((System.Drawing.Image)(resources.GetObject("buttonCars.Image")));
            this.buttonCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCars.Location = new System.Drawing.Point(0, 80);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(220, 60);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Cars";
            this.buttonCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCars.UseVisualStyleBackColor = true;
            // 
            // BRANCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BRANCH";
            this.Text = "BRANCH CAR MANAGER";
            this.Load += new System.EventHandler(this.BRANCH_CAR_MANAGER_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonCars;
    }
}

