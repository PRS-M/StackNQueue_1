namespace StackNQueue_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.Label();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(112, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 20);
            this.nameBox.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(15, 32);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(229, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Location = new System.Drawing.Point(125, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 213);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(107, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            // 
            // nextInLine
            // 
            this.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextInLine.Location = new System.Drawing.Point(6, 163);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(107, 36);
            this.nextInLine.TabIndex = 6;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(6, 137);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(107, 23);
            this.addFlapjacks.TabIndex = 6;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 68);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 8;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(6, 91);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 9;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(6, 114);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 10;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 19);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(63, 20);
            this.howMany.TabIndex = 7;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(6, 45);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 7;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(15, 91);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(104, 212);
            this.line.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breakfast line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.Label nextInLine;
    }
}

