﻿namespace WeCode1._0
{
    partial class ProperDialog
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
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxLanguageType = new System.Windows.Forms.ComboBox();
            this.checkBoxIsOnRootCreate = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.Location = new System.Drawing.Point(12, 18);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(32, 17);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "属性";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(12, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(44, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "标题：";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelType.Location = new System.Drawing.Point(12, 92);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(92, 17);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "选择语言类型：";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTitle.Location = new System.Drawing.Point(107, 49);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(277, 23);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxLanguageType
            // 
            this.comboBoxLanguageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguageType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxLanguageType.FormattingEnabled = true;
            this.comboBoxLanguageType.Items.AddRange(new object[] {
            "Text",
            "C/C++",
            "HTML",
            "Pascal/Delphi",
            "Java",
            "VB/VB.NET",
            "XML",
            "C#",
            "TSQL",
            "PostgreSQL",
            "Python",
            "AS3",
            "Lua",
            "JavaScript",
            "PHP",
            "Haxe",
            "Go"});
            this.comboBoxLanguageType.Location = new System.Drawing.Point(107, 89);
            this.comboBoxLanguageType.Name = "comboBoxLanguageType";
            this.comboBoxLanguageType.Size = new System.Drawing.Size(277, 25);
            this.comboBoxLanguageType.TabIndex = 4;
            // 
            // checkBoxIsOnRootCreate
            // 
            this.checkBoxIsOnRootCreate.AutoSize = true;
            this.checkBoxIsOnRootCreate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIsOnRootCreate.Location = new System.Drawing.Point(14, 132);
            this.checkBoxIsOnRootCreate.Name = "checkBoxIsOnRootCreate";
            this.checkBoxIsOnRootCreate.Size = new System.Drawing.Size(147, 21);
            this.checkBoxIsOnRootCreate.TabIndex = 5;
            this.checkBoxIsOnRootCreate.Text = "在顶层新建目录或文章";
            this.checkBoxIsOnRootCreate.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOk.Location = new System.Drawing.Point(207, 156);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(309, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProperDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 199);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxIsOnRootCreate);
            this.Controls.Add(this.comboBoxLanguageType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProperDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxLanguageType;
        private System.Windows.Forms.CheckBox checkBoxIsOnRootCreate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}