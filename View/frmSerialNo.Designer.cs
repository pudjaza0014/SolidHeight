
namespace SolidHeight.View
{
    partial class frmSerialNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerialNo));
            this.tblfrmSerialList = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLotNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.txtTotalPCCA = new System.Windows.Forms.TextBox();
            this.dgvSerialList = new System.Windows.Forms.DataGridView();
            this.strSerialValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMSG = new System.Windows.Forms.Label();
            this.seqNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strSerialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsSerialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tblfrmSerialList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerialList)).BeginInit();
            this.tblButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSerialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tblfrmSerialList
            // 
            this.tblfrmSerialList.ColumnCount = 1;
            this.tblfrmSerialList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblfrmSerialList.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tblfrmSerialList.Controls.Add(this.dgvSerialList, 0, 1);
            this.tblfrmSerialList.Controls.Add(this.tblButton, 0, 2);
            this.tblfrmSerialList.Controls.Add(this.lblMSG, 0, 3);
            this.tblfrmSerialList.Location = new System.Drawing.Point(12, 12);
            this.tblfrmSerialList.Name = "tblfrmSerialList";
            this.tblfrmSerialList.RowCount = 4;
            this.tblfrmSerialList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tblfrmSerialList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tblfrmSerialList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblfrmSerialList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblfrmSerialList.Size = new System.Drawing.Size(408, 551);
            this.tblfrmSerialList.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lblLotNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtJobName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalPCCA, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblLotNo
            // 
            this.lblLotNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLotNo.AutoSize = true;
            this.lblLotNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNo.Location = new System.Drawing.Point(3, 0);
            this.lblLotNo.Name = "lblLotNo";
            this.lblLotNo.Size = new System.Drawing.Size(114, 32);
            this.lblLotNo.TabIndex = 0;
            this.lblLotNo.Text = "Lot No";
            this.lblLotNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total PCCA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtJobName
            // 
            this.txtJobName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobName.Enabled = false;
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobName.Location = new System.Drawing.Point(123, 3);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.ReadOnly = true;
            this.txtJobName.Size = new System.Drawing.Size(154, 26);
            this.txtJobName.TabIndex = 2;
            // 
            // txtTotalPCCA
            // 
            this.txtTotalPCCA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPCCA.Enabled = false;
            this.txtTotalPCCA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPCCA.Location = new System.Drawing.Point(123, 35);
            this.txtTotalPCCA.Name = "txtTotalPCCA";
            this.txtTotalPCCA.ReadOnly = true;
            this.txtTotalPCCA.Size = new System.Drawing.Size(154, 26);
            this.txtTotalPCCA.TabIndex = 3;
            // 
            // dgvSerialList
            // 
            this.dgvSerialList.AllowUserToAddRows = false;
            this.dgvSerialList.AllowUserToDeleteRows = false;
            this.dgvSerialList.AllowUserToResizeRows = false;
            this.dgvSerialList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSerialList.AutoGenerateColumns = false;
            this.dgvSerialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seqNoDataGridViewTextBoxColumn,
            this.strSerialNoDataGridViewTextBoxColumn,
            this.strSerialValues});
            this.dgvSerialList.DataSource = this.clsSerialBindingSource;
            this.dgvSerialList.Location = new System.Drawing.Point(3, 74);
            this.dgvSerialList.Name = "dgvSerialList";
            this.dgvSerialList.RowHeadersWidth = 51;
            this.dgvSerialList.Size = new System.Drawing.Size(402, 373);
            this.dgvSerialList.TabIndex = 1;
            this.dgvSerialList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerialList_CellClick);
            this.dgvSerialList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerialList_CellEndEdit);
            this.dgvSerialList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerialList_CellEnter);
            this.dgvSerialList.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSerialList_CellLeave);
            // 
            // strSerialValues
            // 
            this.strSerialValues.DataPropertyName = "strSerialValues";
            this.strSerialValues.HeaderText = "SerialValues";
            this.strSerialValues.MaxInputLength = 25;
            this.strSerialValues.MinimumWidth = 6;
            this.strSerialValues.Name = "strSerialValues";
            this.strSerialValues.Width = 125;
            // 
            // tblButton
            // 
            this.tblButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButton.ColumnCount = 1;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Controls.Add(this.btnOK, 0, 0);
            this.tblButton.Location = new System.Drawing.Point(3, 453);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButton.Size = new System.Drawing.Size(402, 54);
            this.tblButton.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(396, 48);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "SAVE";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMSG
            // 
            this.lblMSG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMSG.AutoSize = true;
            this.lblMSG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSG.Location = new System.Drawing.Point(3, 510);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(402, 41);
            this.lblMSG.TabIndex = 3;
            this.lblMSG.Text = "READY";
            this.lblMSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMSG.Visible = false;
            // 
            // seqNoDataGridViewTextBoxColumn
            // 
            this.seqNoDataGridViewTextBoxColumn.DataPropertyName = "SeqNo";
            this.seqNoDataGridViewTextBoxColumn.HeaderText = "SeqNo";
            this.seqNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seqNoDataGridViewTextBoxColumn.Name = "seqNoDataGridViewTextBoxColumn";
            this.seqNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // strSerialNoDataGridViewTextBoxColumn
            // 
            this.strSerialNoDataGridViewTextBoxColumn.DataPropertyName = "strSerialNo";
            this.strSerialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.strSerialNoDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.strSerialNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.strSerialNoDataGridViewTextBoxColumn.Name = "strSerialNoDataGridViewTextBoxColumn";
            this.strSerialNoDataGridViewTextBoxColumn.Width = 50;
            // 
            // clsSerialBindingSource
            // 
            this.clsSerialBindingSource.DataSource = typeof(SolidHeight.Models.clsSerial);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(283, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limit 10 Serial";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSerialNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 823);
            this.Controls.Add(this.tblfrmSerialList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSerialNo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPC Measure : SerialNo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSerialNo_FormClosing);
            this.Load += new System.EventHandler(this.frmSerialNo_Load);
            this.tblfrmSerialList.ResumeLayout(false);
            this.tblfrmSerialList.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerialList)).EndInit();
            this.tblButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clsSerialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblfrmSerialList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLotNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.TextBox txtTotalPCCA;
        private System.Windows.Forms.DataGridView dgvSerialList;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.BindingSource clsSerialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strSerialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strSerialValues;
        private System.Windows.Forms.Label label2;
    }
}