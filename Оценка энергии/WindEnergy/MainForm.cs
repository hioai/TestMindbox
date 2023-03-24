using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;

namespace WindEnergy
{
    public partial class MainForm : Form
    {
        private bool nonNumberEntered = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void tBDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tBWPUF_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tBEfficiency_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tBInvertor_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tBTime_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void tBDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void tBWPUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void tBEfficiency_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void tBInvertor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void tBTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (rBHours.Checked)
            {
                if (int.Parse(tBTime.Text) >= 0 & int.Parse(tBTime.Text) <= 48)
                {
                    string sTest = "";
                    int i = 0;
                    double[] aWinds = new double[48];
                    double dWind = 0;
                    string sLatitude = tBLatitude.Text;
                    string sLongtitude = tBLongitude.Text;
                    string sAPI = "https://api.openweathermap.org/data/2.5/onecall?lat=" + sLatitude + "&lon=" + sLongtitude + "&exclude=current,minutely,daily&appid=a3cffa38c49f0965340afea3180a025d";

                    rTBTest.Text = "Подождите, идет вычисление...";

                    WebRequest request = WebRequest.Create(sAPI);

                    request.Method = "POST";
                    request.ContentType = "application/x-www-urlencoded";

                    WebResponse response = request.GetResponse();

                    string answer = string.Empty;

                    //получили поток ответа и записали в строковую переменную
                    using (Stream s = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(s))
                        {
                            answer = reader.ReadToEnd();
                        }
                    }

                    response.Close();

                    JObject hourlyWind = JObject.Parse(answer);

                    IList<JToken> results = hourlyWind["hourly"].Children().ToList();

                    IList<Hourly> hourlies = new List<Hourly>();

                    foreach (JToken result in results)
                    {
                        Hourly hourly = result.ToObject<Hourly>();
                        hourlies.Add(hourly);

                    }
                    foreach (JToken result in results)
                    {
                        double inner = result["wind_speed"].Value<double>();

                        aWinds[i] = inner;
                        i++;
                    }


                    for (int j = 0; j <= int.Parse(tBTime.Text); j++)
                    {
                        dWind += aWinds[int.Parse(tBTime.Text)];
                    }

                    double dWindAverage = dWind / int.Parse(tBTime.Text);
                    double dRadius = double.Parse(tBDiameter.Text) / 2;
                    double dEnergy = Math.Round((0.92 * Math.Pow(dRadius, 2) * Math.Pow(dWindAverage, 3) * double.Parse(tBDiameter.Text)) / 1000, 3);
                    double dPowerWT = Math.Round(double.Parse(tBEfficiency.Text) * double.Parse(tBInverter.Text) * 0.5 * double.Parse(tBWPUF.Text) * 1.225 * (Math.Pow(double.Parse(tBDiameter.Text), 2) * Math.PI / 4) * Math.Pow(dWindAverage, 3) / 1000, 6);

                    sTest += "Средняя скорость ветра, м/с: " + Math.Round(dWindAverage, 3).ToString() + "\nРадиус ветроколеса, м: " + dRadius.ToString() + "\nЭнергия ВЭУ, кВТ: " + dEnergy.ToString() + "\nСредняя мощность: " + dPowerWT.ToString();
                    rTBTest.Text = sTest;

                    Graphic newGraphic = new Graphic();
                    newGraphic.Owner = this;
                    newGraphic.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    Axis ax = new Axis();
                    ax.Title = "Время, ч";
                    newGraphic.chart1.ChartAreas[0].AxisX = ax;
                    Axis ay = new Axis();
                    ay.Title = "Мощность, кВТ";
                    newGraphic.chart1.ChartAreas[0].AxisY = ay;
                    for (int j = 0; j < int.Parse(tBTime.Text); j++)
                    {
                        newGraphic.chart1.Series[0].Points.AddXY(j, Math.Round(double.Parse(tBEfficiency.Text) * double.Parse(tBInverter.Text) * 0.5 * double.Parse(tBWPUF.Text) * 1.225 * (Math.Pow(double.Parse(tBDiameter.Text), 2) * Math.PI / 4) * Math.Pow(aWinds[j], 3) / 1000, 6));
                    }
                    newGraphic.ShowDialog();
                }
                else
                {
                    rTBTest.Text = "Попробуйте ввести время в промежутке от 1 до 47";
                }
            }

             else 
                if(rBDays.Checked)
                {
                    DateTime dateTime = monthCalendar.SelectionEnd;
                    DateTime dateTime1 = monthCalendar.SelectionStart;

                    string sTest = "";
                    int j = 0;
                    int k = int.Parse(Math.Round((dateTime - dateTime1).TotalDays * 24).ToString());
                    double[] aWinds = new double[k];
                    double dWind = 0;
                    string sLatitude = tBLatitude.Text;
                    string sLongtitude = tBLongitude.Text;
                    DateTimeOffset dDateTime = monthCalendar.SelectionStart;

                    for(int i = 0; i < Math.Round((dateTime - dateTime1).TotalDays); i++)
                    {
                        string sDateTimeUNIX = dDateTime.ToUnixTimeSeconds().ToString();
                        string sAPI = "https://api.openweathermap.org/data/2.5/onecall/timemachine?lat=" + sLatitude + "&lon=" + sLongtitude + "&dt=" + sDateTimeUNIX + "&appid=a3cffa38c49f0965340afea3180a025d";

                        rTBTest.Text = "Подождите, идет вычисление...";
                        //rTBTest.Text = (dateTime - dateTime1).TotalDays.ToString();
                        WebRequest request = WebRequest.Create(sAPI);

                        request.Method = "POST";
                        request.ContentType = "application/x-www-urlencoded";

                        WebResponse response = request.GetResponse();

                        string answer = string.Empty;

                        //получили поток ответа и записали в строковую переменную
                        using (Stream s = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(s))
                            {
                                answer = reader.ReadToEnd();
                            }
                        }

                        response.Close();

                    JObject hourlyWind = JObject.Parse(answer);

                    IList<JToken> results = hourlyWind["hourly"].Children().ToList();

                    IList<Hourly> hourlies = new List<Hourly>();

                    foreach (JToken result in results)
                    {
                        Hourly hourly = result.ToObject<Hourly>();
                        hourlies.Add(hourly);

                    }
                    foreach (JToken result in results)
                        {
                            double inner = result["wind_speed"].Value<double>();

                            aWinds[j] = inner;
                            //rTBTest.Text += aWinds[j].ToString() + "\n";
                            j++;
                        }
                    dDateTime = dDateTime.AddDays(1);
                    }
                for (int n = 0; n < k; n++)
                {
                    dWind += aWinds[n];
                }

                double dWindAverage = dWind / k;
                double dRadius = double.Parse(tBDiameter.Text) / 2;
                double dEnergy = Math.Round((0.92 * Math.Pow(dRadius, 2) * Math.Pow(dWindAverage, 3) * double.Parse(tBDiameter.Text)) / 1000, 3);
                double dPowerWT = Math.Round(double.Parse(tBEfficiency.Text) * double.Parse(tBInverter.Text) * 0.5 * double.Parse(tBWPUF.Text) * 1.225 * (Math.Pow(double.Parse(tBDiameter.Text), 2) * Math.PI / 4) * Math.Pow(dWindAverage, 3) / 1000, 6);

                sTest += "Средняя скорость ветра, м/с: " + Math.Round(dWindAverage, 3).ToString() + "\nРадиус ветроколеса, м: " + dRadius.ToString() + "\nЭнергия ВЭУ, кВТ: " + dEnergy.ToString() + "\nСредняя мощность: " + dPowerWT.ToString();
                rTBTest.Text = sTest;

                Graphic newGraphic = new Graphic();
                newGraphic.Owner = this;
                newGraphic.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                Axis ax = new Axis();
                ax.Title = "Время, ч";
                newGraphic.chart1.ChartAreas[0].AxisX = ax;
                Axis ay = new Axis();
                ay.Title = "Мощность, кВТ";
                newGraphic.chart1.ChartAreas[0].AxisY = ay;
                for (int n = 0; n < k; n++)
                {
                    newGraphic.chart1.Series[0].Points.AddXY(n, Math.Round(double.Parse(tBEfficiency.Text) * double.Parse(tBInverter.Text) * 0.5 * double.Parse(tBWPUF.Text) * 1.225 * (Math.Pow(double.Parse(tBDiameter.Text), 2) * Math.PI / 4) * Math.Pow(aWinds[n], 3) / 1000, 6));
                }
                newGraphic.ShowDialog();

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            monthCalendar.MaxDate = thisDay;
            monthCalendar.MinDate = thisDay.AddDays(-4);
        }

        private void rBHours_CheckedChanged(object sender, EventArgs e)
        {
            if(rBHours.Checked)
            {
                monthCalendar.Visible = false;
                tBTime.Visible = true;
            }
        }

        private void rBDays_CheckedChanged(object sender, EventArgs e)
        {
            if(rBDays.Checked)
            {
                monthCalendar.Visible = true;
                tBTime.Visible = false;
            }
        }
    }
}
