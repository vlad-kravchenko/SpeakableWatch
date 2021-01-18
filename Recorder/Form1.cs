using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Recorder
{
    public partial class Form1 : Form
    {
        private string path = "audio\\";
        private string AudioFileName;
        private WaveIn waveIn;
        private WaveFileWriter writer;
        Dictionary<string, string> words = new Dictionary<string, string>();
        private int curNum = -1;

        public Form1()
        {
            if (!Directory.Exists("audio\\")) Directory.CreateDirectory("audio\\");
            InitializeWords();
            InitializeComponent();
            NextItem();
        }

        private void InitializeWords()
        {
            words.Add("00hh.wav", "ноль часов");
            words.Add("01hh.wav", "один час");
            words.Add("02hh.wav", "два часа");
            words.Add("03hh.wav", "три часа");
            words.Add("04hh.wav", "чётыре часа");
            words.Add("05hh.wav", "пять часов");
            words.Add("06hh.wav", "шесть часов");
            words.Add("07hh.wav", "семь часов");
            words.Add("08hh.wav", "восемь часов");
            words.Add("09hh.wav", "девять часов");
            words.Add("10hh.wav", "десять часов");
            words.Add("11hh.wav", "одиннадцать часов");
            words.Add("12hh.wav", "двенадцать часов");
            words.Add("13hh.wav", "тринадцать часов");
            words.Add("14hh.wav", "четырнадцать часов");
            words.Add("15hh.wav", "пятнадцать часов");
            words.Add("16hh.wav", "шестнадцать часов");
            words.Add("17hh.wav", "семнадцать часов");
            words.Add("18hh.wav", "восемнадцать часов");
            words.Add("19hh.wav", "девятнадцать часов");
            words.Add("20hh.wav", "двадцать часов");
            words.Add("21hh.wav", "двадцать один час");
            words.Add("22hh.wav", "двадцать два часа");
            words.Add("23hh.wav", "двадцать три часа");
            words.Add("zero.wav", "ровно");
            words.Add("00mm.wav", "минут");
            words.Add("01mm.wav", "одна минута");
            words.Add("02mm.wav", "две минуты");
            words.Add("03mm.wav", "три минуты");
            words.Add("04mm.wav", "чётыре минуты");
            words.Add("05mm.wav", "пять минут");
            words.Add("06mm.wav", "шесть минут");
            words.Add("07mm.wav", "семь минут");
            words.Add("08mm.wav", "восемь минут");
            words.Add("09mm.wav", "девять минут");
            words.Add("10mm.wav", "десять минут");
            words.Add("11mm.wav", "одиннадцать минут");
            words.Add("12mm.wav", "двенадцать минут");
            words.Add("13mm.wav", "тринадцать минут");
            words.Add("14mm.wav", "четырнадцать минут");
            words.Add("15mm.wav", "пятнадцать минут");
            words.Add("16mm.wav", "шестнадцать минут");
            words.Add("17mm.wav", "семнадцать минут");
            words.Add("18mm.wav", "восемнадцать минут");
            words.Add("19mm.wav", "девятнадцать минут");
            words.Add("20.wav", "двадцать");
            words.Add("30.wav", "тридцать");
            words.Add("40.wav", "сорок");
            words.Add("50.wav", "пятьдесят");
        }

        private void lbRecord_MouseEnter(object sender, EventArgs e)
        {
            lbRecord.Text = "ИДЁТ ЗАПИСЬ";
            lbRecord.BackColor = Color.Pink;
            StartRecording();
        }

        private void lbRecord_MouseLeave(object sender, EventArgs e)
        {
            lbRecord.Text = "НАВЕДИТЕ МЫШКУ ДЛЯ ЗАПИСИ";
            lbRecord.BackColor = BackColor;
            StopRecording();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextItem();
        }

        private void NextItem()
        {
            curNum++;
            if (curNum >= words.Count) curNum = 0;
            lbText.Text = words.Values.ElementAt(curNum);
            AudioFileName = words.Keys.ElementAt(curNum);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SoundPlayer sp = new SoundPlayer(path + AudioFileName))
                {
                    sp.PlaySync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void StartRecording()
        {
            try
            {
                waveIn = new WaveIn();
                waveIn.DeviceNumber = 0;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.RecordingStopped += waveIn_RecordingStopped;
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                writer = new WaveFileWriter(path + AudioFileName, waveIn.WaveFormat);
                waveIn.StartRecording();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!");
            }
        }

        private void StopRecording()
        {
            if (waveIn == null) return;
            waveIn.StopRecording();
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
            }
            else
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void waveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped), sender, e);
            }
            else
            {
                waveIn.Dispose();
                waveIn = null;
                writer.Close();
                writer=null;
            }
        }
    }
}
