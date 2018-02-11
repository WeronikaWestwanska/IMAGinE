using Fundus_v3.Properties;
using FundusOperations.ColorsConversion;
using FundusOperations.EdgeDetection;
using FundusOperations.VesselsDetection;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using FundusOperations.NoiseFiltering;

namespace Fundus_v3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //double contrast = Convert.ToDouble(contrastTextBox.Text);
            this.storeAsColorCheckBox.Checked = Properties.Settings.Default.StoreAsColorWherePossible;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningFile = new OpenFileDialog();
            OpeningFile.Filter = "(*.png,*.bmp,*.jpg,*.ppm)|*.png;*.bmp;*.jpg;*.ppm";

            if (OpeningFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var image = System.Drawing.Image.FromFile(OpeningFile.FileName);
                rgbInputImgBox.Image = image;
                ohtaInputImgBox.Image = image;
                labInputImgBox.Image = image;
                hsvInputImgBox.Image = image;
                gaborInputImgBox.Image = image;
                sobelInputImgBox.Image = image;
                otherFiltersInputImgBox.Image = image;
                mfrFilteringInputImgBox.Image = image;
                contrastInputImgBox.Image = image;
                experimentImgBox.Image = image;

                inputTextBox.Text = OpeningFile.FileName;
            }
        }

        #region SaveButtons

        private void rgbSaveButton_Click(object sender, EventArgs e)
        {
            Save(rgbOutputImgBox, outputImgTextBox);
        }

        private void ohtSaveButton_Click(object sender, EventArgs e)
        {
            Save(ohtaOutputImgBox, ohtaOutputImgTextBox);
        }

        private void labSaveButton_Click(object sender, EventArgs e)
        {
            Save(labOutputImgBox, labOutputImgTextBox);
        }

        private void hsvSaveButton_Click(object sender, EventArgs e)
        {
            Save(hsvOutputImgBox, hsvOutputImgTextBox);
        }

        private void gaborSaveButton_Click(object sender, EventArgs e)
        {
            Save(gaborOutputImgBox, gaborOutputImgTextBox);
        }

        private void sobelSaveButton_Click(object sender, EventArgs e)
        {
            Save(sobelOutputImgBox, sobelOutputImgTextBox);
        }

        private void otherFiltersSaveButton_Click(object sender, EventArgs e)
        {
            Save(otherFiltersOutputImgBox, otherFiltersOutputImgTextBox);
        }
        private void contrastSaveButton_Click(object sender, EventArgs e)
        {
            Save(contrastOutputImgBox, contrastOutputImgTextBox);
        }
        private void mfrFilteringSaveButton_Click(object sender, EventArgs e)
        {
            Save(mfrFilteringOutputImgBox, mfrFilteringOutputImgTextBox);
        }
        private void experimentSaveButton_Click(object sender, EventArgs e)
        {
            Save(experimentOutputImgBox, experimentOutputImgTextBox);
        }

        private void Save(PictureBox pictureBox, TextBox textBox)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog SavingFile = new SaveFileDialog();
                SavingFile.Filter = "(*.png,*.bmp,*.jpg)|*.png;*. bmp;*.jpg";
                if (SavingFile.ShowDialog() == DialogResult.OK)
                {
                    if (inputTextBox.Text != SavingFile.FileName)
                    {
                        pictureBox.Image.Save(SavingFile.FileName);
                        textBox.Text = SavingFile.FileName;
                    }
                    else
                    {
                        MessageBox.Show("You cannot overwrite the input file. Choose another filename.");

                    }

                }
            }
        }
  
        #endregion SaveButtons

        #region combobox definitions
        private void rgbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgbInputImgBox.Image != null)
            {
                if(rgbComboBox.SelectedItem.Equals("R channel"))
                {
                    rgbOutputImgBox.Image = new ColorChannels().SaveRedChannel(rgbInputImgBox.Image);
                }
                else if (rgbComboBox.SelectedItem.Equals("B channel"))
                {
                    rgbOutputImgBox.Image = new ColorChannels().SaveBlueChannel(rgbInputImgBox.Image);
                }
                else if (rgbComboBox.SelectedItem.Equals("G channel"))
                {
                    rgbOutputImgBox.Image = new ColorChannels().SaveGreenChannel(rgbInputImgBox.Image);
                }

            }
        }

        private void ohtaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ohtaInputImgBox.Image != null)
            {
                
                if (ohtaComboBox.SelectedItem.Equals("Ohta1 channel"))
                {
                    ohtaOutputImgBox.Image = new ColorChannels().SaveOhta1Channel(ohtaInputImgBox.Image);
                }
                else if (ohtaComboBox.SelectedItem.Equals("Ohta2 channel"))
                {
                    ohtaOutputImgBox.Image = new ColorChannels().SaveOhta2Channel(ohtaInputImgBox.Image);
                }
                else if (ohtaComboBox.SelectedItem.Equals("Ohta3 channel"))
                {
                    ohtaOutputImgBox.Image = new ColorChannels().SaveOhta3Channel(ohtaInputImgBox.Image);
                }
            }
            else
            {
                ohtaComboBox.SelectedItem = null;
            }
        }

        private void hsvComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hsvInputImgBox.Image != null)
            {
                if (hsvComboBox.SelectedItem.Equals("S channel"))
                {
                    var imageOperations = new ColorChannels();
                    hsvOutputImgBox.Image = imageOperations.SaveSChannel(hsvInputImgBox.Image);
                }
                else if (hsvComboBox.SelectedItem.Equals("V channel"))
                {
                    hsvOutputImgBox.Image = new ColorChannels().SaveVChannel(hsvInputImgBox.Image);
                }
            }
        }

        private void labComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labInputImgBox.Image != null)
            {
                if (labComboBox.SelectedItem.Equals("L channel"))
                {
                    labOutputImgBox.Image = new ColorChannels().SaveLChannel(labInputImgBox.Image);

                }
                else if(labComboBox.SelectedItem.Equals("a channel"))
                {
                    labOutputImgBox.Image = new ColorChannels().SaveAChannel(labInputImgBox.Image);

                }
                else if (labComboBox.SelectedItem.Equals("b channel"))
                {
                    labOutputImgBox.Image = new ColorChannels().SaveBChannel(labInputImgBox.Image);

                }
            }
        }
        #endregion combobox definitions

        #region Gabor

        private void gaborButton_Click(object sender, EventArgs e)
        {
           
            if (gaborInputImgBox.Image != null)
            {
                var GaborFilterBank = new GaborFilterBank(new Bitmap(gaborInputImgBox.Image),
                    Settings.Default.StoreAsColorWherePossible);
                gaborOutputImgBox.Image = GaborFilterBank.Filter(sizeTextBox.Text, lambdaTextBox.Text,
                  numberOfFiltersTextBox.Text, psiTextBox.Text, sigmaTextBox.Text, gammaTextBox.Text);
            }
        }

        #endregion

        #region Sobel

        private void sobelButton_Click(object sender, EventArgs e)
        {
            if (sobelInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(sobelInputImgBox.Image);
                var sobelFilterClient = new SobelFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                sobelOutputImgBox.Image = sobelFilterClient.Filter();
            }
        }
        #endregion

        #region Horizontal Mask

        private void horizontalMaskButton_Click(object sender, EventArgs e)
        {
            if (sobelInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(sobelInputImgBox.Image);
                var sobelHorizontalMaskClient = new SobelHorizontalMask(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                sobelOutputImgBox.Image = sobelHorizontalMaskClient.Filter();
            }
        }
        #endregion Horizonal Mask

        #region Vertical Mask

        private void verticalMaskButton_Click(object sender, EventArgs e)
        {
            if (sobelInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(sobelInputImgBox.Image);
                var sobelVerticalMaskClient = new SobelVerticalMask(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                sobelOutputImgBox.Image = sobelVerticalMaskClient.Filter();
            }
        }

        #endregion Vertical Mask

        #region LightnessEqualisation Filter

        private void lightnessEqualisationButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var filterSize = Int32.Parse(othersFilterSizeBox.Text);
                var MedianLightnessEqualisationFilterMaskClient = new MedianLightnessEqualisationFilter(inputBitmap,
                    Properties.Settings.Default.StoreAsColorWherePossible,filterSize);
                otherFiltersOutputImgBox.Image = MedianLightnessEqualisationFilterMaskClient.Filter();
            }
        }

        #endregion LightnessEqualisation Filter

        #region Other Filters

        private void laplacianFilterButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var laplacianFilterMaskClient = new LaplacianFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                otherFiltersOutputImgBox.Image = laplacianFilterMaskClient.Filter();
            }
        }

        private void highPassFilterButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var highPassFilterMaskClient = new HighPassFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                otherFiltersOutputImgBox.Image = highPassFilterMaskClient.Filter();
            }
        }

        private void gausianFilterButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var GausianFilterMaskClient = new GausianFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                otherFiltersOutputImgBox.Image = GausianFilterMaskClient.Filter();
            }
        }

        private void lowPassFilterButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var LowPassFilterMaskClient = new LowPassFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                otherFiltersOutputImgBox.Image = LowPassFilterMaskClient.Filter();
            }
        }
        private void meanButton_Click(object sender, EventArgs e)
        {
            if (otherFiltersInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
                var meanFilterMaskClient = new MeanFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible);
                otherFiltersOutputImgBox.Image = meanFilterMaskClient.Filter();
            }
        }
        private void medianButton_Click(object sender, EventArgs e)
        {
            var inputBitmap = new Bitmap(otherFiltersInputImgBox.Image);
            var medianFilterMaskClient = new MedianFilter(inputBitmap,
                Settings.Default.StoreAsColorWherePossible);
            otherFiltersOutputImgBox.Image = medianFilterMaskClient.Filter();
        }


        #endregion // Other Filters

        #region Store As Color CheckBox

        private void storeAsColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StoreAsColorWherePossible = this.storeAsColorCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion // Store As Color CheckBox

        #region Mfr Filtering

        private void mfrFilteringStartButton_Click(object sender, EventArgs e)
        {
            if (mfrFilteringInputImgBox.Image != null)
            {
                var inputBitmap = new Bitmap(mfrFilteringInputImgBox.Image);
                MfrFilter filter = new MfrFilter(inputBitmap,
                    Settings.Default.StoreAsColorWherePossible,
                    Int32.Parse(mfrFilterSizeTextBox.Text, Thread.CurrentThread.CurrentCulture),
                    Double.Parse(mfrScalingFactorTextBox.Text, Thread.CurrentThread.CurrentCulture),
                    Int32.Parse(mfrNumberOfFiltersTextBox.Text, Thread.CurrentThread.CurrentCulture),
                    Double.Parse(mfrFixedSegmentLengthTextBox.Text, Thread.CurrentThread.CurrentCulture),
                    Double.Parse(mfrSigmaTextBox.Text, Thread.CurrentThread.CurrentCulture),
                    Double.Parse(mfrSigmaTruncationTextBox.Text, Thread.CurrentThread.CurrentCulture));

                mfrFilteringOutputImgBox.Image = filter.Filter();
            }
        }

        #endregion // Mfr Filtering
        #region Contrast
        private void contrastButton_Click(object sender, EventArgs e)
        {
            if (contrastInputImgBox.Image != null)
            {
                float contrast = (float)Convert.ToDouble(contrastValueTextBox.Text);
                contrastOutputImgBox.Image = new ColorChannels().SaveContrast(contrastInputImgBox.Image, contrast);
            }
        }
        #endregion //Contrast
        #region MultiImageProcessing
        private Bitmap Mfr(Bitmap inputImage)
        {
            var mfrImage = new MfrFilter(inputImage,
                Settings.Default.StoreAsColorWherePossible,
                Int32.Parse(mfrFilterSizeTextBox.Text, Thread.CurrentThread.CurrentCulture),
                Double.Parse(mfrScalingFactorTextBox.Text, Thread.CurrentThread.CurrentCulture),
                Int32.Parse(mfrNumberOfFiltersTextBox.Text, Thread.CurrentThread.CurrentCulture),
                Double.Parse(mfrFixedSegmentLengthTextBox.Text, Thread.CurrentThread.CurrentCulture),
                Double.Parse(mfrSigmaTextBox.Text, Thread.CurrentThread.CurrentCulture),
                Double.Parse(mfrSigmaTruncationTextBox.Text, Thread.CurrentThread.CurrentCulture)).Filter();

            return mfrImage;
        }
        private Bitmap Gabor(Bitmap inputImage)
        {
            var gaborImageBitmap = new GaborFilter();
            var GaborFilterBank = new GaborFilterBank(new Bitmap(inputImage),
    Settings.Default.StoreAsColorWherePossible);
            var gaborImage = GaborFilterBank.Filter(sizeTextBox.Text, lambdaTextBox.Text,
              numberOfFiltersTextBox.Text, psiTextBox.Text, sigmaTextBox.Text, gammaTextBox.Text);
            var nn = new Bitmap(gaborImage);
            return nn;
        }

        private Bitmap Contrast(Bitmap inputImage)
        {
            float contrast = (float)Convert.ToDouble(contrastValueTextBox.Text);
            return new ColorChannels().SaveContrast(inputImage, contrast);
        }
        private Bitmap AChannel(Image inputImage)
        {
            return new ColorChannels().SaveAChannel(inputImage);
        }
        private Bitmap Green(Image inputImage)
        {
            return new ColorChannels().SaveGreenChannel(inputImage);
        }
        private Bitmap VChannel(Image inputImage)
        {
            return new ColorChannels().SaveVChannel(inputImage);
        }
        private Bitmap Ohta1(Image inputImage)
        {
            return new ColorChannels().SaveOhta1Channel(inputImage);
        }
        private Bitmap Ohta2(Image inputImage)
        {
            return new ColorChannels().SaveOhta2Channel(inputImage);
        }
        private Bitmap Ohta3(Image inputImage)
        {
            return new ColorChannels().SaveOhta3Channel(inputImage);
        }
        private Bitmap Median(Bitmap inputImage)
        {
            var filterSize = Int32.Parse(othersFilterSizeBox.Text);
            return new MedianLightnessEqualisationFilter(inputImage, Settings.Default.StoreAsColorWherePossible, filterSize).Filter();
        }
        private Bitmap Sobel(Bitmap inputImage)
        {
            return new SobelFilter(inputImage, Settings.Default.StoreAsColorWherePossible).Filter();
        }
        private Bitmap Laplacian(Bitmap inputImage)
        {
            return new LaplacianFilter(inputImage, Settings.Default.StoreAsColorWherePossible).Filter();
        }
        private void A1Button_Click(object sender, EventArgs e)
        {
            // 1st step a channel (Lab)
            var aFilterImage = AChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(aFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);

            // dispose old bitmaps
            aFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;
        }

        private void A2Button_Click(object sender, EventArgs e)
        {
            // 1st step a channel (Lab)
            var aFilterImage = AChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(aFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            aFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (gaborImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void A3Button_Click(object sender, EventArgs e)
        {
            // 1st step a channel (Lab)
            var aFilterImage = AChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(aFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Sobel
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            aFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (sobelImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void A4Button_Click(object sender, EventArgs e)
        {
            // 1st step a channel (Lab)
            var aFilterImage = AChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(aFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplacian
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            aFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (laplaceImage)

            experimentOutputImgBox.Image = laplaceImage;
        }

        private void B1Button_Click(object sender, EventArgs e)
        {
            // 1st step green color
            var greenFilterImage = Green(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(greenFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);
            //var newImage = Contrast(mfrImage);

            // dispose old bitmaps
            greenFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;

        }

        private void B2Button_Click(object sender, EventArgs e)
        {
            // 1st step green color
            var greenFilterImage = Green(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(greenFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            greenFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (gaborImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void B3Button_Click(object sender, EventArgs e)
        {
            // 1st step green color
            var greenFilterImage = Green(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(greenFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(greenFilterImage);

            // 4th Sobel
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            greenFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (sobelImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void B4Button_Click(object sender, EventArgs e)
        {
            // 1st step green color
            var greenFilterImage = Green(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(greenFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplace
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            greenFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (laplaceImage)

            experimentOutputImgBox.Image = laplaceImage;
        }

        private void C1Button_Click(object sender, EventArgs e)
        {
            // 1st step V channel (HSV)
            var vFilterImage = VChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(vFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);

            // dispose old bitmaps
            vFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;
        }

        private void C2Button_Click(object sender, EventArgs e)
        {
            // 1st step V channel (HSV)
            var vFilterImage = VChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(vFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            vFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (gaborImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void C3Button_Click(object sender, EventArgs e)
        {
            // 1st step V channel (HSV)
            var vFilterImage = VChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(vFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Sobel
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            vFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (sobelImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void C4Button_Click(object sender, EventArgs e)
        {
            // 1st step V channel (HSV)
            var vFilterImage = VChannel(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(vFilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplacian
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            vFilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (laplaceImage)

            experimentOutputImgBox.Image = laplaceImage;
        }

        private void D1Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta1 channel
            var ohta1FilterImage = Ohta1(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta1FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);

            // dispose old bitmaps
            ohta1FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;
        }

        private void D2Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta1 channel
            var ohta1FilterImage = Ohta1(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta1FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            ohta1FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (gaborImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void D3Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta1 channel
            var ohta1FilterImage = Ohta1(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta1FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Sobel
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            ohta1FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (sobelImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void D4Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta1 channel
            var ohta1FilterImage = Ohta1(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta1FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplacian
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            ohta1FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (laplaceImage)

            experimentOutputImgBox.Image = laplaceImage;
        }

        private void E1Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta2 channel
            var ohta2FilterImage = Ohta2(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta2FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);

            // dispose old bitmaps
            ohta2FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;
        }

        private void E2Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta2 channel
            var ohta2FilterImage = Ohta2(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta2FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            ohta2FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (gaborImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void E3Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta2 channel
            var ohta2FilterImage = Ohta2(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta2FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            ohta2FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (sobelImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void E4Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta2 channel
            var ohta2FilterImage = Ohta2(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta2FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplacian
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            ohta2FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (laplaceImage)

            experimentOutputImgBox.Image = laplaceImage;
        }

        private void F1Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta3 channel
            var ohta3FilterImage = Ohta3(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta3FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th mfr
            var mfrImage = Mfr(contrastFilterImage);

            // dispose old bitmaps
            ohta3FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = mfrImage;
        }

        private void F2Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta3 channel
            var ohta3FilterImage = Ohta3(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta3FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Gabor
            var gaborImage = Gabor(contrastFilterImage);

            // dispose old bitmaps
            ohta3FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = gaborImage;
        }

        private void F3Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta3 channel
            var ohta3FilterImage = Ohta3(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta3FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Sobel
            var sobelImage = Sobel(contrastFilterImage);

            // dispose old bitmaps
            ohta3FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = sobelImage;
        }

        private void F4Button_Click(object sender, EventArgs e)
        {
            // 1st step Ohta3 channel
            var ohta3FilterImage = Ohta3(experimentImgBox.Image);

            // 2nd step median
            var medianFilterImage = Median(ohta3FilterImage);

            // 3rd step constrast enhancement
            var contrastFilterImage = Contrast(medianFilterImage);

            // 4th Laplace
            var laplaceImage = Laplacian(contrastFilterImage);

            // dispose old bitmaps
            ohta3FilterImage.Dispose();
            medianFilterImage.Dispose();
            contrastFilterImage.Dispose();

            // do not dispose bitmap we are displaying (mfrImage)

            experimentOutputImgBox.Image = laplaceImage;
        }
        #endregion // MultiImageProcessing
    }
}