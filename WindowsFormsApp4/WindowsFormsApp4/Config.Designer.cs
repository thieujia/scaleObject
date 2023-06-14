
namespace WindowsFormsApp4
{
    partial class Config
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Input = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_app = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(158, 43);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(395, 20);
            this.txt_input.TabIndex = 1;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(158, 88);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(395, 20);
            this.txt_output.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            // 
            // btn_Input
            // 
            this.btn_Input.Location = new System.Drawing.Point(552, 41);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(29, 23);
            this.btn_Input.TabIndex = 5;
            this.btn_Input.Text = "...";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(552, 86);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(29, 23);
            this.btn_output.TabIndex = 6;
            this.btn_output.Text = "...";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(286, 191);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_app
            // 
            this.txt_app.Location = new System.Drawing.Point(158, 134);
            this.txt_app.Name = "txt_app";
            this.txt_app.Size = new System.Drawing.Size(395, 20);
            this.txt_app.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "AppStart";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_app);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_output);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_app;
        private System.Windows.Forms.Label label2;
    }
}