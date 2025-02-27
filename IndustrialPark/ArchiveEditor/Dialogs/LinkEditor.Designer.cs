﻿namespace IndustrialPark
{
    partial class LinkEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxLinks = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonArrowDown = new System.Windows.Forms.Button();
            this.buttonArrowUp = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxEventData = new System.Windows.Forms.GroupBox();
            this.groupBoxSourceCheckOrFlags = new System.Windows.Forms.GroupBox();
            this.textBoxSourceCheckOrFlags = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxArgumentAsset = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxHex = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonTargetSelf = new System.Windows.Forms.Button();
            this.buttonTargetPlus1 = new System.Windows.Forms.Button();
            this.textBoxTargetAsset = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboSendEvent = new System.Windows.Forms.ComboBox();
            this.groupBoxSourceEvent = new System.Windows.Forms.GroupBox();
            this.comboRecieveEvent = new System.Windows.Forms.ComboBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxEventData.SuspendLayout();
            this.groupBoxSourceCheckOrFlags.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxSourceEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxLinks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Links";
            // 
            // listBoxLinks
            // 
            this.listBoxLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLinks.FormattingEnabled = true;
            this.listBoxLinks.Location = new System.Drawing.Point(6, 19);
            this.listBoxLinks.Name = "listBoxLinks";
            this.listBoxLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLinks.Size = new System.Drawing.Size(298, 301);
            this.listBoxLinks.TabIndex = 1;
            this.listBoxLinks.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(18, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(99, 351);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPaste.Location = new System.Drawing.Point(99, 380);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(75, 23);
            this.buttonPaste.TabIndex = 5;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Location = new System.Drawing.Point(18, 380);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonArrowDown
            // 
            this.buttonArrowDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArrowDown.Location = new System.Drawing.Point(183, 380);
            this.buttonArrowDown.Name = "buttonArrowDown";
            this.buttonArrowDown.Size = new System.Drawing.Size(22, 23);
            this.buttonArrowDown.TabIndex = 7;
            this.buttonArrowDown.Text = "▼";
            this.buttonArrowDown.UseVisualStyleBackColor = true;
            this.buttonArrowDown.Click += new System.EventHandler(this.buttonArrowDown_Click);
            // 
            // buttonArrowUp
            // 
            this.buttonArrowUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArrowUp.Location = new System.Drawing.Point(183, 351);
            this.buttonArrowUp.Name = "buttonArrowUp";
            this.buttonArrowUp.Size = new System.Drawing.Size(22, 23);
            this.buttonArrowUp.TabIndex = 6;
            this.buttonArrowUp.Text = "▲";
            this.buttonArrowUp.UseVisualStyleBackColor = true;
            this.buttonArrowUp.Click += new System.EventHandler(this.buttonArrowUp_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(336, 377);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(454, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxEventData
            // 
            this.groupBoxEventData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEventData.Controls.Add(this.groupBoxSourceCheckOrFlags);
            this.groupBoxEventData.Controls.Add(this.groupBox2);
            this.groupBoxEventData.Controls.Add(this.groupBox6);
            this.groupBoxEventData.Controls.Add(this.groupBox5);
            this.groupBoxEventData.Controls.Add(this.groupBox4);
            this.groupBoxEventData.Controls.Add(this.groupBoxSourceEvent);
            this.groupBoxEventData.Location = new System.Drawing.Point(328, 12);
            this.groupBoxEventData.Name = "groupBoxEventData";
            this.groupBoxEventData.Size = new System.Drawing.Size(244, 360);
            this.groupBoxEventData.TabIndex = 2;
            this.groupBoxEventData.TabStop = false;
            this.groupBoxEventData.Text = "Event Data";
            // 
            // groupBoxSourceCheckOrFlags
            // 
            this.groupBoxSourceCheckOrFlags.Controls.Add(this.textBoxSourceCheckOrFlags);
            this.groupBoxSourceCheckOrFlags.Location = new System.Drawing.Point(8, 231);
            this.groupBoxSourceCheckOrFlags.Name = "groupBoxSourceCheckOrFlags";
            this.groupBoxSourceCheckOrFlags.Size = new System.Drawing.Size(230, 47);
            this.groupBoxSourceCheckOrFlags.TabIndex = 11;
            this.groupBoxSourceCheckOrFlags.TabStop = false;
            this.groupBoxSourceCheckOrFlags.Text = "Source Check";
            this.toolTip1.SetToolTip(this.groupBoxSourceCheckOrFlags, "Link will only be activated if the sender asset matches this one. Optional.");
            // 
            // textBoxSourceCheckOrFlags
            // 
            this.textBoxSourceCheckOrFlags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSourceCheckOrFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSourceCheckOrFlags.Location = new System.Drawing.Point(6, 19);
            this.textBoxSourceCheckOrFlags.Name = "textBoxSourceCheckOrFlags";
            this.textBoxSourceCheckOrFlags.Size = new System.Drawing.Size(218, 20);
            this.textBoxSourceCheckOrFlags.TabIndex = 17;
            this.toolTip1.SetToolTip(this.textBoxSourceCheckOrFlags, "Link will only be activated if the sender asset matches this one. Optional.");
            this.textBoxSourceCheckOrFlags.TextChanged += new System.EventHandler(this.textBoxSourceCheck_TextChanged);
            this.textBoxSourceCheckOrFlags.Leave += new System.EventHandler(this.textBoxSourceCheck_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArgumentAsset);
            this.groupBox2.Location = new System.Drawing.Point(8, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Argument Asset";
            this.toolTip1.SetToolTip(this.groupBox2, "Asset which will be sent as argument on this link. This varies depending on the D" +
        "estination Event. Optional on most cases.");
            // 
            // textBoxArgumentAsset
            // 
            this.textBoxArgumentAsset.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxArgumentAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxArgumentAsset.Location = new System.Drawing.Point(6, 19);
            this.textBoxArgumentAsset.Name = "textBoxArgumentAsset";
            this.textBoxArgumentAsset.Size = new System.Drawing.Size(218, 20);
            this.textBoxArgumentAsset.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxArgumentAsset, "Asset which will be sent as argument on this link. This varies depending on the D" +
        "estination Event. Optional on most cases.\r\n");
            this.textBoxArgumentAsset.TextChanged += new System.EventHandler(this.textBoxArgumentAsset_TextChanged);
            this.textBoxArgumentAsset.Leave += new System.EventHandler(this.textBoxArgumentAsset_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.checkBoxHex);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(8, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 70);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Arguments";
            this.toolTip1.SetToolTip(this.groupBox6, "Arguments for link, vary depending on destination event.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "1";
            // 
            // checkBoxHex
            // 
            this.checkBoxHex.AutoSize = true;
            this.checkBoxHex.Location = new System.Drawing.Point(173, 0);
            this.checkBoxHex.Name = "checkBoxHex";
            this.checkBoxHex.Size = new System.Drawing.Size(45, 17);
            this.checkBoxHex.TabIndex = 11;
            this.checkBoxHex.Text = "Hex";
            this.checkBoxHex.UseVisualStyleBackColor = true;
            this.checkBoxHex.CheckedChanged += new System.EventHandler(this.checkBoxHex_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(25, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(136, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(136, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(25, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonTargetSelf);
            this.groupBox5.Controls.Add(this.buttonTargetPlus1);
            this.groupBox5.Controls.Add(this.textBoxTargetAsset);
            this.groupBox5.Location = new System.Drawing.Point(8, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 47);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Target Asset";
            this.toolTip1.SetToolTip(this.groupBox5, "Asset to which this link will be sent.");
            // 
            // buttonTargetSelf
            // 
            this.buttonTargetSelf.Location = new System.Drawing.Point(131, 0);
            this.buttonTargetSelf.Name = "buttonTargetSelf";
            this.buttonTargetSelf.Size = new System.Drawing.Size(42, 20);
            this.buttonTargetSelf.TabIndex = 11;
            this.buttonTargetSelf.Text = "Self";
            this.buttonTargetSelf.UseVisualStyleBackColor = true;
            this.buttonTargetSelf.Click += new System.EventHandler(this.buttonTargetSelf_Click);
            // 
            // buttonTargetPlus1
            // 
            this.buttonTargetPlus1.Location = new System.Drawing.Point(179, 0);
            this.buttonTargetPlus1.Name = "buttonTargetPlus1";
            this.buttonTargetPlus1.Size = new System.Drawing.Size(42, 20);
            this.buttonTargetPlus1.TabIndex = 11;
            this.buttonTargetPlus1.Text = "+1";
            this.buttonTargetPlus1.UseVisualStyleBackColor = true;
            this.buttonTargetPlus1.Click += new System.EventHandler(this.buttonTargetPlus1_Click);
            // 
            // textBoxTargetAsset
            // 
            this.textBoxTargetAsset.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTargetAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTargetAsset.Location = new System.Drawing.Point(6, 19);
            this.textBoxTargetAsset.Name = "textBoxTargetAsset";
            this.textBoxTargetAsset.Size = new System.Drawing.Size(218, 20);
            this.textBoxTargetAsset.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxTargetAsset, "Asset to which this link will be sent.");
            this.textBoxTargetAsset.TextChanged += new System.EventHandler(this.textBoxTargetAsset_TextChanged);
            this.textBoxTargetAsset.Leave += new System.EventHandler(this.textBoxTargetAsset_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboSendEvent);
            this.groupBox4.Location = new System.Drawing.Point(8, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 47);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target Event";
            this.toolTip1.SetToolTip(this.groupBox4, "Event sent by this link.");
            // 
            // comboSendEvent
            // 
            this.comboSendEvent.FormattingEnabled = true;
            this.comboSendEvent.Location = new System.Drawing.Point(6, 19);
            this.comboSendEvent.Name = "comboSendEvent";
            this.comboSendEvent.Size = new System.Drawing.Size(218, 21);
            this.comboSendEvent.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboSendEvent, "Event sent by this link.");
            this.comboSendEvent.SelectedIndexChanged += new System.EventHandler(this.comboSendEvent_SelectedIndexChanged);
            // 
            // groupBoxSourceEvent
            // 
            this.groupBoxSourceEvent.Controls.Add(this.comboRecieveEvent);
            this.groupBoxSourceEvent.Controls.Add(this.numericUpDownTime);
            this.groupBoxSourceEvent.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSourceEvent.Name = "groupBoxSourceEvent";
            this.groupBoxSourceEvent.Size = new System.Drawing.Size(232, 47);
            this.groupBoxSourceEvent.TabIndex = 1;
            this.groupBoxSourceEvent.TabStop = false;
            this.groupBoxSourceEvent.Text = "Source Event";
            this.toolTip1.SetToolTip(this.groupBoxSourceEvent, "Event which activates this link.");
            // 
            // comboRecieveEvent
            // 
            this.comboRecieveEvent.FormattingEnabled = true;
            this.comboRecieveEvent.Location = new System.Drawing.Point(6, 19);
            this.comboRecieveEvent.Name = "comboRecieveEvent";
            this.comboRecieveEvent.Size = new System.Drawing.Size(220, 21);
            this.comboRecieveEvent.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboRecieveEvent, "Event which activates this link.");
            this.comboRecieveEvent.SelectedIndexChanged += new System.EventHandler(this.comboReceiveEvent_SelectedIndexChanged);
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.DecimalPlaces = 4;
            this.numericUpDownTime.Location = new System.Drawing.Point(8, 19);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(218, 20);
            this.numericUpDownTime.TabIndex = 18;
            this.numericUpDownTime.Visible = false;
            this.numericUpDownTime.ValueChanged += new System.EventHandler(this.numericUpDownTime_ValueChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHelp.Location = new System.Drawing.Point(211, 351);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(105, 23);
            this.buttonHelp.TabIndex = 20;
            this.buttonHelp.Text = "Help!";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // LinkEditor
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxEventData);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonArrowDown);
            this.Controls.Add(this.buttonArrowUp);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LinkEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link List Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxEventData.ResumeLayout(false);
            this.groupBoxSourceCheckOrFlags.ResumeLayout(false);
            this.groupBoxSourceCheckOrFlags.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBoxSourceEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxLinks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonArrowDown;
        private System.Windows.Forms.Button buttonArrowUp;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxEventData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxArgumentAsset;
        private System.Windows.Forms.TextBox textBoxSourceCheckOrFlags;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxHex;
        private System.Windows.Forms.TextBox textBoxTargetAsset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSourceCheckOrFlags;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonTargetPlus1;
        private System.Windows.Forms.Button buttonTargetSelf;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboSendEvent;
        private System.Windows.Forms.GroupBox groupBoxSourceEvent;
        private System.Windows.Forms.ComboBox comboRecieveEvent;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
    }
}