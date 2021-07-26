
namespace StampsClient
{
    partial class DataBaseView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Cl
        /// 
        /// ean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this._mainPanel = new System.Windows.Forms.FlowLayoutPanel();
      this._databaseFilePicker = new System.Windows.Forms.FlowLayoutPanel();
      this._databaseFileName = new System.Windows.Forms.TextBox();
      this._browseButton = new System.Windows.Forms.Button();
      this._databaseContents = new System.Windows.Forms.DataGridView();
      this._mainPanel.SuspendLayout();
      this._databaseFilePicker.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._databaseContents)).BeginInit();
      this.SuspendLayout();
      // 
      // _mainPanel
      // 
      this._mainPanel.AutoScroll = true;
      this._mainPanel.AutoSize = true;
      this._mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this._mainPanel.BackColor = System.Drawing.Color.White;
      this._mainPanel.Controls.Add(this._databaseFilePicker);
      this._mainPanel.Controls.Add(this._databaseContents);
      this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this._mainPanel.Location = new System.Drawing.Point(0, 0);
      this._mainPanel.MinimumSize = new System.Drawing.Size(720, 550);
      this._mainPanel.Name = "_mainPanel";
      this._mainPanel.Size = new System.Drawing.Size(720, 550);
      this._mainPanel.TabIndex = 1;
      // 
      // _databaseFilePicker
      // 
      this._databaseFilePicker.AutoSize = true;
      this._databaseFilePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this._databaseFilePicker.BackColor = System.Drawing.Color.White;
      this._databaseFilePicker.Controls.Add(this._databaseFileName);
      this._databaseFilePicker.Controls.Add(this._browseButton);
      this._databaseFilePicker.Dock = System.Windows.Forms.DockStyle.Left;
      this._databaseFilePicker.Location = new System.Drawing.Point(3, 3);
      this._databaseFilePicker.MinimumSize = new System.Drawing.Size(520, 35);
      this._databaseFilePicker.Name = "_databaseFilePicker";
      this._databaseFilePicker.Size = new System.Drawing.Size(520, 35);
      this._databaseFilePicker.TabIndex = 0;
      // 
      // _databaseFileName
      // 
      this._databaseFileName.BackColor = System.Drawing.Color.White;
      this._databaseFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this._databaseFileName.Dock = System.Windows.Forms.DockStyle.Left;
      this._databaseFileName.Location = new System.Drawing.Point(3, 3);
      this._databaseFileName.MaximumSize = new System.Drawing.Size(1000, 24);
      this._databaseFileName.MinimumSize = new System.Drawing.Size(411, 24);
      this._databaseFileName.Name = "_databaseFileName";
      this._databaseFileName.ReadOnly = true;
      this._databaseFileName.Size = new System.Drawing.Size(411, 24);
      this._databaseFileName.TabIndex = 0;
      // 
      // _browseButton
      // 
      this._browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this._browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
      this._browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this._browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._browseButton.ForeColor = System.Drawing.SystemColors.Control;
      this._browseButton.Location = new System.Drawing.Point(420, 2);
      this._browseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
      this._browseButton.Name = "_browseButton";
      this._browseButton.Size = new System.Drawing.Size(75, 23);
      this._browseButton.TabIndex = 1;
      this._browseButton.Text = "Browse";
      this._browseButton.UseVisualStyleBackColor = false;
      // 
      // _databaseContents
      // 
      this._databaseContents.AllowUserToAddRows = false;
      this._databaseContents.AllowUserToDeleteRows = false;
      this._databaseContents.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._databaseContents.BackgroundColor = System.Drawing.Color.White;
      this._databaseContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this._databaseContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._databaseContents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this._databaseContents.Location = new System.Drawing.Point(3, 44);
      this._databaseContents.MinimumSize = new System.Drawing.Size(700, 480);
      this._databaseContents.Name = "_databaseContents";
      this._databaseContents.ReadOnly = true;
      this._databaseContents.Size = new System.Drawing.Size(700, 500);
      this._databaseContents.TabIndex = 1;
      // 
      // DataBaseView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.CausesValidation = false;
      this.Controls.Add(this._mainPanel);
      this.Name = "DataBaseView";
      this.Size = new System.Drawing.Size(720, 550);
      this._mainPanel.ResumeLayout(false);
      this._mainPanel.PerformLayout();
      this._databaseFilePicker.ResumeLayout(false);
      this._databaseFilePicker.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._databaseContents)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel _mainPanel;
    private System.Windows.Forms.FlowLayoutPanel _databaseFilePicker;
    private System.Windows.Forms.TextBox _databaseFileName;
    private System.Windows.Forms.Button _browseButton;
    private System.Windows.Forms.DataGridView _databaseContents;
  }
}
