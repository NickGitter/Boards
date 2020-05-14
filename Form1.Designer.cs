namespace CutBoards
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.dgv_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_result_all = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_result_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStandartBoardLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.grb_result_mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalMod = new System.Windows.Forms.Label();
            this.lblBoardsCountToBuy = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество досок для заказа:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(176, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calculate.Location = new System.Drawing.Point(16, 390);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(146, 23);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Рассчитать";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Length,
            this.dgv_Count});
            this.dgvInput.Location = new System.Drawing.Point(16, 62);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.Size = new System.Drawing.Size(332, 315);
            this.dgvInput.TabIndex = 4;
            // 
            // dgv_Length
            // 
            this.dgv_Length.HeaderText = "Длина доски";
            this.dgv_Length.Name = "dgv_Length";
            // 
            // dgv_Count
            // 
            this.dgv_Count.HeaderText = "Количество";
            this.dgv_Count.Name = "dgv_Count";
            // 
            // grb_result_all
            // 
            this.grb_result_all.HeaderText = "Распределение";
            this.grb_result_all.Name = "grb_result_all";
            this.grb_result_all.ReadOnly = true;
            // 
            // grb_result_index
            // 
            this.grb_result_index.HeaderText = "Доска";
            this.grb_result_index.Name = "grb_result_index";
            this.grb_result_index.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Перечень досок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "метров";
            // 
            // txtStandartBoardLength
            // 
            this.txtStandartBoardLength.Location = new System.Drawing.Point(108, 9);
            this.txtStandartBoardLength.Name = "txtStandartBoardLength";
            this.txtStandartBoardLength.Size = new System.Drawing.Size(100, 20);
            this.txtStandartBoardLength.TabIndex = 1;
            this.txtStandartBoardLength.Text = "6.00";
            this.txtStandartBoardLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Остаток:";
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grb_result_index,
            this.grb_result_all,
            this.grb_result_mod});
            this.dgvOutput.Location = new System.Drawing.Point(3, 62);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.Size = new System.Drawing.Size(352, 315);
            this.dgvOutput.TabIndex = 6;
            // 
            // grb_result_mod
            // 
            this.grb_result_mod.HeaderText = "Остаток";
            this.grb_result_mod.Name = "grb_result_mod";
            this.grb_result_mod.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стандарт доски:";
            // 
            // lblTotalMod
            // 
            this.lblTotalMod.AutoSize = true;
            this.lblTotalMod.Location = new System.Drawing.Point(186, 39);
            this.lblTotalMod.Name = "lblTotalMod";
            this.lblTotalMod.Size = new System.Drawing.Size(13, 13);
            this.lblTotalMod.TabIndex = 11;
            this.lblTotalMod.Text = "0";
            // 
            // lblBoardsCountToBuy
            // 
            this.lblBoardsCountToBuy.AutoSize = true;
            this.lblBoardsCountToBuy.Location = new System.Drawing.Point(186, 13);
            this.lblBoardsCountToBuy.Name = "lblBoardsCountToBuy";
            this.lblBoardsCountToBuy.Size = new System.Drawing.Size(13, 13);
            this.lblBoardsCountToBuy.TabIndex = 9;
            this.lblBoardsCountToBuy.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_calculate);
            this.splitContainer1.Panel1.Controls.Add(this.dgvInput);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtStandartBoardLength);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalMod);
            this.splitContainer1.Panel2.Controls.Add(this.lblBoardsCountToBuy);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOutput);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(732, 425);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 425);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Распил досок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn grb_result_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn grb_result_index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStandartBoardLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn grb_result_mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMod;
        private System.Windows.Forms.Label lblBoardsCountToBuy;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

