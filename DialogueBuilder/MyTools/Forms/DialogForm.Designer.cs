namespace DialogBuilder.MyTools.Forms
{
    partial class DialogForm
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
            lblPrompt = new Label();
            txtInput = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(53, 57);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(100, 32);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Prompt";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(53, 126);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(388, 23);
            txtInput.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.Green;
            btnOk.Location = new Point(53, 192);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 35);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(280, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 35);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Name = "DialogueForm";
            Text = "DialogueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtInput;
        private Button btnOk;
        private Button btnCancel;
    }
}