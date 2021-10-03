using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp_ImagesViewer
{
    public partial class Form1 : Form
    {
        //Properites I neeed
        Panel[] MyMainPanels = new Panel[3];
        Panel[] ModelsPanels = new Panel[3];
        public Form1()
        {
            InitializeComponent();
            InitialMainPanel();
            HideMainPanels();
            PutHomePanelAtFirst();
            InitializeOpenFileDialog();
            InitialModelsPanel();
            HideModelsPanels();
        }

        //initial Main Panels in MyMainPanels Array
        private void InitialMainPanel()
        {
            try
            {
                MyMainPanels[0] = HomePanel;
                MyMainPanels[1] = ModelsPanel;
                MyMainPanels[2] = AboutPanel;
            }
            catch (Exception ex)
            {
                //There a problem in Main panels. -> check thiem.
                MessageBox.Show("There is a problem , some one make a change in code.");
            }
        }

        //initial Models Panels in MyMainPanels Array
        private void InitialModelsPanel()
        {
            try
            {
                ModelsPanels[0] = SingleModelPanel;
                ModelsPanels[1] = MultiPicturesModelPanel;
                ModelsPanels[2] = SlideShowPanel;
            }
            catch (Exception ex)
            {
                //There a problem in Models panels. -> check thiem.
                MessageBox.Show("There is a problem , some one make a change in code.");
            }
        }

        //hide Main Panels
        private void HideMainPanels()
        {
            try
            {
                foreach (Panel p in MyMainPanels)
                {
                    p.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //Than mean there is a problem in Main Panels check thiem.
                MessageBox.Show("There is a problem.");
            }
        }

        //hide Models Panels
        private void HideModelsPanels()
        {
            try
            {
                foreach (Panel p in ModelsPanels)
                {
                    p.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //Than mean there is a problem in Models Panels check thiem.
                MessageBox.Show("There is a problem.");
            }
        }

        //open Home Panel.
        private void HomeButton_Click(object sender, EventArgs e)
        {
            try
            {
                HideMainPanels();
                EnableModels();
                HomePanel.Dock = DockStyle.Fill;
                HomePanel.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show("There is a problem");
            }
        }

        //prepare app by put home at first
        private void PutHomePanelAtFirst()
        {
            try
            {
                HomePanel.Dock = DockStyle.Fill;
                HomePanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        //open About Panel
        private void AboutButton_Click(object sender, EventArgs e)
        {
            try
            {
                HideMainPanels();
                EnableModels();
                AboutPanel.Dock = DockStyle.Fill;
                AboutPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }
        }

        //open Models Panel
        private void OpenModelsPanel()
        {
            try
            {
                HideMainPanels();
                ModelsPanel.Dock = DockStyle.Fill;
                ModelsPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        //Open Picture(s)
        private void OpenPictures_Service_Label_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = OpenPictures.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (OpenPictures.FileNames.Count() > 0)
                    {
                        OpenModelsPanel();
                        foreach (string imagePath in OpenPictures.FileNames)
                        {
                            ImagesListBox.Items.Add(imagePath);
                        }
                        ImagesListBox.SelectedIndex = 0;
                    }
                    singlePictureModelToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Don't Choose any thing");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }
        }

        private void InitializeOpenFileDialog()
        {
            try
            {
                // Set the file dialog to filter for graphics files.
                this.OpenPictures.Filter =
                    "Images (*.BMP;*.JPG;*.JPEG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.GIF;";

                this.OpenPictures.Multiselect = true;

                this.OpenPictures.Title = "Open Single or multiple Picture";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        //event SelectedIndexChanged in List Box.
        private void ImagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (SingleModelPanel.Visible == true)
                {
                    SingleModelPicture.Image = Image.FromFile(ImagesListBox.SelectedItem.ToString());
                }else if(SlideShowPanel.Visible == true)
                {
                    SlideShowPicture.Image = Image.FromFile(ImagesListBox.SelectedItem.ToString());
                    toolStripStatusLabel1.Text = ImagesListBox.SelectedItem.ToString();
                }else{
                    ShowPictures_inMultiPictureModelButton_Click(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("you made an error....");
            }
}

        //show privous picture.
        private void PrivousButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ImagesListBox.Items.Count >= 1)
                {
                    if (ImagesListBox.SelectedIndex == 0)
                        ImagesListBox.SelectedIndex = ImagesListBox.Items.Count - 1;
                    else
                        ImagesListBox.SelectedIndex--;
                }
                else
                {
                    MessageBox.Show("There is no pictures selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you made an error...");
            }
        }

        //show Next picture.
        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ImagesListBox.Items.Count >= 1)
                {
                    if (ImagesListBox.SelectedIndex == ImagesListBox.Items.Count - 1)
                        ImagesListBox.SelectedIndex = 0;
                    else
                        ImagesListBox.SelectedIndex++;

                    if (SlideShowPanel.Visible == true)
                        toolStripStatusLabel1.Text = ImagesListBox.SelectedItem.ToString();
                    //StatusBarLabel.Text = ImagesListBox.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("There is no pictures selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you made an error...");
            }
        }

        //Rotate Picture
        private void RotateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(ImagesListBox.Items.Count >= 1)
                {
                    SingleModelPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    SingleModelPicture.Refresh();
                }
                else
                {
                    MessageBox.Show("There is no Pictures selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you made an error.");
            }
            
        }

        //Remove Image From List.
        private void RemovePictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImagesListBox.Items.Count >= 1)
                {
                    int index = ImagesListBox.SelectedIndex;
                    if (ImagesListBox.Items.Count == 1)
                    {
                        SingleModelPicture.Image = SingleModelPicture.InitialImage;
                        ImagesListBox.Items.Clear();
                    }else
                    {
                        if(ImagesListBox.SelectedIndex == 0)
                        {
                            ImagesListBox.SelectedIndex++;
                            ImagesListBox.Items.RemoveAt(index);
                        }else
                        {
                            ImagesListBox.SelectedIndex--;
                            ImagesListBox.Items.RemoveAt(index);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("There is no Pictures selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("you made an error.");
            }
        }

        //Open Single Picture Model
        private void singlePictureModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenModelsPanel();
                HideModelsPanels();
                DisaplyModels();
                AppOptions.Items[1].Enabled = true;//Slide Show
                SingleModelPanel.Dock = DockStyle.Fill;
                SingleModelPanel.Visible = true;
                ImagesListBox.SelectionMode = SelectionMode.One;
                if (ImagesListBox.Items.Count >= 1)
                {
                    if (ImagesListBox.SelectedIndex == -1)
                        ImagesListBox.SelectedIndex = 0;
                    SingleModelPicture.Image = Image.FromFile(ImagesListBox.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }

        }

        //Open Multi-Pictures Model
        private void multiPictureModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenModelsPanel();
                HideModelsPanels();
                DisaplyModels();
                AppOptions.Items[2].Enabled = true;//Multi-pictures
                MultiPicturesModelPanel.Dock = DockStyle.Fill;
                MultiPicturesModelPanel.Visible = true;
                ImagesListBox.SelectionMode = SelectionMode.MultiSimple;
                ShowPictures_inMultiPictureModelButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }
        }

        //Show Multiple (Selected)Pictures.
        private void ShowPictures_inMultiPictureModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                MultiPicturesModelPanel.Controls.Clear();
                MultiPicturesModelPanel.Controls.Add(MultiPictureLabel);
                int X = 10, Y = 70;
                foreach (string item in ImagesListBox.SelectedItems)
                {
                    PictureBox newImage = new PictureBox();
                    newImage.Size = new Size(200, 200);
                    newImage.Location = new Point(X, Y);
                    X += 210;
                    newImage.Image = Image.FromFile(item);
                    newImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    MultiPicturesModelPanel.Controls.Add(newImage);
                    if (210 > (MultiPicturesModelPanel.Width - X))
                    {
                        X = 10;
                        Y += 240;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        private void OpenPictures_s_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = OpenPictures.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (OpenPictures.FileNames.Count() > 0)
                    {
                        OpenModelsPanel();
                        foreach (string imagePath in OpenPictures.FileNames)
                        {
                            ImagesListBox.Items.Add(imagePath);
                        }
                        if (ImagesListBox.SelectedIndex == -1)
                            ImagesListBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Don't Choose any thing");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an Error.");
            }
        }

        //open Slide Show Panel
        private void slideShowModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenModelsPanel();
                HideModelsPanels();
                DisaplyModels();
                AppOptions.Items[3].Enabled = true;//Slide Show
                SlideShowPanel.Dock = DockStyle.Fill;
                SlideShowPanel.Visible = true;
                ImagesListBox.SelectionMode = SelectionMode.One;
                if (SlideShowControlButton.Text == "Pause")
                {
                    SlideShowControlButton.Text = "Play";
                }
                if (ImagesListBox.Items.Count >= 1)
                {
                    timer1.Start();
                }
                else
                {
                    SlideShowControlButton.Text = "Play";
                    MessageBox.Show("There is no Pictures.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                NextButton_Click(sender, e);

                if (ImagesListBox.SelectedIndex == ImagesListBox.Items.Count - 1)
                {
                    SlideShowControlButton.Text = "Play";
                    timer1.Stop();
                    NextButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }

        }

        private void SlideShowControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImagesListBox.Items.Count >= 1)
                {
                    if (SlideShowControlButton.Text == "Pause")
                    {
                        SlideShowControlButton.Text = "Play";
                        timer1.Stop();
                    }
                    else
                    {
                        SlideShowControlButton.Text = "Pause";
                        timer1.Start();
                    }
                }
                else
                {
                    MessageBox.Show("There is no Pictures.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }
        }

        //Close App.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        //Disapply anther models options.
        private void DisaplyModels()
        {
            try
            {
                AppOptions.Items[1].Enabled = false;
                AppOptions.Items[2].Enabled = false;
                AppOptions.Items[3].Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }

        }

        private void EnableModels()
        {
            try
            {
                AppOptions.Items[1].Enabled = true;
                AppOptions.Items[2].Enabled = true;
                AppOptions.Items[3].Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error.");
            }

        }

    }
}

