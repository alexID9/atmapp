namespace atmapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            amountlbl = new Label();
            pinlbl = new Label();
            pinbox = new MaskedTextBox();
            amountbox = new TextBox();
            submitbtn = new Button();
            amounterror = new ErrorProvider(components);
            pinerror = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)amounterror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pinerror).BeginInit();
            SuspendLayout();
            // 
            // amountlbl
            // 
            amountlbl.AutoSize = true;
            amountlbl.Location = new Point(59, 46);
            amountlbl.Name = "amountlbl";
            amountlbl.Size = new Size(74, 25);
            amountlbl.TabIndex = 0;
            amountlbl.Text = "amount";
            // 
            // pinlbl
            // 
            pinlbl.AutoSize = true;
            pinlbl.Location = new Point(59, 115);
            pinlbl.Name = "pinlbl";
            pinlbl.Size = new Size(40, 25);
            pinlbl.TabIndex = 1;
            pinlbl.Text = "PIN";
            // 
            // pinbox
            // 
            pinbox.Location = new Point(59, 143);
            pinbox.Name = "pinbox";
            pinbox.PasswordChar = '$';
            pinbox.Size = new Size(150, 31);
            pinbox.TabIndex = 2;
            // 
            // amountbox
            // 
            amountbox.Location = new Point(59, 74);
            amountbox.Name = "amountbox";
            amountbox.Size = new Size(150, 31);
            amountbox.TabIndex = 3;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(97, 208);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(112, 34);
            submitbtn.TabIndex = 4;
            submitbtn.Text = "submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += Submition;
            // 
            // amounterror
            // 
            amounterror.ContainerControl = this;
            // 
            // pinerror
            // 
            pinerror.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(submitbtn);
            Controls.Add(amountbox);
            Controls.Add(pinbox);
            Controls.Add(pinlbl);
            Controls.Add(amountlbl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amounterror).EndInit();
            ((System.ComponentModel.ISupportInitialize)pinerror).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label amountlbl;
        private Label pinlbl;
        private MaskedTextBox pinbox;
        private TextBox amountbox;
        private Button submitbtn;
        private ErrorProvider amounterror;
        private ErrorProvider pinerror;
    }
}