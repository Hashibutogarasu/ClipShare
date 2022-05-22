
namespace ClipShare {
    partial class ClipShare {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipShare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecievedClipBox = new System.Windows.Forms.TextBox();
            this.RecievedClip = new System.Windows.Forms.Label();
            this.NowClipBox = new System.Windows.Forms.TextBox();
            this.NowClip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordCheck = new System.Windows.Forms.CheckBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.ServerOnOffButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.ServerIPBox = new System.Windows.Forms.TextBox();
            this.ServerNoticeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NoticeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NoticeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RecievedClipBox);
            this.panel1.Controls.Add(this.RecievedClip);
            this.panel1.Controls.Add(this.NowClipBox);
            this.panel1.Controls.Add(this.NowClip);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 195);
            this.panel1.TabIndex = 0;
            // 
            // RecievedClipBox
            // 
            this.RecievedClipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecievedClipBox.Location = new System.Drawing.Point(12, 111);
            this.RecievedClipBox.Multiline = true;
            this.RecievedClipBox.Name = "RecievedClipBox";
            this.RecievedClipBox.ReadOnly = true;
            this.RecievedClipBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecievedClipBox.Size = new System.Drawing.Size(361, 67);
            this.RecievedClipBox.TabIndex = 7;
            this.RecievedClipBox.TextChanged += new System.EventHandler(this.RecievedClipBox_TextChanged);
            // 
            // RecievedClip
            // 
            this.RecievedClip.AutoSize = true;
            this.RecievedClip.Location = new System.Drawing.Point(12, 93);
            this.RecievedClip.Name = "RecievedClip";
            this.RecievedClip.Size = new System.Drawing.Size(93, 15);
            this.RecievedClip.TabIndex = 6;
            this.RecievedClip.Text = "受け取った内容：";
            // 
            // NowClipBox
            // 
            this.NowClipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NowClipBox.Location = new System.Drawing.Point(12, 27);
            this.NowClipBox.Multiline = true;
            this.NowClipBox.Name = "NowClipBox";
            this.NowClipBox.ReadOnly = true;
            this.NowClipBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NowClipBox.Size = new System.Drawing.Size(361, 62);
            this.NowClipBox.TabIndex = 5;
            // 
            // NowClip
            // 
            this.NowClip.AutoSize = true;
            this.NowClip.Location = new System.Drawing.Point(12, 9);
            this.NowClip.Name = "NowClip";
            this.NowClip.Size = new System.Drawing.Size(146, 15);
            this.NowClip.TabIndex = 4;
            this.NowClip.Text = "現在のクリップボードの内容：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.PasswordCheck);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.ServerStatusLabel);
            this.panel2.Controls.Add(this.ServerOnOffButton);
            this.panel2.Controls.Add(this.PasswordBox);
            this.panel2.Controls.Add(this.PasswordLabel);
            this.panel2.Controls.Add(this.ServerIPLabel);
            this.panel2.Controls.Add(this.ServerIPBox);
            this.panel2.Location = new System.Drawing.Point(13, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 108);
            this.panel2.TabIndex = 1;
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.AutoSize = true;
            this.PasswordCheck.Location = new System.Drawing.Point(268, 47);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(103, 19);
            this.PasswordCheck.TabIndex = 7;
            this.PasswordCheck.Text = "パスワードを保存";
            this.PasswordCheck.UseVisualStyleBackColor = true;
            this.PasswordCheck.CheckedChanged += new System.EventHandler(this.PasswordCheck_CheckedChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(144, 76);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(51, 19);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "未起動";
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.AutoSize = true;
            this.ServerStatusLabel.Location = new System.Drawing.Point(49, 78);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(89, 15);
            this.ServerStatusLabel.TabIndex = 5;
            this.ServerStatusLabel.Text = "サーバーの状態：";
            // 
            // ServerOnOffButton
            // 
            this.ServerOnOffButton.Location = new System.Drawing.Point(201, 72);
            this.ServerOnOffButton.Name = "ServerOnOffButton";
            this.ServerOnOffButton.Size = new System.Drawing.Size(172, 23);
            this.ServerOnOffButton.TabIndex = 4;
            this.ServerOnOffButton.Text = "サーバーを起動する";
            this.ServerOnOffButton.UseVisualStyleBackColor = true;
            this.ServerOnOffButton.Click += new System.EventHandler(this.ServerOnOffButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(144, 43);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.ReadOnly = true;
            this.PasswordBox.Size = new System.Drawing.Size(118, 23);
            this.PasswordBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(75, 46);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "パスワード：";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(12, 12);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(126, 15);
            this.ServerIPLabel.TabIndex = 1;
            this.ServerIPLabel.Text = "クライアントのIPとポート：";
            // 
            // ServerIPBox
            // 
            this.ServerIPBox.Location = new System.Drawing.Point(144, 9);
            this.ServerIPBox.Name = "ServerIPBox";
            this.ServerIPBox.ReadOnly = true;
            this.ServerIPBox.Size = new System.Drawing.Size(229, 23);
            this.ServerIPBox.TabIndex = 0;
            // 
            // ServerNoticeIcon
            // 
            this.ServerNoticeIcon.ContextMenuStrip = this.NoticeContextMenu;
            this.ServerNoticeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ServerNoticeIcon.Icon")));
            this.ServerNoticeIcon.Text = "ClipShare";
            this.ServerNoticeIcon.Visible = true;
            // 
            // NoticeContextMenu
            // 
            this.NoticeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowItem,
            this.CloseItem});
            this.NoticeContextMenu.Name = "NoticeContextMenu";
            this.NoticeContextMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // ShowItem
            // 
            this.ShowItem.Name = "ShowItem";
            this.ShowItem.Size = new System.Drawing.Size(98, 22);
            this.ShowItem.Text = "表示";
            this.ShowItem.Click += new System.EventHandler(this.ShowItem_Click);
            // 
            // CloseItem
            // 
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.Size = new System.Drawing.Size(98, 22);
            this.CloseItem.Text = "終了";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // ClipShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 334);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 373);
            this.MinimumSize = new System.Drawing.Size(417, 236);
            this.Name = "ClipShare";
            this.ShowInTaskbar = false;
            this.Text = "ClipShare";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClopShareClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.NoticeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RecievedClipBox;
        private System.Windows.Forms.Label RecievedClip;
        private System.Windows.Forms.TextBox NowClipBox;
        private System.Windows.Forms.Label NowClip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.TextBox ServerIPBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Button ServerOnOffButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox PasswordCheck;
        private System.Windows.Forms.NotifyIcon ServerNoticeIcon;
        private System.Windows.Forms.ContextMenuStrip NoticeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowItem;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
    }
}

