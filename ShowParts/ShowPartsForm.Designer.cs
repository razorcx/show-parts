namespace ShowParts
{
	partial class ShowParts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowParts));
			this.buttonSelectPartsInModel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBoxMainPartNames = new System.Windows.Forms.ListBox();
			this.comboBox1ShowSettings = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxShowSecondaries = new System.Windows.Forms.CheckBox();
			this.checkBoxBolts = new System.Windows.Forms.CheckBox();
			this.checkBoxCutsFittings = new System.Windows.Forms.CheckBox();
			this.checkBoxShowComponents = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSelectPartsInModel
			// 
			this.buttonSelectPartsInModel.Location = new System.Drawing.Point(233, 290);
			this.buttonSelectPartsInModel.Name = "buttonSelectPartsInModel";
			this.buttonSelectPartsInModel.Size = new System.Drawing.Size(151, 33);
			this.buttonSelectPartsInModel.TabIndex = 17;
			this.buttonSelectPartsInModel.Text = "Select Parts";
			this.buttonSelectPartsInModel.UseVisualStyleBackColor = true;
			this.buttonSelectPartsInModel.Click += new System.EventHandler(this.buttonSelectPartsInModel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "Part Names";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ShowParts.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// listBoxMainPartNames
			// 
			this.listBoxMainPartNames.FormattingEnabled = true;
			this.listBoxMainPartNames.ItemHeight = 16;
			this.listBoxMainPartNames.Location = new System.Drawing.Point(12, 95);
			this.listBoxMainPartNames.Name = "listBoxMainPartNames";
			this.listBoxMainPartNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxMainPartNames.Size = new System.Drawing.Size(214, 228);
			this.listBoxMainPartNames.TabIndex = 18;
			// 
			// comboBox1ShowSettings
			// 
			this.comboBox1ShowSettings.FormattingEnabled = true;
			this.comboBox1ShowSettings.Location = new System.Drawing.Point(233, 95);
			this.comboBox1ShowSettings.Name = "comboBox1ShowSettings";
			this.comboBox1ShowSettings.Size = new System.Drawing.Size(150, 24);
			this.comboBox1ShowSettings.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "Show Setting";
			// 
			// checkBoxShowSecondaries
			// 
			this.checkBoxShowSecondaries.AutoSize = true;
			this.checkBoxShowSecondaries.Location = new System.Drawing.Point(233, 136);
			this.checkBoxShowSecondaries.Name = "checkBoxShowSecondaries";
			this.checkBoxShowSecondaries.Size = new System.Drawing.Size(147, 21);
			this.checkBoxShowSecondaries.TabIndex = 21;
			this.checkBoxShowSecondaries.Text = "Show Secondaries";
			this.checkBoxShowSecondaries.UseVisualStyleBackColor = true;
			// 
			// checkBoxBolts
			// 
			this.checkBoxBolts.AutoSize = true;
			this.checkBoxBolts.Location = new System.Drawing.Point(233, 163);
			this.checkBoxBolts.Name = "checkBoxBolts";
			this.checkBoxBolts.Size = new System.Drawing.Size(99, 21);
			this.checkBoxBolts.TabIndex = 22;
			this.checkBoxBolts.Text = "Show Bolts";
			this.checkBoxBolts.UseVisualStyleBackColor = true;
			// 
			// checkBoxCutsFittings
			// 
			this.checkBoxCutsFittings.AutoSize = true;
			this.checkBoxCutsFittings.Location = new System.Drawing.Point(233, 190);
			this.checkBoxCutsFittings.Name = "checkBoxCutsFittings";
			this.checkBoxCutsFittings.Size = new System.Drawing.Size(145, 21);
			this.checkBoxCutsFittings.TabIndex = 23;
			this.checkBoxCutsFittings.Text = "Show Cuts/Fittings";
			this.checkBoxCutsFittings.UseVisualStyleBackColor = true;
			// 
			// checkBoxShowComponents
			// 
			this.checkBoxShowComponents.AutoSize = true;
			this.checkBoxShowComponents.Location = new System.Drawing.Point(233, 217);
			this.checkBoxShowComponents.Name = "checkBoxShowComponents";
			this.checkBoxShowComponents.Size = new System.Drawing.Size(147, 21);
			this.checkBoxShowComponents.TabIndex = 24;
			this.checkBoxShowComponents.Text = "Show Components";
			this.checkBoxShowComponents.UseVisualStyleBackColor = true;
			// 
			// ShowParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 341);
			this.Controls.Add(this.checkBoxShowComponents);
			this.Controls.Add(this.checkBoxCutsFittings);
			this.Controls.Add(this.checkBoxBolts);
			this.Controls.Add(this.checkBoxShowSecondaries);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1ShowSettings);
			this.Controls.Add(this.listBoxMainPartNames);
			this.Controls.Add(this.buttonSelectPartsInModel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShowParts";
			this.Text = "Show Parts";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ShowParts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSelectPartsInModel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBoxMainPartNames;
		private System.Windows.Forms.ComboBox comboBox1ShowSettings;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxShowSecondaries;
		private System.Windows.Forms.CheckBox checkBoxBolts;
		private System.Windows.Forms.CheckBox checkBoxCutsFittings;
		private System.Windows.Forms.CheckBox checkBoxShowComponents;
	}
}

