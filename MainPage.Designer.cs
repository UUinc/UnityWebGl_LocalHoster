
namespace UnityWebGl_LocalHoster
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.title_L = new System.Windows.Forms.Label();
            this.gamePath_L = new System.Windows.Forms.Label();
            this.gamePath_BTN = new System.Windows.Forms.Button();
            this.port_L = new System.Windows.Forms.Label();
            this.port_TB = new System.Windows.Forms.TextBox();
            this.start_BTN = new System.Windows.Forms.Button();
            this.folderPathName_L = new System.Windows.Forms.Label();
            this.version_L = new System.Windows.Forms.Label();
            this.localhostLink_L = new System.Windows.Forms.Label();
            this.gamePath_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // title_L
            // 
            this.title_L.AutoSize = true;
            this.title_L.BackColor = System.Drawing.Color.Transparent;
            this.title_L.Font = new System.Drawing.Font("Source Sans Pro", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_L.ForeColor = System.Drawing.Color.White;
            this.title_L.Location = new System.Drawing.Point(34, 33);
            this.title_L.Name = "title_L";
            this.title_L.Size = new System.Drawing.Size(435, 47);
            this.title_L.TabIndex = 0;
            this.title_L.Text = "Unity WebGl Local Hoster";
            // 
            // gamePath_L
            // 
            this.gamePath_L.AutoSize = true;
            this.gamePath_L.BackColor = System.Drawing.Color.Transparent;
            this.gamePath_L.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath_L.ForeColor = System.Drawing.Color.White;
            this.gamePath_L.Location = new System.Drawing.Point(46, 135);
            this.gamePath_L.Name = "gamePath_L";
            this.gamePath_L.Size = new System.Drawing.Size(182, 28);
            this.gamePath_L.TabIndex = 1;
            this.gamePath_L.Text = "WebGl Game Path*";
            // 
            // gamePath_BTN
            // 
            this.gamePath_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.gamePath_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamePath_BTN.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath_BTN.ForeColor = System.Drawing.Color.White;
            this.gamePath_BTN.Location = new System.Drawing.Point(231, 135);
            this.gamePath_BTN.Name = "gamePath_BTN";
            this.gamePath_BTN.Size = new System.Drawing.Size(92, 30);
            this.gamePath_BTN.TabIndex = 2;
            this.gamePath_BTN.Text = "browse";
            this.gamePath_BTN.UseVisualStyleBackColor = false;
            this.gamePath_BTN.Click += new System.EventHandler(this.gamePath_BTN_Click);
            // 
            // port_L
            // 
            this.port_L.AutoSize = true;
            this.port_L.BackColor = System.Drawing.Color.Transparent;
            this.port_L.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_L.ForeColor = System.Drawing.Color.White;
            this.port_L.Location = new System.Drawing.Point(46, 198);
            this.port_L.Name = "port_L";
            this.port_L.Size = new System.Drawing.Size(51, 28);
            this.port_L.TabIndex = 3;
            this.port_L.Text = "Port";
            // 
            // port_TB
            // 
            this.port_TB.BackColor = System.Drawing.Color.White;
            this.port_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port_TB.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_TB.ForeColor = System.Drawing.Color.Black;
            this.port_TB.Location = new System.Drawing.Point(231, 200);
            this.port_TB.MaxLength = 4;
            this.port_TB.Name = "port_TB";
            this.port_TB.Size = new System.Drawing.Size(92, 26);
            this.port_TB.TabIndex = 4;
            this.port_TB.Text = "8000";
            this.port_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_BTN
            // 
            this.start_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.start_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_BTN.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_BTN.ForeColor = System.Drawing.Color.White;
            this.start_BTN.Location = new System.Drawing.Point(128, 333);
            this.start_BTN.Name = "start_BTN";
            this.start_BTN.Size = new System.Drawing.Size(120, 40);
            this.start_BTN.TabIndex = 5;
            this.start_BTN.Text = "start localhost";
            this.start_BTN.UseVisualStyleBackColor = false;
            this.start_BTN.Click += new System.EventHandler(this.start_BTN_Click);
            // 
            // folderPathName_L
            // 
            this.folderPathName_L.AutoSize = true;
            this.folderPathName_L.BackColor = System.Drawing.Color.Transparent;
            this.folderPathName_L.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderPathName_L.ForeColor = System.Drawing.Color.White;
            this.folderPathName_L.Location = new System.Drawing.Point(330, 141);
            this.folderPathName_L.Name = "folderPathName_L";
            this.folderPathName_L.Size = new System.Drawing.Size(0, 18);
            this.folderPathName_L.TabIndex = 6;
            // 
            // version_L
            // 
            this.version_L.AutoSize = true;
            this.version_L.BackColor = System.Drawing.Color.Transparent;
            this.version_L.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_L.ForeColor = System.Drawing.Color.White;
            this.version_L.Location = new System.Drawing.Point(46, 263);
            this.version_L.Name = "version_L";
            this.version_L.Size = new System.Drawing.Size(80, 28);
            this.version_L.TabIndex = 8;
            this.version_L.Text = "Version";
            // 
            // localhostLink_L
            // 
            this.localhostLink_L.AutoSize = true;
            this.localhostLink_L.BackColor = System.Drawing.Color.Transparent;
            this.localhostLink_L.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localhostLink_L.ForeColor = System.Drawing.Color.White;
            this.localhostLink_L.Location = new System.Drawing.Point(122, 387);
            this.localhostLink_L.Name = "localhostLink_L";
            this.localhostLink_L.Size = new System.Drawing.Size(0, 18);
            this.localhostLink_L.TabIndex = 9;
            this.localhostLink_L.Click += new System.EventHandler(this.localhostLink_L_Click);
            // 
            // gamePath_toolTip
            // 
            this.gamePath_toolTip.ShowAlways = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.BackgroundImage = global::UnityWebGl_LocalHoster.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 733);
            this.Controls.Add(this.localhostLink_L);
            this.Controls.Add(this.version_L);
            this.Controls.Add(this.folderPathName_L);
            this.Controls.Add(this.start_BTN);
            this.Controls.Add(this.port_TB);
            this.Controls.Add(this.port_L);
            this.Controls.Add(this.gamePath_BTN);
            this.Controls.Add(this.gamePath_L);
            this.Controls.Add(this.title_L);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainPage";
            this.Text = "Unity WebGl Local Hoster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_L;
        private System.Windows.Forms.Label gamePath_L;
        private System.Windows.Forms.Button gamePath_BTN;
        private System.Windows.Forms.Label port_L;
        private System.Windows.Forms.TextBox port_TB;
        private System.Windows.Forms.Button start_BTN;
        private System.Windows.Forms.Label folderPathName_L;
        private System.Windows.Forms.Label version_L;
        private System.Windows.Forms.Label localhostLink_L;
        private System.Windows.Forms.ToolTip gamePath_toolTip;
    }
}

