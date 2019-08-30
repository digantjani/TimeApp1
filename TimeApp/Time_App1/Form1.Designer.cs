namespace Time_App1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.starguideDataSet = new Time_App1.StarguideDataSet();
            this.agentStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agent_StatusTableAdapter = new Time_App1.StarguideDataSetTableAdapters.Agent_StatusTableAdapter();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn__login_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.starguideDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clock In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(205, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clock Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // starguideDataSet
            // 
            this.starguideDataSet.DataSetName = "StarguideDataSet";
            this.starguideDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentStatusBindingSource
            // 
            this.agentStatusBindingSource.DataMember = "Agent_Status";
            this.agentStatusBindingSource.DataSource = this.starguideDataSet;
            // 
            // agent_StatusTableAdapter
            // 
            this.agent_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::Time_App1.Properties.Resources.minimize_icon;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(385, 2);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn__login_exit
            // 
            this.btn__login_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn__login_exit.BackgroundImage = global::Time_App1.Properties.Resources.close_iconm;
            this.btn__login_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn__login_exit.FlatAppearance.BorderSize = 0;
            this.btn__login_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn__login_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn__login_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__login_exit.Location = new System.Drawing.Point(408, 2);
            this.btn__login_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn__login_exit.Name = "btn__login_exit";
            this.btn__login_exit.Size = new System.Drawing.Size(20, 20);
            this.btn__login_exit.TabIndex = 5;
            this.btn__login_exit.UseVisualStyleBackColor = false;
            this.btn__login_exit.Click += new System.EventHandler(this.btn__login_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Time_App1.Properties.Resources.pets;
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clock IN/OUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn__login_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock In/Out";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.starguideDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private StarguideDataSet starguideDataSet;
        private System.Windows.Forms.BindingSource agentStatusBindingSource;
        private StarguideDataSetTableAdapters.Agent_StatusTableAdapter agent_StatusTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btn_minimize;
        internal System.Windows.Forms.Button btn__login_exit;
        private System.Windows.Forms.Label label2;
    }
}

