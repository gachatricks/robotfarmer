namespace RobotFarmer
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
            this.AutoFarmTimer = new System.Windows.Forms.Timer(this.components);
            this.startB = new System.Windows.Forms.Button();
            this.reloadB = new System.Windows.Forms.Button();
            this.stepsLB = new System.Windows.Forms.Label();
            this.findBW = new System.ComponentModel.BackgroundWorker();
            this.forwardB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delayNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stepNUD = new System.Windows.Forms.NumericUpDown();
            this.addB = new System.Windows.Forms.Button();
            this.resetB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delayLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoFarmTimer
            // 
            this.AutoFarmTimer.Interval = 1000;
            this.AutoFarmTimer.Tick += new System.EventHandler(this.AutoFarmTimer_Tick);
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.DarkGreen;
            this.startB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startB.ForeColor = System.Drawing.Color.White;
            this.startB.Location = new System.Drawing.Point(381, 177);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(117, 44);
            this.startB.TabIndex = 0;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // reloadB
            // 
            this.reloadB.BackColor = System.Drawing.Color.Black;
            this.reloadB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadB.ForeColor = System.Drawing.Color.White;
            this.reloadB.Location = new System.Drawing.Point(284, 177);
            this.reloadB.Name = "reloadB";
            this.reloadB.Size = new System.Drawing.Size(91, 44);
            this.reloadB.TabIndex = 1;
            this.reloadB.Text = "Reload";
            this.reloadB.UseVisualStyleBackColor = false;
            this.reloadB.Click += new System.EventHandler(this.reloadB_Click);
            // 
            // stepsLB
            // 
            this.stepsLB.AutoSize = true;
            this.stepsLB.BackColor = System.Drawing.Color.Transparent;
            this.stepsLB.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsLB.Location = new System.Drawing.Point(9, 181);
            this.stepsLB.Name = "stepsLB";
            this.stepsLB.Size = new System.Drawing.Size(213, 36);
            this.stepsLB.TabIndex = 2;
            this.stepsLB.Text = "Steps: 100/100";
            // 
            // findBW
            // 
            this.findBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.findBW_DoWork);
            this.findBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.findBW_RunWorkerCompleted);
            // 
            // forwardB
            // 
            this.forwardB.BackColor = System.Drawing.Color.White;
            this.forwardB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forwardB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardB.ForeColor = System.Drawing.Color.Black;
            this.forwardB.Location = new System.Drawing.Point(238, 177);
            this.forwardB.Name = "forwardB";
            this.forwardB.Size = new System.Drawing.Size(40, 44);
            this.forwardB.TabIndex = 5;
            this.forwardB.Text = ">>";
            this.forwardB.UseVisualStyleBackColor = false;
            this.forwardB.Click += new System.EventHandler(this.forwardB_Click);
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.White;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.ForeColor = System.Drawing.Color.Black;
            this.backB.Location = new System.Drawing.Point(192, 177);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(40, 44);
            this.backB.TabIndex = 6;
            this.backB.Text = "<<";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Controls.Add(this.delayLB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.resetB);
            this.groupBox1.Controls.Add(this.addB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stepNUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delayNUD);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // delayNUD
            // 
            this.delayNUD.Location = new System.Drawing.Point(7, 30);
            this.delayNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.delayNUD.Name = "delayNUD";
            this.delayNUD.Size = new System.Drawing.Size(95, 26);
            this.delayNUD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step";
            // 
            // stepNUD
            // 
            this.stepNUD.Location = new System.Drawing.Point(7, 88);
            this.stepNUD.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.stepNUD.Name = "stepNUD";
            this.stepNUD.Size = new System.Drawing.Size(95, 26);
            this.stepNUD.TabIndex = 3;
            // 
            // addB
            // 
            this.addB.BackColor = System.Drawing.Color.DarkGreen;
            this.addB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.ForeColor = System.Drawing.Color.White;
            this.addB.Location = new System.Drawing.Point(220, 26);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(117, 44);
            this.addB.TabIndex = 5;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = false;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // resetB
            // 
            this.resetB.BackColor = System.Drawing.Color.White;
            this.resetB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetB.ForeColor = System.Drawing.Color.Black;
            this.resetB.Location = new System.Drawing.Point(220, 77);
            this.resetB.Name = "resetB";
            this.resetB.Size = new System.Drawing.Size(117, 44);
            this.resetB.TabIndex = 7;
            this.resetB.Text = "Remove";
            this.resetB.UseVisualStyleBackColor = false;
            this.resetB.Click += new System.EventHandler(this.resetB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Delay:";
            // 
            // delayLB
            // 
            this.delayLB.AutoSize = true;
            this.delayLB.BackColor = System.Drawing.Color.Black;
            this.delayLB.ForeColor = System.Drawing.Color.GreenYellow;
            this.delayLB.Location = new System.Drawing.Point(123, 127);
            this.delayLB.Name = "delayLB";
            this.delayLB.Size = new System.Drawing.Size(72, 19);
            this.delayLB.TabIndex = 9;
            this.delayLB.Text = "1000 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::RobotFarmer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(510, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.forwardB);
            this.Controls.Add(this.stepsLB);
            this.Controls.Add(this.reloadB);
            this.Controls.Add(this.startB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 480);
            this.MinimumSize = new System.Drawing.Size(526, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Farmer (Version 2.0) - Nox 6.2.5.0 Support";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AutoFarmTimer;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button reloadB;
        private System.Windows.Forms.Label stepsLB;
        private System.ComponentModel.BackgroundWorker findBW;
        private System.Windows.Forms.Button forwardB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown delayNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stepNUD;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button resetB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label delayLB;
    }
}

