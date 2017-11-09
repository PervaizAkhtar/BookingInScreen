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
            this.lblQty = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelFabric = new System.Windows.Forms.Panel();
            this.panelPlu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.lblTicketTotal = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWINDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.panelColor.SuspendLayout();
            this.panelFabric.SuspendLayout();
            this.panelPlu.SuspendLayout();
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
            this.treeList1.Appearance.Row.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.treeList1.Appearance.Row.Options.UseFont = true;
            this.treeList1.BackgroundImage = global::DXListView.Properties.Resources.Customers_Ticket;
            this.treeList1.CausesValidation = false;
            this.treeList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList1.Location = new System.Drawing.Point(433, 60);
            this.treeList1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.treeList1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.treeList1.LookAndFeel.TouchUI = true;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Margin = new System.Windows.Forms.Padding(6);
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
            this.btnVOID.Location = new System.Drawing.Point(715, 575);
            this.btnVOID.Name = "btnVOID";
            this.btnVOID.Size = new System.Drawing.Size(74, 48);
            this.btnVOID.TabIndex = 59;
            this.btnVOID.Text = "VOID";
            this.btnVOID.Click += new System.EventHandler(this.btnVOID_Click);
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQty.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(703, 9);
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
            this.Button1.Location = new System.Drawing.Point(78, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(96, 48);
            this.Button1.TabIndex = 67;
            this.Button1.Tag = "5.50";
            this.Button1.Text = "Jacket";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(174, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 48);
            this.button2.TabIndex = 68;
            this.button2.Tag = "2.50";
            this.button2.Text = "Shirt";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(270, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 69;
            this.button3.Tag = "3.50";
            this.button3.Text = "Trousers";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(270, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 48);
            this.button4.TabIndex = 72;
            this.button4.Tag = "20";
            this.button4.Text = "Coat";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(174, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 48);
            this.button5.TabIndex = 71;
            this.button5.Tag = "100.50";
            this.button5.Text = "3 Piece Suit";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(78, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 48);
            this.button6.TabIndex = 70;
            this.button6.Tag = "10.50";
            this.button6.Text = "2 Piece Suit";
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Beige;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(2, 54);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 48);
            this.btn3.TabIndex = 73;
            this.btn3.Text = "2";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Beige;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(2, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 48);
            this.button7.TabIndex = 74;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(76, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 48);
            this.button9.TabIndex = 76;
            this.button9.Tag = "1.00";
            this.button9.Text = "Grey";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(173, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 48);
            this.button10.TabIndex = 77;
            this.button10.Tag = "10.50";
            this.button10.Text = "Lt. Grey";
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(270, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 48);
            this.button11.TabIndex = 78;
            this.button11.Tag = "0.00";
            this.button11.Text = "White";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(76, 50);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 48);
            this.button12.TabIndex = 79;
            this.button12.Tag = "1.50";
            this.button12.Text = "Navy";
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(173, 50);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 48);
            this.button13.TabIndex = 80;
            this.button13.Tag = "1.20";
            this.button13.Text = "Red";
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(270, 50);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(96, 48);
            this.button14.TabIndex = 81;
            this.button14.Tag = "1.30";
            this.button14.Text = "Blue";
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(268, 53);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(96, 48);
            this.button15.TabIndex = 87;
            this.button15.Tag = "1.30";
            this.button15.Text = "Interlined";
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(171, 53);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(96, 48);
            this.button16.TabIndex = 86;
            this.button16.Tag = "2.50";
            this.button16.Text = "Voucher";
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(74, 53);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(96, 48);
            this.button17.TabIndex = 85;
            this.button17.Tag = "1.50";
            this.button17.Text = "Stainguarding";
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(268, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(96, 48);
            this.button18.TabIndex = 84;
            this.button18.Tag = "0.00";
            this.button18.Text = "Re Proof";
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(171, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 48);
            this.button19.TabIndex = 83;
            this.button19.Tag = "1.50";
            this.button19.Text = "Silk";
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(74, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(96, 48);
            this.button20.TabIndex = 82;
            this.button20.Tag = "0.20";
            this.button20.Text = "Linen";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.panelColor.Controls.Add(this.button14);
            this.panelColor.Controls.Add(this.button13);
            this.panelColor.Controls.Add(this.button12);
            this.panelColor.Controls.Add(this.button11);
            this.panelColor.Controls.Add(this.button10);
            this.panelColor.Controls.Add(this.button9);
            this.panelColor.Location = new System.Drawing.Point(4, 120);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(366, 105);
            this.panelColor.TabIndex = 88;
            this.panelColor.Visible = false;
            // 
            // panelFabric
            // 
            this.panelFabric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.panelFabric.Controls.Add(this.button15);
            this.panelFabric.Controls.Add(this.button16);
            this.panelFabric.Controls.Add(this.button17);
            this.panelFabric.Controls.Add(this.button18);
            this.panelFabric.Controls.Add(this.button19);
            this.panelFabric.Controls.Add(this.button20);
            this.panelFabric.Location = new System.Drawing.Point(6, 227);
            this.panelFabric.Name = "panelFabric";
            this.panelFabric.Size = new System.Drawing.Size(364, 107);
            this.panelFabric.TabIndex = 89;
            this.panelFabric.Visible = false;
            // 
            // panelPlu
            // 
            this.panelPlu.Controls.Add(this.button7);
            this.panelPlu.Controls.Add(this.btn3);
            this.panelPlu.Controls.Add(this.button4);
            this.panelPlu.Controls.Add(this.button5);
            this.panelPlu.Controls.Add(this.button6);
            this.panelPlu.Controls.Add(this.button3);
            this.panelPlu.Controls.Add(this.button2);
            this.panelPlu.Controls.Add(this.Button1);
            this.panelPlu.Location = new System.Drawing.Point(2, 8);
            this.panelPlu.Name = "panelPlu";
            this.panelPlu.Size = new System.Drawing.Size(368, 106);
            this.panelPlu.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 94;
            this.label1.Text = "Acc : 0  - MR Z ERO - zero limited1";
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(432, 576);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 48);
            this.button8.TabIndex = 95;
            this.button8.Text = "NEXT ITEM";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblTicketTotal
            // 
            this.lblTicketTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketTotal.Font = new System.Drawing.Font("Courier New", 11.5F);
            this.lblTicketTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTicketTotal.Location = new System.Drawing.Point(702, 36);
            this.lblTicketTotal.Name = "lblTicketTotal";
            this.lblTicketTotal.Size = new System.Drawing.Size(86, 24);
            this.lblTicketTotal.TabIndex = 96;
            this.lblTicketTotal.Text = "Total";
            this.lblTicketTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(4, 563);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(74, 48);
            this.button21.TabIndex = 97;
            this.button21.Text = "SHOW LINES";
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button22.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(84, 563);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(74, 48);
            this.button22.TabIndex = 98;
            this.button22.Text = "HIDE LINES";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.ControlBox = false;
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.lblTicketTotal);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPlu);
            this.Controls.Add(this.panelFabric);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnVOID);
            this.Controls.Add(this.treeList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking In Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nORTHWINDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.panelFabric.ResumeLayout(false);
            this.panelPlu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NORTHWINDDataSet nORTHWINDDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NORTHWINDDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        internal System.Windows.Forms.Button btnVOID;
        internal System.Windows.Forms.Label lblQty;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button button7;
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
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelFabric;
        private System.Windows.Forms.Panel panelPlu;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Label lblTicketTotal;
        internal System.Windows.Forms.Button button21;
        internal System.Windows.Forms.Button button22;
    }
}