using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                // Declaration of variables
                int score1 = Convert.ToInt16(textBox2.Text);
                int score2 = Convert.ToInt16(textBox7.Text);
                int score3 = Convert.ToInt16(textBox11.Text);
                int score4 = Convert.ToInt16(textBox15.Text);
                int score5 = Convert.ToInt16(textBox19.Text);
                int score6 = Convert.ToInt16(textBox23.Text);
                int score7 = Convert.ToInt16(textBox27.Text);
                int score8 = Convert.ToInt16(textBox31.Text);
                int score9 = Convert.ToInt16(textBox35.Text);
                int score10 = Convert.ToInt16(textBox39.Text);
                int score11 = Convert.ToInt16(textBox43.Text);
                int score12 = Convert.ToInt16(textBox47.Text);
                int unit1 = Convert.ToInt16(textBox3.Text);
                int unit2 = Convert.ToInt16(textBox6.Text);
                int unit3 = Convert.ToInt16(textBox10.Text);
                int unit4 = Convert.ToInt16(textBox14.Text);
                int unit5 = Convert.ToInt16(textBox18.Text);
                int unit6 = Convert.ToInt16(textBox22.Text);
                int unit7 = Convert.ToInt16(textBox26.Text);
                int unit8 = Convert.ToInt16(textBox30.Text);
                int unit9 = Convert.ToInt16(textBox34.Text);
                int unit10 = Convert.ToInt16(textBox38.Text);
                int unit11 = Convert.ToInt16(textBox42.Text);
                int unit12 = Convert.ToInt16(textBox46.Text);

                // computation for the first column
                if (score1 >= 70)
                {
                    score1 = 5;
                    int numPoint = score1 * unit1;
                    textBox4.Text = numPoint.ToString();
                }
                else if (score1 >= 60)
                {
                    score1 = 4;
                    int numPoint = score1 * unit1;
                    textBox4.Text = numPoint.ToString();
                }
                else if (score1 >= 50)
                {
                    score1 = 3;
                    int numPoint = score1 * unit1;
                    textBox4.Text = numPoint.ToString();
                }
                else if (score1 >= 45)
                {
                    score1 = 2;
                    int numPoint = score1 * unit1;
                    textBox4.Text = numPoint.ToString();
                }
                else if (score1 <= 44)
                {
                    score1 = 0;
                    int numPoint = score1 * unit1;
                    textBox4.Text = numPoint.ToString();
                }
                //Computation for the second column
                if (score2 >= 70)
                {
                    score2 = 5;
                    int numPoint = score2 * unit2;
                    textBox5.Text = numPoint.ToString();
                }
                else if (score2 >= 60)
                {
                    score2 = 4;
                    int numPoint = score2 * unit2;
                    textBox5.Text = numPoint.ToString();
                }
                else if (score2 >= 50)
                {
                    score2 = 3;
                    int numPoint = score2 * unit2;
                    textBox5.Text = numPoint.ToString();
                }
                else if (score2 >= 45)
                {
                    score2 = 2;
                    int numPoint = score2 * unit2;
                    textBox5.Text = numPoint.ToString();
                }
                else if (score2 <= 44)
                {
                    score2 = 0;
                    int numPoint = score2 * unit2;
                    textBox5.Text = numPoint.ToString();
                }
                // Computation for the third column
                if (score3 >= 70)
                {
                    score3 = 5;
                    int numPoint = score3 * unit3;
                    textBox9.Text = numPoint.ToString();
                }
                else if (score3 >= 60)
                {
                    score3 = 4;
                    int numPoint = score3 * unit3;
                    textBox9.Text = numPoint.ToString();
                }
                else if (score3 >= 50)
                {
                    score3 = 3;
                    int numPoint = score3 * unit3;
                    textBox9.Text = numPoint.ToString();
                }
                else if (score3 >= 45)
                {
                    score3 = 2;
                    int numPoint = score3 * unit3;
                    textBox9.Text = numPoint.ToString();
                }
                else if (score3 <= 44)
                {
                    score3 = 0;
                    int numPoint = score3 * unit3;
                    textBox9.Text = numPoint.ToString();
                }
                // Computation for the fourth column
                if (score4 >= 70)
                {
                    score4 = 5;
                    int numPoint = score4 * unit4;
                    textBox13.Text = numPoint.ToString();
                }
                else if (score4 >= 60)
                {
                    score4 = 4;
                    int numPoint = score4 * unit4;
                    textBox13.Text = numPoint.ToString();
                }
                else if (score4 >= 50)
                {
                    score4 = 3;
                    int numPoint = score4 * unit4;
                    textBox13.Text = numPoint.ToString();
                }
                else if (score4 >= 45)
                {
                    score4 = 2;
                    int numPoint = score4 * unit4;
                    textBox13.Text = numPoint.ToString();
                }
                else if (score4 <= 44)
                {
                    score4 = 0;
                    int numPoint = score4 * unit4;
                    textBox13.Text = numPoint.ToString();
                }
                // Computation for the fifth column
                if (score5 >= 70)
                {
                    score5 = 5;
                    int numPoint = score5 * unit5;
                    textBox17.Text = numPoint.ToString();
                }
                else if (score5 >= 60)
                {
                    score5 = 4;
                    int numPoint = score5 * unit5;
                    textBox17.Text = numPoint.ToString();
                }
                else if (score5 >= 50)
                {
                    score5 = 3;
                    int numPoint = score5 * unit5;
                    textBox17.Text = numPoint.ToString();
                }
                else if (score5 >= 45)
                {
                    score5 = 2;
                    int numPoint = score5 * unit5;
                    textBox17.Text = numPoint.ToString();
                }
                else if (score5 <= 44)
                {
                    score5 = 0;
                    int numPoint = score5 * unit5;
                    textBox17.Text = numPoint.ToString();
                }
                // Computation for the sixth column
                if (score6 >= 70)
                {
                    score6 = 5;
                    int numPoint = score6 * unit6;
                    textBox21.Text = numPoint.ToString();
                }
                else if (score6 >= 60)
                {
                    score6 = 4;
                    int numPoint = score6 * unit6;
                    textBox21.Text = numPoint.ToString();
                }
                else if (score6 >= 50)
                {
                    score6 = 3;
                    int numPoint = score6 * unit6;
                    textBox21.Text = numPoint.ToString();
                }
                else if (score6 >= 45)
                {
                    score6 = 2;
                    int numPoint = score6 * unit6;
                    textBox21.Text = numPoint.ToString();
                }
                else if (score6 <= 44)
                {
                    score6 = 0;
                    int numPoint = score6 * unit6;
                    textBox21.Text = numPoint.ToString();
                }
                // Computation for the seventh column
                if (score7 >= 70)
                {
                    score7 = 5;
                    int numPoint = score7 * unit7;
                    textBox25.Text = numPoint.ToString();
                }
                else if (score7 >= 60)
                {
                    score7 = 4;
                    int numPoint = score7 * unit7;
                    textBox25.Text = numPoint.ToString();
                }
                else if (score7 >= 50)
                {
                    score7 = 3;
                    int numPoint = score7 * unit7;
                    textBox25.Text = numPoint.ToString();
                }
                else if (score7 >= 45)
                {
                    score7 = 2;
                    int numPoint = score7 * unit7;
                    textBox25.Text = numPoint.ToString();
                }
                else if (score7 <= 44)
                {
                    score7 = 0;
                    int numPoint = score7 * unit7;
                    textBox25.Text = numPoint.ToString();
                }
                // computation for the eighth column
                if (score8 >= 70)
                {
                    score8 = 5;
                    int numPoint = score8 * unit8;
                    textBox29.Text = numPoint.ToString();
                }
                else if (score8 >= 60)
                {
                    score8 = 4;
                    int numPoint = score8 * unit8;
                    textBox29.Text = numPoint.ToString();
                }
                else if (score8 >= 50)
                {
                    score8 = 3;
                    int numPoint = score8 * unit8;
                    textBox29.Text = numPoint.ToString();
                }
                else if (score8 >= 45)
                {
                    score8 = 2;
                    int numPoint = score8 * unit8;
                    textBox29.Text = numPoint.ToString();
                }
                else if (score8 <= 44)
                {
                    score8 = 0;
                    int numPoint = score8 * unit8;
                    textBox29.Text = numPoint.ToString();
                }
                // Computation for the ninth column
                if (score9 >= 70)
                {
                    score9 = 5;
                    int numPoint = score9 * unit9;
                    textBox33.Text = numPoint.ToString();
                }
                else if (score9 >= 60)
                {
                    score9 = 4;
                    int numPoint = score9 * unit9;
                    textBox33.Text = numPoint.ToString();
                }
                else if (score9 >= 50)
                {
                    score9 = 3;
                    int numPoint = score9 * unit9;
                    textBox33.Text = numPoint.ToString();
                }
                else if (score9 >= 45)
                {
                    score9 = 2;
                    int numPoint = score9 * unit9;
                    textBox33.Text = numPoint.ToString();
                }
                else if (score9 <= 44)
                {
                    score9 = 0;
                    int numPoint = score9 * unit9;
                    textBox33.Text = numPoint.ToString();
                }
                // Computation for the tenth column
                if (score10 >= 70)
                {
                    score10 = 5;
                    int numPoint = score10 * unit10;
                    textBox37.Text = numPoint.ToString();
                }
                else if (score10 >= 60)
                {
                    score10 = 4;
                    int numPoint = score10 * unit10;
                    textBox37.Text = numPoint.ToString();
                }
                else if (score10 >= 50)
                {
                    score10 = 3;
                    int numPoint = score10 * unit10;
                    textBox37.Text = numPoint.ToString();
                }
                else if (score10 >= 45)
                {
                    score10 = 2;
                    int numPoint = score10 * unit10;
                    textBox37.Text = numPoint.ToString();
                }
                else if (score10 <= 44)
                {
                    score10 = 0;
                    int numPoint = score10 * unit10;
                    textBox37.Text = numPoint.ToString();
                }
                // Computation for the eleventh column
                if (score11 >= 70)
                {
                    score11 = 5;
                    int numPoint = score11 * unit11;
                    textBox41.Text = numPoint.ToString();
                }
                else if (score11 >= 60)
                {
                    score11 = 4;
                    int numPoint = score11 * unit11;
                    textBox41.Text = numPoint.ToString();
                }
                else if (score11 >= 50)
                {
                    score11 = 3;
                    int numPoint = score11 * unit11;
                    textBox41.Text = numPoint.ToString();
                }
                else if (score11 >= 45)
                {
                    score11 = 2;
                    int numPoint = score11 * unit11;
                    textBox41.Text = numPoint.ToString();
                }
                else if (score11 <= 44)
                {
                    score11 = 0;
                    int numPoint = score11 * unit11;
                    textBox41.Text = numPoint.ToString();
                }
                //Computation for the twelveth column
                if (score12 >= 70)
                {
                    score12 = 5;
                    int numPoint = score12 * unit12;
                    textBox45.Text = numPoint.ToString();
                }
                else if (score12 >= 60)
                {
                    score12 = 4;
                    int numPoint = score12 * unit12;
                    textBox45.Text = numPoint.ToString();
                }
                else if (score12 >= 50)
                {
                    score12 = 3;
                    int numPoint = score12 * unit12;
                    textBox45.Text = numPoint.ToString();
                }
                else if (score12 >= 45)
                {
                    score12 = 2;
                    int numPoint = score12 * unit12;
                    textBox45.Text = numPoint.ToString();
                }
                else if (score12 <= 44)
                {
                    score12 = 0;
                    int numPoint = score12 * unit12;
                    textBox45.Text = numPoint.ToString();
                }
                // Declaration of value store in the TotalPoint as string
                int totalPoint1 = Convert.ToInt16(textBox4.Text);
                int totalPoint2 = Convert.ToInt16(textBox5.Text);
                int totalPoint3 = Convert.ToInt16(textBox9.Text);
                int totalPoint4 = Convert.ToInt16(textBox13.Text);
                int totalPoint5 = Convert.ToInt16(textBox17.Text);
                int totalPoint6 = Convert.ToInt16(textBox21.Text);
                int totalPoint7 = Convert.ToInt16(textBox25.Text);
                int totalPoint8 = Convert.ToInt16(textBox29.Text);
                int totalPoint9 = Convert.ToInt16(textBox33.Text);
                int totalPoint10 = Convert.ToInt16(textBox37.Text);
                int totalPoint11 = Convert.ToInt16(textBox41.Text);
                int totalPoint12 = Convert.ToInt16(textBox45.Text);

                // Calculations for 7 courses
                if (score8 == 0 && score9 == 0 && score10 == 0 && score11 == 0 && score12 == 0 && unit8 == 0 && unit9 == 0 && unit10 == 0 && unit11 == 0 && unit12 == 0 && textBox32.Text == "" && textBox36.Text == "" && textBox40.Text == "" && textBox44.Text == "" && textBox48.Text == "")
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }

                //Calculation for 8 courses
                else if (score9 == 0 && score10 == 0 && score11 == 0 && score12 == 0 && unit9 == 0 && unit10 == 0 && unit11 == 0 && unit12 == 0 && textBox36.Text == "" && textBox40.Text == "" && textBox44.Text == "" && textBox48.Text == "")
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7 + totalPoint8;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }
                // Calculations for 9 courses
                else if (score10 == 0 && score11 == 0 && score12 == 0 && unit10 == 0 && unit11 == 0 && unit12 == 0 && textBox40.Text == "" && textBox44.Text == "" && textBox48.Text == "")
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8 + unit9;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7 + totalPoint8 + totalPoint9;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }
                //Calculations for 10 courses
                else if (score11 == 0 && score12 == 0 && unit11 == 0 && unit12 == 0 && textBox44.Text == "" && textBox48.Text == "")
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8 + unit9 + unit10;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7 + totalPoint8 + totalPoint9 + totalPoint10;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }
                //Calculations for 11 courses
                else if (score12 == 0 && unit12 == 0 && textBox48.Text == "")
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8 + unit9 + unit10 + unit11;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7 + totalPoint8 + totalPoint9 + totalPoint10 + totalPoint11;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }
                // Calculations for 12 courses
                else
                {
                    double totalUnit = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8 + unit9 + unit10 + unit11 + unit12;
                    double finalTotalPoint = totalPoint1 + totalPoint2 + totalPoint3 + totalPoint4 + totalPoint5 + totalPoint6 + totalPoint7 + totalPoint8 + totalPoint9 + totalPoint10 + totalPoint11 + totalPoint12;
                    textBox49.Text = totalUnit.ToString();
                    textBox50.Text = finalTotalPoint.ToString();
                    double grade = finalTotalPoint / totalUnit;
                    double gradePoint = Math.Round(grade, 2);
                    textBox51.Text = gradePoint.ToString();
                }
                double gradePointAverage = Convert.ToDouble(textBox51.Text);
                if (gradePointAverage >= 4.5)
                {
                    textBox52.Text = "First Class";
                }
                else if (gradePointAverage >= 3.5)
                {
                    textBox52.Text = "Second Class Upper";
                }
                else if (gradePointAverage >= 2.5)
                {
                    textBox52.Text = "Second Class Lower";
                }
                else
                    textBox52.Text = "Third Class";
            }
            catch
            {
                MessageBox.Show("Please enter a value", "Empty Input ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox21.ReadOnly = true;
            textBox25.ReadOnly = true;
            textBox29.ReadOnly = true;
            textBox33.ReadOnly = true;
            textBox37.ReadOnly = true;
            textBox41.ReadOnly = true;
            textBox45.ReadOnly = true;
            textBox49.ReadOnly = true;
            textBox50.ReadOnly = true;
            textBox51.ReadOnly = true;
            textBox52.ReadOnly = true;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        //Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox3.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox7.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox6.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox11.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox10.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox15.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox14.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox19.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox18.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox23.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox22.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox27.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox26.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox31.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox30.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox35.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox34.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox39.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox38.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox43.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox42.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox47.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        // code to handle error due to character or string in the textbox for value
        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textBox46.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "This Program was created on 06-July-2020 by GEORGE KADIRI OLUSEGUN during SoftCodeTech Training."; 
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void aboutToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "For comments, suggetions, and contributions on how improve this calculator Call 08139782777 or Email khadreegeorge@gmail.com"; 
        }

        private void helpToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void helpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void aboutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void howToUseTheCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "For Calculations of less than 12 courses. Please leave the remaining Course Code blank and input 0 to Scores and Units.The minimum Courses the Calculator can calculate is 7 and the maximum is 12.";
            
        }

        private void commentBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "For Comments, suggetions, and contributions on how improve this calculator Call 08139782777 or Email khadreegeorge@gmail.com";
        }

        private void howToUseTheCalculatorToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void commentBoxToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox2.Text = "This program was design by a Computer Engineering student  Futarian for Futarians"
;        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox2.Text = "This program was design by a CPE Futarian for Futarians";
        }

        private void commentBoxToolStripMenuItem_MouseLeave_1(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
