using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using JDSolutions.XmlRpc;
using JDSolutions.XmlRpc.Elements;
using newtelligence.DasBlog.Runtime;

namespace SharpWinBlogger
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button btnGetBlogs;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.DataGrid blogListGrid;
		private System.Windows.Forms.ComboBox blogIDsCombo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNumEntries;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxDasBlogContentPath;
		private System.Windows.Forms.Button btnGetFromBlogger;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.LinkLabel linkLabel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetFromBlogger = new System.Windows.Forms.Button();
			this.blogIDsCombo = new System.Windows.Forms.ComboBox();
			this.btnGetBlogs = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel4 = new System.Windows.Forms.Panel();
			this.blogListGrid = new System.Windows.Forms.DataGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDasBlogContentPath = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNumEntries = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.blogListGrid)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetFromBlogger
			// 
			this.btnGetFromBlogger.Location = new System.Drawing.Point(8, 312);
			this.btnGetFromBlogger.Name = "btnGetFromBlogger";
			this.btnGetFromBlogger.Size = new System.Drawing.Size(192, 24);
			this.btnGetFromBlogger.TabIndex = 8;
			this.btnGetFromBlogger.Text = "Retrieve entries from selected blog";
			this.btnGetFromBlogger.Click += new System.EventHandler(this.btnGetFromBlogger_Click);
			// 
			// blogIDsCombo
			// 
			this.blogIDsCombo.Location = new System.Drawing.Point(16, 224);
			this.blogIDsCombo.Name = "blogIDsCombo";
			this.blogIDsCombo.Size = new System.Drawing.Size(184, 21);
			this.blogIDsCombo.TabIndex = 7;
			this.blogIDsCombo.SelectedIndexChanged += new System.EventHandler(this.blogIDsCombo_SelectedIndexChanged);
			// 
			// btnGetBlogs
			// 
			this.btnGetBlogs.Location = new System.Drawing.Point(8, 128);
			this.btnGetBlogs.Name = "btnGetBlogs";
			this.btnGetBlogs.Size = new System.Drawing.Size(192, 23);
			this.btnGetBlogs.TabIndex = 6;
			this.btnGetBlogs.Text = "Get List of My Blogs";
			this.btnGetBlogs.Click += new System.EventHandler(this.btnGetBlogs_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(16, 96);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(184, 20);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.Text = "";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(16, 48);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(184, 20);
			this.txtUserName.TabIndex = 3;
			this.txtUserName.Text = "";
			this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 510);
			this.panel2.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(765, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 510);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.blogListGrid);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(216, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(549, 510);
			this.panel4.TabIndex = 1;
			// 
			// blogListGrid
			// 
			this.blogListGrid.DataMember = "";
			this.blogListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.blogListGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.blogListGrid.Location = new System.Drawing.Point(0, 0);
			this.blogListGrid.Name = "blogListGrid";
			this.blogListGrid.Size = new System.Drawing.Size(549, 510);
			this.blogListGrid.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.groupBox2);
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.textBoxNumEntries);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.textBoxDasBlogContentPath);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.blogIDsCombo);
			this.panel3.Controls.Add(this.btnGetBlogs);
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.txtUserName);
			this.panel3.Controls.Add(this.btnGetFromBlogger);
			this.panel3.Controls.Add(this.linkLabel1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(216, 510);
			this.panel3.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 440);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Save all entries in dasBlog content";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 9;
			this.label1.Text = "Blogger username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Blogger password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "List of my blogs:";
			// 
			// textBoxDasBlogContentPath
			// 
			this.textBoxDasBlogContentPath.Location = new System.Drawing.Point(8, 408);
			this.textBoxDasBlogContentPath.Name = "textBoxDasBlogContentPath";
			this.textBoxDasBlogContentPath.Size = new System.Drawing.Size(192, 20);
			this.textBoxDasBlogContentPath.TabIndex = 12;
			this.textBoxDasBlogContentPath.Text = "C:\\Inetpub\\wwwroot\\dasBlog\\content";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 388);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Local DasBlog content folder path:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Numbers of entries to retrieve:";
			// 
			// textBoxNumEntries
			// 
			this.textBoxNumEntries.Location = new System.Drawing.Point(16, 280);
			this.textBoxNumEntries.Name = "textBoxNumEntries";
			this.textBoxNumEntries.Size = new System.Drawing.Size(184, 20);
			this.textBoxNumEntries.TabIndex = 14;
			this.textBoxNumEntries.Text = "100";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 160);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 8);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(-8, 336);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 8);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Location = new System.Drawing.Point(8, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Step 1:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Location = new System.Drawing.Point(8, 184);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Step 2:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label8.Location = new System.Drawing.Point(8, 360);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 17);
			this.label8.TabIndex = 20;
			this.label8.Text = "Step 3:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(4, 25);
			this.linkLabel1.Location = new System.Drawing.Point(8, 480);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(200, 23);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "(C) http://www.ShitalShah.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(768, 510);
			this.Controls.Add(this.panel2);
			this.Name = "Form1";
			this.Text = "Blogger To dasBlog Converter Tool";
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.blogListGrid)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnGetBlogs_Click(object sender, System.EventArgs e)
		{
			Blogger oBlogger = new Blogger(txtUserName.Text, txtPassword.Text);
			BlogInfo[] userBlogs = oBlogger.GetUserBlogInfo();
			
			blogIDsCombo.DataSource = userBlogs;
			blogIDsCombo.DisplayMember = "blogName";
			blogIDsCombo.ValueMember = "blogid";
		}

		private void blogIDsCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		DataSet blogItemDataSet = new DataSet();
		private void btnGetFromBlogger_Click(object sender, System.EventArgs e)
		{
			Blogger oBlogger = new Blogger(txtUserName.Text, txtPassword.Text);
			BlogInfo selectedBlog = (BlogInfo)blogIDsCombo.SelectedItem;
			oBlogger.BlogID = selectedBlog.blogid;

			this.Cursor = Cursors.WaitCursor;
			oBlogger.GetRecentPostsInDataSet(int.Parse(textBoxNumEntries.Text), blogItemDataSet);
		
			blogListGrid.DataSource = blogItemDataSet;
			blogListGrid.DataMember = "BlogItem";
			this.Cursor = Cursors.Default;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			IBlogDataService dataService = BlogDataServiceFactory.GetService(textBoxDasBlogContentPath.Text,null);

			foreach (DataRow row in blogItemDataSet.Tables["BlogItem"].Rows)
			{

					Entry newEntry = new Entry();
					newEntry.Author = row["AuthorName"].ToString();
					string fullContent = row["Content"].ToString();
					int titleStart = fullContent.IndexOf(@"<h5>")+"@</h5>".Length ;
					int titleEnd = fullContent.IndexOf(@"</h5>") ;
					newEntry.Content = fullContent.Substring(titleEnd+"@</h5>".Length-1);
					newEntry.Description = "";
					newEntry.Title = fullContent.Substring (titleStart-2,titleEnd-titleStart+2);
					newEntry.CreatedLocalTime = ((DateTime)row["PostDate"]).AddHours(3);
					newEntry.CreatedUtc = ((DateTime)row["PostDate"]).AddHours(3).ToUniversalTime();
					newEntry.ModifiedLocalTime  =  ((DateTime)row["LastModified"]).AddHours(3);
					newEntry.ModifiedUtc =  ((DateTime)row["LastModified"]).AddHours(3).ToUniversalTime();
					newEntry.EntryId = Guid.NewGuid().ToString();
					dataService.SaveEntry(newEntry);
				}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.ShitalShah.com");
		}

	}
	public class MWLPost
	{
		public DateTime dateCreated;
		public object userid;
		public string postid;
		public string content;
	}
}
