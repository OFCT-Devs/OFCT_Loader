using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
		readonly String configFileLocation = @"../OFCTloaderConfig.cfg";

		public Form1()
		{
			InitializeComponent();

			Button_Set.Click += SetTextFiles;
			Button_Init.Click += Start;

			if (File.Exists(redTeamNameFileLocation) && File.ReadAllText(redTeamNameFileLocation).Length > 0)
			{
				TextBox_RedTeamName.Text = File.ReadAllLines(redTeamNameFileLocation)[0];
			}
			else
			{
				File.WriteAllText(redTeamNameFileLocation, "");
			}

			if (File.Exists(blueTeamNameFileLocation) && File.ReadAllText(blueTeamNameFileLocation).Length > 0)
			{
				TextBox_BlueTeamName.Text = File.ReadAllLines(blueTeamNameFileLocation)[0];
			}
			else
			{
				File.WriteAllText(blueTeamNameFileLocation, "");
			}

			if (File.Exists(bracketFileLocation) && File.ReadAllText(bracketFileLocation).Length > 0)
			{
				TextBox_Round.Text = File.ReadAllLines(bracketFileLocation)[0];
			}
			else
			{
				File.WriteAllText(bracketFileLocation, "");
			}

			if (File.Exists(scheduleFileLocation) && File.ReadAllText(scheduleFileLocation).Length > 0)
			{
				TextBox_Schedule.Text = File.ReadAllLines(scheduleFileLocation)[0];
			}
			else
			{
				File.WriteAllText(scheduleFileLocation, "");
			}

			if (File.Exists(streamTitleFileLocation) && File.ReadAllText(streamTitleFileLocation).Length > 0)
			{
				TextBox_Title.Text = File.ReadAllLines(streamTitleFileLocation)[0];
			}
			else
			{
				File.WriteAllText(streamTitleFileLocation, "");
			}

			if (!File.Exists(configFileLocation)){
				CreateSettingsFile();
			}
		}

		void SetTextFiles(object sender, EventArgs e)
		{
			File.WriteAllText(redTeamNameFileLocation, TextBox_RedTeamName.Text);
			File.WriteAllText(blueTeamNameFileLocation, TextBox_BlueTeamName.Text);
			File.WriteAllText(bracketFileLocation, TextBox_Round.Text);
			File.WriteAllText(scheduleFileLocation, TextBox_Schedule.Text);
			File.WriteAllText(streamTitleFileLocation, TextBox_Title.Text);

			MessageBox.Show("텍스트 파일을 업데이트했습니다.");
		}

		void Start(object sender, EventArgs e)
		{
			if (CheckBox_Hexchat.Checked)
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
			if (CheckBox_SR.Checked)
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
			if (CheckBox_Tourney.Checked)
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
			if (CheckBox_MapPick.Checked)
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
