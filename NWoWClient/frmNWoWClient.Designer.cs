namespace NWoWClient
{
    partial class frmNWoWClient
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
            this.lblObjectType = new System.Windows.Forms.Label();
            this.tbCharacterName = new System.Windows.Forms.TextBox();
            this.btnGetObject = new System.Windows.Forms.Button();
            this.cbObjectType = new System.Windows.Forms.ComboBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(3, 12);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(94, 13);
            this.lblObjectType.TabIndex = 0;
            this.lblObjectType.Text = "Object type to get:";
            // 
            // tbCharacterName
            // 
            this.tbCharacterName.Location = new System.Drawing.Point(103, 39);
            this.tbCharacterName.Name = "tbCharacterName";
            this.tbCharacterName.Size = new System.Drawing.Size(169, 20);
            this.tbCharacterName.TabIndex = 1;
            // 
            // btnGetObject
            // 
            this.btnGetObject.Location = new System.Drawing.Point(12, 116);
            this.btnGetObject.Name = "btnGetObject";
            this.btnGetObject.Size = new System.Drawing.Size(260, 23);
            this.btnGetObject.TabIndex = 3;
            this.btnGetObject.Text = "Get object";
            this.btnGetObject.UseVisualStyleBackColor = true;
            this.btnGetObject.Click += new System.EventHandler(this.btnGetObject_Click);
            // 
            // cbObjectType
            // 
            this.cbObjectType.FormattingEnabled = true;
            this.cbObjectType.Items.AddRange(new object[] {
            "Character"});
            this.cbObjectType.Location = new System.Drawing.Point(103, 12);
            this.cbObjectType.Name = "cbObjectType";
            this.cbObjectType.Size = new System.Drawing.Size(169, 21);
            this.cbObjectType.TabIndex = 0;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(3, 42);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(85, 13);
            this.lblCharacterName.TabIndex = 4;
            this.lblCharacterName.Text = "Character name:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(3, 65);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server:";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(103, 65);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(169, 21);
            this.cbServer.TabIndex = 2;
            // 
            // frmNWoWClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.cbObjectType);
            this.Controls.Add(this.btnGetObject);
            this.Controls.Add(this.tbCharacterName);
            this.Controls.Add(this.lblObjectType);
            this.Name = "frmNWoWClient";
            this.Text = "frmNWoWClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.TextBox tbCharacterName;
        private System.Windows.Forms.Button btnGetObject;
        private System.Windows.Forms.ComboBox cbObjectType;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbServer;
    }
}