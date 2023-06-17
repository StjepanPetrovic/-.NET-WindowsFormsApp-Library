namespace Library
{
    partial class AddMemberForm
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(106, 28);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(169, 22);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(106, 70);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(169, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(162, 110);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(113, 23);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add a member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 155);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Name = "AddMemberForm";
            this.Text = "Add a member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAddMember;
    }
}

