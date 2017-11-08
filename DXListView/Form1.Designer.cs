namespace DXListView
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
            this.btnVOID = new System.Windows.Forms.Button();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVOID
            // 
            this.btnVOID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVOID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVOID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOID.Location = new System.Drawing.Point(715, 529);
            this.btnVOID.Name = "btnVOID";
            this.btnVOID.Size = new System.Drawing.Size(74, 48);
            this.btnVOID.TabIndex = 61;
            this.btnVOID.Text = "VOID";
            this.btnVOID.Click += new System.EventHandler(this.btnVOID_Click);
            // 
            // treeList1
            // 
            this.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.Red;
            this.treeList1.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeList1.AppearancePrint.Row.Image = global::DXListView.Properties.Resources.Customers_Ticket;
            this.treeList1.AppearancePrint.Row.Options.UseImage = true;
            this.treeList1.BackgroundImage = global::DXListView.Properties.Resources.Customers_Ticket;
            this.treeList1.BestFitVisibleOnly = true;
            this.treeList1.Location = new System.Drawing.Point(432, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(356, 514);
            this.treeList1.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.ControlBox = false;
            this.Controls.Add(this.btnVOID);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tree View Test 1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnVOID;
        private DevExpress.XtraTreeList.TreeList treeList1;
    }
}