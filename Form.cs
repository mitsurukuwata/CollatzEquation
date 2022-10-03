using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace _3x_1UI
{
    public partial class Form1 : Form
    {
   
        public int number;
        NumbersLists numbersLists = new NumbersLists();
        List<DataPoint> dataPoints;
        List<DataPoint> dataPointsMines;
        List<DataPoint> _dataPoints;
        List<DataPoint> _dataPointsMines;
        List<int> _numbersPlus;
        List<int> _numbersMines;
        List<double> _plusAvarage;
        List<double> _plusDeviation;
        List<double> _minesAvarage;
        List<double> _minesDeviation;

        public string filePath;

        public Form1()
        {
            InitializeComponent();
            
        }

        static double standardDeviation(List<int> sequence)
        {
            double result = 0;

            if (sequence.Any())
            {
                double average = sequence.Average();
                double sum = sequence.Sum(d => Math.Pow(d - average, 2));
                result = Math.Sqrt((sum) / sequence.Count());
            }
            return result;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            numbersLists.plus = new List<int>();
            numbersLists.mines = new List<int>();
            numbersLists.MinesAvarage = new List<double>();
            numbersLists.MinesDeviation = new List<double>();
            numbersLists.PlusAvarage = new List<double>();
            numbersLists.PlusDeviation = new List<double>();
            dataPoints = new List<DataPoint>();
            dataPointsMines = new List<DataPoint>();
            
            
            try
            {
                number = int.Parse(numberBox.Text);
                if (number > 0)
                {
                    chart1.Series["Number"].Points.AddXY(0, number);
                    numbersLists.plus.Add(number);
                    dataPoints.Add(new DataPoint(0, number));
                    plusNumbers.Text += number.ToString() + "\n";
                    while (number != 1)
                    {

                        _numbersPlus = numbersLists.plus;
                        if (number % 2 == 0)
                        {
                            number = number / 2;
                            chart1.Series["Number"].Points.AddXY(0, number);
                            chart1.Series["Number"].Label = "#PERCENT #VALY";
                            plusNumbers.Text += number.ToString() + "\n";
                            dataPoints.Add(new DataPoint(0, number));
                            numbersLists.plus.Add(number);
                            _dataPoints = dataPoints;
                        }
                        else
                        {
                            number = (number * 3) + 1;
                            chart1.Series["Number"].Points.AddXY(0, number);
                            chart1.Series["Number"].Label = "#PERCENT #VALY";
                            plusNumbers.Text += number.ToString() + "\n";
                            dataPoints.Add(new DataPoint(0, number));
                            numbersLists.plus.Add(number);
                            _dataPoints = dataPoints;
                        }
                    }
                    double standard_deviation = standardDeviation(numbersLists.plus);
                    double avarage = numbersLists.plus.Sum() / numbersLists.plus.Count;
                    numbersLists.PlusAvarage.Add(avarage);
                    numbersLists.PlusDeviation.Add(standard_deviation);

                    _plusAvarage = numbersLists.PlusAvarage;
                    _plusDeviation = numbersLists.PlusDeviation;

                    avarageLabel.Text += avarage.ToString() + " ";
                    standarDeviationLabel.Text += standard_deviation.ToString() + " ";

                }
                else
                {
                    chart1.Series["M.Numbers"].Points.AddXY(0, number);
                    numbersLists.mines.Add(number);
                    dataPointsMines.Add(new DataPoint(0, number));
                    minesNumbers.Text += number.ToString() + "\n";
                    if (SpecialBtn.Checked)
                    {
                        while (number != -1)
                        {

                            _numbersMines = numbersLists.mines;
                            if (number % 2 == 0)
                            {
                                number = number / 2;
                                dataPointsMines.Add(new DataPoint(0, number));
                                chart1.Series["M.Numbers"].Points.AddXY(0, number);
                                chart1.Series["M.Numbers"].Label = "#PERCENT #VALY";
                                minesNumbers.Text += number.ToString() + "\n";
                                numbersLists.mines.Add(number);
                                _dataPointsMines = dataPointsMines;
                            }
                            else
                            {
                                number = (number * 3) - 1;
                                dataPointsMines.Add(new DataPoint(0, number));
                                chart1.Series["M.Numbers"].Points.AddXY(0, number);
                                chart1.Series["M.Numbers"].Label = "#PERCENT #VALY";
                                minesNumbers.Text += number.ToString() + "\n"; ;
                                numbersLists.mines.Add(number);
                                _dataPointsMines = dataPointsMines;
                            }
                        }
                        double standard_deviation = standardDeviation(numbersLists.mines);
                        double avarage = numbersLists.mines.Sum() / numbersLists.mines.Count;
                        numbersLists.MinesAvarage.Add(avarage);
                        numbersLists.MinesDeviation.Add(standard_deviation);
                        _minesAvarage = numbersLists.MinesAvarage;
                        _minesDeviation = numbersLists.MinesDeviation;
                        avarageMinesLabel.Text += avarage.ToString() + " ";
                        standardDeviationMinesLabel.Text += standard_deviation.ToString() + " ";
                    }
                    if (SameEquation.Checked)
                    {
                        int i = 0;
                        while (i < int.Parse(textBox1.Text))
                        {
                            i++;
                            _numbersMines = numbersLists.mines;
                            if (number % 2 == 0)
                            {
                                number = number / 2;
                                dataPointsMines.Add(new DataPoint(0, number));
                                chart1.Series["M.Numbers"].Points.AddXY(0, number);
                                chart1.Series["M.Numbers"].Label = "#PERCENT #VALY";
                                minesNumbers.Text += number.ToString() + "\n";
                                numbersLists.mines.Add(number);
                                _dataPointsMines = dataPointsMines;
                            }
                            else
                            {
                                number = (number * 3) + 1;
                                dataPointsMines.Add(new DataPoint(0, number));
                                chart1.Series["M.Numbers"].Points.AddXY(0, number);
                                chart1.Series["M.Numbers"].Label = "#PERCENT #VALY";
                                minesNumbers.Text += number.ToString() + "\n"; ;
                                numbersLists.mines.Add(number);
                                _dataPointsMines = dataPointsMines;
                            }
                        }
                        double standard_deviation = standardDeviation(numbersLists.mines);
                        double avarage = numbersLists.mines.Sum() / numbersLists.mines.Count;
                        numbersLists.MinesAvarage.Add(avarage);
                        numbersLists.MinesDeviation.Add(standard_deviation);
                        _minesAvarage = numbersLists.MinesAvarage;
                        _minesDeviation = numbersLists.MinesDeviation;
                        avarageMinesLabel.Text += avarage.ToString() + " ";
                        standardDeviationMinesLabel.Text += standard_deviation.ToString() + " ";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            chart1.Series["Number"].Points.Clear();
            chart1.Series["M.Numbers"].Points.Clear();
            plusNumbers.Text = " ";
            minesNumbers.Text = " ";
            avarageLabel.Text = "Avarage (+) : ";
            standarDeviationLabel.Text = "Standard Deviation (+) : ";
            avarageMinesLabel.Text = "Avarage (-) : ";
            standardDeviationMinesLabel.Text = "Standard Deviation (-) : ";
            dataPoints.Clear();
            dataPointsMines.Clear();
        }

        private void jsonSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {               
                string folderName = jsonPathBox.Text;
                string json = JsonConvert.SerializeObject(_dataPoints);
                File.WriteAllText($@"{filePath}\{folderName}.json", json);

                string jsonMines = JsonConvert.SerializeObject(_dataPointsMines);
                File.WriteAllText($@"{filePath}\{folderName}_Mines.json", jsonMines);

                numbersLists.plus = _numbersPlus;
                numbersLists.mines = _numbersMines;
                numbersLists.MinesAvarage = _minesAvarage;
                numbersLists.MinesDeviation = _minesDeviation;
                numbersLists.PlusAvarage = _plusAvarage;
                numbersLists.PlusDeviation = _plusDeviation;

               string jsonPLusNumbers = JsonConvert.SerializeObject(numbersLists);
               File.WriteAllText($@"{filePath}\{folderName}_Numbers.json", jsonPLusNumbers);
               MessageBox.Show("Save Completed");    
            }

            catch (Exception)
            {
                MessageBox.Show("Error try again or restart the program");
            }
        }

        private void loadJson_Click(object sender, EventArgs e)
        {
           
                        string folderName = jsonPathBox.Text;
                        string pathPlus = $@"{filePath}\{folderName}.json";

                        var chartData = JsonConvert.DeserializeObject<List<DataPoint>>(File.ReadAllText(pathPlus));

                        string pathMines = $@"{filePath}\{folderName}_Mines.json";
                        var chartDataMines = JsonConvert.DeserializeObject<List<DataPoint>>(File.ReadAllText(pathMines));

                        string pathNumbers = $@"{filePath}\{folderName}_Numbers.json";
                        var numbersList = JsonConvert.DeserializeObject<NumbersLists>(File.ReadAllText(pathNumbers));

                        int? length = chartData?.Count;
                        int? lengthMines = chartDataMines?.Count;

                        if (length != null)
                        {
                            chart1.Series["Number"].Label = "#PERCENT #VALY";
                            for (int i = 0; i < chartData.Count; i++)
                            {
                                chart1.Series["Number"].Points.AddXY(chartData[i].X, chartData[i].Y);
                            }
                            for (int i = 0; i < numbersList.plus.Count; i++)
                            {
                                plusNumbers.Text += numbersList.plus.ElementAt(i).ToString() + "\n";
                            }

                            avarageLabel.Text += numbersList.PlusAvarage.ElementAt(0).ToString() + " ";
                            standarDeviationLabel.Text += numbersList.PlusDeviation.ElementAt(0).ToString() + " ";       

                        }

                        if (lengthMines != null)
                        {  
                            chart1.Series["M.Numbers"].Label = "#PERCENT #VALY";
                            for (int i = 0; i < chartDataMines.Count; i++)
                            {
                                chart1.Series["M.Numbers"].Points.AddXY(chartDataMines[i].X, chartDataMines[i].Y);
                            }
                            for (int i = 0; i < numbersList.mines.Count; i++)
                            {
                                minesNumbers.Text += numbersList.mines.ElementAt(i).ToString() + "\n";
                            }

                            avarageMinesLabel.Text += numbersList.MinesAvarage.ElementAt(0).ToString() + " ";
                            standardDeviationMinesLabel.Text += numbersList.MinesDeviation.ElementAt(0).ToString() + " ";
                        }            
        }
        private void pathFinder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    WebBrowser wb = new WebBrowser();
                    wb.Url = new Uri(fbd.SelectedPath);

                    filePath = fbd.SelectedPath;
                    pathText.Text += filePath;
                }
            }
        }
        
        private void SettingsFormOnColorsChanged(Settings settings)
        {
            if (settings.Panel1BackColor.HasValue)
            {
                panel1.BackColor = settings.Panel1BackColor.Value;
            }

            if (settings.MainFormBackColor.HasValue)
            {
                BackColor = settings.MainFormBackColor.Value;
            }

            if (settings.ChartBackColor.HasValue)
            {
                chart1.BackColor = settings.ChartBackColor.Value;
            }

            if (settings.Panel2BackColor.HasValue)
            {
                panel2.BackColor = settings.Panel2BackColor.Value;
            }
        }
        private void settingBtn_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsMenu();
            settingsForm.ColorsChanged += SettingsFormOnColorsChanged;
            settingsForm.ShowDialog();
            settingsForm.Activate();
        }
    }
}
