using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OFCTloader
{
	public partial class Form1 : Form
	{
		readonly String redTeamNameFileLocation = @"../RedTeamName.txt";
		readonly String blueTeamNameFileLocation = @"../BlueTeamName.txt";
		readonly String bracketFileLocation = @"../braket.txt";
		readonly String scheduleFileLocation = @"../schedule.txt";
		readonly String streamTitleFileLocation = @"../StreamTitle.txt";
		readonly String tournamentNameFileLocation = @"./TournamentName.txt";
		readonly String configFileLocation = @"../OFCTloaderConfig.cfg";

		public static Form1 F1;

		public Form1()
		{
			InitializeComponent();
			F1 = this;

			F1.Size = new Size(400, 340);
			tabctrl_main.Size = new Size(347, 230);
			tabctrl_main.Selecting += MainTabChanged;

			txtbx_vs_red.TextChanged += VStitlesUpdate;
			txtbx_vs_blue.TextChanged += VStitlesUpdate;
			txtbx_vs_bracket.TextChanged += VStitlesUpdate;
			txtbx_vs_code.TextChanged += VStitlesUpdate;
			timepicker_vs_schedule.ValueChanged += VStitlesUpdate;
			txtbx_vs_tournamentName.TextChanged += VStitlesUpdate;

			btn_vs_update.Click += VSsetTextFiles;


			txtbx_showcase_bracket.TextChanged += ShowcaseTitlesUpdate;
			txtbx_showcase_tournamentName.TextChanged += ShowcaseTitlesUpdate;

			btn_showcase_update.Click += ShowcaseSetTextFiles;

			btn_manual_update.Click += ManualSetTextFiles;

			btn_init.Click += Start;


			UpdateValues();

			rotxtbx_showcase_streamTitle.Text = File.ReadAllLines(streamTitleFileLocation)[0];

			if (!File.Exists(configFileLocation))
			{
				CreateSettingsFile();
			}
		}

		void Start(object sender, EventArgs e)
		{
			if (chkbx_hexchat.Checked)
			{
				var location = ReadSettingsFile("HexchatLocation");
				if (location == "")
				{
					location = @"C:\Program Files\HexChat\hexchat.exe";
				}
				try
				{
					Process.Start(location.Replace("/", @"\"));
				}
				catch (Win32Exception)
				{
					MessageBox.Show("HexChat을 찾을 수 없습니다!");
				}
			}
			if (chkbx_SR.Checked)
			{
				if (File.Exists("./osuStateReader.exe"))
				{
					Process.Start(@".\osuStateReader.exe");
				}
				else
				{
					MessageBox.Show("osu!StateReader가 없습니다!");
				}
			}
			if (chkbx_tourney.Checked)
			{
				try
				{
					Process.Start(ReadSettingsFile("osu!TourneyLocation").Replace("/", @"\"));
				}
				catch (Win32Exception)
				{
					MessageBox.Show("osu!Tourney 경로가 잘못되었습니다!");
				}
				catch (InvalidOperationException)
				{
					MessageBox.Show("osu!Tourney 경로가 없습니다!\nOFCTloaderConfig.cfg 파일의 osu!TourneyLocation 태그를 작성해주세요.");
				}
			}
			if (chkbx_mapPick.Checked)
			{
				try
				{
					Process.Start(@"..\mapPick.csv");
				}
				catch (Win32Exception)
				{
					MessageBox.Show("mapPick.csv 파일을 찾을 수 없습니다!");
				}
			}
		}


		void VStitlesUpdate(object sender, EventArgs e)
		{
			rotxtbx_vs_twitchTitle.Text = txtbx_vs_tournamentName.Text + " " + txtbx_vs_bracket.Text + " : " + txtbx_vs_red.Text + " vs. " + txtbx_vs_blue.Text + " (" + txtbx_vs_code.Text + ")";
			rotxtbx_vs_twitchAlert.Text = txtbx_vs_tournamentName.Text + " " + txtbx_vs_red.Text + " vs. " + txtbx_vs_blue.Text + " 경기가 시작되었습니다!";
			rotxtbx_vs_discordAlert.Text = "@here " + txtbx_vs_tournamentName.Text + " " + txtbx_vs_bracket.Text + " : " + txtbx_vs_red.Text + " vs. " + txtbx_vs_blue.Text + " (" + txtbx_vs_code.Text + ")" + " 경기가 시작되었습니다!\nhttps://www.twitch.tv/ofct_official";
		}

		void VSsetTextFiles(object sender, EventArgs e)
		{
			File.WriteAllText(redTeamNameFileLocation, txtbx_vs_red.Text);
			File.WriteAllText(blueTeamNameFileLocation, txtbx_vs_blue.Text);
			File.WriteAllText(bracketFileLocation, txtbx_vs_bracket.Text + " : " + txtbx_vs_code.Text);
			File.WriteAllText(scheduleFileLocation, timepicker_vs_schedule.Text);
			File.WriteAllText(tournamentNameFileLocation, txtbx_vs_tournamentName.Text);

			MessageBox.Show("텍스트 파일을 업데이트했습니다.\n트위치 방송 제목, 생방송 알림과 #스트리밍-알림 채널 공지해주세요!");

			UpdateValues();
		}

		void ShowcaseTitlesUpdate(object sender, EventArgs e)
		{
			rotxtbx_showcase_streamTitle.Text = txtbx_showcase_tournamentName.Text + " " + txtbx_showcase_bracket.Text + " 맵풀 쇼케이스";
			rotxtbx_showcase_twitchTitle.Text = txtbx_showcase_tournamentName.Text + " " + txtbx_showcase_bracket.Text + " : 맵풀 쇼케이스";
			rotxtbx_showcase_twitchAlert.Text = txtbx_showcase_tournamentName.Text + " " + txtbx_showcase_bracket.Text + " 맵풀 쇼케이스가 시작되었습니다!";
			rotxtbx_showcase_discordAlert.Text = "@here " + txtbx_showcase_tournamentName.Text + " " + txtbx_showcase_bracket.Text + " 맵풀 쇼케이스가 시작되었습니다!\nhttps://www.twitch.tv/ofct_official";
		}

		void ShowcaseSetTextFiles(object sender, EventArgs e)
		{
			File.WriteAllText(tournamentNameFileLocation, txtbx_showcase_tournamentName.Text);
			File.WriteAllText(streamTitleFileLocation, rotxtbx_showcase_streamTitle.Text);

			MessageBox.Show("텍스트 파일을 업데이트했습니다.\n트위치 방송 제목, 생방송 알림과 #스트리밍-알림 채널 공지해주세요!");

			UpdateValues();
		}

		void ManualSetTextFiles(object sender, EventArgs e)
		{
			File.WriteAllText(redTeamNameFileLocation, txtbx_manual_red.Text);
			File.WriteAllText(blueTeamNameFileLocation, txtbx_manual_blue.Text);
			File.WriteAllText(bracketFileLocation, txtbx_manual_bracket.Text);
			File.WriteAllText(scheduleFileLocation, txtbx_manual_schedule.Text);
			File.WriteAllText(streamTitleFileLocation, txtbx_manual_streamTitle.Text);
			File.WriteAllText(tournamentNameFileLocation, txtbx_manual_tournamentName.Text);

			MessageBox.Show("텍스트 파일을 업데이트했습니다.");

			UpdateValues();
		}


		void MainTabChanged(object sender, TabControlCancelEventArgs e)
		{
			if(tabctrl_main.SelectedIndex == 0)
			{
				F1.Size = new Size(400, 340);
				tabctrl_main.Size = new Size(347, 230);
			}
			else if(tabctrl_main.SelectedIndex == 1)
			{
				F1.Size = new Size(540, 450);
				tabctrl_main.Size = new Size(505, 341);
			}
		}

		void UpdateValues()
		{
			if (File.Exists(redTeamNameFileLocation) && File.ReadAllText(redTeamNameFileLocation).Length > 0)
			{
				string redTeamName = File.ReadAllLines(redTeamNameFileLocation)[0];
				txtbx_vs_red.Text = redTeamName;
				txtbx_manual_red.Text = redTeamName;
			}
			else
			{
				File.WriteAllText(redTeamNameFileLocation, "");
			}

			if (File.Exists(blueTeamNameFileLocation) && File.ReadAllText(blueTeamNameFileLocation).Length > 0)
			{
				string blueTeamName = File.ReadAllLines(blueTeamNameFileLocation)[0];
				txtbx_vs_blue.Text = blueTeamName;
				txtbx_manual_blue.Text = blueTeamName;
			}
			else
			{
				File.WriteAllText(blueTeamNameFileLocation, "");
			}

			if (File.Exists(bracketFileLocation) && File.ReadAllText(bracketFileLocation).Length > 0)
			{
				string bracketFileValue = File.ReadAllLines(bracketFileLocation)[0];
				txtbx_manual_bracket.Text = bracketFileValue;
				if (bracketFileValue.Contains(" : "))
				{
					txtbx_vs_bracket.Text = bracketFileValue.Split(new string[] { " : " }, StringSplitOptions.None)[0];
					txtbx_showcase_bracket.Text = bracketFileValue.Split(new string[] { " : " }, StringSplitOptions.None)[0];
					txtbx_vs_code.Text = bracketFileValue.Split(new string[] { " : " }, StringSplitOptions.None)[1];
				}
			}
			else
			{
				File.WriteAllText(bracketFileLocation, "");
			}

			if (File.Exists(scheduleFileLocation) && File.ReadAllText(scheduleFileLocation).Length > 0)
			{
				string scheduleFileValue = File.ReadAllLines(scheduleFileLocation)[0];
				txtbx_manual_schedule.Text = scheduleFileValue;
			}
			else
			{
				File.WriteAllText(scheduleFileLocation, "");
			}

			if (File.Exists(streamTitleFileLocation) && File.ReadAllText(streamTitleFileLocation).Length > 0)
			{
				string streamTitle = File.ReadAllLines(streamTitleFileLocation)[0];
				txtbx_manual_streamTitle.Text = streamTitle;
			}
			else
			{
				File.WriteAllText(streamTitleFileLocation, "");
			}

			if(File.Exists(tournamentNameFileLocation) && File.ReadAllText(tournamentNameFileLocation).Length > 0)
			{
				string tournamentName = File.ReadAllLines(tournamentNameFileLocation)[0];
				txtbx_vs_tournamentName.Text = tournamentName;
				txtbx_showcase_tournamentName.Text = tournamentName;
				txtbx_manual_tournamentName.Text = tournamentName;
			}
			else
			{
				File.WriteAllText(tournamentNameFileLocation, "");
			}
		}

		void CreateSettingsFile()
		{
			string[] lines = { "OFCTloader 설정 파일", "", "HexchatLocation : ", "osu!TourneyLocation : ", "", "--반드시 작성해 주셔야 하는 태그는 osu!ToueneyLocation입니다. 이외의 태그는 미작성 시 기본 위치로 지정됩니다.", "각 경로는 exe 파일의 이름을 포함하도록 적어주세요", @"ex)C:\Program Files\HexChat\hexchat.exe" };
			File.WriteAllLines(configFileLocation, lines);
		}

		String ReadSettingsFile(String tag)
		{
			string[] lines = File.ReadAllLines(configFileLocation);
			foreach (string line in lines)
			{
				if (line.StartsWith(tag + " : "))
				{
					return Regex.Replace(line, tag + " : ", "");
				}
			}
			return "";
		}
	}
}
