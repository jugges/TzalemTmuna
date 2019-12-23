
namespace TzalemTmuna.Forms
{
    partial class Settings
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpCustomize = new MetroFramework.Controls.MetroTabPage();
            this.lblDarkMode = new MetroFramework.Controls.MetroLabel();
            this.tDarkMode = new MetroFramework.Controls.MetroToggle();
            this.tpPassword = new MetroFramework.Controls.MetroTabPage();
            this.tpReports = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tpCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpCustomize);
            this.metroTabControl1.Controls.Add(this.tpPassword);
            this.metroTabControl1.Controls.Add(this.tpReports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(795, 838);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpCustomize
            // 
            this.tpCustomize.Controls.Add(this.lblDarkMode);
            this.tpCustomize.Controls.Add(this.tDarkMode);
            this.tpCustomize.HorizontalScrollbarBarColor = true;
            this.tpCustomize.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCustomize.HorizontalScrollbarSize = 10;
            this.tpCustomize.Location = new System.Drawing.Point(4, 38);
            this.tpCustomize.Name = "tpCustomize";
            this.tpCustomize.Size = new System.Drawing.Size(787, 796);
            this.tpCustomize.TabIndex = 2;
            this.tpCustomize.Text = "Customize";
            this.tpCustomize.VerticalScrollbarBarColor = true;
            this.tpCustomize.VerticalScrollbarHighlightOnWheel = false;
            this.tpCustomize.VerticalScrollbarSize = 10;
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Location = new System.Drawing.Point(0, 1);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(78, 19);
            this.lblDarkMode.TabIndex = 3;
            this.lblDarkMode.Text = "Dark Mode:";
            // 
            // tDarkMode
            // 
            this.tDarkMode.AutoSize = true;
            this.tDarkMode.Checked = true;
            this.tDarkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tDarkMode.Location = new System.Drawing.Point(84, 3);
            this.tDarkMode.Name = "tDarkMode";
            this.tDarkMode.Size = new System.Drawing.Size(80, 17);
            this.tDarkMode.TabIndex = 2;
            this.tDarkMode.Text = "On";
            this.tDarkMode.UseSelectable = true;
            // 
            // tpPassword
            // 
            this.tpPassword.HorizontalScrollbarBarColor = true;
            this.tpPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.tpPassword.HorizontalScrollbarSize = 10;
            this.tpPassword.Location = new System.Drawing.Point(4, 38);
            this.tpPassword.Name = "tpPassword";
            this.tpPassword.Size = new System.Drawing.Size(787, 796);
            this.tpPassword.TabIndex = 0;
            this.tpPassword.Text = "Change Password";
            this.tpPassword.VerticalScrollbarBarColor = true;
            this.tpPassword.VerticalScrollbarHighlightOnWheel = false;
            this.tpPassword.VerticalScrollbarSize = 10;
            // 
            // tpReports
            // 
            this.tpReports.HorizontalScrollbarBarColor = true;
            this.tpReports.HorizontalScrollbarHighlightOnWheel = false;
            this.tpReports.HorizontalScrollbarSize = 10;
            this.tpReports.Location = new System.Drawing.Point(4, 38);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(787, 796);
            this.tpReports.TabIndex = 1;
            this.tpReports.Text = "Reports";
            this.tpReports.VerticalScrollbarBarColor = true;
            this.tpReports.VerticalScrollbarHighlightOnWheel = false;
            this.tpReports.VerticalScrollbarSize = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 918);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.metroTabControl1.ResumeLayout(false);
            this.tpCustomize.ResumeLayout(false);
            this.tpCustomize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpPassword;
        private MetroFramework.Controls.MetroTabPage tpReports;
        private MetroFramework.Controls.MetroTabPage tpCustomize;
        private MetroFramework.Controls.MetroLabel lblDarkMode;
        private MetroFramework.Controls.MetroToggle tDarkMode;
    }
}