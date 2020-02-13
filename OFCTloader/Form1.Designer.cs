namespace OFCTloader
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.TextBox_RedTeamName = new System.Windows.Forms.TextBox();
			this.TextBox_BlueTeamName = new System.Windows.Forms.TextBox();
			this.TextBox_Round = new System.Windows.Forms.TextBox();
			this.TextBox_Schedule = new System.Windows.Forms.TextBox();
			this.TextBox_Title = new System.Windows.Forms.TextBox();
			this.Button_Set = new System.Windows.Forms.Button();
			this.CheckBox_Hexchat = new System.Windows.Forms.CheckBox();
			this.CheckBox_SR = new System.Windows.Forms.CheckBox();
			this.CheckBox_Tourney = new System.Windows.Forms.CheckBox();
			this.CheckBox_MapPick = new System.Windows.Forms.CheckBox();
			this.Button_Init = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Product Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "OFCT loader";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(305, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "20200130";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Button_Set);
			this.groupBox1.Controls.Add(this.TextBox_Title);
			this.groupBox1.Controls.Add(this.TextBox_Schedule);
			this.groupBox1.Controls.Add(this.TextBox_Round);
			this.groupBox1.Controls.Add(this.TextBox_BlueTeamName);
			this.groupBox1.Controls.Add(this.TextBox_RedTeamName);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox1.Location = new System.Drawing.Point(20, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 240);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "방송 정보 업데이트";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Button_Init);
			this.groupBox2.Controls.Add(this.CheckBox_MapPick);
			this.groupBox2.Controls.Add(this.CheckBox_Tourney);
			this.groupBox2.Controls.Add(this.CheckBox_SR);
			this.groupBox2.Controls.Add(this.CheckBox_Hexchat);
			this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.groupBox2.Location = new System.Drawing.Point(276, 70);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(219, 240);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "방송 시작";

			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(6, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Red";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(214, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Blue";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(106, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "vs.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.Location = new System.Drawing.Point(22, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 15);
			this.label6.TabIndex = 7;
			this.label6.Text = "라운드";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label7.Location = new System.Drawing.Point(6, 157);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "경기 일정";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(6, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 15);
			this.label8.TabIndex = 9;
			this.label8.Text = "방송 제목";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// TextBox_RedTeamName
			// 
			this.TextBox_RedTeamName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TextBox_RedTeamName.Location = new System.Drawing.Point(39, 37);
			this.TextBox_RedTeamName.Name = "TextBox_RedTeamName";
			this.TextBox_RedTeamName.Size = new System.Drawing.Size(190, 23);
			this.TextBox_RedTeamName.TabIndex = 10;
			// 
			// TextBox_BlueTeamName
			// 
			this.TextBox_BlueTeamName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TextBox_BlueTeamName.Location = new System.Drawing.Point(18, 84);
			this.TextBox_BlueTeamName.Name = "TextBox_BlueTeamName";
			this.TextBox_BlueTeamName.Size = new System.Drawing.Size(190, 23);
			this.TextBox_BlueTeamName.TabIndex = 11;
			// 
			// TextBox_Round
			// 
			this.TextBox_Round.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TextBox_Round.Location = new System.Drawing.Point(71, 124);
			this.TextBox_Round.Name = "TextBox_Round";
			this.TextBox_Round.Size = new System.Drawing.Size(173, 23);
			this.TextBox_Round.TabIndex = 12;
			// 
			// TextBox_Schedule
			// 
			this.TextBox_Schedule.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TextBox_Schedule.Location = new System.Drawing.Point(71, 153);
			this.TextBox_Schedule.Name = "TextBox_Schedule";
			this.TextBox_Schedule.Size = new System.Drawing.Size(173, 23);
			this.TextBox_Schedule.TabIndex = 13;
			// 
			// TextBox_Title
			// 
			this.TextBox_Title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TextBox_Title.Location = new System.Drawing.Point(71, 182);
			this.TextBox_Title.Name = "TextBox_Title";
			this.TextBox_Title.Size = new System.Drawing.Size(173, 23);
			this.TextBox_Title.TabIndex = 14;
			// 
			// Button_Set
			// 
			this.Button_Set.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Button_Set.Location = new System.Drawing.Point(88, 211);
			this.Button_Set.Name = "Button_Set";
			this.Button_Set.Size = new System.Drawing.Size(75, 23);
			this.Button_Set.TabIndex = 15;
			this.Button_Set.Text = "설정";
			this.Button_Set.UseVisualStyleBackColor = true;
			// 
			// CheckBox_Hexchat
			// 
			this.CheckBox_Hexchat.AutoSize = true;
			this.CheckBox_Hexchat.Checked = true;
			this.CheckBox_Hexchat.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox_Hexchat.Location = new System.Drawing.Point(20, 58);
			this.CheckBox_Hexchat.Name = "CheckBox_Hexchat";
			this.CheckBox_Hexchat.Size = new System.Drawing.Size(126, 25);
			this.CheckBox_Hexchat.TabIndex = 0;
			this.CheckBox_Hexchat.Text = "Hexchat 실행";
			this.CheckBox_Hexchat.UseVisualStyleBackColor = true;
			// 
			// CheckBox_SR
			// 
			this.CheckBox_SR.AutoSize = true;
			this.CheckBox_SR.Checked = true;
			this.CheckBox_SR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox_SR.Location = new System.Drawing.Point(20, 89);
			this.CheckBox_SR.Name = "CheckBox_SR";
			this.CheckBox_SR.Size = new System.Drawing.Size(188, 25);
			this.CheckBox_SR.TabIndex = 1;
			this.CheckBox_SR.Text = "osu!StateReader 실행";
			this.CheckBox_SR.UseVisualStyleBackColor = true;
			// 
			// CheckBox_Tourney
			// 
			this.CheckBox_Tourney.AutoSize = true;
			this.CheckBox_Tourney.Checked = true;
			this.CheckBox_Tourney.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox_Tourney.Location = new System.Drawing.Point(20, 120);
			this.CheckBox_Tourney.Name = "CheckBox_Tourney";
			this.CheckBox_Tourney.Size = new System.Drawing.Size(155, 25);
			this.CheckBox_Tourney.TabIndex = 2;
			this.CheckBox_Tourney.Text = "osu!tourney 실행";
			this.CheckBox_Tourney.UseVisualStyleBackColor = true;
			// 
			// CheckBox_MapPick
			// 
			this.CheckBox_MapPick.AutoSize = true;
			this.CheckBox_MapPick.Checked = true;
			this.CheckBox_MapPick.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CheckBox_MapPick.Location = new System.Drawing.Point(20, 151);
			this.CheckBox_MapPick.Name = "CheckBox_MapPick";
			this.CheckBox_MapPick.Size = new System.Drawing.Size(155, 25);
			this.CheckBox_MapPick.TabIndex = 3;
			this.CheckBox_MapPick.Text = "mapPick.csv 편집";
			this.CheckBox_MapPick.UseVisualStyleBackColor = true;
			// 
			// Button_Init
			// 
			this.Button_Init.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Button_Init.Location = new System.Drawing.Point(71, 211);
			this.Button_Init.Name = "Button_Init";
			this.Button_Init.Size = new System.Drawing.Size(75, 23);
			this.Button_Init.TabIndex = 16;
			this.Button_Init.Text = "실행";
			this.Button_Init.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 321);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "OFCT loader";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBox_RedTeamName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Button_Set;
		private System.Windows.Forms.TextBox TextBox_Title;
		private System.Windows.Forms.TextBox TextBox_Schedule;
		private System.Windows.Forms.TextBox TextBox_Round;
		private System.Windows.Forms.TextBox TextBox_BlueTeamName;
		private System.Windows.Forms.CheckBox CheckBox_MapPick;
		private System.Windows.Forms.CheckBox CheckBox_Tourney;
		private System.Windows.Forms.CheckBox CheckBox_SR;
		private System.Windows.Forms.CheckBox CheckBox_Hexchat;
		private System.Windows.Forms.Button Button_Init;
	}
}

