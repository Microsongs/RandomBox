﻿namespace LootBox_RandomBox_
{
    partial class mainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.addButton = new System.Windows.Forms.Button();
            this.boxList_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.lootBoxImage = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.tryButton = new System.Windows.Forms.Button();
            this.language_comboList = new System.Windows.Forms.ComboBox();
            this.itemList_dataGridView = new System.Windows.Forms.DataGridView();
            this.result_dataGridView = new System.Windows.Forms.DataGridView();
            this.settingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lootBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 602);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 60);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // boxList_label
            // 
            this.boxList_label.AutoSize = true;
            this.boxList_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxList_label.Location = new System.Drawing.Point(12, 25);
            this.boxList_label.Name = "boxList_label";
            this.boxList_label.Size = new System.Drawing.Size(119, 33);
            this.boxList_label.TabIndex = 3;
            this.boxList_label.Text = "Box List";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(989, 25);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(98, 33);
            this.result_label.TabIndex = 4;
            this.result_label.Text = "Result";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(172, 602);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(140, 60);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(86, 677);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 60);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // lootBoxImage
            // 
            this.lootBoxImage.Location = new System.Drawing.Point(500, 77);
            this.lootBoxImage.Name = "lootBoxImage";
            this.lootBoxImage.Size = new System.Drawing.Size(437, 529);
            this.lootBoxImage.TabIndex = 7;
            this.lootBoxImage.TabStop = false;
            this.lootBoxImage.Click += new System.EventHandler(this.LootBoxImage_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(259, 677);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 60);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // tryButton
            // 
            this.tryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tryButton.Location = new System.Drawing.Point(654, 642);
            this.tryButton.Name = "tryButton";
            this.tryButton.Size = new System.Drawing.Size(151, 71);
            this.tryButton.TabIndex = 9;
            this.tryButton.Text = "Try";
            this.tryButton.UseVisualStyleBackColor = false;
            // 
            // language_comboList
            // 
            this.language_comboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.language_comboList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language_comboList.FormattingEnabled = true;
            this.language_comboList.Location = new System.Drawing.Point(1023, 642);
            this.language_comboList.Name = "language_comboList";
            this.language_comboList.Size = new System.Drawing.Size(256, 41);
            this.language_comboList.TabIndex = 10;
            this.language_comboList.SelectedIndexChanged += new System.EventHandler(this.Language_comboList_SelectedIndexChanged);
            // 
            // itemList_dataGridView
            // 
            this.itemList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList_dataGridView.Location = new System.Drawing.Point(12, 77);
            this.itemList_dataGridView.Name = "itemList_dataGridView";
            this.itemList_dataGridView.ReadOnly = true;
            this.itemList_dataGridView.RowHeadersWidth = 82;
            this.itemList_dataGridView.RowTemplate.Height = 33;
            this.itemList_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemList_dataGridView.Size = new System.Drawing.Size(455, 504);
            this.itemList_dataGridView.TabIndex = 11;
            // 
            // result_dataGridView
            // 
            this.result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dataGridView.Location = new System.Drawing.Point(969, 77);
            this.result_dataGridView.Name = "result_dataGridView";
            this.result_dataGridView.RowHeadersWidth = 82;
            this.result_dataGridView.RowTemplate.Height = 33;
            this.result_dataGridView.Size = new System.Drawing.Size(455, 504);
            this.result_dataGridView.TabIndex = 12;
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(327, 602);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(140, 60);
            this.settingButton.TabIndex = 14;
            this.settingButton.Text = "확률";
            this.settingButton.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 751);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.result_dataGridView);
            this.Controls.Add(this.itemList_dataGridView);
            this.Controls.Add(this.language_comboList);
            this.Controls.Add(this.tryButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.lootBoxImage);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.boxList_label);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "LootBox(RandomBox)";
            ((System.ComponentModel.ISupportInitialize)(this.lootBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label boxList_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox lootBoxImage;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button tryButton;
        private System.Windows.Forms.ComboBox language_comboList;
        private System.Windows.Forms.DataGridView itemList_dataGridView;
        private System.Windows.Forms.DataGridView result_dataGridView;
        private System.Windows.Forms.Button settingButton;
    }
}

