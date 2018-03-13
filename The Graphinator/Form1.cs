using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace The_Graphinator
{
	public partial class Form1 : Form
	{
		private Boolean saveXL;
		private double start, end, interval,
			ystart, yend, yinterval;

		public Form1()
		{
			InitializeComponent();
		}

		private void loadSteps(bool threeD) {
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

			if (threeD)
			{
				try
				{
					yinterval = double.Parse(T_IntervalY.Text);
				}
				catch (Exception ex)
				{
					yinterval = 0.1;
				}

				try
				{
					ystart = double.Parse(T_StartY.Text);
				}
				catch (Exception ex)
				{
					ystart = 1;
				}

				try
				{
					yend = double.Parse(T_EndY.Text);
				}
				catch (Exception ex)
				{
					yend = 10;
				}
			}
			else
			{
				ystart = 1;
				yend = 2;
				yinterval = 1;
			}
		}

		private void graph(bool threeD) {
			loadSteps(threeD);
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
			int ymax = (int)((yend - ystart) / yinterval);
			int index = 1;

			progressBar1.Maximum = max;

			for (int i = 1; i <= max; i++)
			{
				progressBar1.Value = i;
				progressBar1.Refresh();
				
				double x = i * interval + start;

				for (int j = 1; j <= ymax; j++)
				{

					double y = j * yinterval + ystart;

					string xlEquation = "=";

					foreach (char c in T_Equation.Text)
					{
						Application.DoEvents();

						if (c == 'X' || c == 'x')
						{
							xlEquation += x;
						}
						else if (threeD && (c == 'Y' || c == 'y'))
						{
							xlEquation += y;
						}
						else
						{
							xlEquation += c;
						}
					}

					++index;
					try
					{
						if (!threeD)
						{
							xlWorkSheet.Cells[index, 1] = x.ToString();
							xlWorkSheet.Cells[index, 2] = xlEquation;
						}
						else
						{
							xlWorkSheet.Cells[1, j + 1] = y.ToString();
							xlWorkSheet.Cells[i+1, 1] = x.ToString();
							xlWorkSheet.Cells[i+1, j+1] = xlEquation;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Invalid equation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}

			Excel.Range chartYRange, chartXRange, chartZRange;

			Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
			Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(0, 0, 465, 330);
			Excel.Chart chartPage = myChart.Chart;
			
			int last = max * ymax;
			chartXRange = xlWorkSheet.get_Range("A1", "A" + last);
			chartYRange = xlWorkSheet.get_Range("B1", "B" + last);
				
			if (!threeD)
			{
				chartPage.SetSourceData(chartYRange, misValue);
			}
			else
			{
				try
				{
					char endC = System.Convert.ToChar(Convert.ToInt32('B') + ymax - 1);
					chartZRange = xlWorkSheet.get_Range("A1", endC + "" + max);
					chartPage.SetSourceData(chartZRange, misValue);
				}
				catch(Exception ex) {
					MessageBox.Show("Chart y-range too large.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			chartPage.ChartType = (threeD) ? Excel.XlChartType.xlSurface : Excel.XlChartType.xlLine;
			chartPage.Legend.Clear();

				if(!threeD) chartPage.SeriesCollection(1).XValues = chartXRange;

				Excel.Axis yaxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
				yaxis.HasTitle = true;
				yaxis.AxisTitle.Text = "Y";

				Excel.Axis xaxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
				xaxis.HasTitle = true;
				xaxis.AxisTitle.Text = "X";
			
			if(threeD){
				Excel.Axis zAxis = (Excel.Axis)chartPage.Axes(Excel.XlAxisType.xlValue,
					Excel.XlAxisGroup.xlPrimary);
				zAxis.HasTitle = true;
				zAxis.AxisTitle.Text = "Z";
			}

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

		private void button1_Click(object sender, EventArgs e)
		{
			if (C_Dim.Text.Equals("z=")) {
				graph(true);
				return;
			}

			graph(false);
		}

		private void T_Equation_TextChanged(object sender, EventArgs e)
		{

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

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

		private void C_Dim_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool b = C_Dim.Text.Equals("z=");
			label1.Visible = label5.Visible = label6.Visible = b;
			T_StartY.Visible = T_EndY.Visible = T_IntervalY.Visible = b;
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
