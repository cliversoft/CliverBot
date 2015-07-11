namespace Cliver.CrawlerManager
{
    partial class SysTrayForm
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuCrawlers = new System.Windows.Forms.MenuItem();
            this.StopService = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.mCheckNow = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuSeparator = new System.Windows.Forms.MenuItem();
            this.menuSeparator1 = new System.Windows.Forms.MenuItem();
            this.menuSeparator2 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = this.Icon;
            this.notifyIcon1.Text = "Crawler Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.show);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCrawlers,
            this.menuSettings,
            this.menuSeparator1,
            this.StopService,
            this.mCheckNow,
            this.menuSeparator2,
            this.menuHelp,
            this.menuAbout,
            this.menuSeparator,
            this.menuExit});
            // 
            // menuCrawlers
            // 
            this.menuCrawlers.DefaultItem = true;
           // this.menuCrawlers.Index = 0;
            this.menuCrawlers.Text = "Crawlers";
            this.menuCrawlers.Click += new System.EventHandler(this.show);
            // 
            // mCheckNow
            // 
          //  this.mCheckNow.Index = 1;
            this.mCheckNow.Text = "Check Now";
            this.mCheckNow.Click += new System.EventHandler(this.CheckNow_Click);
            // 
            // menuSettings
            // 
          //  this.menuSettings.Index = 2;
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // StopService
            // 
         //   this.StopService.Index = 3;
            this.StopService.Text = "Stop Service";
            this.StopService.Click += new System.EventHandler(this.StopService_Click);
            // 
            // menuHelp
            // 
         //   this.menuHelp.Index = 4;
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // menuAbout
            // 
         //   this.menuAbout.Index = 5;
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuSeparator
            // 
            //   this.menuSeparator.Index = 6;
            this.menuSeparator.Text = "-";
            this.menuSeparator1.Text = "-";
            this.menuSeparator2.Text = "-";
            // 
            // menuExit
            // 
         //   this.menuExit.Index = 7;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exit);
            // 
            // SysTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(144, 196);
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysTray";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SysTray_Load);
            this.ResumeLayout(false);

		}
		#endregion		    

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuCrawlers;
        private System.Windows.Forms.MenuItem mCheckNow;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem menuSeparator;
        private System.Windows.Forms.MenuItem StopService;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuSeparator1;
        private System.Windows.Forms.MenuItem menuSeparator2;
	}
}