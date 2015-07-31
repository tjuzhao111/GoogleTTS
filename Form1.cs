using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
//
using System.Media;
using NAudio;
using NAudio.Wave;
using System.Threading;
//

namespace GoogleTTS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static string mp3dir = Environment.CurrentDirectory + "\\wave\\";
        public string prefix = "";
        private void convert_Click(object sender, EventArgs e)
        {
            // prefix
            if (chapterTextBox.Text == string.Empty)
                prefix = DateTime.Now.ToString("yyyyMMddHHmmss");
            else
                prefix = chapterTextBox.Text;
            prefix += "-";

            processStr(sourceTextBox.Text);
        }

        //parameter
        struct para
        {
            public string str;
            public int index;
        };

        //all file paths
        System.Collections.ArrayList files = new System.Collections.ArrayList();

        private void processStr(String str)
        {
            files.Clear();
            string[] ContentLines = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int len = ContentLines.Length;
            int index = 0;
            for (int i = 0; i < len; i++)
            {
                string currentLine = ContentLines[i];
                string[] delim = { "." };
                // delimeter
                if (textBox1.Text == string.Empty)
                {
                    if (zhRadioButton.Checked)
                        delim = new string[] { "。" };
                    else if (enRadioButton.Checked)
                        delim = new string[] { ",", "." };
                    else if (jpRadioButton.Checked)
                        delim = new string[] { "。" };
                }
                else 
                {
                    delim = textBox1.Text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                }

                //
                string[] senSet = currentLine.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                int inLen = senSet.Length;
                for (int j = 0; j < inLen; j++)
                {
                    index++;
                    string destStr = senSet[j];
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "处理中:"+destStr;
                    // length limit
                    if (destStr.Length > 100)
                    {
                        //Console.WriteLine(destStr);
                        MessageBox.Show("这句话太长了，谷歌娘根本来不及给你读嘛！");
                        continue;
                    }
                    
                    //multi-thread switch
                    if (mThreadCheckBox.Checked)
                    {
                        para par = new para();
                        par.str = senSet[j];
                        par.index = index;
                        Thread newThread = new Thread(new ParameterizedThreadStart(getTTSMT));
                        newThread.Start(par);
                        newThread.Join();
                    }
                    else
                    {
                        getTTS(senSet[j], index);
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "处理中:" + senSet[j];
                    }
                }
            }
            // status
            statusLabel.Text = "正在进行收尾工作...";
            //// merge all files
            string strFilePattern = prefix + "*.mp3";
            string[] strFiles = Directory.GetFiles(mp3dir, strFilePattern);
            //NAudio
            FileStream fileStream = new FileStream(prefix+".mp3", FileMode.OpenOrCreate);
            foreach (string file in strFiles)
            {
                Mp3FileReader reader = new Mp3FileReader(file);
                if ((fileStream.Position == 0) && (reader.Id3v2Tag != null))
                {
                    fileStream.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                }
                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                {
                    fileStream.Write(frame.RawData, 0, frame.RawData.Length);
                }
                reader.Close();
            }
            fileStream.Close();
            ////
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "所有句子全部完成！";

            //
            if (playCheckBox.Checked)
            {
                playMp3(prefix+".mp3");
            }

            if (!saveCheckBox.Checked)
            {
                try
                {
                    File.Delete(prefix + ".mp3");
                }
                catch 
                {
                    MessageBox.Show("Something is wrong.");
                }
            }
        }

        // getTTS multi threads
        private void getTTSMT(Object obj)
        {
            para par = (para)obj;
            getTTS(par.str, par.index);
        }

        // get google speech
        private string getTTS(string str, int index)
        {
            //Console.WriteLine(str);
            ////
            string sText = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(str));
            string sLang = getLocal();
            Uri uriMp3 = new Uri("http://translate.google.cn/translate_tts?tl=" + sLang + "&q=" + sText);

            
            //
            if (!Directory.Exists(mp3dir))
            {
                Directory.CreateDirectory(mp3dir);
            }
            string sMp3Path = mp3dir + prefix + index.ToString("000") + @".mp3";
            //
            WebClient wcMp3Speech = new WebClient();
            try
            {
                wcMp3Speech.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 9.0; Windows;)");
                wcMp3Speech.DownloadFile(uriMp3, sMp3Path);
            }
            catch
            {
                MessageBox.Show("错误: 网络连接异常，无法连接到Google服务器. :(");
            }
            ////
            return sMp3Path;
            //Console.WriteLine(sMp3Path);
        }

        // get localization info
        private string getLocal() 
        {
            if (enRadioButton.Checked)
                return "en";
            else if (zhRadioButton.Checked)
                return "zh";
            else
                return "ja";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipsLabel.Text = "提示: 请确保当前选择语言正确，否则转换结果异常。";
        }

        private void zhRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipsLabel.Text = "提示: 请确保当前选择语言正确，否则转换结果异常。";
        }

        private void jpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipsLabel.Text = "提示: 请确保当前选择语言正确，否则转换结果异常。";
        }

        private void playMp3(string sMp3Path)
        {
            IWavePlayer waveOutDevice;
            AudioFileReader audioFileReader;
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(sMp3Path);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        private void playCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (playCheckBox.Checked)
            {
                saveCheckBox.Checked = true;
                saveCheckBox.Enabled = false;
            }
            else
            {
                saveCheckBox.Enabled = true;
            }
        }

        private void saveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mThreadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mThreadCheckBox.Checked)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "已启用多线程处理，可能会造成系统不稳定.";
            }
            else 
            {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Click go!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            about abw = new about();
            abw.StartPosition = FormStartPosition.CenterScreen;
            abw.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("自定义分句，分句符以空格隔开.");
        }
    }
}
