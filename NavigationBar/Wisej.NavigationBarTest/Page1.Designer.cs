﻿using Wisej.Web;

namespace Wisej.NavigationBarTest
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navigationBarItem1 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem2 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem3 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem4 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem5 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.animation2 = new Wisej.Web.Animation(this.components);
            this.button1 = new Wisej.Web.Ext.SideButton.SideButton();
            this.label1 = new Wisej.Web.Label();
            this.ribbonBar1 = new Wisej.Web.Ext.RibbonBar.RibbonBar();
            this.ribbonBarPage1 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.ribbonBarGroup1 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.ribbonBarItemButton1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.ribbonBarItemButton2 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.ribbonBarItemButton3 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.ribbonBarItemButton4 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.ribbonBarGroup2 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.ribbonBarGroup3 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.ribbonBarGroup4 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.ribbonBarPage2 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.ribbonBarPage3 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.odometer1 = new Wisej.Web.Ext.Odometer.Odometer();
            this.coolClock1 = new Wisej.Web.Ext.CoolClock.CoolClock();
            this.button2 = new Wisej.Web.Button();
            this.flexLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2,
            this.navigationBarItem5});
            this.panel1.Logo = "Images\\itg-128x128.png";
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 781);
            this.panel1.Text = "Nav App";
            this.panel1.UserAvatar = "https://www.gravatar.com/avatar/00000000000000000000000000000000";
            this.panel1.UserName = "Some User";
            this.panel1.UserStatus = "Online";
            this.panel1.TitleClick += new System.EventHandler(this.panel1_TitleClick);
            this.panel1.ItemClick += new Wisej.Web.Ext.NavigationBar.NavigationBarItemClickEventHandler(this.panel1_ItemClick);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Icon = "resource.wx/Wisej.Ext.ElegantIcons/3x3-grid.svg?color=#3FBF77";
            this.navigationBarItem1.InfoText = "new";
            this.navigationBarItem1.InfoTextBackColor = System.Drawing.Color.Salmon;
            this.navigationBarItem1.InfoTextForeColor = System.Drawing.Color.White;
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Dashboard";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Icon = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-file.svg?color=#00CEFF";
            this.navigationBarItem2.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarItem3,
            this.navigationBarItem4});
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Projects";
            // 
            // navigationBarItem3
            // 
            this.navigationBarItem3.Icon = "resource.wx/Wisej.Ext.MaterialDesign/high-signal-indicator.svg?color=#FF002F";
            this.navigationBarItem3.InfoText = "3";
            this.navigationBarItem3.InfoTextBackColor = System.Drawing.Color.SpringGreen;
            this.navigationBarItem3.InfoTextForeColor = System.Drawing.Color.White;
            this.navigationBarItem3.Name = "navigationBarItem3";
            this.navigationBarItem3.Text = "Priority";
            // 
            // navigationBarItem4
            // 
            this.navigationBarItem4.Icon = "resource.wx/Wisej.Ext.MaterialDesign/exit-to-app-button.svg?color=#DFFF00";
            this.navigationBarItem4.InfoTextForeColor = System.Drawing.Color.White;
            this.navigationBarItem4.Name = "navigationBarItem4";
            this.navigationBarItem4.Text = "External";
            // 
            // navigationBarItem5
            // 
            this.navigationBarItem5.Icon = "resource.wx/Wisej.Ext.MaterialDesign/user-shape.svg?color=#00CEFF";
            this.navigationBarItem5.Name = "navigationBarItem5";
            this.navigationBarItem5.Text = "Users";
            // 
            // flexLayoutPanel1
            // 
            this.animation2.GetAnimation(this.flexLayoutPanel1).Event = "disappear";
            this.animation2.GetAnimation(this.flexLayoutPanel1).Name = "slideRightOut";
            this.animation1.GetAnimation(this.flexLayoutPanel1).Event = "appear";
            this.animation1.GetAnimation(this.flexLayoutPanel1).Name = "slideRightIn";
            this.flexLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flexLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flexLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Right;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(735, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Padding = new Wisej.Web.Padding(5, 40, 5, 0);
            this.flexLayoutPanel1.Size = new System.Drawing.Size(42, 781);
            this.flexLayoutPanel1.TabIndex = 4;
            this.flexLayoutPanel1.TabStop = true;
            this.flexLayoutPanel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg?color=#BF3F62";
            this.pictureBox1.Location = new System.Drawing.Point(8, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 40);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/set-alarm.svg?color=#3F52BF";
            this.pictureBox2.Location = new System.Drawing.Point(8, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 40);
            // 
            // button1
            // 
            this.button1.Alignment = Wisej.Web.LeftRightAlignment.Right;
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Collapsed = true;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageSource = "icon-left";
            this.button1.Location = new System.Drawing.Point(735, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 5;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.Location = new System.Drawing.Point(201, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Pages.Add(this.ribbonBarPage1);
            this.ribbonBar1.Pages.Add(this.ribbonBarPage2);
            this.ribbonBar1.Pages.Add(this.ribbonBarPage3);
            this.ribbonBar1.Size = new System.Drawing.Size(534, 129);
            // 
            // ribbonBarPage1
            // 
            this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup1);
            this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup2);
            this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup3);
            this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup4);
            this.ribbonBarPage1.Text = "ribbonBarPage1";
            // 
            // ribbonBarGroup1
            // 
            this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton1);
            this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton2);
            this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton3);
            this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton4);
            this.ribbonBarGroup1.Text = "ribbonBarGroup1";
            // 
            // ribbonBarItemButton1
            // 
            this.ribbonBarItemButton1.Name = "ribbonBarItemButton1";
            this.ribbonBarItemButton1.Text = "ribbonBarItemButton1";
            // 
            // ribbonBarItemButton2
            // 
            this.ribbonBarItemButton2.Name = "ribbonBarItemButton2";
            this.ribbonBarItemButton2.Text = "ribbonBarItemButton2";
            // 
            // ribbonBarItemButton3
            // 
            this.ribbonBarItemButton3.Name = "ribbonBarItemButton3";
            this.ribbonBarItemButton3.Text = "ribbonBarItemButton3";
            // 
            // ribbonBarItemButton4
            // 
            this.ribbonBarItemButton4.Name = "ribbonBarItemButton4";
            this.ribbonBarItemButton4.Text = "ribbonBarItemButton4";
            // 
            // ribbonBarGroup2
            // 
            this.ribbonBarGroup2.Text = "ribbonBarGroup2";
            // 
            // ribbonBarGroup3
            // 
            this.ribbonBarGroup3.Text = "ribbonBarGroup3";
            // 
            // ribbonBarGroup4
            // 
            this.ribbonBarGroup4.Text = "ribbonBarGroup4";
            // 
            // ribbonBarPage2
            // 
            this.ribbonBarPage2.Text = "ribbonBarPage2";
            // 
            // ribbonBarPage3
            // 
            this.ribbonBarPage3.Text = "ribbonBarPage3";
            // 
            // odometer1
            // 
            this.odometer1.FontSize = 25;
            this.odometer1.Location = new System.Drawing.Point(303, 192);
            this.odometer1.Name = "odometer1";
            this.odometer1.Size = new System.Drawing.Size(188, 61);
            this.odometer1.Skin = Wisej.Web.Ext.Odometer.OdometerSkin.SlotMachine;
            this.odometer1.TabIndex = 1;
            this.odometer1.Value = 1212;
            // 
            // coolClock1
            // 
            this.coolClock1.Location = new System.Drawing.Point(343, 410);
            this.coolClock1.Name = "coolClock1";
            this.coolClock1.Size = new System.Drawing.Size(92, 95);
            this.coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.Securephp;
            this.coolClock1.Text = "coolClock1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.coolClock1);
            this.Controls.Add(this.odometer1);
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(777, 781);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.flexLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.NavigationBar.NavigationBar panel1;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem1;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem2;
		private Web.Animation animation1;
		private Web.Animation animation2;
		private Web.PictureBox pictureBox1;
		private Web.PictureBox pictureBox2;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.Ext.SideButton.SideButton button1;
		private Web.Label label1;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem3;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem4;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem5;
        private Web.Ext.RibbonBar.RibbonBar ribbonBar1;
        private Web.Ext.RibbonBar.RibbonBarPage ribbonBarPage1;
        private Web.Ext.RibbonBar.RibbonBarPage ribbonBarPage2;
        private Web.Ext.RibbonBar.RibbonBarPage ribbonBarPage3;
        private Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup1;
        private Web.Ext.RibbonBar.RibbonBarItemButton ribbonBarItemButton1;
        private Web.Ext.RibbonBar.RibbonBarItemButton ribbonBarItemButton2;
        private Web.Ext.RibbonBar.RibbonBarItemButton ribbonBarItemButton3;
        private Web.Ext.RibbonBar.RibbonBarItemButton ribbonBarItemButton4;
        private Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup2;
        private Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup3;
        private Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup4;
        private Web.Ext.Odometer.Odometer odometer1;
        private Web.Ext.CoolClock.CoolClock coolClock1;
        private Button button2;
    }
}
