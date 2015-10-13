namespace RegularExpressionTesting
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regularExpressionControl = new System.Windows.Forms.TextBox();
            this.contentControl = new System.Windows.Forms.TextBox();
            this.resultControl = new System.Windows.Forms.TextBox();
            this.escapedRegularExpressionControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regularExpressionControl
            // 
            this.regularExpressionControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regularExpressionControl.Location = new System.Drawing.Point(12, 12);
            this.regularExpressionControl.Name = "regularExpressionControl";
            this.regularExpressionControl.Size = new System.Drawing.Size(1121, 20);
            this.regularExpressionControl.TabIndex = 0;
            this.regularExpressionControl.Text = "<link\\s+rel\\s*=\\s*\"image_src\"[^>]+href\\s*=\\s*\"([^\"]+)\"\\s*/>";
            this.regularExpressionControl.TextChanged += new System.EventHandler(this.regularExpressionControl_TextChanged);
            // 
            // contentControl
            // 
            this.contentControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentControl.Location = new System.Drawing.Point(12, 64);
            this.contentControl.MaxLength = 2147483647;
            this.contentControl.Multiline = true;
            this.contentControl.Name = "contentControl";
            this.contentControl.Size = new System.Drawing.Size(1121, 459);
            this.contentControl.TabIndex = 1;
            this.contentControl.Text = resources.GetString("contentControl.Text");
            this.contentControl.TextChanged += new System.EventHandler(this.ContentChanged);
            // 
            // resultControl
            // 
            this.resultControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultControl.Location = new System.Drawing.Point(12, 529);
            this.resultControl.Multiline = true;
            this.resultControl.Name = "resultControl";
            this.resultControl.Size = new System.Drawing.Size(1121, 238);
            this.resultControl.TabIndex = 2;
            // 
            // escapedRegularExpressionControl
            // 
            this.escapedRegularExpressionControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.escapedRegularExpressionControl.Location = new System.Drawing.Point(12, 38);
            this.escapedRegularExpressionControl.Name = "escapedRegularExpressionControl";
            this.escapedRegularExpressionControl.Size = new System.Drawing.Size(1121, 20);
            this.escapedRegularExpressionControl.TabIndex = 5;
            this.escapedRegularExpressionControl.TextChanged += escapedRegularExpressionControl_TextChanged;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 779);
            this.Controls.Add(this.escapedRegularExpressionControl);
            this.Controls.Add(this.resultControl);
            this.Controls.Add(this.contentControl);
            this.Controls.Add(this.regularExpressionControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regularExpressionControl;
        private System.Windows.Forms.TextBox contentControl;
        private System.Windows.Forms.TextBox resultControl;
        private System.Windows.Forms.TextBox escapedRegularExpressionControl;
    }
}

