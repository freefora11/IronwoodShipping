using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crate;
using Novacode;
using System.Diagnostics;



namespace Crate
{
    public partial class Form1 : Form
    {
        //arrays with amount 
        TextBox[] arrAmountTextBoxPanel;
        TextBox[] arrAmountTextBoxDoor;
        TextBox[] arrAmountTextBoxPost;
        TextBox[] arrAmountTextBoxUrinal;

        //arrays with widths
        TextBox[] arrWidthTextBoxPanel;
        TextBox[] arrWidthTextBoxDoor;
        TextBox[] arrWidthTextBoxPost;
        TextBox[] arrWidthTextBoxUrinal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        //when panel enter button is clicked, create fields in panel
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int totalPieces = Convert.ToInt32(numericUpDownTotal.Text);
            if (totalPieces > 6)
            {
                totalPieces = 6;
            }
            tableLayoutPanel1.Controls.Clear();
            //adds the label for each panel counting from 1
            Label[] arrLabel = new Label[totalPieces];
            TextBox[] arrHeightTextBoxPanel = new TextBox[totalPieces];
            arrWidthTextBoxPanel = new TextBox[totalPieces];
            arrAmountTextBoxPanel = new TextBox[totalPieces];
            for (int i = 0; i < totalPieces; i++)
            {
                //add label to array
                Label label = new Label();
                label.Text = i + 1 + ".";
                arrLabel[i] = label;
                //add textbox to height textbox array
                TextBox tbHeight = new TextBox();
                tbHeight.Name = "panelHeight" + (i + 1);
                tbHeight.Text = numericUpDownHeight.Text;
                arrHeightTextBoxPanel[i] = tbHeight;
                //add textbox to width array
                TextBox tbWidth = new TextBox();
                tbWidth.Name = "panelWidth" + (i + 1);
                arrWidthTextBoxPanel[i] = tbWidth;
                // add textbox to amount array
                TextBox tbAmount = new TextBox();
                tbAmount.Name = "panelAmount" + (i + 1);
                tbAmount.Text = "0";
                arrAmountTextBoxPanel[i] = tbAmount;
            }
            //add arrays to table layout panel
            int labelCount = 0;
            int heightCount = 0;
            int widthCount = 0;
            int amountCount = 0;
            foreach (Control c in arrLabel)
            {
                tableLayoutPanel1.Controls.Add(c, 0, labelCount);
                labelCount++;
            }
            foreach (Control c in arrHeightTextBoxPanel)
            {
                tableLayoutPanel1.Controls.Add(c, 1, heightCount);
                heightCount++;
            }
            foreach (Control c in arrWidthTextBoxPanel)
            {
                tableLayoutPanel1.Controls.Add(c, 2, widthCount);
                widthCount++;
            }
            foreach (Control c in arrAmountTextBoxPanel)
            {
                tableLayoutPanel1.Controls.Add(c, 3, amountCount);
                amountCount++;
            }
        }

        private void labelPanelWidth_Click(object sender, EventArgs e)
        {

        }

        //when Door Enter button is clicked, add controls to panel
        private void buttonEnter2_Click(object sender, EventArgs e)
        {
            int totalPieces = Convert.ToInt32(numericUpDownTotal2.Text);
            if (totalPieces > 6)
            {
                totalPieces = 6;
            }
            tableLayoutDoor.Controls.Clear();
            //adds the label for each panel counting from 1
            Label[] arrLabel = new Label[totalPieces];
            TextBox[] arrHeightTextBoxDoor = new TextBox[totalPieces];
            arrWidthTextBoxDoor = new TextBox[totalPieces];
            arrAmountTextBoxDoor = new TextBox[totalPieces];
            for (int i = 0; i < totalPieces; i++)
            {
                //add label to array
                Label label = new Label();
                label.Text = i + 1 + ".";
                arrLabel[i] = label;
                //add textbox to height textbox array
                TextBox tbHeight = new TextBox();
                tbHeight.Name = "doorHeight" + (i + 1);
                tbHeight.Text = numericUpDownHeight2.Text;
                arrHeightTextBoxDoor[i] = tbHeight;
                //add textbox to width array
                TextBox tbWidth = new TextBox();
                tbWidth.Name = "doorWidth" + (i + 1);
                arrWidthTextBoxDoor[i] = tbWidth;
                // add textbox to amount array
                TextBox tbAmount = new TextBox();
                tbAmount.Name = "doorAmount" + (i + 1);
                tbAmount.Text = "0";
                arrAmountTextBoxDoor[i] = tbAmount;
            }
            //add arrays to table layout panel
            int labelCount = 0;
            int heightCount = 0;
            int widthCount = 0;
            int amountCount = 0;
            foreach (Control c in arrLabel)
            {
                tableLayoutDoor.Controls.Add(c, 0, labelCount);
                labelCount++;
            }
            foreach (Control c in arrHeightTextBoxDoor)
            {
                tableLayoutDoor.Controls.Add(c, 1, heightCount);
                heightCount++;
            }
            foreach (Control c in arrWidthTextBoxDoor)
            {
                tableLayoutDoor.Controls.Add(c, 2, widthCount);
                widthCount++;
            }
            foreach (Control c in arrAmountTextBoxDoor)
            {
                tableLayoutDoor.Controls.Add(c, 3, amountCount);
                amountCount++;
            }
        }
        //when post enter button is clicked, create fields for the post
        private void buttonPostEnter_Click(object sender, EventArgs e)
        {
            int totalPieces = Convert.ToInt32(numericUpDownTotal3.Text);
            if (totalPieces > 10)
            {
                totalPieces = 10;
            }
            tableLayoutPost.Controls.Clear();
            //adds the label for each panel counting from 1
            Label[] arrLabel = new Label[totalPieces];
            TextBox[] arrHeightTextBoxPost = new TextBox[totalPieces];
            arrWidthTextBoxPost = new TextBox[totalPieces];
            arrAmountTextBoxPost = new TextBox[totalPieces];
            for (int i = 0; i < totalPieces; i++)
            {
                //add label to array
                Label label = new Label();
                label.Text = i + 1 + ".";
                arrLabel[i] = label;
                //add textbox to height textbox array
                TextBox tbHeight = new TextBox();
                tbHeight.Name = "postHeight" + (i + 1);
                tbHeight.Text = numericUpDownHeight3.Text;
                arrHeightTextBoxPost[i] = tbHeight;
                //add textbox to width array
                TextBox tbWidth = new TextBox();
                tbWidth.Name = "postWidth" + (i + 1);
                arrWidthTextBoxPost[i] = tbWidth;
                // add textbox to amount array
                TextBox tbAmount = new TextBox();
                tbAmount.Name = "postAmount" + (i + 1);
                tbAmount.Text = "0";
                arrAmountTextBoxPost[i] = tbAmount;
            }
            //add arrays to table layout panel
            int labelCount = 0;
            int heightCount = 0;
            int widthCount = 0;
            int amountCount = 0;
            foreach (Control c in arrLabel)
            {
                tableLayoutPost.Controls.Add(c, 0, labelCount);
                labelCount++;
            }
            foreach (Control c in arrHeightTextBoxPost)
            {
                tableLayoutPost.Controls.Add(c, 1, heightCount);
                heightCount++;
            }
            foreach (Control c in arrWidthTextBoxPost)
            {
                tableLayoutPost.Controls.Add(c, 2, widthCount);
                widthCount++;
            }
            foreach (Control c in arrAmountTextBoxPost)
            {
                tableLayoutPost.Controls.Add(c, 3, amountCount);
                amountCount++;
            }
        }
        //when urinal enter button is clicked, creates fields for each urinal
        private void buttonUrinalEnter_Click(object sender, EventArgs e)
        {
            int totalPieces = Convert.ToInt32(numericUpDownTotal4.Text);
            if (totalPieces > 6)
            {
                totalPieces = 6;
            }
            tableLayoutUrinal.Controls.Clear();
            //adds the label for each panel counting from 1
            Label[] arrLabel = new Label[totalPieces];
            TextBox[] arrHeightTextBoxUrinal = new TextBox[totalPieces];
            arrWidthTextBoxUrinal = new TextBox[totalPieces];
            arrAmountTextBoxUrinal = new TextBox[totalPieces];
            for (int i = 0; i < totalPieces; i++)
            {
                //add label to array
                Label label = new Label();
                label.Text = i + 1 + ".";
                arrLabel[i] = label;
                //add textbox to height textbox array
                TextBox tbHeight = new TextBox();
                tbHeight.Name = "urinalHeight" + (i + 1);
                tbHeight.Text = numericUpDownHeight4.Text;
                arrHeightTextBoxUrinal[i] = tbHeight;
                //add textbox to width array
                TextBox tbWidth = new TextBox();
                tbWidth.Name = "urinalWidth" + (i + 1);
                arrWidthTextBoxUrinal[i] = tbWidth;
                // add textbox to amount array
                TextBox tbAmount = new TextBox();
                tbAmount.Name = "urinalAmount" + (i + 1);
                tbAmount.Text = "0";
                arrAmountTextBoxUrinal[i] = tbAmount;
            }
            //add arrays to table layout panel
            int labelCount = 0;
            int heightCount = 0;
            int widthCount = 0;
            int amountCount = 0;
            foreach (Control c in arrLabel)
            {
                tableLayoutUrinal.Controls.Add(c, 0, labelCount);
                labelCount++;
            }
            foreach (Control c in arrHeightTextBoxUrinal)
            {
                tableLayoutUrinal.Controls.Add(c, 1, heightCount);
                heightCount++;
            }
            foreach (Control c in arrWidthTextBoxUrinal)
            {
                tableLayoutUrinal.Controls.Add(c, 2, widthCount);
                widthCount++;
            }
            foreach (Control c in arrAmountTextBoxUrinal)
            {
                tableLayoutUrinal.Controls.Add(c, 3, amountCount);
                amountCount++;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            double crateHeight = 0;
            double crateLength = 0;
            double crateWidth = 0;
            int doors = 0;
            int panels = 0;
            int post = 0;
            int urinals = 0;
            double doorHeight = 0;
            double panelHeight = 0;
            double postHeight = 0;
            double urinalHeight = 0;
            string doorType = "";
            bool zeroSight;
            string material = "";
            try
            {


                //get amount of each piece
                panels = Convert.ToInt32(numericUpDownTotal.Value);
                doors = Convert.ToInt32(numericUpDownTotal2.Value);
                post = Convert.ToInt32(numericUpDownTotal3.Value);
                urinals = Convert.ToInt32(numericUpDownTotal4.Value);

                //get material
                if (radioButtonLaminate.Checked)
                {
                    material = radioButtonLaminate.Text;
                }
                else if (radioButtonPhenolic.Checked)
                {
                    material = radioButtonPhenolic.Text;
                }
                else if (radioButtonVener.Checked)
                {
                    material = radioButtonVener.Text;
                }

                //get door type
                if (radioButtonStandard.Checked)
                {
                    doorType = radioButtonStandard.Text;
                }
                else if (radioButtonMolding.Checked)
                {
                    doorType = radioButtonMolding.Text;
                }
                else if (radioButtonLouver.Checked)
                {
                    doorType = radioButtonLouver.Text;
                }

                //get zerosight
                if (checkBoxZeroSight.Checked)
                {
                    zeroSight = true;
                }
                else
                {
                    zeroSight = false;
                }

                //get heights
                doorHeight = Convert.ToDouble(numericUpDownHeight2.Value);
                postHeight = Convert.ToDouble(numericUpDownHeight3.Value);
                panelHeight = Convert.ToDouble(numericUpDownHeight.Value);
                urinalHeight = Convert.ToDouble(numericUpDownHeight4.Value);

                //create job class
                Job job = new Job(doors, post, panels, urinals);
                job.setHeightPieces(doorHeight);
                job.setHeightPost(postHeight);
                job.setHeightUrinal(urinalHeight);
                job.setMaterial(material);
                job.setZeroSight(zeroSight);
                job.ChangeTypeDoor(doorType);

                //get width of panels
                if (arrAmountTextBoxPanel != null)
                {
                    int panelCountHolder = 0;
                    for (int i = 0; i < arrAmountTextBoxPanel.Count(); i++)
                    {
                        double amountHolder = Convert.ToDouble(arrAmountTextBoxPanel[i].Text);


                        if (amountHolder == 1)
                        {
                            job.setWidthPanel(panelCountHolder, Convert.ToDouble(arrWidthTextBoxPanel[i].Text));
                            Console.WriteLine("panel width: " + Convert.ToDouble(arrWidthTextBoxPanel[i].Text));
                            panelCountHolder++;
                        }
                        else if (amountHolder > 1)
                        {
                            for (int j = 0; j < amountHolder; j++)
                            {
                                job.setWidthPanel(panelCountHolder, Convert.ToDouble(arrWidthTextBoxPanel[i].Text));
                                Console.WriteLine("panel width: " + Convert.ToDouble(arrWidthTextBoxPanel[i].Text));
                                panelCountHolder++;
                            }
                        }
                    }
                }

                //get width for doors
                if (arrAmountTextBoxDoor != null)
                {
                    int doorCountHolder = 0;
                    for (int i = 0; i < arrAmountTextBoxDoor.Count(); i++)
                    {
                        double amountHolder = Convert.ToDouble(arrAmountTextBoxDoor[i].Text);


                        if (amountHolder == 1)
                        {
                            job.setWidthDoor(doorCountHolder, Convert.ToDouble(arrWidthTextBoxDoor[i].Text));
                            Console.WriteLine("Door width: " + Convert.ToDouble(arrWidthTextBoxDoor[i].Text));
                            doorCountHolder++;
                        }
                        else if (amountHolder > 1)
                        {
                            for (int j = 0; j < amountHolder; j++)
                            {
                                job.setWidthDoor(doorCountHolder, Convert.ToDouble(arrWidthTextBoxDoor[i].Text));
                                Console.WriteLine("Door width: " + Convert.ToDouble(arrWidthTextBoxDoor[i].Text));
                                doorCountHolder++;
                            }
                        }
                    }
                }

                //get width for post
                if (arrAmountTextBoxPost != null)
                {
                    int postCountHolder = 0;
                    for (int i = 0; i < arrAmountTextBoxPost.Count(); i++)
                    {
                        double amountHolder = Convert.ToDouble(arrAmountTextBoxPost[i].Text);


                        if (amountHolder == 1)
                        {
                            job.setWidthPost(postCountHolder, Convert.ToDouble(arrWidthTextBoxPost[i].Text));
                            Console.WriteLine("Post width: " + Convert.ToDouble(arrWidthTextBoxPost[i].Text));
                            postCountHolder++;
                        }
                        else if (amountHolder > 1)
                        {
                            for (int j = 0; j < amountHolder; j++)
                            {
                                job.setWidthPost(postCountHolder, Convert.ToDouble(arrWidthTextBoxPost[i].Text));
                                Console.WriteLine("Post width: " + Convert.ToDouble(arrWidthTextBoxPost[i].Text));
                                postCountHolder++;
                            }
                        }
                    }
                }

                //get width for urinal
                if (arrAmountTextBoxUrinal != null)
                {
                    int urinalCountHolder = 0;
                    for (int i = 0; i < arrAmountTextBoxUrinal.Count(); i++)
                    {
                        double amountHolder = Convert.ToDouble(arrAmountTextBoxUrinal[i].Text);


                        if (amountHolder == 1)
                        {
                            job.setWidthUrinal(urinalCountHolder, Convert.ToDouble(arrWidthTextBoxUrinal[i].Text));
                            Console.WriteLine("Urinal width: " + Convert.ToDouble(arrWidthTextBoxUrinal[i].Text));
                            urinalCountHolder++;
                        }
                        else if (amountHolder > 1)
                        {
                            for (int j = 0; j < amountHolder; j++)
                            {
                                job.setWidthUrinal(urinalCountHolder, Convert.ToDouble(arrWidthTextBoxUrinal[i].Text));
                                Console.WriteLine("Urinal width: " + Convert.ToDouble(arrWidthTextBoxUrinal[i].Text));
                                urinalCountHolder++;
                            }
                        }
                    }
                }
                //get crate Height
                crateHeight = job.CrateHeight();
                //get crate length
                crateLength = job.getHeightPost() + 6;
                //get crate width
                if (checkBoxZeroSight.Checked)
                {
                    crateWidth = 60;
                }
                else
                {
                    crateWidth = 59;
                }


                //make word document
                string file = "PO_" + textBox2.Text + ".docx";
                using (DocX document = DocX.Create(file))
                {
                    //variables
                    string jobName = textBox1.Text;
                    string poNumber = textBox2.Text;
                    string smallWall = (crateWidth + 0.125).ToString() + "\"  X  " + crateHeight.ToString() + "\" (2 each)";
                    string largeWall = crateLength.ToString() + "\"  X  " + crateHeight.ToString() + "\" (2 each)";
                    string lid = (crateWidth + 5.5).ToString() + "\"  X  " + Convert.ToInt16(crateLength / 2).ToString() + "\" (2 each)";
                    string pallet = (crateWidth + 6).ToString() + "\"  X  " + Convert.ToInt16(crateLength).ToString() + "\"";


                    //create template
                    Paragraph pHeader = document.InsertParagraph();

                    pHeader.AppendLine("Job Name: " + jobName).FontSize(20);
                    pHeader.AppendLine();
                    pHeader.AppendLine("PO #: " + poNumber).FontSize(20);

                    Paragraph pMainBody = document.InsertParagraph();

                    pMainBody.IndentationBefore = 4;
                    pMainBody.AppendLine();
                    pMainBody.AppendLine();
                    pMainBody.AppendLine("Pallet Size:    ").FontSize(18).Append(pallet).FontSize(18).Append(" (atleast)").FontSize(18);
                    pMainBody.AppendLine();
                    pMainBody.AppendLine();
                    pMainBody.AppendLine();
                    pMainBody.AppendLine("Walls:     ").FontSize(18);
                    pMainBody.Append(smallWall).FontSize(18);
                    pMainBody.AppendLine().FontSize(18);
                    pMainBody.AppendLine("               " + largeWall).FontSize(18);
                    pMainBody.AppendLine();
                    pMainBody.AppendLine();
                    pMainBody.AppendLine();
                    pMainBody.AppendLine("Lid Size:  ").FontSize(18).Append(lid).FontSize(18);

                    
                    document.Save();
                    labelSuccess.Visible = true;
                    labelSuccess.ForeColor = Color.Green;
                    labelSuccess.Text = "Process Successful!";
                    try
                    {
                        Process.Start("Winword.exe", file);

                    }
                    catch (Exception)
                    {
                        Process.Start("WordPad.EXE", file);
                    }


                }
            }
            catch (Exception)
            {

                labelSuccess.Visible = true;
                labelSuccess.Text = "Process Unsuccessful!";
                labelSuccess.ForeColor = Color.Red;
                MessageBox.Show("Please make sure everything was filled out correctly: \n -Material \n -door type \n -correct amount for each piece \n - valid numbers");
            }
            
        }



        private void radioButtonMolding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
