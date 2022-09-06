
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.title_L = new System.Windows.Forms.Label();
            this.gamePath_L = new System.Windows.Forms.Label();
            this.gamePath_BTN = new System.Windows.Forms.Button();
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
            this.title_L.Size = new System.Drawing.Size(427, 47);
            this.title_L.TabIndex = 0;
            this.title_L.Text = "Unity WebGl LocalHoster";
            // 
            // gamePath_L
            // 
            this.gamePath_L.AutoSize = true;
            this.gamePath_L.BackColor = System.Drawing.Color.Transparent;
            this.gamePath_L.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath_L.ForeColor = System.Drawing.Color.White;
            this.gamePath_L.Location = new System.Drawing.Point(46, 135);
            this.gamePath_L.Name = "gamePath_L";
            this.gamePath_L.Size = new System.Drawing.Size(174, 28);
            this.gamePath_L.TabIndex = 1;
            this.gamePath_L.Text = "WebGl Game Path";
            // 
            // gamePath_BTN
            // 
            this.gamePath_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.gamePath_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamePath_BTN.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePath_BTN.ForeColor = System.Drawing.Color.White;
            this.gamePath_BTN.Location = new System.Drawing.Point(226, 135);
            this.gamePath_BTN.Name = "gamePath_BTN";
            this.gamePath_BTN.Size = new System.Drawing.Size(92, 30);
            this.gamePath_BTN.TabIndex = 2;
            this.gamePath_BTN.Text = "browse";
            this.gamePath_BTN.UseVisualStyleBackColor = false;
            this.gamePath_BTN.Click += new System.EventHandler(this.gamePath_BTN_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            this.BackgroundImage = global::UnityWebGl_LocalHoster.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 733);
            this.Controls.Add(this.gamePath_BTN);
            this.Controls.Add(this.gamePath_L);
            this.Controls.Add(this.title_L);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainPage";
            this.Text = "Unity WebGl LocalHoster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_L;
        private System.Windows.Forms.Label gamePath_L;
        private System.Windows.Forms.Button gamePath_BTN;
    }
}

