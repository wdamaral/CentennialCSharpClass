namespace Assignment4
{
    partial class FormAddCourse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEvaluations = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtNoEvaluations = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblEvaluations);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblCourseCode);
            this.panel1.Controls.Add(this.txtNoEvaluations);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCourseCode);
            this.panel1.Location = new System.Drawing.Point(63, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 480);
            this.panel1.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(297, 209);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(572, 136);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(116, 256);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(158, 32);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblEvaluations
            // 
            this.lblEvaluations.AutoSize = true;
            this.lblEvaluations.Location = new System.Drawing.Point(39, 388);
            this.lblEvaluations.Name = "lblEvaluations";
            this.lblEvaluations.Size = new System.Drawing.Size(235, 32);
            this.lblEvaluations.TabIndex = 5;
            this.lblEvaluations.Text = "No of evaluations";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(184, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(99, 51);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(175, 32);
            this.lblCourseCode.TabIndex = 3;
            this.lblCourseCode.Text = "Course code";
            // 
            // txtNoEvaluations
            // 
            this.txtNoEvaluations.Location = new System.Drawing.Point(297, 386);
            this.txtNoEvaluations.Name = "txtNoEvaluations";
            this.txtNoEvaluations.Size = new System.Drawing.Size(177, 38);
            this.txtNoEvaluations.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(297, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(572, 38);
            this.txtName.TabIndex = 1;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCourseCode.Location = new System.Drawing.Point(297, 51);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(237, 38);
            this.txtCourseCode.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Assignment4.Properties.Resources.reset_128;
            this.btnReset.Location = new System.Drawing.Point(834, 591);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 129);
            this.btnReset.TabIndex = 5;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Assignment4.Properties.Resources.save_128;
            this.btnSave.Location = new System.Drawing.Point(658, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 129);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wagner D\'Amaral - 300932673";
            // 
            // FormAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddCourse";
            this.Text = "Add Course";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEvaluations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.NumericUpDown txtNoEvaluations;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEvaluations;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
    }
}