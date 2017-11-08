namespace DXListView
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nORTHWINDDataSet = new DXListView.NORTHWINDDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new DXListView.NORTHWINDDataSetTableAdapters.OrdersTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.btnVOID = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWINDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nORTHWINDDataSet
            // 
            this.nORTHWINDDataSet.DataSetName = "NORTHWINDDataSet";
            this.nORTHWINDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nORTHWINDDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.BackgroundImage = global::DXListView.Properties.Resources.Customers_Ticket;
            this.treeList1.Location = new System.Drawing.Point(432, 38);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(356, 514);
            this.treeList1.TabIndex = 0;
            this.treeList1.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterExpand);
            this.treeList1.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCollapse);
            // 
            // btnVOID
            // 
            this.btnVOID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVOID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVOID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOID.Location = new System.Drawing.Point(715, 555);
            this.btnVOID.Name = "btnVOID";
            this.btnVOID.Size = new System.Drawing.Size(74, 48);
            this.btnVOID.TabIndex = 59;
            this.btnVOID.Text = "VOID";
            this.btnVOID.Click += new System.EventHandler(this.btnVOID_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeading.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(429, -1);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(260, 36);
            this.lblHeading.TabIndex = 60;
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQty.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(703, -1);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(86, 24);
            this.lblQty.TabIndex = 66;
            this.lblQty.Text = "Qty: 1";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(80, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(96, 48);
            this.Button1.TabIndex = 67;
            this.Button1.Text = "Jacket";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(176, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 48);
            this.button2.TabIndex = 68;
            this.button2.Text = "Shirt";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(272, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 69;
            this.button3.Text = "Trousers";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(272, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 48);
            this.button4.TabIndex = 72;
            this.button4.Text = "Trousers";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(176, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 48);
            this.button5.TabIndex = 71;
            this.button5.Text = "Shirt";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(80, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 48);
            this.button6.TabIndex = 70;
            this.button6.Text = "Jacket";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Beige;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(4, 62);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 48);
            this.btn3.TabIndex = 73;
            this.btn3.Text = "2";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Beige;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(4, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 48);
            this.button7.TabIndex = 74;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Beige;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(4, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 48);
            this.button8.TabIndex = 75;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(64, 33);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 48);
            this.button9.TabIndex = 76;
            this.button9.Text = "Grey";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(161, 34);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 48);
            this.button10.TabIndex = 77;
            this.button10.Text = "Lt. Grey";
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(258, 35);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 48);
            this.button11.TabIndex = 78;
            this.button11.Text = "White";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(64, 83);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 48);
            this.button12.TabIndex = 79;
            this.button12.Text = "Navy";
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(161, 83);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 48);
            this.button13.TabIndex = 80;
            this.button13.Text = "Red";
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(258, 83);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(96, 48);
            this.button14.TabIndex = 81;
            this.button14.Text = "Blue";
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(267, 65);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(96, 48);
            this.button15.TabIndex = 87;
            this.button15.Text = "Interlined";
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(170, 65);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 48);
            this.button16.TabIndex = 86;
            this.button16.Text = "Voucher";
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(73, 65);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(96, 48);
            this.button17.TabIndex = 85;
            this.button17.Text = "Stainguarding";
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(267, 17);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(96, 48);
            this.button18.TabIndex = 84;
            this.button18.Text = "Re Proof";
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(170, 16);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 48);
            this.button19.TabIndex = 83;
            this.button19.Text = "Silk";
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(73, 15);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(96, 48);
            this.button20.TabIndex = 82;
            this.button20.Text = "Linen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Location = new System.Drawing.Point(6, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 166);
            this.panel1.TabIndex = 88;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Location = new System.Drawing.Point(8, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 150);
            this.panel2.TabIndex = 89;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Beige;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(4, 168);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(70, 48);
            this.button21.TabIndex = 90;
            this.button21.Text = "4";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(4, 556);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(74, 48);
            this.button22.TabIndex = 91;
            this.button22.Text = "TEST 1";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button23.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(82, 556);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(74, 48);
            this.button23.TabIndex = 92;
            this.button23.Text = "TEST 2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.ControlBox = false;
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnVOID);
            this.Controls.Add(this.treeList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Booking In Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWINDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NORTHWINDDataSet nORTHWINDDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NORTHWINDDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        internal System.Windows.Forms.Button btnVOID;
        internal System.Windows.Forms.Label lblHeading;
        internal System.Windows.Forms.Label lblQty;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button button10;
        internal System.Windows.Forms.Button button11;
        internal System.Windows.Forms.Button button12;
        internal System.Windows.Forms.Button button13;
        internal System.Windows.Forms.Button button14;
        internal System.Windows.Forms.Button button15;
        internal System.Windows.Forms.Button button16;
        internal System.Windows.Forms.Button button17;
        internal System.Windows.Forms.Button button18;
        internal System.Windows.Forms.Button button19;
        internal System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button button21;
        internal System.Windows.Forms.Button button22;
        internal System.Windows.Forms.Button button23;
    }
}