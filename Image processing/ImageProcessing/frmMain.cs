using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            PaintingtoolStrip.Visible = false;
        }
        //Allaith Ghadban
        //December 12,2016
        //ImageProcessing
        //This program modifies a picture by rotating it, inverting it or by many other processes. The user can upload any image into the program in order to modify it.The user can also save the picture after modification.
        //Enchancements:
        //Save button
        //Hover texts to provide instructions
        //Paint mode
        //Resize trackbar
        //An extra form to ask the user if they want to save their painting onto the image.
        //Reset to initial image button.
        //These are all the additional things I put into the program, I know you would only consider resizetrackbar and painting as an enchancement
        //however, I added more small enchancements just to make the program more user friendly, and so that it will be functional enough in order for me to user later on.
        //Requirements:
        //All requirements are done.
        //Variables for the pixels
        private Color[,] Original;
        private Color[,] New;
        private Color[,] SetInitial;
        private int ResizeTemp;
        private bool CommencePainting = false;
        private int X;
        //Microsoft visual studio will say that the enabled and paint variables are not in use, but they actually are.
        private bool Paint = false;
        private int Red;
        private int ResizePreviousValue;
        private  int Blue;
        private bool Efficiency = false;
        private int Green;
        private int Y;
        private bool Enabled = false;
        //This variable enables the user to use the eraser when they click the eraser button.
        private bool Eraser = false;
        private bool AskSave = false;
        Bitmap bmp;
        OpenFileDialog fileDialog = new OpenFileDialog();
        frmVerification FV = new frmVerification();
        private void uploadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgMain.Image = new Bitmap(fileDialog.FileName);
                    bmp = new Bitmap(fileDialog.FileName);
                    //Resizing the arrays.
                    Original = new Color[bmp.Width, bmp.Height];
                    New = new Color[bmp.Width, bmp.Height];
                    //Whenever a user uploads a new image, the contents of the setinitial array are deleted.
                    SetInitial = new Color[bmp.Width, bmp.Height];
                    for (int i = 0; i < Original.GetLength(0); i++)
                    {
                        for (int j = 0; j < Original.GetLength(1); j++)
                        {
                            //Saving the pixels on the array for modification.
                            //The original array is made so that the reset functionality could work.
                            Original[i,j] = bmp.GetPixel(i,j);
                            New[i, j] = bmp.GetPixel(i, j);
                        }
                    }
                    ResizeTrackBar.Value = 0;
                    //Once the image is uploaded the height and width are updated.
                    lblHeights.Text = New.GetLength(1).ToString();
                    lblWidths.Text = New.GetLength(0).ToString();
                    //In order for the user to use the filters, they have to upload an image. If a filter was activated without having a picture, then the application will crash. 
                    brightenToolStripMenuItem.Enabled = true;
                    invertToolStripMenuItem.Enabled = true;
                    resetToolStripMenuItem.Enabled = true;
                    grayScaleToolStripMenuItem.Enabled = true;
                    darkenToolStripMenuItem.Enabled = true;
                    mirrorHToolStripMenuItem.Enabled = true;
                    mirrorVToolStripMenuItem.Enabled = true;
                    rotateToolStripMenuItem.Enabled = true;
                    flipXToolStripMenuItem.Enabled = true;
                    flipYToolStripMenuItem.Enabled = true;
                    scale50ToolStripMenuItem.Enabled = true;
                    scale200ToolStripMenuItem.Enabled = true;
                    blurToolStripMenuItem.Enabled = true;
                    saveToolStripMenuItem.Enabled = true;
                    ResizeTrackBar.Enabled = true;
                    //The reason why this is false, is because whenever a user uploads a new image, the setinitial variable is reset, therefore if the restore image button remains enabled, the program will crash since there is no image to be restored.
                    RestoreTempImageToolStripMenuItem.Enabled = false;
                    AskSave = false;
                    ResizeTemp = 0;
                    Efficiency = false;
                    clockwiseToolStripMenuItem.Enabled = true;
                    SetTempToolStripMenuItem.Enabled = true;
                    counterclockwiseToolStripMenuItem.Enabled = true;
                  //The enable variable stops the user from activating paint mode, until an image is uploaded.
                    Enabled = true;
                }
                catch 
                {
                    //Just in case you tried to crash it.
                    MessageBox.Show("Please enter a proper image.");
                }
            }  
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //Exiting, cannot be more obvious.
          Environment.Exit(0);
        }
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //You might wonder why I reset these values, when they actually get reset on their own when frmVerification dialog gets opened.
            //I did this because, if the user presses the button X on frmVerification, instead of cancel, the variables do not reset, therefore the program begins to malfunction.
            FV.Cancel = true;
            FV.Certainty = false;
           //For the AskSave if statements, I will only explain it for gray, because it works in exactly the same way in other methods, except that the asksave works differently in the resizetrackbar.
            //The explanation of how the AskSave works in the ResizeTrackbar, is available in the resizetrackbar method.
            if (AskSave == true)
            {
                //AskSave is activated when any painting is done.
                FV.ShowDialog();
                //If the user presses cancel, then FV.Cancel is equal to true, therefore graying the pixels does not happen.
               if (FV.Cancel == false)
                {
                   //If the user pressed no or yes, then the process of coloring the pixels continues.
                    AskSave = false;
                }
            }
            if (AskSave == false)
            {
                //The efficiency variable is only declared to make the zoomtrackbar work faster.
                Efficiency = false;
                if (FV.Certainty == true&&FV.Cancel==false)
                {
                    //If the user decides to save their painting, the New variable is made to equal bmp, since the painted image is inside the bmp variable.
                    for (int i = 0; i < New.GetLength(0); i++)
                    {
                        for (int j = 0; j < New.GetLength(1); j++)
                        {
                            New[i, j] = bmp.GetPixel(i, j);
                        }
                    }
                }
                for (int i = 0; i < New.GetLength(0); i++)
                {
                    for (int j = 0; j < New.GetLength(1); j++)
                    {
                        int a = New[i, j].A;
                        int r = New[i, j].R;
                        int g = New[i, j].G;
                        int b = New[i, j].B;
                        //Since the average of the colors is grey, I take the average of r,g and b in order to turn the pixels to grey.
                        //Credit goes to Mr. Moniaga for his approach
                        int Average = (r + b + g) / 3;
                        bmp.SetPixel(i, j, Color.FromArgb(a, Average, Average, Average));
                        New[i, j] = bmp.GetPixel(i, j);
                    }
                }
                //Displaying the new picture.
                imgMain.Image = bmp;
            }
        }
        private void RestoreTempImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //What this button does is that it temporarly saves the image, and the user has the option between reseting the image to when it was uploaded
            //or to restore it to the point where they saved it.
            //Resizing the bmp and the New to the size of the temporary picture.
            New = new Color[SetInitial.GetLength(0), SetInitial.GetLength(1)];
            bmp = new Bitmap(SetInitial.GetLength(0), SetInitial.GetLength(1));
            AskSave = false;
            for (int i = 0; i < New.GetLength(0); i++)
            {
                for (int j = 0; j < New.GetLength(1); j++)
                {
                    New[i, j] = SetInitial[i, j];
                    bmp.SetPixel(i, j, New[i, j]);
                }
            }
           //Restoring all the values of the resizetrackbar to the point when the image was temporarly stored.
            ResizeTrackBar.Value = ResizePreviousValue;
            ResizeTemp = ResizePreviousValue;
            lblHeights.Text = New.GetLength(1).ToString();
            lblWidths.Text = New.GetLength(0).ToString();
            imgMain.Image = bmp;
        }
        private void SetTempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Setting the image as the reference. 
            //So that you do not try to crash my program, I greyed out the restore temporary picture button, and it is enabled when the user temporarly stores an image.
            //Please keep in mind, I still did the reset button in the requirements. The reset to initial image, is just a nice touch.
            RestoreTempImageToolStripMenuItem.Enabled = true;
            //I declared this value in order to store the exact location of the resizetrackbar once the image is saved.
            ResizePreviousValue = ResizeTrackBar.Value;
            SetInitial = new Color[New.GetLength(0), New.GetLength(1)];
            for (int i = 0; i < New.GetLength(0); i++)
            {
                for (int j = 0; j < New.GetLength(1); j++)
                {
                    SetInitial[i, j] = bmp.GetPixel(i, j);
                }
            }
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeTemp = 0;
            //Since the "New" variable was scaled to 200 or 50, I have to resize the array again to its original size.
            New = new Color[Original.GetLength(0), Original.GetLength(1)];
            bmp = new Bitmap(Original.GetLength(0), Original.GetLength(1));
            AskSave = false;
            for (int i = 0; i < New.GetLength(0); i++)
            {
                for (int j = 0; j < New.GetLength(1); j++)
                {
                    //I have the original uploaded image on the original variable, therefore I redeclare new (the change variable) and I change the bitmap in order to display the original image.
                    New[i, j] = Original[i, j];
                    //Nevertheless I resized bitmap, so it is technically empty, therefore I need to refill it using the Original variable. 
                    bmp.SetPixel(i,j,New[i,j]);
                }
            }
            //Displaying the reseted picture.
            Efficiency = false;
            lblHeights.Text = New.GetLength(1).ToString();
            lblWidths.Text = New.GetLength(0).ToString();
            ResizeTrackBar.Value = 0;
            imgMain.Image = bmp;
        }
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FV.Cancel = true;
            FV.Certainty = false;
              if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
              if (AskSave == false)
              {
                  Efficiency = false;
                  if (FV.Certainty == true&&FV.Cancel==false)
                  {
                      for (int i = 0; i < New.GetLength(0); i++)
                      {
                          for (int j = 0; j < New.GetLength(1); j++)
                          {
                              //Making the "New" variable equal to bmp.
                              New[i, j] = bmp.GetPixel(i, j);
                          }
                      }
                  }
                  for (int i = 0; i < New.GetLength(0); i++)
                  {
                      for (int j = 0; j < New.GetLength(1); j++)
                      {
                          //Getting the values of all the channels of the picture.
                          int a = New[i, j].A;
                          int r = New[i, j].R;
                          int g = New[i, j].G;
                          int b = New[i, j].B;
                          //Inverting the image by subtracting the a, r, g and b values from 255.
                          bmp.SetPixel(i, j, Color.FromArgb(a, 255 - r, 255 - g, 255 - b));
                          New[i, j] = bmp.GetPixel(i, j);
                      }
                  }
                  //Displaying the new picture.
                  imgMain.Image = bmp;
              }
        }
        private void brightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FV.Cancel = true;
            FV.Certainty = false;
            if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
        if (AskSave == false)
        {
            Efficiency = false;
            if (FV.Certainty == true&&FV.Cancel==false)
            {
                for (int i = 0; i < New.GetLength(0); i++)
                {
                    for (int j = 0; j < New.GetLength(1); j++)
                    {
                        New[i, j] = bmp.GetPixel(i, j);
                    }
                }
            }
            // https://www.codeproject.com/articles/33838/image-processing-using-c
            //Credit goes to codeproject for coding the algorithm.
            Efficiency = false;
            for (int i = 0; i < New.GetLength(0); i++)
            {
                for (int j = 0; j < New.GetLength(1); j++)
                {
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    //The higher the r, g or b value the greater the brightness, so I had a 120 to the value of r, g and b in order to increase the brightness
                    r = New[i, j].R + 120;
                    g = New[i, j].G + 120;
                    b = New[i, j].B + 120;
                    //Since I add 120, the r, g or b values might exceed 255, so I declared these if statements in order to change any value that exceeds 255 into 255.
                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (b > 255)
                    {
                        b = 255;
                    }
                    //Setting the pixels to their new brightness on bitmap.
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                    New[i, j] = bmp.GetPixel(i, j);
                }
            }
            //Displaying the new picture.
            imgMain.Image = bmp;
        }
        }
        private void scale50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FV.Cancel = true;
            FV.Certainty = false;
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true&&FV.Cancel==false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 int k = 0;
                 int l = 0;
                 int Height = New.GetLength(1);
                 int Width = New.GetLength(0);
                 try
                 {
                     //Everytime I have a picture with odd widths and heights, my program crashes, so what I did was that I added one to the numbers to make them even.
                     if (New.GetLength(0) % 2 != 0)
                     {
                         Width++;
                     }
                     if (New.GetLength(1) % 2 != 0)
                     {
                         Height++;
                     }
                     bmp = new Bitmap(Width / 2, Height / 2);
                     for (int i = 0; i < New.GetLength(0); i=i+2)
                     {
                         for (int j = 0; j < New.GetLength(1); j=j+2)
                         {
                             int a = New[i, j].A;
                             int r = New[i, j].R;
                             int g = New[i, j].G;
                             int b = New[i, j].B;
                             //Each two repetition counts as one repetition for l.
                             
                                 
                             
                             //Since bmp got resized, if it follows i and j, it would crash because it does not have the same length as the variable "New".
                             //I used k and l here so that out of 2 pixels only 1 pixel gets taken and saved into bitmap, therefore reducing the size of the picture by half. 
                             bmp.SetPixel(k, l, Color.FromArgb(a, r, g, b));
                             l++;
                        }
                         l = 0;
                         //Each two repetition counts as one repetition for k.
                        
                             k++;
                         
                     }
                     //Resizing the "New" variable
                     New = new Color[bmp.Width, bmp.Height];
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             //After bmp got resized, the minimized contents are moved to the "New" variable.
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                     lblHeights.Text = New.GetLength(1).ToString();
                     lblWidths.Text = New.GetLength(0).ToString();
                     imgMain.Image = bmp;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex);
                 }
             }
        }
        private void flipXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int l = 0;
            FV.Cancel = true;
            FV.Certainty = false;
          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true&&FV.Cancel==false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = New.GetLength(1) - 1; j > 0; j--)
                     {
                         //Since i resembles the width and j resembled the height, I inverted j, since inverting the height will result in a vertical reflection.
                         bmp.SetPixel(i, l, New[i, j]);
                         l++;
                     }
                     l = 0;
                 }
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 //Displaying the new picture.
                 imgMain.Image = bmp;
             }
          }
        private void flipYToolStripMenuItem_Click(object sender, EventArgs e)
         {
            FV.Cancel = true;
            FV.Certainty = false;          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 //I declared k so that bmp stores the new values normally by starting at 0,0 and proceeding normally.
                 int k = 0;
                 for (int i = New.GetLength(0) - 1; i > 0; i--)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         //Since i resembles the width and j resembled the height, I inverted i, since inverting the width will result in a horizontal reflection.
                         bmp.SetPixel(k, j, New[i, j]);
                     }
                     k++;
                 }
                 //Storing the pixels to the "New" variable.
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 //Displaying the new picture.
                 imgMain.Image = bmp;
             }  
        }
        private void mirrorVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 0;
            FV.Cancel = true;
            FV.Certainty = false;
          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = New.GetLength(1) - 1; j > 0; j--)
                     {
                        //What this algorithm does is that it takes all the pixels of the second or buttom horizontal half of the picture, flips it vertically, and then places it as the other half.
                         New[i, k] = New[i, j];
                         //Storing the pixels on the "New" variable to bitmap.
                         bmp.SetPixel(i, k, New[i, k]);
                         k++;
                     }
                     k = 0;
                 }
                 //Displaying the new picture.
                 imgMain.Image = bmp;
             }
        }
        private void mirrorHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 0;
            int l = 0;
              FV.Cancel = true;
            FV.Certainty = false;
          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 for (int i = New.GetLength(0) - 1; i > 0; i--)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         //What this algorithm does is that it takes all the pixels from the second vertical half of the picture, flips them horizontally and replaces them as the other half.
                         New[k, l] = New[i, j];
                         bmp.SetPixel(k, l, New[k, l]);
                         l++;
                     }
                     l = 0;
                     k++;
                 }
                 //Displaying the new picture.
                 imgMain.Image = bmp;
             }
        }
        private void scale200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //You might try to crash my scale 200, by repetitively increasing the size of the image.
            //The program will reach a certain point where it will freeze, and it looks like it crashed, however it did not.
            //If you wait a couple minutes, the try catch shows a messagebox with the error, and after that you can use the program normally.
            int k = 0;
            int l = 0;
             FV.Cancel = true;
             FV.Certainty = false;
             if (AskSave == true)
             {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
             }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true&&FV.Cancel==false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                {
                    for (int j = 0; j < New.GetLength(1); j++)
                    {
                        New[i, j] = bmp.GetPixel(i, j);
                    }
                }
                 }
            try
            {
                //Resizing the bitmap
                bmp = new Bitmap(New.GetLength(0) * 2, New.GetLength(1) * 2);
                for (int i = 0; i < New.GetLength(0) * 2; i++)
                {
                    for (int j = 0; j < New.GetLength(1) * 2; j++)
                    {
                        //In order for the image to be enlarged, each pixel is doubled, therefore the image would also be doubled.
                        int a = New[k, l].A;
                        int r = New[k, l].R;
                        int g = New[k, l].G;
                        int b = New[k, l].B;
                        //Each two repetition counts as one repetition for l.
                        if (j != 0 && j % 2 == 0)
                        {
                            l++;
                        }
                        bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    l = 0;
                    //Each two repetition counts as one repetition for k.
                    if (i != 0 && i % 2 == 0)
                    {
                        k++;
                    }
                }
                //Resizing the "New" color.
                New = new Color[bmp.Width, bmp.Height];
                for (int i = 0; i < New.GetLength(0); i++)
                {
                    for (int j = 0; j < New.GetLength(1); j++)
                    {
                        New[i, j] = bmp.GetPixel(i, j);
                    }
                }
                lblHeights.Text = New.GetLength(1).ToString();
                lblWidths.Text = New.GetLength(0).ToString();
                imgMain.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
          }   
        }
        private void darkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FV.Cancel = true;
            FV.Certainty = false;
          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         //This code was taken from codeproject for brightnening an image, and changed in order to darken an image.
                         int r = 0;
                         int g = 0;
                         int b = 0;
                         //The lower the r, g or b value the lower the brightness, therefore the darker it is. I substract 90 in order to darken the pixels.
                         r = New[i, j].R - 90;
                         g = New[i, j].G - 90;
                         b = New[i, j].B - 90;
                         //Since I substract 110, the r, g or b values might go below 0, so I declared these if statements in order to change any value that goes below zero into zero.
                         if (r < 0)
                         {
                             r = 0;
                         }
                         if (g < 0)
                         {
                             g = 0;
                         }
                         if (b < 0)
                         {
                             b = 0;
                         }
                         //Setting the pixels to their new brightness on bitmap.
                         bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 //Displaying the new picture.
                 imgMain.Image = bmp;
             }
        }
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FV.Cancel = true;
             FV.Certainty = false;
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 //Idea was taken from http://www.pixelstech.net/article/1353768112-Gaussian-Blur-Algorithm
                 //The website explains that in order to blur an image the average value of the pixels around the target pixel is taken.
                 //The reason I declared this variable and this while loop is because if this algorithm is run once, the blur is not very noticable, however if I run it 4 times, it blurs the image very well.
                 int Repeats = 0;
                 while (Repeats < 4)
                 {
                     for (int i = 1; i < New.GetLength(0) - 1; i++)
                     {
                         for (int j = 1; j < New.GetLength(1) - 1; j++)
                         {
                             //What this algorithm does is that, it averages 8 pixels. For example we have a pixel at [1,5], it takes the average of [0,5],[0,4],[0,6],[1,4],[1,6],[2,4],[2,5] and [2,6].
                             //The reason why it results in a blur is because we are technically combining the pixels together and thus reducing clarity of an image. 
                             int AverageA = (New[i - 1, j].A + New[i + 1, j].A + New[i, j - 1].A + New[i, j + 1].A + New[i - 1, j + 1].A + New[i + 1, j + 1].A + New[i - 1, j - 1].A + New[i + 1, j - 1].A) / 8;
                             int AverageR = (New[i - 1, j].R + New[i + 1, j].R + New[i, j - 1].R + New[i, j + 1].R + New[i - 1, j + 1].R + New[i + 1, j + 1].R + New[i - 1, j - 1].R + New[i + 1, j - 1].R) / 8;
                             int AverageG = (New[i - 1, j].G + New[i + 1, j].G + New[i, j - 1].G + New[i, j + 1].G + New[i - 1, j + 1].G + New[i + 1, j + 1].G + New[i - 1, j - 1].G + New[i + 1, j - 1].G) / 8;
                             int AverageB = (New[i - 1, j].B + New[i + 1, j].B + New[i, j - 1].B + New[i, j + 1].B + New[i - 1, j + 1].B + New[i + 1, j + 1].B + New[i - 1, j - 1].B + New[i + 1, j - 1].B) / 8;
                             bmp.SetPixel(i, j, Color.FromArgb(AverageA, AverageR, AverageG, AverageB));
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                     Repeats++;
                 }
                 imgMain.Image = bmp;
             }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Saving an image as a png
                SaveFileDialog SD = new SaveFileDialog();
               SD.Filter = "PNG(*.PNG)|*.png";
                if (SD.ShowDialog() == DialogResult.OK)
                {
                   imgMain.Image.Save(SD.FileName, ImageFormat.Jpeg);
                }
            }
            catch 
            {
                //Just in case anything goes wrong with the saving.
                MessageBox.Show("Error in saving the image.");
            }
        }
        private void Resize_Scroll(object sender, EventArgs e)
        {
             FV.Cancel = true;
            FV.Certainty = false;
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
               if (FV.Cancel==true)
               {
                   //If the user painted something onto the image, and they decided to press cancel or X on the dialog, the resizetrackbar will be restored to its previous position.
                   ResizeTrackBar.Value = ResizeTemp;
               }
            }
             if (AskSave == false)
             {
                //The reason why I declared an efficiency variable is because, when we usually use a resizetrackbar, it does the resizing quickly
                 //However, if it has perform a very long for loop everytime they resize a picture, the program gets slow, and that is what is happening in this case.
                 //The for loop is only activated when, the user wants to save their painting on the image.
                
                 if (FV.Certainty == false&&Efficiency==true)
                 {
                     //Unlike all other functions (example: rotate, invert, brighten and etc), FV.Certainty is equal to false
                     //that is because resizing using the resizetrackbar changes the bmp, which also contains the painting, so if the user decides that
                     //they do not want the painting, bmp is reset to New, and New does not have the painting on to it.
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             bmp.SetPixel(i, j, New[i, j]);
                         }
                     }
                 }
                 Efficiency = false;
                 //The resizetrackbar allows the user to enlarge or shrink a picture. Let us assume the user puts in a large picture, no problem, the user can easily shrink the picture which allows the user to see the picture more clearly.
                 //The Difference variable calculates the difference in between where the trackbar was, and where it was moved.
                 //The reason for this is because so that the program knows how far the trackbar was moved, whether one step or two steps.
                 int Difference = Math.Abs(ResizeTrackBar.Value - ResizeTemp);
                 try
                 {
                     //ResizeTemp is the previous value of ResizeTrackBar, I declared it in order to know where the user moved the trackbar, whether to the left or to the right.
                     //If the Resizetrackbar is larger than Resizetemp than means that the trackbar has been moved to the right, since as you move it to the right, the resizetrackbar.value increases according to the tick frequency.
                     //The program can see if resizetrackbar.Value increased by comparing it to its previous value stored in resizetemp
                     //Each step increases or decreases the size of the image by 2 to the power of the disance moved by the scroller.
                     if (ResizeTemp < ResizeTrackBar.Value)
                     {
                         //Shrinking
                         bmp = new Bitmap(imgMain.Image, bmp.Width / (int)(Math.Pow(2, Difference)), bmp.Height / (int)(Math.Pow(2, Difference)));
                     }
                     //If the resizetrackbar.value is smaller than resizetemp  it means that it has been moved to the left, since as you move it to the left, the resizetrackbar.value decreases according to the tick frequency.
                     //The program can see if resizetrackbar.Value decreased by comparing it to its previous value stored in resizetemp
                     if (ResizeTemp > ResizeTrackBar.Value)
                     {
                         //Enlarging
                         bmp = new Bitmap(imgMain.Image, bmp.Width * (int)(Math.Pow(2, Difference)), bmp.Height * (int)(Math.Pow(2, Difference)));
                     }
                 }
                 catch
                 {
                 }
                 //Resizing the array.
                 New = new Color[bmp.Width, bmp.Height];
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         //Refilling the "New" variable, since all the content was deleted, because it was resized. 
                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 ResizeTemp = ResizeTrackBar.Value;
                 lblHeights.Text = bmp.Height.ToString();
                 lblWidths.Text = bmp.Width.ToString();
                 imgMain.Image = bmp;
             }
        }
        private void AboutToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image processing assignment. Put any image in order to modify it.");
        }
        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 0;
            int l = 0;
             FV.Cancel = true;
            FV.Certainty = false;
          
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 //When rotating an image, the width becomes the height, and the height becomes the width, therefore in order to adapt to that I must resize bitmap.
                 bmp = new Bitmap(New.GetLength(1), New.GetLength(0));
                 //In order to get a clockwise rotate, I need to invert the i for loop.
                 for (int i = New.GetLength(1) - 1; i > 0; i--)
                 {
                     //The New.GetLength(1) and New.GetLength(0) were flipped since the height becomes the width and width becomes the height.
                     for (int j = 0; j < New.GetLength(0); j++)
                     {
                         //I switched i and j in New in order for the image to be rotated. 
                         //The way this for loop processes the image is by starting with the end of the first row, and proceeds by going down vertically. 
                         //When it is done with the first vertical group, it goes back to the first row and processes the vertical group before the one that was previous processed.
                         //In other words, the program processes the columns starting from right to left. 
                         bmp.SetPixel(k, l, New[j, i]);
                         l++;
                     }
                     l = 0;
                     k++;
                 }
                 New = new Color[bmp.Width, bmp.Height];
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {
                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 //Displaying the new picture.
                 lblHeights.Text = New.GetLength(1).ToString();
                 lblWidths.Text = New.GetLength(0).ToString();
                 imgMain.Image = bmp;
             }
        }
        private void counterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = 0;
             FV.Cancel = true;
            FV.Certainty = false;
             if (AskSave == true)
            {
                FV.ShowDialog();
               if (FV.Cancel == false)
                {
                    AskSave = false;
                }
            }
             if (AskSave == false)
             {
                 Efficiency = false;
                 if (FV.Certainty == true && FV.Cancel == false)
                 {
                     for (int i = 0; i < New.GetLength(0); i++)
                     {
                         for (int j = 0; j < New.GetLength(1); j++)
                         {
                             New[i, j] = bmp.GetPixel(i, j);
                         }
                     }
                 }
                 //When rotating an image, the width becomes the height, and the height becomes the width, therefore in order to adapt to that I must change my variables which includes bitmap and "New" variable.
                 bmp = new Bitmap(New.GetLength(1), New.GetLength(0));
                 for (int i = 0; i < New.GetLength(1); i++)
                 {
                     //The j look was inverted in order to result in a counter clock wise rotation.
                     for (int j = New.GetLength(0) - 1; j > 0; j--)
                     {
                         //The New.GetLength(1) and New.GetLength(0) were flipped since the height becomes the width and width becomes the height, and also because I did not resize the "New" variable.
                         //Unlike the clockwise rotation, this program proceeds differently,it starts at the beginning of the last row, and moves vertically upwards.
                         //This way of processing results in a counter clock wise rotation.
                         bmp.SetPixel(i, k, New[j, i]);
                         k++;
                     }
                     k = 0;
                 }
                 //Resizing the "New" variable.
                 New = new Color[bmp.Width, bmp.Height];
                 for (int i = 0; i < New.GetLength(0); i++)
                 {
                     for (int j = 0; j < New.GetLength(1); j++)
                     {

                         New[i, j] = bmp.GetPixel(i, j);
                     }
                 }
                 //Displaying the new picture.
                 lblHeights.Text = New.GetLength(1).ToString();
                 lblWidths.Text = New.GetLength(0).ToString();
                 imgMain.Image = bmp;
             }
        }
        private void imgMain_Click(object sender, EventArgs e)
        {
            //The CommencePainting variable is used to enable painting on the image, once an image has been uploaded and the paint mode button was clicked.
            if (CommencePainting == true)
            {
                //The Point and MousEventArgs code were taken from http://stackoverflow.com/questions/7055211/how-to-get-the-position-of-a-click
                MouseEventArgs Mouse = (MouseEventArgs)e;
                //Coordinates of the pixel the user touched.
                Point Coordinates = Mouse.Location;
                //Saving the coordinates of where the user clicked, in order to paint.
                X = Coordinates.X;
                Y = Coordinates.Y;
                //This block of code erases.
                if (Paint == true&&Eraser==true)
                {
                    //The reason why I declared a try catch for each bmp.SetPixel is because whenever the user is painting on the sides of the picture, the multiple try catches color the pixels in bound.
                    //However if I put all of them into one try catch, the program would not paint the pixels that are in bound only because one pixel was out of bound.
                    //I set bmp to New, because when the user paints, the changes are only saved to bmp, and not to the New variable, therefore I can easily undo it.
                    //However, if the user paints and activates a function like rotate or blur, the painting would be saved on to bmp and the New variable, therefore the user can no longer undo the paint.
                    try
                    {
                        bmp.SetPixel(X, Y, New[X,Y]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, New[X+1, Y-1]);
                    }
                    catch { }
                    try
                    {

                        bmp.SetPixel(X, Y - 1, New[X, Y-1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 1, New[X-1, Y+1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y, New[X-1, Y]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y, New[X+1, Y]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 1, New[X-1, Y+1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X, Y + 1, New[X, Y+1]);
                    }
                    catch { }
                 
                    try
                    {
                        bmp.SetPixel(X + 1, Y + 1, New[X+1,Y+1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y + 2, New[X+1, Y+2]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X, Y + 2, New[X, Y+2]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 2, New[X-1, Y+2]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y - 1, New[X-2, Y-1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 1, New[X-2, Y+1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 2, New[X-2, Y+2]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, New[X+1, Y-1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y - 1, New[X-2, Y-1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y, New[X-2, Y]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 1, New[X-2, Y+1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, New[X+1, Y-1]);
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y - 1, New[X-1, Y-1]);
                    }
                    catch { }
                    imgMain.Image = bmp;
                
                
                }
                if (Paint == true&&Eraser==false)
                {
                    //The AskSave variable is activated whenever the user draws anything onto the picture.
                    //What it does is that it asks the user if they want to save their painting onto the image, when they wish to rotate, invert or whatever.
                    AskSave = true;
                    Efficiency = true;
                   //This algorithm is responsible for coloring the pixels.
                    //After the coordinates of the pixel are obtained, the surrounding pixels are colored, by the color the user chooses.
                    try
                    {
                        bmp.SetPixel(X, Y, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {

                        bmp.SetPixel(X, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y + 2, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X, Y + 2, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y + 2, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 2, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 2, Y + 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X + 1, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    try
                    {
                        bmp.SetPixel(X - 1, Y - 1, Color.FromArgb(Red, Green, Blue));
                    }
                    catch { }
                    imgMain.Image = bmp;
                }
            }
        }
        private void imgMainUp_Click(object sender, MouseEventArgs e)
        {
            //Whenever the user is no longer holding onto the mouse, paint is equal to false, thus the brush stops coloring.
            Paint = false;
        }
        private void imgMainDown_Click(object sender, MouseEventArgs e)
        {
            //Whenever the user clicks and holds onto the  mouse, paint is equal to true, thus the brush begins coloring.
            Paint = true;
        }
        private void PaintStripButton2_Click(object sender, EventArgs e)
        {
            //Since the user might open the paint mode and starting painting, I stopped that from happening before a picture is put in.
            if (Enabled == true)
            {
                CommencePainting = true;
                PaintingtoolStrip.Visible = true;
            }
            if (Enabled == false)
            {
                MessageBox.Show("You must put a picture in first.");
            }
        }
        //All the buttons below work the same way, thus I will use magenta as an example to show how they work.
        private void MagentaStripButton_Click(object sender, EventArgs e)
        {
            //When the magenta button is pressed the highlight (Checked) turns on for the magenta button (MagentaStripButton.Checked=true) and all other highlights are removed.
            Eraser = false;
            //When pressing on magenta it sets the color of the r,g and b channels to give magenta.
            Red = 255;
            Green = 51;
            Blue = 153;
            MagentaStripButton.Checked = true;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = false;
        }
        private void GreenStripButton_Click(object sender, EventArgs e)
        {
           Eraser = false;
            Red = 0;
            Green = 255;
            Blue = 0;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = true;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = false;
        }
        private void RedStripButton_Click(object sender, EventArgs e)
        {
           Eraser = false;
            Red = 255;
            Green = 0;
            Blue = 0;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = true;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = false;
        }
        private void BlueStripButton_Click(object sender, EventArgs e)
        {
            Eraser = false;
            Red = 0;
            Green = 0;
            Blue = 255;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = true;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = false;
        }

        private void BlackStripButton_Click(object sender, EventArgs e)
        {
            Eraser = false;
            Red = 0 ;
            Green = 0;
            Blue = 0;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = true;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = false;
        }
        private void WhiteStripButton_Click(object sender, EventArgs e)
        {
            Eraser = false;
            Red = 255;
            Green = 255;
            Blue = 255;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = true;
            EraserStripButton.Checked = false;
        }
        private void EraserStripButton_Click(object sender, EventArgs e)
        {
            Eraser = true;
            MagentaStripButton.Checked = false;
            GreenStripButton.Checked = false;
            BlackStripButton.Checked = false;
            RedStripButton.Checked = false;
            BlueStripButton.Checked = false;
            WhiteStripButton.Checked = false;
            EraserStripButton.Checked = true;
        }
     }
}
