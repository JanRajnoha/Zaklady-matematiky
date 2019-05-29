namespace Mate_version2
{
    partial class aktualizace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aktualizace));
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.load_pic = new System.Windows.Forms.PictureBox();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Expo", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(55, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(306, 33);
            this.Title.TabIndex = 422;
            this.Title.Text = "Aktualizace programu";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.Color.Black;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(450, 40);
            this.presunpanel.TabIndex = 424;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Expo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.status.Location = new System.Drawing.Point(68, 57);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(368, 53);
            this.status.TabIndex = 425;
            this.status.Text = "Program hledá aktualizace";
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.Transparent;
            this.cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel.Location = new System.Drawing.Point(102, 113);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(244, 50);
            this.cancel.TabIndex = 426;
            this.cancel.Text = "Storno";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 428;
            this.label1.Text = "Základy matematiky";
            this.label1.Visible = false;
            // 
            // load_pic
            // 
            this.load_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_pic.Location = new System.Drawing.Point(12, 46);
            this.load_pic.Name = "load_pic";
            this.load_pic.Size = new System.Drawing.Size(50, 50);
            this.load_pic.TabIndex = 427;
            this.load_pic.TabStop = false;
            this.load_pic.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.nacteno);
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.Color.Black;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.aktualizace;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 423;
            this.icoprog.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 429;
            this.label2.Text = "Základy matematiky";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 430;
            this.label3.Text = "Základy matematiky";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 431;
            this.label4.Text = "Základy matematiky";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 432;
            this.label5.Text = "Základy matematiky";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 433;
            this.label6.Text = "Základy matematiky";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 434;
            this.label7.Text = "Základy matematiky";
            this.label7.Visible = false;
            // 
            // aktualizace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(448, 175);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_pic);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aktualizace";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "aktualizace";
            this.Load += new System.EventHandler(this.aktualizace_Load);
            this.Shown += new System.EventHandler(this.nacteno);
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label presunpanel;
        private System.Windows.Forms.PictureBox load_pic;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer time;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label status;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
    }
}