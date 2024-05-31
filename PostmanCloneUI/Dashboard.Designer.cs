namespace PostmanCloneUI
{
	partial class Dashboard
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
			formHeader = new Label();
			apiLabel = new Label();
			apiLink = new TextBox();
			callApi = new Button();
			statusStripLabel = new ToolStripStatusLabel();
			statusStrip = new StatusStrip();
			HttpRequestType = new ComboBox();
			TabItems = new TabControl();
			resultsTab = new TabPage();
			resultsText = new TextBox();
			bodyTab = new TabPage();
			label1 = new Label();
			bodyText = new TextBox();
			statusStrip.SuspendLayout();
			TabItems.SuspendLayout();
			resultsTab.SuspendLayout();
			bodyTab.SuspendLayout();
			SuspendLayout();
			// 
			// formHeader
			// 
			formHeader.AutoSize = true;
			formHeader.Font = new Font("Montserrat Medium", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
			formHeader.Location = new Point(120, 36);
			formHeader.Name = "formHeader";
			formHeader.Size = new Size(217, 67);
			formHeader.TabIndex = 0;
			formHeader.Text = "Postman";
			// 
			// apiLabel
			// 
			apiLabel.AutoSize = true;
			apiLabel.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			apiLabel.Location = new Point(120, 145);
			apiLabel.Name = "apiLabel";
			apiLabel.Size = new Size(79, 50);
			apiLabel.TabIndex = 0;
			apiLabel.Text = "API:";
			// 
			// apiLink
			// 
			apiLink.BorderStyle = BorderStyle.FixedSingle;
			apiLink.Location = new Point(398, 151);
			apiLink.Name = "apiLink";
			apiLink.Size = new Size(784, 36);
			apiLink.TabIndex = 1;
			// 
			// callApi
			// 
			callApi.Location = new Point(1204, 145);
			callApi.Name = "callApi";
			callApi.Size = new Size(112, 48);
			callApi.TabIndex = 3;
			callApi.Text = "Call";
			callApi.UseVisualStyleBackColor = true;
			callApi.Click += callApi_Click;
			// 
			// statusStripLabel
			// 
			statusStripLabel.Font = new Font("Montserrat", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
			statusStripLabel.Name = "statusStripLabel";
			statusStripLabel.Size = new Size(77, 34);
			statusStripLabel.Text = "Ready";
			// 
			// statusStrip
			// 
			statusStrip.BackColor = SystemColors.ControlLightLight;
			statusStrip.ImageScalingSize = new Size(24, 24);
			statusStrip.Items.AddRange(new ToolStripItem[] { statusStripLabel });
			statusStrip.Location = new Point(0, 806);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(1440, 40);
			statusStrip.TabIndex = 2;
			statusStrip.Text = "statusStrip";
			// 
			// HttpRequestType
			// 
			HttpRequestType.DropDownStyle = ComboBoxStyle.DropDownList;
			HttpRequestType.FormattingEnabled = true;
			HttpRequestType.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
			HttpRequestType.Location = new Point(210, 145);
			HttpRequestType.Name = "HttpRequestType";
			HttpRequestType.Size = new Size(182, 46);
			HttpRequestType.TabIndex = 4;
			// 
			// TabItems
			// 
			TabItems.Controls.Add(resultsTab);
			TabItems.Controls.Add(bodyTab);
			TabItems.Font = new Font("Montserrat Light", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TabItems.Location = new Point(132, 235);
			TabItems.Name = "TabItems";
			TabItems.SelectedIndex = 0;
			TabItems.Size = new Size(1184, 561);
			TabItems.TabIndex = 5;
			// 
			// resultsTab
			// 
			resultsTab.Controls.Add(resultsText);
			resultsTab.Location = new Point(4, 47);
			resultsTab.Name = "resultsTab";
			resultsTab.Padding = new Padding(3);
			resultsTab.Size = new Size(1176, 510);
			resultsTab.TabIndex = 0;
			resultsTab.Text = "Results";
			resultsTab.UseVisualStyleBackColor = true;
			// 
			// resultsText
			// 
			resultsText.BackColor = SystemColors.Window;
			resultsText.BorderStyle = BorderStyle.FixedSingle;
			resultsText.Dock = DockStyle.Fill;
			resultsText.Location = new Point(3, 3);
			resultsText.Multiline = true;
			resultsText.Name = "resultsText";
			resultsText.ReadOnly = true;
			resultsText.ScrollBars = ScrollBars.Both;
			resultsText.Size = new Size(1170, 504);
			resultsText.TabIndex = 2;
			// 
			// bodyTab
			// 
			bodyTab.Controls.Add(bodyText);
			bodyTab.Location = new Point(4, 47);
			bodyTab.Name = "bodyTab";
			bodyTab.Padding = new Padding(3);
			bodyTab.Size = new Size(1176, 510);
			bodyTab.TabIndex = 1;
			bodyTab.Text = "Body";
			bodyTab.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Montserrat Light", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(351, 36);
			label1.Name = "label1";
			label1.Size = new Size(143, 67);
			label1.TabIndex = 0;
			label1.Text = "Clone";
			// 
			// bodyText
			// 
			bodyText.BackColor = SystemColors.Window;
			bodyText.BorderStyle = BorderStyle.FixedSingle;
			bodyText.Dock = DockStyle.Fill;
			bodyText.Location = new Point(3, 3);
			bodyText.Multiline = true;
			bodyText.Name = "bodyText";
			bodyText.ScrollBars = ScrollBars.Both;
			bodyText.Size = new Size(1170, 504);
			bodyText.TabIndex = 3;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(15F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ClientSize = new Size(1440, 846);
			Controls.Add(TabItems);
			Controls.Add(HttpRequestType);
			Controls.Add(callApi);
			Controls.Add(statusStrip);
			Controls.Add(apiLink);
			Controls.Add(apiLabel);
			Controls.Add(label1);
			Controls.Add(formHeader);
			Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "Dashboard";
			Text = "Postman Clone by Nalitect studio";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			TabItems.ResumeLayout(false);
			resultsTab.ResumeLayout(false);
			resultsTab.PerformLayout();
			bodyTab.ResumeLayout(false);
			bodyTab.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label formHeader;
		private Label apiLabel;
		private TextBox apiLink;
		private Button callApi;
		private ToolStripStatusLabel statusStripLabel;
		private StatusStrip statusStrip;
		private ComboBox HttpRequestType;
		private TabControl TabItems;
		private TabPage resultsTab;
		private TextBox resultsText;
		private TabPage bodyTab;
		private Label label1;
		private TextBox bodyText;
	}
}