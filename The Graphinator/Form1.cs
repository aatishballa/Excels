using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace The_Graphinator
{
	public partial class Form1 : Form
	{
		private Boolean saveXL;
		private double start, end, interval;

		public Form1()
		{
			InitializeComponent();
		}

		private void loadSteps() {
			try
			{
				interval = double.Parse(T_Interval.Text);
			}
			catch (Exception ex)
			{
				interval = 0.1;
			}

			try
			{
				start = double.Parse(T_Start.Text);
			}
			catch (Exception ex)
			{
				start = 0;
			}

			try
			{
				end = double.Parse(T_End.Text);
			}
			catch (Exception ex)
			{
				end = 10;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			loadSteps();
			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;

			xlApp = new Excel.Application();
			xlApp.DisplayAlerts = false;

			xlWorkBook = xlApp.Workbooks.Add(misValue);
			xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

			//add data 
			int max = (int)((end - start) / interval);
			for (int i = 1; i <= max; i++)
			{
				double x = i * interval;

				string xlEquation = "=";

				foreach (char c in T_Equation.Text)
				{
					if (c == 'X' || c == 'x')
					{
						xlEquation += x;
					}
					else
					{
						xlEquation += c;
					}
				}

				xlWorkSheet.Cells[i, 1] = xlEquation;
			}

			Excel.Range chartRange;

			Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
			Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(0, 0, 465, 330);
			Excel.Chart chartPage = myChart.Chart;

			chartRange = xlWorkSheet.get_Range("A1", "A" + max);
			//chartRange = xlWorkSheet.get_Range("A1", "A100"); //0.1 increments up to 10
			chartPage.SetSourceData(chartRange, misValue);
			chartPage.ChartType = Excel.XlChartType.xlLine;
			chartPage.Legend.Clear();
			
			Excel.Axis yaxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
			yaxis.HasTitle = true;
			yaxis.AxisTitle.Text = "Y";

			Excel.Axis xaxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
			xaxis.HasTitle = true;
			xaxis.AxisTitle.Text = "X";


			//export chart as picture file
			if (pictureBox1.Image != null)
			{
				pictureBox1.Image.Dispose();
				pictureBox1.Image = null;
			}
			chartPage.Export(AppDomain.CurrentDomain.BaseDirectory + "test.bmp", "BMP", misValue);

			//load picture to picturebox
			pictureBox1.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "test.bmp");

			xlWorkBook.Close(saveXL, misValue, misValue);
			xlApp.Quit();

			releaseObject(xlWorkSheet);
			releaseObject(xlWorkBook);
			releaseObject(xlApp);
			releaseObject(chartPage);
		}

		private void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			saveXL = !saveXL;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
