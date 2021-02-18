
namespace DelegateWinForm
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
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxViewToggle = new System.Windows.Forms.GroupBox();
            this.rbtnDefault = new System.Windows.Forms.RadioButton();
            this.rbtnLastName = new System.Windows.Forms.RadioButton();
            this.rbtnFirstName = new System.Windows.Forms.RadioButton();
            this.rbtnFullName = new System.Windows.Forms.RadioButton();
            this.gbxViewToggle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(261, 80);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(394, 238);
            this.lbxPeople.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 324);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(219, 79);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxViewToggle
            // 
            this.gbxViewToggle.Controls.Add(this.rbtnFullName);
            this.gbxViewToggle.Controls.Add(this.rbtnFirstName);
            this.gbxViewToggle.Controls.Add(this.rbtnLastName);
            this.gbxViewToggle.Controls.Add(this.rbtnDefault);
            this.gbxViewToggle.Location = new System.Drawing.Point(40, 108);
            this.gbxViewToggle.Name = "gbxViewToggle";
            this.gbxViewToggle.Size = new System.Drawing.Size(110, 178);
            this.gbxViewToggle.TabIndex = 2;
            this.gbxViewToggle.TabStop = false;
            this.gbxViewToggle.Text = "View";
            // 
            // rbtnDefault
            // 
            this.rbtnDefault.AutoSize = true;
            this.rbtnDefault.Location = new System.Drawing.Point(7, 34);
            this.rbtnDefault.Name = "rbtnDefault";
            this.rbtnDefault.Size = new System.Drawing.Size(57, 17);
            this.rbtnDefault.TabIndex = 0;
            this.rbtnDefault.TabStop = true;
            this.rbtnDefault.Text = "default";
            this.rbtnDefault.UseVisualStyleBackColor = true;
            // 
            // rbtnLastName
            // 
            this.rbtnLastName.AutoSize = true;
            this.rbtnLastName.Location = new System.Drawing.Point(7, 58);
            this.rbtnLastName.Name = "rbtnLastName";
            this.rbtnLastName.Size = new System.Drawing.Size(71, 17);
            this.rbtnLastName.TabIndex = 1;
            this.rbtnLastName.TabStop = true;
            this.rbtnLastName.Text = "Lastname";
            this.rbtnLastName.UseVisualStyleBackColor = true;
            // 
            // rbtnFirstName
            // 
            this.rbtnFirstName.AutoSize = true;
            this.rbtnFirstName.Location = new System.Drawing.Point(7, 82);
            this.rbtnFirstName.Name = "rbtnFirstName";
            this.rbtnFirstName.Size = new System.Drawing.Size(70, 17);
            this.rbtnFirstName.TabIndex = 2;
            this.rbtnFirstName.TabStop = true;
            this.rbtnFirstName.Text = "Firstname";
            this.rbtnFirstName.UseVisualStyleBackColor = true;
            // 
            // rbtnFullName
            // 
            this.rbtnFullName.AutoSize = true;
            this.rbtnFullName.Location = new System.Drawing.Point(7, 106);
            this.rbtnFullName.Name = "rbtnFullName";
            this.rbtnFullName.Size = new System.Drawing.Size(67, 17);
            this.rbtnFullName.TabIndex = 3;
            this.rbtnFullName.TabStop = true;
            this.rbtnFullName.Text = "Fullname";
            this.rbtnFullName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxViewToggle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbxPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxViewToggle.ResumeLayout(false);
            this.gbxViewToggle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxViewToggle;
        private System.Windows.Forms.RadioButton rbtnFirstName;
        private System.Windows.Forms.RadioButton rbtnLastName;
        private System.Windows.Forms.RadioButton rbtnDefault;
        private System.Windows.Forms.RadioButton rbtnFullName;
    }
}

