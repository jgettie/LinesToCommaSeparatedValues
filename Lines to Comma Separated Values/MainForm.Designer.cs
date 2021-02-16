namespace Lines_to_Comma_Separated_Values
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboardAsCommaSeparatedValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(13, 13);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(547, 271);
            this.txtValue.TabIndex = 0;
            this.txtValue.WordWrap = false;
            // 
            // btnCopyToClipboardAsCommaSeparatedValues
            // 
            this.btnCopyToClipboardAsCommaSeparatedValues.Location = new System.Drawing.Point(148, 290);
            this.btnCopyToClipboardAsCommaSeparatedValues.Name = "btnCopyToClipboardAsCommaSeparatedValues";
            this.btnCopyToClipboardAsCommaSeparatedValues.Size = new System.Drawing.Size(276, 23);
            this.btnCopyToClipboardAsCommaSeparatedValues.TabIndex = 1;
            this.btnCopyToClipboardAsCommaSeparatedValues.Text = "Copy to Clipboard as Comma Separated Values";
            this.btnCopyToClipboardAsCommaSeparatedValues.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardAsCommaSeparatedValues.Click += new System.EventHandler(this.btnCopyToClipboardAsCommaSeparatedValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 320);
            this.Controls.Add(this.btnCopyToClipboardAsCommaSeparatedValues);
            this.Controls.Add(this.txtValue);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lines to Comma Separated Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCopyToClipboardAsCommaSeparatedValues;
    }
}

