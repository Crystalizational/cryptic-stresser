﻿namespace Cryptic_Stresser
{
	// Token: 0x02000008 RID: 8
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000034A0 File Offset: 0x000016A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000034D8 File Offset: 0x000016D8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Guna.UI2.AnimatorNS.Animation animation = new global::Guna.UI2.AnimatorNS.Animation();
			global::Guna.UI2.AnimatorNS.Animation animation2 = new global::Guna.UI2.AnimatorNS.Animation();
			global::Guna.UI2.AnimatorNS.Animation animation3 = new global::Guna.UI2.AnimatorNS.Animation();
			global::Guna.UI2.AnimatorNS.Animation animation4 = new global::Guna.UI2.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Cryptic_Stresser.Form1));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Token = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.email = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Pass = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.User = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.reg111 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Back = new global::Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.Back2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.reg = new global::Guna.UI2.WinForms.Guna2Transition();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Pass2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.User1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.msg = new global::System.Windows.Forms.Panel();
			this.msgtext = new global::System.Windows.Forms.Label();
			this.msgclose = new global::Guna.UI2.WinForms.Guna2Button();
			this.exitlogin = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.G = new global::Guna.UI2.WinForms.Guna2Transition();
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl3 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.meg = new global::Guna.UI2.WinForms.Guna2Transition();
			this.exit = new global::System.Windows.Forms.Timer(this.components);
			this.msgpanel = new global::Guna.UI2.WinForms.Guna2Transition();
			this.timeformsg = new global::System.Windows.Forms.Timer(this.components);
			this.guna2DragControl4 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl5 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.msg.SuspendLayout();
			base.SuspendLayout();
			this.meg.SetDecoration(this.pictureBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.pictureBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.pictureBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.pictureBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(123, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(221, 244);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel1.Controls.Add(this.guna2Separator1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Token);
			this.panel1.Controls.Add(this.email);
			this.panel1.Controls.Add(this.Pass);
			this.panel1.Controls.Add(this.User);
			this.panel1.Controls.Add(this.reg111);
			this.panel1.Controls.Add(this.Back);
			this.msgpanel.SetDecoration(this.panel1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.panel1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.panel1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.panel1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.panel1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new global::System.Drawing.Point(79, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(367, 309);
			this.panel1.TabIndex = 1;
			this.panel1.Visible = false;
			this.msgpanel.SetDecoration(this.guna2Separator1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.guna2Separator1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.guna2Separator1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.guna2Separator1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.guna2Separator1.Location = new global::System.Drawing.Point(18, 38);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(206, 10);
			this.guna2Separator1.TabIndex = 10;
			this.guna2Separator1.Click += new global::System.EventHandler(this.guna2Separator1_Click);
			this.label1.AutoSize = true;
			this.meg.SetDecoration(this.label1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.label1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.label1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.label1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Microsoft Tai Le", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(14, 14);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(210, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "Register a Cryptic Account";
			this.Token.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.Token, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.Token, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.Token, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.Token, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Token.DefaultText = "";
			this.Token.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Token.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Token.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Token.DisabledState.Parent = this.Token;
			this.Token.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Token.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Token.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Token.FocusedState.Parent = this.Token;
			this.Token.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Token.ForeColor = global::System.Drawing.Color.White;
			this.Token.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Token.HoverState.Parent = this.Token;
			this.Token.Location = new global::System.Drawing.Point(19, 209);
			this.Token.Name = "Token";
			this.Token.PasswordChar = '\0';
			this.Token.PlaceholderText = "Cryptic Token";
			this.Token.SelectedText = "";
			this.Token.ShadowDecoration.Parent = this.Token;
			this.Token.Size = new global::System.Drawing.Size(303, 24);
			this.Token.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.Token.TabIndex = 8;
			this.email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.email, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.email, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.email, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.email, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.email.DefaultText = "";
			this.email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.DisabledState.Parent = this.email;
			this.email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.FocusedState.Parent = this.email;
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.email.ForeColor = global::System.Drawing.Color.White;
			this.email.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.HoverState.Parent = this.email;
			this.email.Location = new global::System.Drawing.Point(19, 158);
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.PlaceholderText = "Discord/#";
			this.email.SelectedText = "";
			this.email.ShadowDecoration.Parent = this.email;
			this.email.Size = new global::System.Drawing.Size(303, 24);
			this.email.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.email.TabIndex = 7;
			this.Pass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.Pass, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.Pass, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.Pass, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.Pass, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Pass.DefaultText = "";
			this.Pass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Pass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Pass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Pass.DisabledState.Parent = this.Pass;
			this.Pass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Pass.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Pass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Pass.FocusedState.Parent = this.Pass;
			this.Pass.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Pass.ForeColor = global::System.Drawing.Color.White;
			this.Pass.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Pass.HoverState.Parent = this.Pass;
			this.Pass.Location = new global::System.Drawing.Point(19, 104);
			this.Pass.Name = "Pass";
			this.Pass.PasswordChar = '*';
			this.Pass.PlaceholderText = "Password";
			this.Pass.SelectedText = "";
			this.Pass.ShadowDecoration.Parent = this.Pass;
			this.Pass.Size = new global::System.Drawing.Size(303, 24);
			this.Pass.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.Pass.TabIndex = 6;
			this.User.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.User, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.User, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.User, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.User, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.User.DefaultText = "";
			this.User.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.User.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.User.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.User.DisabledState.Parent = this.User;
			this.User.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.User.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.User.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.User.FocusedState.Parent = this.User;
			this.User.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.User.ForeColor = global::System.Drawing.Color.White;
			this.User.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.User.HoverState.Parent = this.User;
			this.User.Location = new global::System.Drawing.Point(19, 59);
			this.User.Name = "User";
			this.User.PasswordChar = '\0';
			this.User.PlaceholderText = "Username";
			this.User.SelectedText = "";
			this.User.ShadowDecoration.Parent = this.User;
			this.User.Size = new global::System.Drawing.Size(303, 24);
			this.User.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.User.TabIndex = 5;
			this.reg111.Animated = true;
			this.reg111.CheckedState.Parent = this.reg111;
			this.reg111.CustomImages.Parent = this.reg111;
			this.G.SetDecoration(this.reg111, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.reg111, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.reg111, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.reg111, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg111.FillColor = global::System.Drawing.Color.Black;
			this.reg111.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.reg111.ForeColor = global::System.Drawing.Color.White;
			this.reg111.HoverState.Parent = this.reg111;
			this.reg111.Location = new global::System.Drawing.Point(19, 278);
			this.reg111.Name = "reg111";
			this.reg111.ShadowDecoration.Parent = this.reg111;
			this.reg111.Size = new global::System.Drawing.Size(148, 28);
			this.reg111.TabIndex = 4;
			this.reg111.Text = "Register";
			this.reg111.Click += new global::System.EventHandler(this.reg111_Click);
			this.Back.Animated = true;
			this.Back.CheckedState.Parent = this.Back;
			this.Back.CustomImages.Parent = this.Back;
			this.G.SetDecoration(this.Back, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.Back, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.Back, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.Back, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Back.FillColor = global::System.Drawing.Color.Black;
			this.Back.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Back.ForeColor = global::System.Drawing.Color.White;
			this.Back.HoverState.Parent = this.Back;
			this.Back.Location = new global::System.Drawing.Point(194, 278);
			this.Back.Name = "Back";
			this.Back.ShadowDecoration.Parent = this.Back;
			this.Back.Size = new global::System.Drawing.Size(148, 28);
			this.Back.TabIndex = 3;
			this.Back.Text = "Back To Login";
			this.Back.Click += new global::System.EventHandler(this.Back_Click);
			this.panel2.Controls.Add(this.Back2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.msgpanel.SetDecoration(this.panel2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.panel2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.panel2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.panel2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.panel2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new global::System.Drawing.Point(79, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(382, 322);
			this.panel2.TabIndex = 10;
			this.panel2.Visible = false;
			this.Back2.Animated = true;
			this.Back2.CheckedState.Parent = this.Back2;
			this.Back2.CustomImages.Parent = this.Back2;
			this.G.SetDecoration(this.Back2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.Back2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.Back2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.Back2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Back2.FillColor = global::System.Drawing.Color.Black;
			this.Back2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Back2.ForeColor = global::System.Drawing.Color.White;
			this.Back2.HoverState.Parent = this.Back2;
			this.Back2.Location = new global::System.Drawing.Point(173, 277);
			this.Back2.Name = "Back2";
			this.Back2.ShadowDecoration.Parent = this.Back2;
			this.Back2.Size = new global::System.Drawing.Size(167, 28);
			this.Back2.TabIndex = 11;
			this.Back2.Text = "Back";
			this.Back2.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.label5.AutoSize = true;
			this.meg.SetDecoration(this.label5, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.label5, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.label5, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.label5, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Microsoft Tai Le", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(11, 279);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(156, 21);
			this.label5.TabIndex = 3;
			this.label5.Text = "The Cryptic Team®";
			this.label4.AutoSize = true;
			this.meg.SetDecoration(this.label4, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.label4, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.label4, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.label4, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Microsoft Tai Le", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(6, 43);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(340, 228);
			this.label4.TabIndex = 2;
			this.label4.Text = componentResourceManager.GetString("label4.Text");
			this.label3.AutoSize = true;
			this.meg.SetDecoration(this.label3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.label3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.label3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.label3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Tai Le", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(12, 43);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0, 21);
			this.label3.TabIndex = 1;
			this.label2.AutoSize = true;
			this.meg.SetDecoration(this.label2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.label2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.label2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.label2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Tai Le", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(5, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(231, 27);
			this.label2.TabIndex = 0;
			this.label2.Text = "Made By Cryptic Team";
			this.reg.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.Transparent;
			this.reg.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation30.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation30.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation30.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(0);
			animation.RotateCoeff = 0f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation30.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation30.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.reg.DefaultAnimation = animation;
			this.reg.Interval = 20;
			this.guna2Button1.Animated = true;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.G.SetDecoration(this.guna2Button1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.guna2Button1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.guna2Button1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.guna2Button1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Black;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(297, 392);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(180, 28);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.Text = "Register A Cryptic Account";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.Pass2.BackColor = global::System.Drawing.Color.Black;
			this.Pass2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.Pass2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.Pass2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.Pass2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.Pass2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Pass2.DefaultText = "";
			this.Pass2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Pass2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Pass2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Pass2.DisabledState.Parent = this.Pass2;
			this.Pass2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Pass2.FillColor = global::System.Drawing.Color.Black;
			this.Pass2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Pass2.FocusedState.Parent = this.Pass2;
			this.Pass2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Pass2.ForeColor = global::System.Drawing.Color.White;
			this.Pass2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Pass2.HoverState.Parent = this.Pass2;
			this.Pass2.Location = new global::System.Drawing.Point(79, 285);
			this.Pass2.Name = "Pass2";
			this.Pass2.PasswordChar = '*';
			this.Pass2.PlaceholderText = "Password";
			this.Pass2.SelectedText = "";
			this.Pass2.ShadowDecoration.Parent = this.Pass2;
			this.Pass2.Size = new global::System.Drawing.Size(303, 33);
			this.Pass2.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.Pass2.TabIndex = 8;
			this.User1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.reg.SetDecoration(this.User1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.User1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.User1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.User1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.User1.DefaultText = "";
			this.User1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.User1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.User1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.User1.DisabledState.Parent = this.User1;
			this.User1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.User1.FillColor = global::System.Drawing.Color.Black;
			this.User1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.User1.FocusedState.Parent = this.User1;
			this.User1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.User1.ForeColor = global::System.Drawing.Color.White;
			this.User1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.User1.HoverState.Parent = this.User1;
			this.User1.Location = new global::System.Drawing.Point(79, 243);
			this.User1.Name = "User1";
			this.User1.PasswordChar = '\0';
			this.User1.PlaceholderText = "Username";
			this.User1.SelectedText = "";
			this.User1.ShadowDecoration.Parent = this.User1;
			this.User1.Size = new global::System.Drawing.Size(303, 28);
			this.User1.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.User1.TabIndex = 7;
			this.guna2Button2.Animated = true;
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.G.SetDecoration(this.guna2Button2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.guna2Button2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.guna2Button2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.guna2Button2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.guna2Button2.FillColor = global::System.Drawing.Color.Black;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(158, 324);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(148, 28);
			this.guna2Button2.TabIndex = 9;
			this.guna2Button2.Text = "Login";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button3.Animated = true;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.G.SetDecoration(this.guna2Button3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.guna2Button3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.guna2Button3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.guna2Button3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.guna2Button3.FillColor = global::System.Drawing.Color.Black;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(7, 392);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(180, 28);
			this.guna2Button3.TabIndex = 10;
			this.guna2Button3.Text = "Info";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.msg.BackColor = global::System.Drawing.Color.Red;
			this.msg.Controls.Add(this.msgtext);
			this.msg.Controls.Add(this.msgclose);
			this.msgpanel.SetDecoration(this.msg, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.msg, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.msg, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.msg, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msg.Location = new global::System.Drawing.Point(84, 6);
			this.msg.Name = "msg";
			this.msg.Size = new global::System.Drawing.Size(330, 36);
			this.msg.TabIndex = 63;
			this.msg.Visible = false;
			this.meg.SetDecoration(this.msgtext, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.msgtext, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.G.SetDecoration(this.msgtext, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.msgtext, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgtext.Font = new global::System.Drawing.Font("Segoe UI", 10.75f, global::System.Drawing.FontStyle.Bold);
			this.msgtext.ForeColor = global::System.Drawing.Color.White;
			this.msgtext.Location = new global::System.Drawing.Point(19, 6);
			this.msgtext.Name = "msgtext";
			this.msgtext.Size = new global::System.Drawing.Size(262, 23);
			this.msgtext.TabIndex = 53;
			this.msgtext.Text = "Something Went Wrong, Try Again";
			this.msgclose.Animated = true;
			this.msgclose.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("msgclose.BackgroundImage");
			this.msgclose.ButtonMode = global::Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.msgclose.CheckedState.Parent = this.msgclose;
			this.msgclose.CustomImages.Parent = this.msgclose;
			this.G.SetDecoration(this.msgclose, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.msgclose, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.msgclose, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.msgclose, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgclose.FillColor = global::System.Drawing.Color.Transparent;
			this.msgclose.Font = new global::System.Drawing.Font("Segoe UI", 11.75f, global::System.Drawing.FontStyle.Bold);
			this.msgclose.ForeColor = global::System.Drawing.Color.White;
			this.msgclose.HoverState.Parent = this.msgclose;
			this.msgclose.Location = new global::System.Drawing.Point(287, 1);
			this.msgclose.Name = "msgclose";
			this.msgclose.ShadowDecoration.Parent = this.msgclose;
			this.msgclose.Size = new global::System.Drawing.Size(37, 34);
			this.msgclose.TabIndex = 45;
			this.exitlogin.Animated = true;
			this.exitlogin.CheckedState.Parent = this.exitlogin;
			this.exitlogin.CustomImages.Parent = this.exitlogin;
			this.G.SetDecoration(this.exitlogin, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this.exitlogin, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this.exitlogin, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this.exitlogin, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.exitlogin.FillColor = global::System.Drawing.Color.Black;
			this.exitlogin.Font = new global::System.Drawing.Font("Segoe UI", 11.75f, global::System.Drawing.FontStyle.Bold);
			this.exitlogin.ForeColor = global::System.Drawing.Color.White;
			this.exitlogin.HoverState.Parent = this.exitlogin;
			this.exitlogin.Location = new global::System.Drawing.Point(430, 5);
			this.exitlogin.Name = "exitlogin";
			this.exitlogin.ShadowDecoration.Parent = this.exitlogin;
			this.exitlogin.Size = new global::System.Drawing.Size(31, 35);
			this.exitlogin.TabIndex = 64;
			this.exitlogin.Text = "X";
			this.exitlogin.Click += new global::System.EventHandler(this.exitlogin_Click);
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2DragControl1.TargetControl = this.pictureBox1;
			this.G.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.Leaf;
			this.G.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation31.BlindCoeff");
			animation2.LeafCoeff = 1f;
			animation2.MaxTime = 1f;
			animation2.MinTime = 0f;
			animation2.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation31.MosaicCoeff");
			animation2.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation31.MosaicShift");
			animation2.MosaicSize = 0;
			animation2.Padding = new global::System.Windows.Forms.Padding(0);
			animation2.RotateCoeff = 0f;
			animation2.RotateLimit = 0f;
			animation2.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation31.ScaleCoeff");
			animation2.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation31.SlideCoeff");
			animation2.TimeCoeff = 0f;
			animation2.TransparencyCoeff = 0f;
			this.G.DefaultAnimation = animation2;
			this.G.Interval = 20;
			this.guna2DragControl2.TargetControl = this.panel1;
			this.guna2DragControl3.TargetControl = this.panel2;
			this.meg.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.Transparent;
			this.meg.Cursor = null;
			animation3.AnimateOnlyDifferences = true;
			animation3.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation32.BlindCoeff");
			animation3.LeafCoeff = 0f;
			animation3.MaxTime = 1f;
			animation3.MinTime = 0f;
			animation3.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation32.MosaicCoeff");
			animation3.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation32.MosaicShift");
			animation3.MosaicSize = 0;
			animation3.Padding = new global::System.Windows.Forms.Padding(0);
			animation3.RotateCoeff = 0f;
			animation3.RotateLimit = 0f;
			animation3.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation32.ScaleCoeff");
			animation3.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation32.SlideCoeff");
			animation3.TimeCoeff = 0f;
			animation3.TransparencyCoeff = 1f;
			this.meg.DefaultAnimation = animation3;
			this.exit.Tick += new global::System.EventHandler(this.exit_Tick);
			this.msgpanel.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.VertSlide;
			this.msgpanel.Cursor = null;
			animation4.AnimateOnlyDifferences = true;
			animation4.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation29.BlindCoeff");
			animation4.LeafCoeff = 0f;
			animation4.MaxTime = 1f;
			animation4.MinTime = 0f;
			animation4.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation29.MosaicCoeff");
			animation4.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation29.MosaicShift");
			animation4.MosaicSize = 0;
			animation4.Padding = new global::System.Windows.Forms.Padding(0);
			animation4.RotateCoeff = 0f;
			animation4.RotateLimit = 0f;
			animation4.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation29.ScaleCoeff");
			animation4.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation29.SlideCoeff");
			animation4.TimeCoeff = 0f;
			animation4.TransparencyCoeff = 0f;
			this.msgpanel.DefaultAnimation = animation4;
			this.timeformsg.Interval = 3000;
			this.timeformsg.Tick += new global::System.EventHandler(this.timeformsg_Tick);
			this.guna2DragControl4.TargetControl = this.panel1;
			this.guna2DragControl5.TargetControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(489, 442);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.exitlogin);
			base.Controls.Add(this.msg);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.Pass2);
			base.Controls.Add(this.User1);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.pictureBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.G.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.reg.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.msgpanel.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.meg.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cryptic Stresser";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.msg.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI2.WinForms.Guna2Transition reg;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001D RID: 29
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400001E RID: 30
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400001F RID: 31
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000020 RID: 32
		private global::Guna.UI2.WinForms.Guna2Button reg111;

		// Token: 0x04000021 RID: 33
		private global::Guna.UI2.WinForms.Guna2Button Back;

		// Token: 0x04000022 RID: 34
		private global::Guna.UI2.WinForms.Guna2Transition G;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000024 RID: 36
		private global::Guna.UI2.WinForms.Guna2TextBox Token;

		// Token: 0x04000025 RID: 37
		private global::Guna.UI2.WinForms.Guna2TextBox email;

		// Token: 0x04000026 RID: 38
		private global::Guna.UI2.WinForms.Guna2TextBox Pass;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2TextBox User;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x04000029 RID: 41
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x0400002A RID: 42
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400002B RID: 43
		private global::Guna.UI2.WinForms.Guna2TextBox Pass2;

		// Token: 0x0400002C RID: 44
		private global::Guna.UI2.WinForms.Guna2TextBox User1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000032 RID: 50
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000033 RID: 51
		private global::Guna.UI2.WinForms.Guna2Button Back2;

		// Token: 0x04000034 RID: 52
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2Transition meg;

		// Token: 0x04000036 RID: 54
		private global::Guna.UI2.WinForms.Guna2Transition msgpanel;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel msg;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label msgtext;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2Button msgclose;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Timer exit;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Timer timeformsg;

		// Token: 0x0400003C RID: 60
		private global::Guna.UI2.WinForms.Guna2Button exitlogin;

		// Token: 0x0400003D RID: 61
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;

		// Token: 0x0400003E RID: 62
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl5;
	}
}
