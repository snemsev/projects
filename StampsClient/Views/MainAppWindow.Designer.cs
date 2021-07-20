
namespace StampsClient
{
    partial class MainAppWindow
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
            this._applicationGrid = new System.Windows.Forms.SplitContainer();
            this.mButtonGroup = new System.Windows.Forms.FlowLayoutPanel();
            this._dbInterfaceBtn = new System.Windows.Forms.Button();
            this._stampsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._applicationGrid)).BeginInit();
            this._applicationGrid.Panel1.SuspendLayout();
            this._applicationGrid.SuspendLayout();
            this.mButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _applicationGrid
            // 
            this._applicationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._applicationGrid.Location = new System.Drawing.Point(0, 0);
            this._applicationGrid.Name = "_applicationGrid";
            // 
            // _applicationGrid.Panel1
            // 
            this._applicationGrid.Panel1.Controls.Add(this.mButtonGroup);
            this._applicationGrid.Size = new System.Drawing.Size(800, 450);
            this._applicationGrid.SplitterDistance = 149;
            this._applicationGrid.TabIndex = 0;
            // 
            // mButtonGroup
            // 
            this.mButtonGroup.Controls.Add(this._dbInterfaceBtn);
            this.mButtonGroup.Controls.Add(this._stampsBtn);
            this.mButtonGroup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mButtonGroup.Location = new System.Drawing.Point(3, 165);
            this.mButtonGroup.Name = "mButtonGroup";
            this.mButtonGroup.Size = new System.Drawing.Size(146, 95);
            this.mButtonGroup.TabIndex = 0;
            // 
            // _dbInterfaceBtn
            // 
            this._dbInterfaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._dbInterfaceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this._dbInterfaceBtn.FlatAppearance.BorderSize = 0;
            this._dbInterfaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._dbInterfaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dbInterfaceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._dbInterfaceBtn.Location = new System.Drawing.Point(3, 3);
            this._dbInterfaceBtn.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this._dbInterfaceBtn.Name = "_dbInterfaceBtn";
            this._dbInterfaceBtn.Size = new System.Drawing.Size(140, 40);
            this._dbInterfaceBtn.TabIndex = 0;
            this._dbInterfaceBtn.Text = "DB Interface";
            this._dbInterfaceBtn.UseVisualStyleBackColor = false;
            // 
            // _stampsBtn
            // 
            this._stampsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this._stampsBtn.FlatAppearance.BorderSize = 0;
            this._stampsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._stampsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._stampsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this._stampsBtn.Location = new System.Drawing.Point(3, 46);
            this._stampsBtn.Margin = new System.Windows.Forms.Padding(3, 0, 1, 3);
            this._stampsBtn.Name = "_stampsBtn";
            this._stampsBtn.Size = new System.Drawing.Size(140, 40);
            this._stampsBtn.TabIndex = 1;
            this._stampsBtn.Text = "Stamps.com";
            this._stampsBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._applicationGrid);
            this.Name = "Form1";
            this.Text = "Stamps Client";
            this._applicationGrid.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._applicationGrid)).EndInit();
            this._applicationGrid.ResumeLayout(false);
            this.mButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _applicationGrid;
        private System.Windows.Forms.FlowLayoutPanel mButtonGroup;
        private System.Windows.Forms.Button _dbInterfaceBtn;
        private System.Windows.Forms.Button _stampsBtn;
    }
}

