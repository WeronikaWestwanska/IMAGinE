namespace Fundus_v3
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox gaborSettingsGroupBox;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            this.psiLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.sigmaTextBox = new System.Windows.Forms.TextBox();
            this.numberOfFiltersTextBox = new System.Windows.Forms.TextBox();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            this.psiTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.sigmaLabel = new System.Windows.Forms.Label();
            this.numberOfFiltersLabel = new System.Windows.Forms.Label();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.gaborButton = new System.Windows.Forms.Button();
            this.mfrFixedSegmentLengthLabel = new System.Windows.Forms.Label();
            this.mfrFilterSizeLabel = new System.Windows.Forms.Label();
            this.mfrSigmaTruncationTextBox = new System.Windows.Forms.TextBox();
            this.mfrSigmaTextBox = new System.Windows.Forms.TextBox();
            this.mfrNumberOfFiltersTextBox = new System.Windows.Forms.TextBox();
            this.mfrScalingFactorTextBox = new System.Windows.Forms.TextBox();
            this.mfrFixedSegmentLengthTextBox = new System.Windows.Forms.TextBox();
            this.mfrFilterSizeTextBox = new System.Windows.Forms.TextBox();
            this.mfrSigmaTruncationLabel = new System.Windows.Forms.Label();
            this.mfrSigmaLabel = new System.Windows.Forms.Label();
            this.mfrNumberOfFiltersLabel = new System.Windows.Forms.Label();
            this.mfrScalingFactorLabel = new System.Windows.Forms.Label();
            this.mfrFilteringStartButton = new System.Windows.Forms.Button();
            this.contrastValueLabel = new System.Windows.Forms.Label();
            this.contrastValueTextBox = new System.Windows.Forms.TextBox();
            this.contrastFilterSizeLabel = new System.Windows.Forms.Label();
            this.contrastButton = new System.Windows.Forms.Button();
            this.contrastFilterSizeTextBox = new System.Windows.Forms.TextBox();
            this.channelsTabControl = new System.Windows.Forms.TabControl();
            this.rgbTabPage = new System.Windows.Forms.TabPage();
            this.rgbOutputFileLabel = new System.Windows.Forms.Label();
            this.outputImgTextBox = new System.Windows.Forms.TextBox();
            this.rgbSaveButton = new System.Windows.Forms.Button();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rgbOutputImgBox = new System.Windows.Forms.PictureBox();
            this.rgbInputImgBox = new System.Windows.Forms.PictureBox();
            this.rgbComboBox = new System.Windows.Forms.ComboBox();
            this.ohtaTabPage = new System.Windows.Forms.TabPage();
            this.ohtSaveButton = new System.Windows.Forms.Button();
            this.ohtaOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.ohtaOutputFileLabel = new System.Windows.Forms.Label();
            this.ohtaOutputImgBox = new System.Windows.Forms.PictureBox();
            this.ohtaInputImgBox = new System.Windows.Forms.PictureBox();
            this.ohtaLabel = new System.Windows.Forms.Label();
            this.ohtaComboBox = new System.Windows.Forms.ComboBox();
            this.labTabPage = new System.Windows.Forms.TabPage();
            this.labSaveButton = new System.Windows.Forms.Button();
            this.labOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.labOutputFileLabel = new System.Windows.Forms.Label();
            this.labOutputImgBox = new System.Windows.Forms.PictureBox();
            this.labInputImgBox = new System.Windows.Forms.PictureBox();
            this.labLabel = new System.Windows.Forms.Label();
            this.labComboBox = new System.Windows.Forms.ComboBox();
            this.hsvTabPage = new System.Windows.Forms.TabPage();
            this.hsvSaveButton = new System.Windows.Forms.Button();
            this.hsvOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.hsvOutputFileLabel = new System.Windows.Forms.Label();
            this.hsvOutputImgBox = new System.Windows.Forms.PictureBox();
            this.hsvInputImgBox = new System.Windows.Forms.PictureBox();
            this.hsvLabel = new System.Windows.Forms.Label();
            this.hsvComboBox = new System.Windows.Forms.ComboBox();
            this.gaborTabPage = new System.Windows.Forms.TabPage();
            this.gaborSaveButton = new System.Windows.Forms.Button();
            this.gaborOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.gaborOutputFileLabel = new System.Windows.Forms.Label();
            this.gaborOutputImgBox = new System.Windows.Forms.PictureBox();
            this.gaborInputImgBox = new System.Windows.Forms.PictureBox();
            this.sobelTabPage = new System.Windows.Forms.TabPage();
            this.horizontalMaskButton = new System.Windows.Forms.Button();
            this.verticalMaskButton = new System.Windows.Forms.Button();
            this.sobelButton = new System.Windows.Forms.Button();
            this.sobelSaveButton = new System.Windows.Forms.Button();
            this.sobelOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.sobelOutputFileLabel = new System.Windows.Forms.Label();
            this.sobelOutputImgBox = new System.Windows.Forms.PictureBox();
            this.sobelInputImgBox = new System.Windows.Forms.PictureBox();
            this.otherFilters = new System.Windows.Forms.TabPage();
            this.medianButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.othersFilterSizeBox = new System.Windows.Forms.TextBox();
            this.othersFilterSizeLabel = new System.Windows.Forms.Label();
            this.lowPassFilterButton = new System.Windows.Forms.Button();
            this.laplacianFilterButton = new System.Windows.Forms.Button();
            this.lightnessEqualisationButton = new System.Windows.Forms.Button();
            this.highPassFilterButton = new System.Windows.Forms.Button();
            this.gausianFilterButton = new System.Windows.Forms.Button();
            this.otherFiltersSaveButton = new System.Windows.Forms.Button();
            this.otherFiltersOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.filtersOutputFileLabel = new System.Windows.Forms.Label();
            this.otherFiltersOutputImgBox = new System.Windows.Forms.PictureBox();
            this.otherFiltersInputImgBox = new System.Windows.Forms.PictureBox();
            this.mfrFilteringTab = new System.Windows.Forms.TabPage();
            this.mfrFilteringOutputImgBox = new System.Windows.Forms.PictureBox();
            this.mfrFilteringInputImgBox = new System.Windows.Forms.PictureBox();
            this.mfrFilteringSaveButton = new System.Windows.Forms.Button();
            this.mfrFilteringOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.mfFilteringOutputImgLabel = new System.Windows.Forms.Label();
            this.contrastTabPage = new System.Windows.Forms.TabPage();
            this.contrastSaveButton = new System.Windows.Forms.Button();
            this.contrastOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastOutputImgBox = new System.Windows.Forms.PictureBox();
            this.contrastInputImgBox = new System.Windows.Forms.PictureBox();
            this.experimentTabPage = new System.Windows.Forms.TabPage();
            this.experimentOutputImgBox = new System.Windows.Forms.PictureBox();
            this.E4Button = new System.Windows.Forms.Button();
            this.E3Button = new System.Windows.Forms.Button();
            this.E2Button = new System.Windows.Forms.Button();
            this.E1Button = new System.Windows.Forms.Button();
            this.D4Button = new System.Windows.Forms.Button();
            this.D3Button = new System.Windows.Forms.Button();
            this.D2Button = new System.Windows.Forms.Button();
            this.D1Button = new System.Windows.Forms.Button();
            this.C4Button = new System.Windows.Forms.Button();
            this.C3Button = new System.Windows.Forms.Button();
            this.C2Button = new System.Windows.Forms.Button();
            this.C1Button = new System.Windows.Forms.Button();
            this.B4Button = new System.Windows.Forms.Button();
            this.B3Button = new System.Windows.Forms.Button();
            this.B2Button = new System.Windows.Forms.Button();
            this.B1Button = new System.Windows.Forms.Button();
            this.A4Button = new System.Windows.Forms.Button();
            this.A3Button = new System.Windows.Forms.Button();
            this.A2Button = new System.Windows.Forms.Button();
            this.A1Button = new System.Windows.Forms.Button();
            this.F4Button = new System.Windows.Forms.Button();
            this.F3Button = new System.Windows.Forms.Button();
            this.F2Button = new System.Windows.Forms.Button();
            this.F1Button = new System.Windows.Forms.Button();
            this.experimentSaveButton = new System.Windows.Forms.Button();
            this.experimentOutputImgTextBox = new System.Windows.Forms.TextBox();
            this.experimentLabel = new System.Windows.Forms.Label();
            this.experimentImgBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.storeAsColorCheckBox = new System.Windows.Forms.CheckBox();
            this.A1toolTip = new System.Windows.Forms.ToolTip(this.components);
            gaborSettingsGroupBox = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            gaborSettingsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.channelsTabControl.SuspendLayout();
            this.rgbTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbInputImgBox)).BeginInit();
            this.ohtaTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ohtaOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohtaInputImgBox)).BeginInit();
            this.labTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labInputImgBox)).BeginInit();
            this.hsvTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hsvOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvInputImgBox)).BeginInit();
            this.gaborTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaborOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaborInputImgBox)).BeginInit();
            this.sobelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobelOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelInputImgBox)).BeginInit();
            this.otherFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherFiltersOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherFiltersInputImgBox)).BeginInit();
            this.mfrFilteringTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfrFilteringOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfrFilteringInputImgBox)).BeginInit();
            this.contrastTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastInputImgBox)).BeginInit();
            this.experimentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experimentOutputImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gaborSettingsGroupBox
            // 
            gaborSettingsGroupBox.BackColor = System.Drawing.Color.LemonChiffon;
            gaborSettingsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            gaborSettingsGroupBox.Controls.Add(this.psiLabel);
            gaborSettingsGroupBox.Controls.Add(this.sizeLabel);
            gaborSettingsGroupBox.Controls.Add(this.gammaTextBox);
            gaborSettingsGroupBox.Controls.Add(this.sigmaTextBox);
            gaborSettingsGroupBox.Controls.Add(this.numberOfFiltersTextBox);
            gaborSettingsGroupBox.Controls.Add(this.lambdaTextBox);
            gaborSettingsGroupBox.Controls.Add(this.psiTextBox);
            gaborSettingsGroupBox.Controls.Add(this.sizeTextBox);
            gaborSettingsGroupBox.Controls.Add(this.gammaLabel);
            gaborSettingsGroupBox.Controls.Add(this.sigmaLabel);
            gaborSettingsGroupBox.Controls.Add(this.numberOfFiltersLabel);
            gaborSettingsGroupBox.Controls.Add(this.lambdaLabel);
            gaborSettingsGroupBox.Controls.Add(this.gaborButton);
            gaborSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            gaborSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            gaborSettingsGroupBox.Location = new System.Drawing.Point(6, 51);
            gaborSettingsGroupBox.Name = "gaborSettingsGroupBox";
            gaborSettingsGroupBox.Size = new System.Drawing.Size(628, 73);
            gaborSettingsGroupBox.TabIndex = 23;
            gaborSettingsGroupBox.TabStop = false;
            gaborSettingsGroupBox.Text = "Settings";
            // 
            // psiLabel
            // 
            this.psiLabel.AutoSize = true;
            this.psiLabel.Location = new System.Drawing.Point(82, 47);
            this.psiLabel.Name = "psiLabel";
            this.psiLabel.Size = new System.Drawing.Size(26, 16);
            this.psiLabel.TabIndex = 24;
            this.psiLabel.Text = "psi";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(76, 16);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(32, 16);
            this.sizeLabel.TabIndex = 23;
            this.sizeLabel.Text = "size";
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.Location = new System.Drawing.Point(460, 44);
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(56, 22);
            this.gammaTextBox.TabIndex = 22;
            this.gammaTextBox.Text = "1.0";
            this.gammaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sigmaTextBox
            // 
            this.sigmaTextBox.Location = new System.Drawing.Point(289, 45);
            this.sigmaTextBox.Name = "sigmaTextBox";
            this.sigmaTextBox.Size = new System.Drawing.Size(56, 22);
            this.sigmaTextBox.TabIndex = 21;
            this.sigmaTextBox.Text = "2.0";
            this.sigmaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberOfFiltersTextBox
            // 
            this.numberOfFiltersTextBox.Location = new System.Drawing.Point(460, 13);
            this.numberOfFiltersTextBox.Name = "numberOfFiltersTextBox";
            this.numberOfFiltersTextBox.Size = new System.Drawing.Size(56, 22);
            this.numberOfFiltersTextBox.TabIndex = 20;
            this.numberOfFiltersTextBox.Text = "8";
            this.numberOfFiltersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Location = new System.Drawing.Point(289, 13);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.Size = new System.Drawing.Size(56, 22);
            this.lambdaTextBox.TabIndex = 19;
            this.lambdaTextBox.Text = "4.0";
            this.lambdaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // psiTextBox
            // 
            this.psiTextBox.Location = new System.Drawing.Point(117, 45);
            this.psiTextBox.Name = "psiTextBox";
            this.psiTextBox.Size = new System.Drawing.Size(56, 22);
            this.psiTextBox.TabIndex = 18;
            this.psiTextBox.Text = "0.0";
            this.psiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeTextBox.Location = new System.Drawing.Point(117, 13);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(56, 22);
            this.sizeTextBox.TabIndex = 17;
            this.sizeTextBox.Text = "7";
            this.sizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(400, 47);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(54, 16);
            this.gammaLabel.TabIndex = 16;
            this.gammaLabel.Text = "gamma";
            // 
            // sigmaLabel
            // 
            this.sigmaLabel.AutoSize = true;
            this.sigmaLabel.Location = new System.Drawing.Point(238, 47);
            this.sigmaLabel.Name = "sigmaLabel";
            this.sigmaLabel.Size = new System.Drawing.Size(45, 16);
            this.sigmaLabel.TabIndex = 15;
            this.sigmaLabel.Text = "sigma";
            // 
            // numberOfFiltersLabel
            // 
            this.numberOfFiltersLabel.AutoSize = true;
            this.numberOfFiltersLabel.Location = new System.Drawing.Point(356, 16);
            this.numberOfFiltersLabel.Name = "numberOfFiltersLabel";
            this.numberOfFiltersLabel.Size = new System.Drawing.Size(101, 16);
            this.numberOfFiltersLabel.TabIndex = 14;
            this.numberOfFiltersLabel.Text = "number of filters";
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(229, 16);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(54, 16);
            this.lambdaLabel.TabIndex = 13;
            this.lambdaLabel.Text = "lambda";
            // 
            // gaborButton
            // 
            this.gaborButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaborButton.Location = new System.Drawing.Point(545, 21);
            this.gaborButton.Name = "gaborButton";
            this.gaborButton.Size = new System.Drawing.Size(77, 33);
            this.gaborButton.TabIndex = 10;
            this.gaborButton.Text = "START";
            this.gaborButton.UseVisualStyleBackColor = true;
            this.gaborButton.Click += new System.EventHandler(this.gaborButton_Click);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            groupBox1.Controls.Add(this.mfrFixedSegmentLengthLabel);
            groupBox1.Controls.Add(this.mfrFilterSizeLabel);
            groupBox1.Controls.Add(this.mfrSigmaTruncationTextBox);
            groupBox1.Controls.Add(this.mfrSigmaTextBox);
            groupBox1.Controls.Add(this.mfrNumberOfFiltersTextBox);
            groupBox1.Controls.Add(this.mfrScalingFactorTextBox);
            groupBox1.Controls.Add(this.mfrFixedSegmentLengthTextBox);
            groupBox1.Controls.Add(this.mfrFilterSizeTextBox);
            groupBox1.Controls.Add(this.mfrSigmaTruncationLabel);
            groupBox1.Controls.Add(this.mfrSigmaLabel);
            groupBox1.Controls.Add(this.mfrNumberOfFiltersLabel);
            groupBox1.Controls.Add(this.mfrScalingFactorLabel);
            groupBox1.Controls.Add(this.mfrFilteringStartButton);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            groupBox1.Location = new System.Drawing.Point(13, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(628, 73);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // mfrFixedSegmentLengthLabel
            // 
            this.mfrFixedSegmentLengthLabel.AutoSize = true;
            this.mfrFixedSegmentLengthLabel.Location = new System.Drawing.Point(14, 47);
            this.mfrFixedSegmentLengthLabel.Name = "mfrFixedSegmentLengthLabel";
            this.mfrFixedSegmentLengthLabel.Size = new System.Drawing.Size(100, 16);
            this.mfrFixedSegmentLengthLabel.TabIndex = 24;
            this.mfrFixedSegmentLengthLabel.Text = "fixed segm. len.";
            // 
            // mfrFilterSizeLabel
            // 
            this.mfrFilterSizeLabel.AutoSize = true;
            this.mfrFilterSizeLabel.Location = new System.Drawing.Point(82, 16);
            this.mfrFilterSizeLabel.Name = "mfrFilterSizeLabel";
            this.mfrFilterSizeLabel.Size = new System.Drawing.Size(32, 16);
            this.mfrFilterSizeLabel.TabIndex = 23;
            this.mfrFilterSizeLabel.Text = "size";
            // 
            // mfrSigmaTruncationTextBox
            // 
            this.mfrSigmaTruncationTextBox.Location = new System.Drawing.Point(460, 44);
            this.mfrSigmaTruncationTextBox.Name = "mfrSigmaTruncationTextBox";
            this.mfrSigmaTruncationTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrSigmaTruncationTextBox.TabIndex = 22;
            this.mfrSigmaTruncationTextBox.Text = "3";
            this.mfrSigmaTruncationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrSigmaTextBox
            // 
            this.mfrSigmaTextBox.Location = new System.Drawing.Point(289, 45);
            this.mfrSigmaTextBox.Name = "mfrSigmaTextBox";
            this.mfrSigmaTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrSigmaTextBox.TabIndex = 21;
            this.mfrSigmaTextBox.Text = "2";
            this.mfrSigmaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrNumberOfFiltersTextBox
            // 
            this.mfrNumberOfFiltersTextBox.Location = new System.Drawing.Point(460, 13);
            this.mfrNumberOfFiltersTextBox.Name = "mfrNumberOfFiltersTextBox";
            this.mfrNumberOfFiltersTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrNumberOfFiltersTextBox.TabIndex = 20;
            this.mfrNumberOfFiltersTextBox.Text = "12";
            this.mfrNumberOfFiltersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrScalingFactorTextBox
            // 
            this.mfrScalingFactorTextBox.Location = new System.Drawing.Point(289, 13);
            this.mfrScalingFactorTextBox.Name = "mfrScalingFactorTextBox";
            this.mfrScalingFactorTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrScalingFactorTextBox.TabIndex = 19;
            this.mfrScalingFactorTextBox.Text = "10";
            this.mfrScalingFactorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrFixedSegmentLengthTextBox
            // 
            this.mfrFixedSegmentLengthTextBox.Location = new System.Drawing.Point(117, 45);
            this.mfrFixedSegmentLengthTextBox.Name = "mfrFixedSegmentLengthTextBox";
            this.mfrFixedSegmentLengthTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrFixedSegmentLengthTextBox.TabIndex = 18;
            this.mfrFixedSegmentLengthTextBox.Text = "9";
            this.mfrFixedSegmentLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrFilterSizeTextBox
            // 
            this.mfrFilterSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mfrFilterSizeTextBox.Location = new System.Drawing.Point(117, 13);
            this.mfrFilterSizeTextBox.Name = "mfrFilterSizeTextBox";
            this.mfrFilterSizeTextBox.Size = new System.Drawing.Size(56, 22);
            this.mfrFilterSizeTextBox.TabIndex = 17;
            this.mfrFilterSizeTextBox.Text = "15";
            this.mfrFilterSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mfrSigmaTruncationLabel
            // 
            this.mfrSigmaTruncationLabel.AutoSize = true;
            this.mfrSigmaTruncationLabel.Location = new System.Drawing.Point(353, 47);
            this.mfrSigmaTruncationLabel.Name = "mfrSigmaTruncationLabel";
            this.mfrSigmaTruncationLabel.Size = new System.Drawing.Size(105, 16);
            this.mfrSigmaTruncationLabel.TabIndex = 16;
            this.mfrSigmaTruncationLabel.Text = "sigma truncation";
            // 
            // mfrSigmaLabel
            // 
            this.mfrSigmaLabel.AutoSize = true;
            this.mfrSigmaLabel.Location = new System.Drawing.Point(238, 47);
            this.mfrSigmaLabel.Name = "mfrSigmaLabel";
            this.mfrSigmaLabel.Size = new System.Drawing.Size(45, 16);
            this.mfrSigmaLabel.TabIndex = 15;
            this.mfrSigmaLabel.Text = "sigma";
            // 
            // mfrNumberOfFiltersLabel
            // 
            this.mfrNumberOfFiltersLabel.AutoSize = true;
            this.mfrNumberOfFiltersLabel.Location = new System.Drawing.Point(356, 16);
            this.mfrNumberOfFiltersLabel.Name = "mfrNumberOfFiltersLabel";
            this.mfrNumberOfFiltersLabel.Size = new System.Drawing.Size(101, 16);
            this.mfrNumberOfFiltersLabel.TabIndex = 14;
            this.mfrNumberOfFiltersLabel.Text = "number of filters";
            // 
            // mfrScalingFactorLabel
            // 
            this.mfrScalingFactorLabel.AutoSize = true;
            this.mfrScalingFactorLabel.Location = new System.Drawing.Point(200, 16);
            this.mfrScalingFactorLabel.Name = "mfrScalingFactorLabel";
            this.mfrScalingFactorLabel.Size = new System.Drawing.Size(87, 16);
            this.mfrScalingFactorLabel.TabIndex = 13;
            this.mfrScalingFactorLabel.Text = "scaling factor";
            // 
            // mfrFilteringStartButton
            // 
            this.mfrFilteringStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mfrFilteringStartButton.Location = new System.Drawing.Point(545, 21);
            this.mfrFilteringStartButton.Name = "mfrFilteringStartButton";
            this.mfrFilteringStartButton.Size = new System.Drawing.Size(77, 33);
            this.mfrFilteringStartButton.TabIndex = 10;
            this.mfrFilteringStartButton.Text = "START";
            this.mfrFilteringStartButton.UseVisualStyleBackColor = true;
            this.mfrFilteringStartButton.Click += new System.EventHandler(this.mfrFilteringStartButton_Click);
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            groupBox2.Controls.Add(this.contrastValueLabel);
            groupBox2.Controls.Add(this.contrastValueTextBox);
            groupBox2.Controls.Add(this.contrastFilterSizeLabel);
            groupBox2.Controls.Add(this.contrastButton);
            groupBox2.Controls.Add(this.contrastFilterSizeTextBox);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            groupBox2.Location = new System.Drawing.Point(13, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(630, 73);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // contrastValueLabel
            // 
            this.contrastValueLabel.AutoSize = true;
            this.contrastValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastValueLabel.Location = new System.Drawing.Point(322, 15);
            this.contrastValueLabel.Name = "contrastValueLabel";
            this.contrastValueLabel.Size = new System.Drawing.Size(119, 18);
            this.contrastValueLabel.TabIndex = 26;
            this.contrastValueLabel.Text = "Contrast Value";
            // 
            // contrastValueTextBox
            // 
            this.contrastValueTextBox.Location = new System.Drawing.Point(467, 11);
            this.contrastValueTextBox.Name = "contrastValueTextBox";
            this.contrastValueTextBox.Size = new System.Drawing.Size(56, 22);
            this.contrastValueTextBox.TabIndex = 25;
            this.contrastValueTextBox.Text = "50";
            this.contrastValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contrastFilterSizeLabel
            // 
            this.contrastFilterSizeLabel.AutoSize = true;
            this.contrastFilterSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastFilterSizeLabel.Location = new System.Drawing.Point(402, 43);
            this.contrastFilterSizeLabel.Name = "contrastFilterSizeLabel";
            this.contrastFilterSizeLabel.Size = new System.Drawing.Size(39, 18);
            this.contrastFilterSizeLabel.TabIndex = 23;
            this.contrastFilterSizeLabel.Text = "size";
            // 
            // contrastButton
            // 
            this.contrastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastButton.Location = new System.Drawing.Point(545, 21);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(77, 31);
            this.contrastButton.TabIndex = 24;
            this.contrastButton.Text = "START";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.contrastButton_Click);
            // 
            // contrastFilterSizeTextBox
            // 
            this.contrastFilterSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrastFilterSizeTextBox.Location = new System.Drawing.Point(467, 39);
            this.contrastFilterSizeTextBox.Name = "contrastFilterSizeTextBox";
            this.contrastFilterSizeTextBox.Size = new System.Drawing.Size(56, 22);
            this.contrastFilterSizeTextBox.TabIndex = 17;
            this.contrastFilterSizeTextBox.Text = "25";
            this.contrastFilterSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // channelsTabControl
            // 
            this.channelsTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.channelsTabControl.Controls.Add(this.rgbTabPage);
            this.channelsTabControl.Controls.Add(this.ohtaTabPage);
            this.channelsTabControl.Controls.Add(this.labTabPage);
            this.channelsTabControl.Controls.Add(this.hsvTabPage);
            this.channelsTabControl.Controls.Add(this.gaborTabPage);
            this.channelsTabControl.Controls.Add(this.sobelTabPage);
            this.channelsTabControl.Controls.Add(this.otherFilters);
            this.channelsTabControl.Controls.Add(this.mfrFilteringTab);
            this.channelsTabControl.Controls.Add(this.contrastTabPage);
            this.channelsTabControl.Controls.Add(this.experimentTabPage);
            this.channelsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channelsTabControl.Location = new System.Drawing.Point(12, 77);
            this.channelsTabControl.Multiline = true;
            this.channelsTabControl.Name = "channelsTabControl";
            this.channelsTabControl.SelectedIndex = 0;
            this.channelsTabControl.ShowToolTips = true;
            this.channelsTabControl.Size = new System.Drawing.Size(661, 498);
            this.channelsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.channelsTabControl.TabIndex = 0;
            // 
            // rgbTabPage
            // 
            this.rgbTabPage.BackColor = System.Drawing.Color.Moccasin;
            this.rgbTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbTabPage.Controls.Add(this.rgbOutputFileLabel);
            this.rgbTabPage.Controls.Add(this.outputImgTextBox);
            this.rgbTabPage.Controls.Add(this.rgbSaveButton);
            this.rgbTabPage.Controls.Add(this.rgbLabel);
            this.rgbTabPage.Controls.Add(this.rgbOutputImgBox);
            this.rgbTabPage.Controls.Add(this.rgbInputImgBox);
            this.rgbTabPage.Controls.Add(this.rgbComboBox);
            this.rgbTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgbTabPage.Location = new System.Drawing.Point(4, 55);
            this.rgbTabPage.Name = "rgbTabPage";
            this.rgbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rgbTabPage.Size = new System.Drawing.Size(653, 439);
            this.rgbTabPage.TabIndex = 0;
            this.rgbTabPage.Text = "RGB";
            this.rgbTabPage.ToolTipText = "Displays RGB model for chosen image";
            // 
            // rgbOutputFileLabel
            // 
            this.rgbOutputFileLabel.AutoSize = true;
            this.rgbOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgbOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rgbOutputFileLabel.Location = new System.Drawing.Point(2, 19);
            this.rgbOutputFileLabel.Name = "rgbOutputFileLabel";
            this.rgbOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.rgbOutputFileLabel.TabIndex = 6;
            this.rgbOutputFileLabel.Text = "Output file";
            // 
            // outputImgTextBox
            // 
            this.outputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputImgTextBox.Location = new System.Drawing.Point(90, 17);
            this.outputImgTextBox.Name = "outputImgTextBox";
            this.outputImgTextBox.ReadOnly = true;
            this.outputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.outputImgTextBox.TabIndex = 4;
            // 
            // rgbSaveButton
            // 
            this.rgbSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgbSaveButton.Location = new System.Drawing.Point(542, 18);
            this.rgbSaveButton.Name = "rgbSaveButton";
            this.rgbSaveButton.Size = new System.Drawing.Size(94, 26);
            this.rgbSaveButton.TabIndex = 2;
            this.rgbSaveButton.Text = "SAVE";
            this.rgbSaveButton.UseVisualStyleBackColor = true;
            this.rgbSaveButton.Click += new System.EventHandler(this.rgbSaveButton_Click);
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(7, 72);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(140, 16);
            this.rgbLabel.TabIndex = 3;
            this.rgbLabel.Text = "Available channels";
            // 
            // rgbOutputImgBox
            // 
            this.rgbOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.rgbOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rgbOutputImgBox.Location = new System.Drawing.Point(342, 130);
            this.rgbOutputImgBox.Name = "rgbOutputImgBox";
            this.rgbOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.rgbOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rgbOutputImgBox.TabIndex = 2;
            this.rgbOutputImgBox.TabStop = false;
            // 
            // rgbInputImgBox
            // 
            this.rgbInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.rgbInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rgbInputImgBox.Location = new System.Drawing.Point(6, 130);
            this.rgbInputImgBox.Name = "rgbInputImgBox";
            this.rgbInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.rgbInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rgbInputImgBox.TabIndex = 1;
            this.rgbInputImgBox.TabStop = false;
            // 
            // rgbComboBox
            // 
            this.rgbComboBox.FormattingEnabled = true;
            this.rgbComboBox.Items.AddRange(new object[] {
            "R channel",
            "G channel",
            "B channel"});
            this.rgbComboBox.Location = new System.Drawing.Point(6, 100);
            this.rgbComboBox.Name = "rgbComboBox";
            this.rgbComboBox.Size = new System.Drawing.Size(136, 24);
            this.rgbComboBox.TabIndex = 0;
            this.rgbComboBox.Text = "Select channel";
            this.rgbComboBox.SelectedIndexChanged += new System.EventHandler(this.rgbComboBox_SelectedIndexChanged);
            // 
            // ohtaTabPage
            // 
            this.ohtaTabPage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ohtaTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ohtaTabPage.Controls.Add(this.ohtSaveButton);
            this.ohtaTabPage.Controls.Add(this.ohtaOutputImgTextBox);
            this.ohtaTabPage.Controls.Add(this.ohtaOutputFileLabel);
            this.ohtaTabPage.Controls.Add(this.ohtaOutputImgBox);
            this.ohtaTabPage.Controls.Add(this.ohtaInputImgBox);
            this.ohtaTabPage.Controls.Add(this.ohtaLabel);
            this.ohtaTabPage.Controls.Add(this.ohtaComboBox);
            this.ohtaTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ohtaTabPage.Location = new System.Drawing.Point(4, 55);
            this.ohtaTabPage.Name = "ohtaTabPage";
            this.ohtaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ohtaTabPage.Size = new System.Drawing.Size(653, 439);
            this.ohtaTabPage.TabIndex = 1;
            this.ohtaTabPage.Text = "OHTA";
            // 
            // ohtSaveButton
            // 
            this.ohtSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ohtSaveButton.Location = new System.Drawing.Point(542, 17);
            this.ohtSaveButton.Name = "ohtSaveButton";
            this.ohtSaveButton.Size = new System.Drawing.Size(94, 27);
            this.ohtSaveButton.TabIndex = 9;
            this.ohtSaveButton.Text = "SAVE";
            this.ohtSaveButton.UseVisualStyleBackColor = true;
            this.ohtSaveButton.Click += new System.EventHandler(this.ohtSaveButton_Click);
            // 
            // ohtaOutputImgTextBox
            // 
            this.ohtaOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ohtaOutputImgTextBox.Location = new System.Drawing.Point(85, 17);
            this.ohtaOutputImgTextBox.Name = "ohtaOutputImgTextBox";
            this.ohtaOutputImgTextBox.ReadOnly = true;
            this.ohtaOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.ohtaOutputImgTextBox.TabIndex = 8;
            // 
            // ohtaOutputFileLabel
            // 
            this.ohtaOutputFileLabel.AutoSize = true;
            this.ohtaOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ohtaOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ohtaOutputFileLabel.Location = new System.Drawing.Point(2, 19);
            this.ohtaOutputFileLabel.Name = "ohtaOutputFileLabel";
            this.ohtaOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.ohtaOutputFileLabel.TabIndex = 7;
            this.ohtaOutputFileLabel.Text = "Output file";
            // 
            // ohtaOutputImgBox
            // 
            this.ohtaOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.ohtaOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ohtaOutputImgBox.Location = new System.Drawing.Point(342, 130);
            this.ohtaOutputImgBox.Name = "ohtaOutputImgBox";
            this.ohtaOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.ohtaOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ohtaOutputImgBox.TabIndex = 6;
            this.ohtaOutputImgBox.TabStop = false;
            // 
            // ohtaInputImgBox
            // 
            this.ohtaInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.ohtaInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ohtaInputImgBox.Location = new System.Drawing.Point(6, 130);
            this.ohtaInputImgBox.Name = "ohtaInputImgBox";
            this.ohtaInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.ohtaInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ohtaInputImgBox.TabIndex = 5;
            this.ohtaInputImgBox.TabStop = false;
            // 
            // ohtaLabel
            // 
            this.ohtaLabel.AutoSize = true;
            this.ohtaLabel.Location = new System.Drawing.Point(7, 72);
            this.ohtaLabel.Name = "ohtaLabel";
            this.ohtaLabel.Size = new System.Drawing.Size(140, 16);
            this.ohtaLabel.TabIndex = 4;
            this.ohtaLabel.Text = "Available channels";
            // 
            // ohtaComboBox
            // 
            this.ohtaComboBox.FormattingEnabled = true;
            this.ohtaComboBox.Items.AddRange(new object[] {
            "Ohta1 channel",
            "Ohta2 channel",
            "Ohta3 channel"});
            this.ohtaComboBox.Location = new System.Drawing.Point(6, 100);
            this.ohtaComboBox.Name = "ohtaComboBox";
            this.ohtaComboBox.Size = new System.Drawing.Size(136, 24);
            this.ohtaComboBox.TabIndex = 1;
            this.ohtaComboBox.Text = "Select channel";
            this.ohtaComboBox.SelectedIndexChanged += new System.EventHandler(this.ohtaComboBox_SelectedIndexChanged);
            // 
            // labTabPage
            // 
            this.labTabPage.BackColor = System.Drawing.Color.Thistle;
            this.labTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTabPage.Controls.Add(this.labSaveButton);
            this.labTabPage.Controls.Add(this.labOutputImgTextBox);
            this.labTabPage.Controls.Add(this.labOutputFileLabel);
            this.labTabPage.Controls.Add(this.labOutputImgBox);
            this.labTabPage.Controls.Add(this.labInputImgBox);
            this.labTabPage.Controls.Add(this.labLabel);
            this.labTabPage.Controls.Add(this.labComboBox);
            this.labTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTabPage.Location = new System.Drawing.Point(4, 55);
            this.labTabPage.Name = "labTabPage";
            this.labTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.labTabPage.Size = new System.Drawing.Size(653, 439);
            this.labTabPage.TabIndex = 2;
            this.labTabPage.Text = "L*a*b*";
            // 
            // labSaveButton
            // 
            this.labSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSaveButton.Location = new System.Drawing.Point(542, 18);
            this.labSaveButton.Name = "labSaveButton";
            this.labSaveButton.Size = new System.Drawing.Size(94, 26);
            this.labSaveButton.TabIndex = 9;
            this.labSaveButton.Text = "SAVE";
            this.labSaveButton.UseVisualStyleBackColor = true;
            this.labSaveButton.Click += new System.EventHandler(this.labSaveButton_Click);
            // 
            // labOutputImgTextBox
            // 
            this.labOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labOutputImgTextBox.Location = new System.Drawing.Point(85, 17);
            this.labOutputImgTextBox.Name = "labOutputImgTextBox";
            this.labOutputImgTextBox.ReadOnly = true;
            this.labOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.labOutputImgTextBox.TabIndex = 8;
            // 
            // labOutputFileLabel
            // 
            this.labOutputFileLabel.AutoSize = true;
            this.labOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labOutputFileLabel.Location = new System.Drawing.Point(2, 19);
            this.labOutputFileLabel.Name = "labOutputFileLabel";
            this.labOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.labOutputFileLabel.TabIndex = 7;
            this.labOutputFileLabel.Text = "Output file";
            // 
            // labOutputImgBox
            // 
            this.labOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.labOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labOutputImgBox.Location = new System.Drawing.Point(342, 130);
            this.labOutputImgBox.Name = "labOutputImgBox";
            this.labOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.labOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labOutputImgBox.TabIndex = 6;
            this.labOutputImgBox.TabStop = false;
            // 
            // labInputImgBox
            // 
            this.labInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.labInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labInputImgBox.Location = new System.Drawing.Point(6, 130);
            this.labInputImgBox.Name = "labInputImgBox";
            this.labInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.labInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labInputImgBox.TabIndex = 5;
            this.labInputImgBox.TabStop = false;
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(7, 72);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(140, 16);
            this.labLabel.TabIndex = 4;
            this.labLabel.Text = "Available channels";
            // 
            // labComboBox
            // 
            this.labComboBox.FormattingEnabled = true;
            this.labComboBox.Items.AddRange(new object[] {
            "L channel",
            "a channel",
            "b channel"});
            this.labComboBox.Location = new System.Drawing.Point(6, 100);
            this.labComboBox.Name = "labComboBox";
            this.labComboBox.Size = new System.Drawing.Size(136, 24);
            this.labComboBox.TabIndex = 1;
            this.labComboBox.Text = "Select channel";
            this.labComboBox.SelectedIndexChanged += new System.EventHandler(this.labComboBox_SelectedIndexChanged);
            // 
            // hsvTabPage
            // 
            this.hsvTabPage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.hsvTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hsvTabPage.Controls.Add(this.hsvSaveButton);
            this.hsvTabPage.Controls.Add(this.hsvOutputImgTextBox);
            this.hsvTabPage.Controls.Add(this.hsvOutputFileLabel);
            this.hsvTabPage.Controls.Add(this.hsvOutputImgBox);
            this.hsvTabPage.Controls.Add(this.hsvInputImgBox);
            this.hsvTabPage.Controls.Add(this.hsvLabel);
            this.hsvTabPage.Controls.Add(this.hsvComboBox);
            this.hsvTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hsvTabPage.Location = new System.Drawing.Point(4, 55);
            this.hsvTabPage.Name = "hsvTabPage";
            this.hsvTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hsvTabPage.Size = new System.Drawing.Size(653, 439);
            this.hsvTabPage.TabIndex = 3;
            this.hsvTabPage.Text = "HSV";
            // 
            // hsvSaveButton
            // 
            this.hsvSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hsvSaveButton.Location = new System.Drawing.Point(542, 18);
            this.hsvSaveButton.Name = "hsvSaveButton";
            this.hsvSaveButton.Size = new System.Drawing.Size(94, 26);
            this.hsvSaveButton.TabIndex = 9;
            this.hsvSaveButton.Text = "SAVE";
            this.hsvSaveButton.UseVisualStyleBackColor = true;
            this.hsvSaveButton.Click += new System.EventHandler(this.hsvSaveButton_Click);
            // 
            // hsvOutputImgTextBox
            // 
            this.hsvOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hsvOutputImgTextBox.Location = new System.Drawing.Point(85, 17);
            this.hsvOutputImgTextBox.Name = "hsvOutputImgTextBox";
            this.hsvOutputImgTextBox.ReadOnly = true;
            this.hsvOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.hsvOutputImgTextBox.TabIndex = 8;
            // 
            // hsvOutputFileLabel
            // 
            this.hsvOutputFileLabel.AutoSize = true;
            this.hsvOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hsvOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsvOutputFileLabel.Location = new System.Drawing.Point(2, 19);
            this.hsvOutputFileLabel.Name = "hsvOutputFileLabel";
            this.hsvOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.hsvOutputFileLabel.TabIndex = 7;
            this.hsvOutputFileLabel.Text = "Output file";
            // 
            // hsvOutputImgBox
            // 
            this.hsvOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.hsvOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hsvOutputImgBox.Location = new System.Drawing.Point(342, 130);
            this.hsvOutputImgBox.Name = "hsvOutputImgBox";
            this.hsvOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.hsvOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hsvOutputImgBox.TabIndex = 6;
            this.hsvOutputImgBox.TabStop = false;
            // 
            // hsvInputImgBox
            // 
            this.hsvInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.hsvInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hsvInputImgBox.Location = new System.Drawing.Point(6, 130);
            this.hsvInputImgBox.Name = "hsvInputImgBox";
            this.hsvInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.hsvInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hsvInputImgBox.TabIndex = 5;
            this.hsvInputImgBox.TabStop = false;
            // 
            // hsvLabel
            // 
            this.hsvLabel.AutoSize = true;
            this.hsvLabel.Location = new System.Drawing.Point(7, 72);
            this.hsvLabel.Name = "hsvLabel";
            this.hsvLabel.Size = new System.Drawing.Size(140, 16);
            this.hsvLabel.TabIndex = 4;
            this.hsvLabel.Text = "Available channels";
            // 
            // hsvComboBox
            // 
            this.hsvComboBox.FormattingEnabled = true;
            this.hsvComboBox.Items.AddRange(new object[] {
            "S channel",
            "V channel"});
            this.hsvComboBox.Location = new System.Drawing.Point(6, 100);
            this.hsvComboBox.Name = "hsvComboBox";
            this.hsvComboBox.Size = new System.Drawing.Size(136, 24);
            this.hsvComboBox.TabIndex = 1;
            this.hsvComboBox.Text = "Select channel";
            this.hsvComboBox.SelectedIndexChanged += new System.EventHandler(this.hsvComboBox_SelectedIndexChanged);
            // 
            // gaborTabPage
            // 
            this.gaborTabPage.BackColor = System.Drawing.Color.LemonChiffon;
            this.gaborTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaborTabPage.Controls.Add(gaborSettingsGroupBox);
            this.gaborTabPage.Controls.Add(this.gaborSaveButton);
            this.gaborTabPage.Controls.Add(this.gaborOutputImgTextBox);
            this.gaborTabPage.Controls.Add(this.gaborOutputFileLabel);
            this.gaborTabPage.Controls.Add(this.gaborOutputImgBox);
            this.gaborTabPage.Controls.Add(this.gaborInputImgBox);
            this.gaborTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaborTabPage.Location = new System.Drawing.Point(4, 55);
            this.gaborTabPage.Name = "gaborTabPage";
            this.gaborTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gaborTabPage.Size = new System.Drawing.Size(653, 439);
            this.gaborTabPage.TabIndex = 4;
            this.gaborTabPage.Tag = "";
            this.gaborTabPage.Text = "GABOR FILTER";
            // 
            // gaborSaveButton
            // 
            this.gaborSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaborSaveButton.Location = new System.Drawing.Point(542, 20);
            this.gaborSaveButton.Name = "gaborSaveButton";
            this.gaborSaveButton.Size = new System.Drawing.Size(94, 26);
            this.gaborSaveButton.TabIndex = 9;
            this.gaborSaveButton.Text = "SAVE";
            this.gaborSaveButton.UseVisualStyleBackColor = true;
            this.gaborSaveButton.Click += new System.EventHandler(this.gaborSaveButton_Click);
            // 
            // gaborOutputImgTextBox
            // 
            this.gaborOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaborOutputImgTextBox.Location = new System.Drawing.Point(85, 19);
            this.gaborOutputImgTextBox.Name = "gaborOutputImgTextBox";
            this.gaborOutputImgTextBox.ReadOnly = true;
            this.gaborOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.gaborOutputImgTextBox.TabIndex = 8;
            // 
            // gaborOutputFileLabel
            // 
            this.gaborOutputFileLabel.AutoSize = true;
            this.gaborOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gaborOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gaborOutputFileLabel.Location = new System.Drawing.Point(2, 21);
            this.gaborOutputFileLabel.Name = "gaborOutputFileLabel";
            this.gaborOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.gaborOutputFileLabel.TabIndex = 7;
            this.gaborOutputFileLabel.Text = "Output file";
            // 
            // gaborOutputImgBox
            // 
            this.gaborOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.gaborOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gaborOutputImgBox.Location = new System.Drawing.Point(342, 132);
            this.gaborOutputImgBox.Name = "gaborOutputImgBox";
            this.gaborOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.gaborOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaborOutputImgBox.TabIndex = 6;
            this.gaborOutputImgBox.TabStop = false;
            // 
            // gaborInputImgBox
            // 
            this.gaborInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.gaborInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaborInputImgBox.Location = new System.Drawing.Point(6, 132);
            this.gaborInputImgBox.Name = "gaborInputImgBox";
            this.gaborInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.gaborInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaborInputImgBox.TabIndex = 5;
            this.gaborInputImgBox.TabStop = false;
            // 
            // sobelTabPage
            // 
            this.sobelTabPage.BackColor = System.Drawing.Color.SlateGray;
            this.sobelTabPage.Controls.Add(this.horizontalMaskButton);
            this.sobelTabPage.Controls.Add(this.verticalMaskButton);
            this.sobelTabPage.Controls.Add(this.sobelButton);
            this.sobelTabPage.Controls.Add(this.sobelSaveButton);
            this.sobelTabPage.Controls.Add(this.sobelOutputImgTextBox);
            this.sobelTabPage.Controls.Add(this.sobelOutputFileLabel);
            this.sobelTabPage.Controls.Add(this.sobelOutputImgBox);
            this.sobelTabPage.Controls.Add(this.sobelInputImgBox);
            this.sobelTabPage.Location = new System.Drawing.Point(4, 55);
            this.sobelTabPage.Name = "sobelTabPage";
            this.sobelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sobelTabPage.Size = new System.Drawing.Size(653, 439);
            this.sobelTabPage.TabIndex = 5;
            this.sobelTabPage.Text = "SOBEL FILTER";
            // 
            // horizontalMaskButton
            // 
            this.horizontalMaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.horizontalMaskButton.Location = new System.Drawing.Point(10, 60);
            this.horizontalMaskButton.Name = "horizontalMaskButton";
            this.horizontalMaskButton.Size = new System.Drawing.Size(294, 31);
            this.horizontalMaskButton.TabIndex = 18;
            this.horizontalMaskButton.Text = "HORIZONTAL MASK";
            this.horizontalMaskButton.UseVisualStyleBackColor = true;
            this.horizontalMaskButton.Click += new System.EventHandler(this.horizontalMaskButton_Click);
            // 
            // verticalMaskButton
            // 
            this.verticalMaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verticalMaskButton.Location = new System.Drawing.Point(10, 97);
            this.verticalMaskButton.Name = "verticalMaskButton";
            this.verticalMaskButton.Size = new System.Drawing.Size(294, 31);
            this.verticalMaskButton.TabIndex = 17;
            this.verticalMaskButton.Text = "VERTICAL MASK";
            this.verticalMaskButton.UseVisualStyleBackColor = true;
            this.verticalMaskButton.Click += new System.EventHandler(this.verticalMaskButton_Click);
            // 
            // sobelButton
            // 
            this.sobelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelButton.Location = new System.Drawing.Point(346, 60);
            this.sobelButton.Name = "sobelButton";
            this.sobelButton.Size = new System.Drawing.Size(294, 31);
            this.sobelButton.TabIndex = 13;
            this.sobelButton.Text = "SOBEL FILTER";
            this.sobelButton.UseVisualStyleBackColor = true;
            this.sobelButton.Click += new System.EventHandler(this.sobelButton_Click);
            // 
            // sobelSaveButton
            // 
            this.sobelSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelSaveButton.Location = new System.Drawing.Point(546, 22);
            this.sobelSaveButton.Name = "sobelSaveButton";
            this.sobelSaveButton.Size = new System.Drawing.Size(94, 26);
            this.sobelSaveButton.TabIndex = 12;
            this.sobelSaveButton.Text = "SAVE";
            this.sobelSaveButton.UseVisualStyleBackColor = true;
            this.sobelSaveButton.Click += new System.EventHandler(this.sobelSaveButton_Click);
            // 
            // sobelOutputImgTextBox
            // 
            this.sobelOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelOutputImgTextBox.Location = new System.Drawing.Point(89, 21);
            this.sobelOutputImgTextBox.Name = "sobelOutputImgTextBox";
            this.sobelOutputImgTextBox.ReadOnly = true;
            this.sobelOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.sobelOutputImgTextBox.TabIndex = 11;
            // 
            // sobelOutputFileLabel
            // 
            this.sobelOutputFileLabel.AutoSize = true;
            this.sobelOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sobelOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sobelOutputFileLabel.Location = new System.Drawing.Point(6, 23);
            this.sobelOutputFileLabel.Name = "sobelOutputFileLabel";
            this.sobelOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.sobelOutputFileLabel.TabIndex = 10;
            this.sobelOutputFileLabel.Text = "Output file";
            // 
            // sobelOutputImgBox
            // 
            this.sobelOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.sobelOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sobelOutputImgBox.Location = new System.Drawing.Point(346, 134);
            this.sobelOutputImgBox.Name = "sobelOutputImgBox";
            this.sobelOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.sobelOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sobelOutputImgBox.TabIndex = 8;
            this.sobelOutputImgBox.TabStop = false;
            // 
            // sobelInputImgBox
            // 
            this.sobelInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.sobelInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sobelInputImgBox.Location = new System.Drawing.Point(10, 134);
            this.sobelInputImgBox.Name = "sobelInputImgBox";
            this.sobelInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.sobelInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sobelInputImgBox.TabIndex = 7;
            this.sobelInputImgBox.TabStop = false;
            // 
            // otherFilters
            // 
            this.otherFilters.BackColor = System.Drawing.Color.Peru;
            this.otherFilters.Controls.Add(this.medianButton);
            this.otherFilters.Controls.Add(this.meanButton);
            this.otherFilters.Controls.Add(this.othersFilterSizeBox);
            this.otherFilters.Controls.Add(this.othersFilterSizeLabel);
            this.otherFilters.Controls.Add(this.lowPassFilterButton);
            this.otherFilters.Controls.Add(this.laplacianFilterButton);
            this.otherFilters.Controls.Add(this.lightnessEqualisationButton);
            this.otherFilters.Controls.Add(this.highPassFilterButton);
            this.otherFilters.Controls.Add(this.gausianFilterButton);
            this.otherFilters.Controls.Add(this.otherFiltersSaveButton);
            this.otherFilters.Controls.Add(this.otherFiltersOutputImgTextBox);
            this.otherFilters.Controls.Add(this.filtersOutputFileLabel);
            this.otherFilters.Controls.Add(this.otherFiltersOutputImgBox);
            this.otherFilters.Controls.Add(this.otherFiltersInputImgBox);
            this.otherFilters.Location = new System.Drawing.Point(4, 55);
            this.otherFilters.Name = "otherFilters";
            this.otherFilters.Padding = new System.Windows.Forms.Padding(3);
            this.otherFilters.Size = new System.Drawing.Size(653, 439);
            this.otherFilters.TabIndex = 6;
            this.otherFilters.Text = "OTHER FILTERS";
            // 
            // medianButton
            // 
            this.medianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.medianButton.Location = new System.Drawing.Point(346, 97);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(148, 31);
            this.medianButton.TabIndex = 33;
            this.medianButton.Text = "MEDIAN 3x3";
            this.medianButton.UseVisualStyleBackColor = true;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            // 
            // meanButton
            // 
            this.meanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.meanButton.Location = new System.Drawing.Point(500, 100);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(140, 28);
            this.meanButton.TabIndex = 32;
            this.meanButton.Text = "MEAN";
            this.meanButton.UseVisualStyleBackColor = true;
            this.meanButton.Click += new System.EventHandler(this.meanButton_Click);
            // 
            // othersFilterSizeBox
            // 
            this.othersFilterSizeBox.Location = new System.Drawing.Point(607, 65);
            this.othersFilterSizeBox.Name = "othersFilterSizeBox";
            this.othersFilterSizeBox.Size = new System.Drawing.Size(30, 22);
            this.othersFilterSizeBox.TabIndex = 31;
            this.othersFilterSizeBox.Text = "21";
            this.othersFilterSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // othersFilterSizeLabel
            // 
            this.othersFilterSizeLabel.AutoSize = true;
            this.othersFilterSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.othersFilterSizeLabel.Location = new System.Drawing.Point(543, 71);
            this.othersFilterSizeLabel.Name = "othersFilterSizeLabel";
            this.othersFilterSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.othersFilterSizeLabel.TabIndex = 30;
            this.othersFilterSizeLabel.Text = "filter size";
            // 
            // lowPassFilterButton
            // 
            this.lowPassFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowPassFilterButton.Location = new System.Drawing.Point(10, 100);
            this.lowPassFilterButton.Name = "lowPassFilterButton";
            this.lowPassFilterButton.Size = new System.Drawing.Size(140, 28);
            this.lowPassFilterButton.TabIndex = 29;
            this.lowPassFilterButton.Text = "LOW-PASS FILTER";
            this.lowPassFilterButton.UseVisualStyleBackColor = true;
            this.lowPassFilterButton.Click += new System.EventHandler(this.lowPassFilterButton_Click);
            // 
            // laplacianFilterButton
            // 
            this.laplacianFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laplacianFilterButton.Location = new System.Drawing.Point(168, 64);
            this.laplacianFilterButton.Name = "laplacianFilterButton";
            this.laplacianFilterButton.Size = new System.Drawing.Size(136, 28);
            this.laplacianFilterButton.TabIndex = 27;
            this.laplacianFilterButton.Text = "LAPLACIAN FILTER";
            this.laplacianFilterButton.UseVisualStyleBackColor = true;
            this.laplacianFilterButton.Click += new System.EventHandler(this.laplacianFilterButton_Click);
            // 
            // lightnessEqualisationButton
            // 
            this.lightnessEqualisationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lightnessEqualisationButton.Location = new System.Drawing.Point(346, 63);
            this.lightnessEqualisationButton.Name = "lightnessEqualisationButton";
            this.lightnessEqualisationButton.Size = new System.Drawing.Size(193, 28);
            this.lightnessEqualisationButton.TabIndex = 26;
            this.lightnessEqualisationButton.Text = "LIGHTNESS EQUALISATION";
            this.lightnessEqualisationButton.UseVisualStyleBackColor = true;
            this.lightnessEqualisationButton.Click += new System.EventHandler(this.lightnessEqualisationButton_Click);
            // 
            // highPassFilterButton
            // 
            this.highPassFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highPassFilterButton.Location = new System.Drawing.Point(168, 100);
            this.highPassFilterButton.Name = "highPassFilterButton";
            this.highPassFilterButton.Size = new System.Drawing.Size(136, 28);
            this.highPassFilterButton.TabIndex = 25;
            this.highPassFilterButton.Text = "HIGH-PASS FILTER";
            this.highPassFilterButton.UseVisualStyleBackColor = true;
            this.highPassFilterButton.Click += new System.EventHandler(this.highPassFilterButton_Click);
            // 
            // gausianFilterButton
            // 
            this.gausianFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gausianFilterButton.Location = new System.Drawing.Point(10, 64);
            this.gausianFilterButton.Name = "gausianFilterButton";
            this.gausianFilterButton.Size = new System.Drawing.Size(140, 28);
            this.gausianFilterButton.TabIndex = 24;
            this.gausianFilterButton.Text = "GAUSIAN FILTER";
            this.gausianFilterButton.UseVisualStyleBackColor = true;
            this.gausianFilterButton.Click += new System.EventHandler(this.gausianFilterButton_Click);
            // 
            // otherFiltersSaveButton
            // 
            this.otherFiltersSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otherFiltersSaveButton.Location = new System.Drawing.Point(546, 22);
            this.otherFiltersSaveButton.Name = "otherFiltersSaveButton";
            this.otherFiltersSaveButton.Size = new System.Drawing.Size(94, 26);
            this.otherFiltersSaveButton.TabIndex = 23;
            this.otherFiltersSaveButton.Text = "SAVE";
            this.otherFiltersSaveButton.UseVisualStyleBackColor = true;
            this.otherFiltersSaveButton.Click += new System.EventHandler(this.otherFiltersSaveButton_Click);
            // 
            // otherFiltersOutputImgTextBox
            // 
            this.otherFiltersOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otherFiltersOutputImgTextBox.Location = new System.Drawing.Point(89, 21);
            this.otherFiltersOutputImgTextBox.Name = "otherFiltersOutputImgTextBox";
            this.otherFiltersOutputImgTextBox.ReadOnly = true;
            this.otherFiltersOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.otherFiltersOutputImgTextBox.TabIndex = 22;
            // 
            // filtersOutputFileLabel
            // 
            this.filtersOutputFileLabel.AutoSize = true;
            this.filtersOutputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtersOutputFileLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtersOutputFileLabel.Location = new System.Drawing.Point(6, 21);
            this.filtersOutputFileLabel.Name = "filtersOutputFileLabel";
            this.filtersOutputFileLabel.Size = new System.Drawing.Size(82, 20);
            this.filtersOutputFileLabel.TabIndex = 21;
            this.filtersOutputFileLabel.Text = "Output file";
            // 
            // otherFiltersOutputImgBox
            // 
            this.otherFiltersOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.otherFiltersOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otherFiltersOutputImgBox.Location = new System.Drawing.Point(346, 134);
            this.otherFiltersOutputImgBox.Name = "otherFiltersOutputImgBox";
            this.otherFiltersOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.otherFiltersOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otherFiltersOutputImgBox.TabIndex = 20;
            this.otherFiltersOutputImgBox.TabStop = false;
            // 
            // otherFiltersInputImgBox
            // 
            this.otherFiltersInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.otherFiltersInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherFiltersInputImgBox.Location = new System.Drawing.Point(10, 134);
            this.otherFiltersInputImgBox.Name = "otherFiltersInputImgBox";
            this.otherFiltersInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.otherFiltersInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otherFiltersInputImgBox.TabIndex = 19;
            this.otherFiltersInputImgBox.TabStop = false;
            // 
            // mfrFilteringTab
            // 
            this.mfrFilteringTab.Controls.Add(this.mfrFilteringOutputImgBox);
            this.mfrFilteringTab.Controls.Add(this.mfrFilteringInputImgBox);
            this.mfrFilteringTab.Controls.Add(groupBox1);
            this.mfrFilteringTab.Controls.Add(this.mfrFilteringSaveButton);
            this.mfrFilteringTab.Controls.Add(this.mfrFilteringOutputImgTextBox);
            this.mfrFilteringTab.Controls.Add(this.mfFilteringOutputImgLabel);
            this.mfrFilteringTab.Location = new System.Drawing.Point(4, 55);
            this.mfrFilteringTab.Name = "mfrFilteringTab";
            this.mfrFilteringTab.Padding = new System.Windows.Forms.Padding(3);
            this.mfrFilteringTab.Size = new System.Drawing.Size(653, 439);
            this.mfrFilteringTab.TabIndex = 7;
            this.mfrFilteringTab.Text = "MFR";
            this.mfrFilteringTab.UseVisualStyleBackColor = true;
            // 
            // mfrFilteringOutputImgBox
            // 
            this.mfrFilteringOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.mfrFilteringOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mfrFilteringOutputImgBox.Location = new System.Drawing.Point(349, 127);
            this.mfrFilteringOutputImgBox.Name = "mfrFilteringOutputImgBox";
            this.mfrFilteringOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.mfrFilteringOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mfrFilteringOutputImgBox.TabIndex = 32;
            this.mfrFilteringOutputImgBox.TabStop = false;
            // 
            // mfrFilteringInputImgBox
            // 
            this.mfrFilteringInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.mfrFilteringInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mfrFilteringInputImgBox.Location = new System.Drawing.Point(13, 127);
            this.mfrFilteringInputImgBox.Name = "mfrFilteringInputImgBox";
            this.mfrFilteringInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.mfrFilteringInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mfrFilteringInputImgBox.TabIndex = 31;
            this.mfrFilteringInputImgBox.TabStop = false;
            // 
            // mfrFilteringSaveButton
            // 
            this.mfrFilteringSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mfrFilteringSaveButton.Location = new System.Drawing.Point(549, 15);
            this.mfrFilteringSaveButton.Name = "mfrFilteringSaveButton";
            this.mfrFilteringSaveButton.Size = new System.Drawing.Size(94, 26);
            this.mfrFilteringSaveButton.TabIndex = 29;
            this.mfrFilteringSaveButton.Text = "SAVE";
            this.mfrFilteringSaveButton.UseVisualStyleBackColor = true;
            this.mfrFilteringSaveButton.Click += new System.EventHandler(this.mfrFilteringSaveButton_Click);
            // 
            // mfrFilteringOutputImgTextBox
            // 
            this.mfrFilteringOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mfrFilteringOutputImgTextBox.Location = new System.Drawing.Point(92, 14);
            this.mfrFilteringOutputImgTextBox.Name = "mfrFilteringOutputImgTextBox";
            this.mfrFilteringOutputImgTextBox.ReadOnly = true;
            this.mfrFilteringOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.mfrFilteringOutputImgTextBox.TabIndex = 28;
            // 
            // mfFilteringOutputImgLabel
            // 
            this.mfFilteringOutputImgLabel.AutoSize = true;
            this.mfFilteringOutputImgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mfFilteringOutputImgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mfFilteringOutputImgLabel.Location = new System.Drawing.Point(9, 16);
            this.mfFilteringOutputImgLabel.Name = "mfFilteringOutputImgLabel";
            this.mfFilteringOutputImgLabel.Size = new System.Drawing.Size(82, 20);
            this.mfFilteringOutputImgLabel.TabIndex = 27;
            this.mfFilteringOutputImgLabel.Text = "Output file";
            // 
            // contrastTabPage
            // 
            this.contrastTabPage.Controls.Add(groupBox2);
            this.contrastTabPage.Controls.Add(this.contrastSaveButton);
            this.contrastTabPage.Controls.Add(this.contrastOutputImgTextBox);
            this.contrastTabPage.Controls.Add(this.contrastLabel);
            this.contrastTabPage.Controls.Add(this.contrastOutputImgBox);
            this.contrastTabPage.Controls.Add(this.contrastInputImgBox);
            this.contrastTabPage.Location = new System.Drawing.Point(4, 55);
            this.contrastTabPage.Name = "contrastTabPage";
            this.contrastTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contrastTabPage.Size = new System.Drawing.Size(653, 439);
            this.contrastTabPage.TabIndex = 8;
            this.contrastTabPage.Text = "CONTRAST";
            this.contrastTabPage.UseVisualStyleBackColor = true;
            // 
            // contrastSaveButton
            // 
            this.contrastSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastSaveButton.Location = new System.Drawing.Point(549, 15);
            this.contrastSaveButton.Name = "contrastSaveButton";
            this.contrastSaveButton.Size = new System.Drawing.Size(94, 26);
            this.contrastSaveButton.TabIndex = 23;
            this.contrastSaveButton.Text = "SAVE";
            this.contrastSaveButton.UseVisualStyleBackColor = true;
            this.contrastSaveButton.Click += new System.EventHandler(this.contrastSaveButton_Click);
            // 
            // contrastOutputImgTextBox
            // 
            this.contrastOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastOutputImgTextBox.Location = new System.Drawing.Point(92, 14);
            this.contrastOutputImgTextBox.Name = "contrastOutputImgTextBox";
            this.contrastOutputImgTextBox.ReadOnly = true;
            this.contrastOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.contrastOutputImgTextBox.TabIndex = 22;
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contrastLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contrastLabel.Location = new System.Drawing.Point(9, 16);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(82, 20);
            this.contrastLabel.TabIndex = 21;
            this.contrastLabel.Text = "Output file";
            // 
            // contrastOutputImgBox
            // 
            this.contrastOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.contrastOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contrastOutputImgBox.Location = new System.Drawing.Point(349, 127);
            this.contrastOutputImgBox.Name = "contrastOutputImgBox";
            this.contrastOutputImgBox.Size = new System.Drawing.Size(294, 298);
            this.contrastOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastOutputImgBox.TabIndex = 20;
            this.contrastOutputImgBox.TabStop = false;
            // 
            // contrastInputImgBox
            // 
            this.contrastInputImgBox.BackColor = System.Drawing.Color.Linen;
            this.contrastInputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrastInputImgBox.Location = new System.Drawing.Point(13, 127);
            this.contrastInputImgBox.Name = "contrastInputImgBox";
            this.contrastInputImgBox.Size = new System.Drawing.Size(294, 298);
            this.contrastInputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastInputImgBox.TabIndex = 19;
            this.contrastInputImgBox.TabStop = false;
            // 
            // experimentTabPage
            // 
            this.experimentTabPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.experimentTabPage.Controls.Add(this.experimentOutputImgBox);
            this.experimentTabPage.Controls.Add(this.E4Button);
            this.experimentTabPage.Controls.Add(this.E3Button);
            this.experimentTabPage.Controls.Add(this.E2Button);
            this.experimentTabPage.Controls.Add(this.E1Button);
            this.experimentTabPage.Controls.Add(this.D4Button);
            this.experimentTabPage.Controls.Add(this.D3Button);
            this.experimentTabPage.Controls.Add(this.D2Button);
            this.experimentTabPage.Controls.Add(this.D1Button);
            this.experimentTabPage.Controls.Add(this.C4Button);
            this.experimentTabPage.Controls.Add(this.C3Button);
            this.experimentTabPage.Controls.Add(this.C2Button);
            this.experimentTabPage.Controls.Add(this.C1Button);
            this.experimentTabPage.Controls.Add(this.B4Button);
            this.experimentTabPage.Controls.Add(this.B3Button);
            this.experimentTabPage.Controls.Add(this.B2Button);
            this.experimentTabPage.Controls.Add(this.B1Button);
            this.experimentTabPage.Controls.Add(this.A4Button);
            this.experimentTabPage.Controls.Add(this.A3Button);
            this.experimentTabPage.Controls.Add(this.A2Button);
            this.experimentTabPage.Controls.Add(this.A1Button);
            this.experimentTabPage.Controls.Add(this.F4Button);
            this.experimentTabPage.Controls.Add(this.F3Button);
            this.experimentTabPage.Controls.Add(this.F2Button);
            this.experimentTabPage.Controls.Add(this.F1Button);
            this.experimentTabPage.Controls.Add(this.experimentSaveButton);
            this.experimentTabPage.Controls.Add(this.experimentOutputImgTextBox);
            this.experimentTabPage.Controls.Add(this.experimentLabel);
            this.experimentTabPage.Controls.Add(this.experimentImgBox);
            this.experimentTabPage.Location = new System.Drawing.Point(4, 55);
            this.experimentTabPage.Name = "experimentTabPage";
            this.experimentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.experimentTabPage.Size = new System.Drawing.Size(653, 439);
            this.experimentTabPage.TabIndex = 9;
            this.experimentTabPage.Text = "EXPERIMENT";
            // 
            // experimentOutputImgBox
            // 
            this.experimentOutputImgBox.BackColor = System.Drawing.Color.Linen;
            this.experimentOutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.experimentOutputImgBox.Location = new System.Drawing.Point(331, 162);
            this.experimentOutputImgBox.Name = "experimentOutputImgBox";
            this.experimentOutputImgBox.Size = new System.Drawing.Size(307, 271);
            this.experimentOutputImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.experimentOutputImgBox.TabIndex = 85;
            this.experimentOutputImgBox.TabStop = false;
            // 
            // E4Button
            // 
            this.E4Button.Location = new System.Drawing.Point(259, 121);
            this.E4Button.Name = "E4Button";
            this.E4Button.Size = new System.Drawing.Size(60, 30);
            this.E4Button.TabIndex = 84;
            this.E4Button.Text = "E4";
            this.A1toolTip.SetToolTip(this.E4Button, "Filtering steps:\r\nOhta2 channel\r\nmedian filter\r\ncontrast enhancement\r\nLaplacian F" +
        "ilter\r\n");
            this.E4Button.UseVisualStyleBackColor = true;
            this.E4Button.Click += new System.EventHandler(this.E4Button_Click);
            // 
            // E3Button
            // 
            this.E3Button.Location = new System.Drawing.Point(193, 121);
            this.E3Button.Name = "E3Button";
            this.E3Button.Size = new System.Drawing.Size(60, 30);
            this.E3Button.TabIndex = 83;
            this.E3Button.Text = "E3";
            this.A1toolTip.SetToolTip(this.E3Button, "Filtering steps:\r\nOhta2 channel\r\nmedian filter\r\ncontrast enhancement\r\nSobel Filte" +
        "r");
            this.E3Button.UseVisualStyleBackColor = true;
            this.E3Button.Click += new System.EventHandler(this.E3Button_Click);
            // 
            // E2Button
            // 
            this.E2Button.Location = new System.Drawing.Point(127, 121);
            this.E2Button.Name = "E2Button";
            this.E2Button.Size = new System.Drawing.Size(60, 30);
            this.E2Button.TabIndex = 82;
            this.E2Button.Text = "E2";
            this.A1toolTip.SetToolTip(this.E2Button, "Filtering steps:\r\nOhta2 channel\r\nmedian filter\r\ncontrast enhancement\r\nGabor Filte" +
        "r");
            this.E2Button.UseVisualStyleBackColor = true;
            this.E2Button.Click += new System.EventHandler(this.E2Button_Click);
            // 
            // E1Button
            // 
            this.E1Button.Location = new System.Drawing.Point(61, 121);
            this.E1Button.Name = "E1Button";
            this.E1Button.Size = new System.Drawing.Size(60, 30);
            this.E1Button.TabIndex = 81;
            this.E1Button.Text = "E1";
            this.A1toolTip.SetToolTip(this.E1Button, "Filtering steps:\r\nOhta2 channel\r\nmedian filter\r\ncontrast enhancement\r\nMFR");
            this.E1Button.UseVisualStyleBackColor = true;
            this.E1Button.Click += new System.EventHandler(this.E1Button_Click);
            // 
            // D4Button
            // 
            this.D4Button.Location = new System.Drawing.Point(524, 85);
            this.D4Button.Name = "D4Button";
            this.D4Button.Size = new System.Drawing.Size(60, 30);
            this.D4Button.TabIndex = 80;
            this.D4Button.Text = "D4";
            this.A1toolTip.SetToolTip(this.D4Button, "Filtering steps:\r\nOhta1 channel\r\nmedian filter\r\ncontrast enhancement\r\nLaplacian F" +
        "ilter");
            this.D4Button.UseVisualStyleBackColor = true;
            this.D4Button.Click += new System.EventHandler(this.D4Button_Click);
            // 
            // D3Button
            // 
            this.D3Button.Location = new System.Drawing.Point(458, 85);
            this.D3Button.Name = "D3Button";
            this.D3Button.Size = new System.Drawing.Size(60, 30);
            this.D3Button.TabIndex = 79;
            this.D3Button.Text = "D3";
            this.A1toolTip.SetToolTip(this.D3Button, "Filtering steps:\r\nOhta1 channel\r\nmedian filter\r\ncontrast enhancement\r\nSobel Filte" +
        "r");
            this.D3Button.UseVisualStyleBackColor = true;
            this.D3Button.Click += new System.EventHandler(this.D3Button_Click);
            // 
            // D2Button
            // 
            this.D2Button.Location = new System.Drawing.Point(392, 85);
            this.D2Button.Name = "D2Button";
            this.D2Button.Size = new System.Drawing.Size(60, 30);
            this.D2Button.TabIndex = 78;
            this.D2Button.Text = "D2";
            this.A1toolTip.SetToolTip(this.D2Button, "Filtering steps:\r\nOhta1 channel\r\nmedian filter\r\ncontrast enhancement\r\nGabor Filte" +
        "r");
            this.D2Button.UseVisualStyleBackColor = true;
            this.D2Button.Click += new System.EventHandler(this.D2Button_Click);
            // 
            // D1Button
            // 
            this.D1Button.Location = new System.Drawing.Point(326, 85);
            this.D1Button.Name = "D1Button";
            this.D1Button.Size = new System.Drawing.Size(60, 30);
            this.D1Button.TabIndex = 77;
            this.D1Button.Text = "D1";
            this.A1toolTip.SetToolTip(this.D1Button, "Filtering steps:\r\nOhta1 channel\r\nmedian filter\r\ncontrast enhancement\r\nMFR\r\n");
            this.D1Button.UseVisualStyleBackColor = true;
            this.D1Button.Click += new System.EventHandler(this.D1Button_Click);
            // 
            // C4Button
            // 
            this.C4Button.Location = new System.Drawing.Point(259, 85);
            this.C4Button.Name = "C4Button";
            this.C4Button.Size = new System.Drawing.Size(60, 30);
            this.C4Button.TabIndex = 76;
            this.C4Button.Text = "C4";
            this.A1toolTip.SetToolTip(this.C4Button, "Filtering steps:\r\nV channel (HSV)\r\nmedian filter\r\ncontrast enhancement\r\nLaplacian" +
        " Filter");
            this.C4Button.UseVisualStyleBackColor = true;
            this.C4Button.Click += new System.EventHandler(this.C4Button_Click);
            // 
            // C3Button
            // 
            this.C3Button.Location = new System.Drawing.Point(193, 85);
            this.C3Button.Name = "C3Button";
            this.C3Button.Size = new System.Drawing.Size(60, 30);
            this.C3Button.TabIndex = 75;
            this.C3Button.Text = "C3";
            this.A1toolTip.SetToolTip(this.C3Button, "Filtering steps:\r\nV channel (HSV)\r\nmedian filter\r\ncontrast enhancement\r\nSobel Fil" +
        "ter");
            this.C3Button.UseVisualStyleBackColor = true;
            this.C3Button.Click += new System.EventHandler(this.C3Button_Click);
            // 
            // C2Button
            // 
            this.C2Button.Location = new System.Drawing.Point(127, 85);
            this.C2Button.Name = "C2Button";
            this.C2Button.Size = new System.Drawing.Size(60, 30);
            this.C2Button.TabIndex = 74;
            this.C2Button.Text = "C2";
            this.A1toolTip.SetToolTip(this.C2Button, "Filtering steps:\r\nV channel (HSV)\r\nmedian filter\r\ncontrast enhancement\r\nGabor Fil" +
        "ter");
            this.C2Button.UseVisualStyleBackColor = true;
            this.C2Button.Click += new System.EventHandler(this.C2Button_Click);
            // 
            // C1Button
            // 
            this.C1Button.Location = new System.Drawing.Point(61, 85);
            this.C1Button.Name = "C1Button";
            this.C1Button.Size = new System.Drawing.Size(60, 30);
            this.C1Button.TabIndex = 73;
            this.C1Button.Text = "C1";
            this.A1toolTip.SetToolTip(this.C1Button, "Filtering steps:\r\nV channel (HSV)\r\nmedian filter\r\ncontrast enhancement\r\nMFR");
            this.C1Button.UseVisualStyleBackColor = true;
            this.C1Button.Click += new System.EventHandler(this.C1Button_Click);
            // 
            // B4Button
            // 
            this.B4Button.Location = new System.Drawing.Point(524, 49);
            this.B4Button.Name = "B4Button";
            this.B4Button.Size = new System.Drawing.Size(60, 30);
            this.B4Button.TabIndex = 72;
            this.B4Button.Text = "B4";
            this.A1toolTip.SetToolTip(this.B4Button, "Filtering steps:\r\nG channel (RGB)\r\nmedian filter\r\ncontrast enhancement\r\nLaplacian" +
        " Filter");
            this.B4Button.UseVisualStyleBackColor = true;
            this.B4Button.Click += new System.EventHandler(this.B4Button_Click);
            // 
            // B3Button
            // 
            this.B3Button.Location = new System.Drawing.Point(458, 49);
            this.B3Button.Name = "B3Button";
            this.B3Button.Size = new System.Drawing.Size(60, 30);
            this.B3Button.TabIndex = 71;
            this.B3Button.Text = "B3";
            this.A1toolTip.SetToolTip(this.B3Button, "Filtering steps:\r\nG channel (RGB)\r\nmedian filter\r\ncontrast enhancement\r\nSobel Fil" +
        "ter");
            this.B3Button.UseVisualStyleBackColor = true;
            this.B3Button.Click += new System.EventHandler(this.B3Button_Click);
            // 
            // B2Button
            // 
            this.B2Button.Location = new System.Drawing.Point(392, 49);
            this.B2Button.Name = "B2Button";
            this.B2Button.Size = new System.Drawing.Size(60, 30);
            this.B2Button.TabIndex = 70;
            this.B2Button.Text = "B2";
            this.A1toolTip.SetToolTip(this.B2Button, "Filtering steps:\r\nG channel (RGB)\r\nmedian filter\r\ncontrast enhancement\r\nGabor Fil" +
        "ter");
            this.B2Button.UseVisualStyleBackColor = true;
            this.B2Button.Click += new System.EventHandler(this.B2Button_Click);
            // 
            // B1Button
            // 
            this.B1Button.Location = new System.Drawing.Point(326, 49);
            this.B1Button.Name = "B1Button";
            this.B1Button.Size = new System.Drawing.Size(60, 30);
            this.B1Button.TabIndex = 69;
            this.B1Button.Text = "B1";
            this.A1toolTip.SetToolTip(this.B1Button, "Filtering steps:\r\nG channel (RGB)\r\nmedian filter\r\ncontrast enhancement\r\nMFR\r\n");
            this.B1Button.UseVisualStyleBackColor = true;
            this.B1Button.Click += new System.EventHandler(this.B1Button_Click);
            // 
            // A4Button
            // 
            this.A4Button.Location = new System.Drawing.Point(259, 49);
            this.A4Button.Name = "A4Button";
            this.A4Button.Size = new System.Drawing.Size(60, 30);
            this.A4Button.TabIndex = 68;
            this.A4Button.Text = "A4";
            this.A1toolTip.SetToolTip(this.A4Button, "Filtering steps:\r\na* channel (L*a*b*)\r\nmedian filter\r\ncontrast enhancement\r\nLapla" +
        "cian Filter\r\n");
            this.A4Button.UseVisualStyleBackColor = true;
            this.A4Button.Click += new System.EventHandler(this.A4Button_Click);
            // 
            // A3Button
            // 
            this.A3Button.Location = new System.Drawing.Point(193, 49);
            this.A3Button.Name = "A3Button";
            this.A3Button.Size = new System.Drawing.Size(60, 30);
            this.A3Button.TabIndex = 67;
            this.A3Button.Text = "A3";
            this.A1toolTip.SetToolTip(this.A3Button, "Filtering steps:\r\na* channel (L*a*b*)\r\nmedian filter\r\ncontrast enhancement\r\nSobel" +
        " Filter\r\n");
            this.A3Button.UseVisualStyleBackColor = true;
            this.A3Button.Click += new System.EventHandler(this.A3Button_Click);
            // 
            // A2Button
            // 
            this.A2Button.Location = new System.Drawing.Point(127, 49);
            this.A2Button.Name = "A2Button";
            this.A2Button.Size = new System.Drawing.Size(60, 30);
            this.A2Button.TabIndex = 66;
            this.A2Button.Text = "A2";
            this.A1toolTip.SetToolTip(this.A2Button, "Filtering steps:\r\na* channel (L*a*b*)\r\nmedian filter\r\ncontrast enhancement\r\nGabor" +
        " Filter\r\n");
            this.A2Button.UseVisualStyleBackColor = true;
            this.A2Button.Click += new System.EventHandler(this.A2Button_Click);
            // 
            // A1Button
            // 
            this.A1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.A1Button.FlatAppearance.BorderSize = 3;
            this.A1Button.Location = new System.Drawing.Point(61, 49);
            this.A1Button.Name = "A1Button";
            this.A1Button.Size = new System.Drawing.Size(60, 30);
            this.A1Button.TabIndex = 65;
            this.A1Button.Tag = "";
            this.A1Button.Text = "A1";
            this.A1toolTip.SetToolTip(this.A1Button, "Filtering steps:\r\na* channel (L*a*b*)\r\nmedian filter\r\ncontrast enhancement\r\nMFR");
            this.A1Button.UseVisualStyleBackColor = true;
            this.A1Button.Click += new System.EventHandler(this.A1Button_Click);
            // 
            // F4Button
            // 
            this.F4Button.Location = new System.Drawing.Point(524, 121);
            this.F4Button.Name = "F4Button";
            this.F4Button.Size = new System.Drawing.Size(60, 30);
            this.F4Button.TabIndex = 60;
            this.F4Button.Text = "F4";
            this.A1toolTip.SetToolTip(this.F4Button, "Filtering steps:\r\nOhta3 channel\r\nmedian filter\r\ncontrast enhancement\r\nLaplacian F" +
        "ilter");
            this.F4Button.UseVisualStyleBackColor = true;
            this.F4Button.Click += new System.EventHandler(this.F4Button_Click);
            // 
            // F3Button
            // 
            this.F3Button.Location = new System.Drawing.Point(458, 121);
            this.F3Button.Name = "F3Button";
            this.F3Button.Size = new System.Drawing.Size(60, 30);
            this.F3Button.TabIndex = 59;
            this.F3Button.Text = "F3";
            this.A1toolTip.SetToolTip(this.F3Button, "Filtering steps:\r\nOhta3 channel\r\nmedian filter\r\ncontrast enhancement\r\nSobel Filte" +
        "r");
            this.F3Button.UseVisualStyleBackColor = true;
            this.F3Button.Click += new System.EventHandler(this.F3Button_Click);
            // 
            // F2Button
            // 
            this.F2Button.Location = new System.Drawing.Point(392, 121);
            this.F2Button.Name = "F2Button";
            this.F2Button.Size = new System.Drawing.Size(60, 30);
            this.F2Button.TabIndex = 58;
            this.F2Button.Text = "F2";
            this.A1toolTip.SetToolTip(this.F2Button, "Filtering steps:\r\nOhta5 channel\r\nmedian filter\r\ncontrast enhancement\r\nGabor Filte" +
        "r");
            this.F2Button.UseVisualStyleBackColor = true;
            this.F2Button.Click += new System.EventHandler(this.F2Button_Click);
            // 
            // F1Button
            // 
            this.F1Button.Location = new System.Drawing.Point(326, 121);
            this.F1Button.Name = "F1Button";
            this.F1Button.Size = new System.Drawing.Size(60, 30);
            this.F1Button.TabIndex = 57;
            this.F1Button.Text = "F1";
            this.A1toolTip.SetToolTip(this.F1Button, "Filtering steps:\r\nOhta3 channel\r\nmedian filter\r\ncontrast enhancement\r\nMFR");
            this.F1Button.UseVisualStyleBackColor = true;
            this.F1Button.Click += new System.EventHandler(this.F1Button_Click);
            // 
            // experimentSaveButton
            // 
            this.experimentSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.experimentSaveButton.Location = new System.Drawing.Point(554, 16);
            this.experimentSaveButton.Name = "experimentSaveButton";
            this.experimentSaveButton.Size = new System.Drawing.Size(94, 26);
            this.experimentSaveButton.TabIndex = 48;
            this.experimentSaveButton.Text = "SAVE";
            this.experimentSaveButton.UseVisualStyleBackColor = true;
            this.experimentSaveButton.Click += new System.EventHandler(this.experimentSaveButton_Click);
            // 
            // experimentOutputImgTextBox
            // 
            this.experimentOutputImgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.experimentOutputImgTextBox.Location = new System.Drawing.Point(97, 15);
            this.experimentOutputImgTextBox.Name = "experimentOutputImgTextBox";
            this.experimentOutputImgTextBox.ReadOnly = true;
            this.experimentOutputImgTextBox.Size = new System.Drawing.Size(450, 26);
            this.experimentOutputImgTextBox.TabIndex = 47;
            // 
            // experimentLabel
            // 
            this.experimentLabel.AutoSize = true;
            this.experimentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.experimentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.experimentLabel.Location = new System.Drawing.Point(14, 17);
            this.experimentLabel.Name = "experimentLabel";
            this.experimentLabel.Size = new System.Drawing.Size(82, 20);
            this.experimentLabel.TabIndex = 46;
            this.experimentLabel.Text = "Output file";
            // 
            // experimentImgBox
            // 
            this.experimentImgBox.BackColor = System.Drawing.Color.Linen;
            this.experimentImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.experimentImgBox.Location = new System.Drawing.Point(10, 162);
            this.experimentImgBox.Name = "experimentImgBox";
            this.experimentImgBox.Size = new System.Drawing.Size(307, 271);
            this.experimentImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.experimentImgBox.TabIndex = 20;
            this.experimentImgBox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadButton.Location = new System.Drawing.Point(559, 20);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(94, 26);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTextBox.Location = new System.Drawing.Point(102, 20);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(450, 26);
            this.inputTextBox.TabIndex = 3;
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFileLabel.Location = new System.Drawing.Point(22, 23);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(70, 20);
            this.inputFileLabel.TabIndex = 5;
            this.inputFileLabel.Text = "Input file";
            // 
            // storeAsColorCheckBox
            // 
            this.storeAsColorCheckBox.AutoSize = true;
            this.storeAsColorCheckBox.Location = new System.Drawing.Point(102, 55);
            this.storeAsColorCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.storeAsColorCheckBox.Name = "storeAsColorCheckBox";
            this.storeAsColorCheckBox.Size = new System.Drawing.Size(167, 17);
            this.storeAsColorCheckBox.TabIndex = 8;
            this.storeAsColorCheckBox.Text = "Store as color, where possible";
            this.storeAsColorCheckBox.UseVisualStyleBackColor = true;
            this.storeAsColorCheckBox.CheckedChanged += new System.EventHandler(this.storeAsColorCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 581);
            this.Controls.Add(this.storeAsColorCheckBox);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.channelsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "IMAGinE";
            gaborSettingsGroupBox.ResumeLayout(false);
            gaborSettingsGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.channelsTabControl.ResumeLayout(false);
            this.rgbTabPage.ResumeLayout(false);
            this.rgbTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbInputImgBox)).EndInit();
            this.ohtaTabPage.ResumeLayout(false);
            this.ohtaTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ohtaOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohtaInputImgBox)).EndInit();
            this.labTabPage.ResumeLayout(false);
            this.labTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labInputImgBox)).EndInit();
            this.hsvTabPage.ResumeLayout(false);
            this.hsvTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hsvOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvInputImgBox)).EndInit();
            this.gaborTabPage.ResumeLayout(false);
            this.gaborTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaborOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaborInputImgBox)).EndInit();
            this.sobelTabPage.ResumeLayout(false);
            this.sobelTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobelOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobelInputImgBox)).EndInit();
            this.otherFilters.ResumeLayout(false);
            this.otherFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherFiltersOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherFiltersInputImgBox)).EndInit();
            this.mfrFilteringTab.ResumeLayout(false);
            this.mfrFilteringTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfrFilteringOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfrFilteringInputImgBox)).EndInit();
            this.contrastTabPage.ResumeLayout(false);
            this.contrastTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastInputImgBox)).EndInit();
            this.experimentTabPage.ResumeLayout(false);
            this.experimentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experimentOutputImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl channelsTabControl;
        private System.Windows.Forms.TabPage rgbTabPage;
        private System.Windows.Forms.PictureBox rgbOutputImgBox;
        private System.Windows.Forms.PictureBox rgbInputImgBox;
        private System.Windows.Forms.ComboBox rgbComboBox;
        private System.Windows.Forms.TabPage ohtaTabPage;
        private System.Windows.Forms.TabPage labTabPage;
        private System.Windows.Forms.TabPage hsvTabPage;
        private System.Windows.Forms.TabPage gaborTabPage;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button rgbSaveButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputImgTextBox;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label rgbOutputFileLabel;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.PictureBox ohtaOutputImgBox;
        private System.Windows.Forms.PictureBox ohtaInputImgBox;
        private System.Windows.Forms.Label ohtaLabel;
        private System.Windows.Forms.ComboBox ohtaComboBox;
        private System.Windows.Forms.PictureBox labOutputImgBox;
        private System.Windows.Forms.PictureBox labInputImgBox;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.ComboBox labComboBox;
        private System.Windows.Forms.PictureBox hsvOutputImgBox;
        private System.Windows.Forms.PictureBox hsvInputImgBox;
        private System.Windows.Forms.Label hsvLabel;
        private System.Windows.Forms.ComboBox hsvComboBox;
        private System.Windows.Forms.PictureBox gaborOutputImgBox;
        private System.Windows.Forms.PictureBox gaborInputImgBox;
        private System.Windows.Forms.Button ohtSaveButton;
        private System.Windows.Forms.TextBox ohtaOutputImgTextBox;
        private System.Windows.Forms.Label ohtaOutputFileLabel;
        private System.Windows.Forms.Button labSaveButton;
        private System.Windows.Forms.TextBox labOutputImgTextBox;
        private System.Windows.Forms.Label labOutputFileLabel;
        private System.Windows.Forms.Button hsvSaveButton;
        private System.Windows.Forms.TextBox hsvOutputImgTextBox;
        private System.Windows.Forms.Label hsvOutputFileLabel;
        private System.Windows.Forms.Button gaborSaveButton;
        private System.Windows.Forms.TextBox gaborOutputImgTextBox;
        private System.Windows.Forms.Label gaborOutputFileLabel;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label sigmaLabel;
        private System.Windows.Forms.Label numberOfFiltersLabel;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.Button gaborButton;
        private System.Windows.Forms.TextBox sigmaTextBox;
        private System.Windows.Forms.TextBox numberOfFiltersTextBox;
        private System.Windows.Forms.TextBox lambdaTextBox;
        private System.Windows.Forms.TextBox psiTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox gammaTextBox;
        private System.Windows.Forms.Label psiLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TabPage sobelTabPage;
        private System.Windows.Forms.Button sobelSaveButton;
        private System.Windows.Forms.TextBox sobelOutputImgTextBox;
        private System.Windows.Forms.Label sobelOutputFileLabel;
        private System.Windows.Forms.PictureBox sobelOutputImgBox;
        private System.Windows.Forms.PictureBox sobelInputImgBox;
        private System.Windows.Forms.Button sobelButton;
        private System.Windows.Forms.Button horizontalMaskButton;
        private System.Windows.Forms.Button verticalMaskButton;
        private System.Windows.Forms.TabPage otherFilters;
        private System.Windows.Forms.Button laplacianFilterButton;
        private System.Windows.Forms.Button lightnessEqualisationButton;
        private System.Windows.Forms.Button highPassFilterButton;
        private System.Windows.Forms.Button gausianFilterButton;
        private System.Windows.Forms.Button otherFiltersSaveButton;
        private System.Windows.Forms.TextBox otherFiltersOutputImgTextBox;
        private System.Windows.Forms.Label filtersOutputFileLabel;
        private System.Windows.Forms.PictureBox otherFiltersOutputImgBox;
        private System.Windows.Forms.PictureBox otherFiltersInputImgBox;
        private System.Windows.Forms.TabPage mfrFilteringTab;
        private System.Windows.Forms.PictureBox mfrFilteringOutputImgBox;
        private System.Windows.Forms.PictureBox mfrFilteringInputImgBox;
        private System.Windows.Forms.Label mfrFixedSegmentLengthLabel;
        private System.Windows.Forms.Label mfrFilterSizeLabel;
        private System.Windows.Forms.TextBox mfrSigmaTruncationTextBox;
        private System.Windows.Forms.TextBox mfrSigmaTextBox;
        private System.Windows.Forms.TextBox mfrNumberOfFiltersTextBox;
        private System.Windows.Forms.TextBox mfrScalingFactorTextBox;
        private System.Windows.Forms.TextBox mfrFixedSegmentLengthTextBox;
        private System.Windows.Forms.TextBox mfrFilterSizeTextBox;
        private System.Windows.Forms.Label mfrSigmaTruncationLabel;
        private System.Windows.Forms.Label mfrSigmaLabel;
        private System.Windows.Forms.Label mfrNumberOfFiltersLabel;
        private System.Windows.Forms.Label mfrScalingFactorLabel;
        private System.Windows.Forms.Button mfrFilteringStartButton;
        private System.Windows.Forms.Button mfrFilteringSaveButton;
        private System.Windows.Forms.TextBox mfrFilteringOutputImgTextBox;
        private System.Windows.Forms.Label mfFilteringOutputImgLabel;
        private System.Windows.Forms.CheckBox storeAsColorCheckBox;
        private System.Windows.Forms.Button lowPassFilterButton;
        private System.Windows.Forms.TabPage contrastTabPage;
        private System.Windows.Forms.Button contrastSaveButton;
        private System.Windows.Forms.TextBox contrastOutputImgTextBox;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.PictureBox contrastOutputImgBox;
        private System.Windows.Forms.PictureBox contrastInputImgBox;
        private System.Windows.Forms.TabPage experimentTabPage;
        private System.Windows.Forms.Button experimentSaveButton;
        private System.Windows.Forms.TextBox experimentOutputImgTextBox;
        private System.Windows.Forms.Label experimentLabel;
        private System.Windows.Forms.ToolTip A1toolTip;
        private System.Windows.Forms.TextBox othersFilterSizeBox;
        private System.Windows.Forms.Label othersFilterSizeLabel;
        private System.Windows.Forms.Label contrastFilterSizeLabel;
        private System.Windows.Forms.Button contrastButton;
        private System.Windows.Forms.TextBox contrastFilterSizeTextBox;
        private System.Windows.Forms.PictureBox experimentOutputImgBox;
        private System.Windows.Forms.Button E4Button;
        private System.Windows.Forms.Button E3Button;
        private System.Windows.Forms.Button E2Button;
        private System.Windows.Forms.Button E1Button;
        private System.Windows.Forms.Button D4Button;
        private System.Windows.Forms.Button D3Button;
        private System.Windows.Forms.Button D2Button;
        private System.Windows.Forms.Button D1Button;
        private System.Windows.Forms.Button C4Button;
        private System.Windows.Forms.Button C3Button;
        private System.Windows.Forms.Button C2Button;
        private System.Windows.Forms.Button C1Button;
        private System.Windows.Forms.Button B4Button;
        private System.Windows.Forms.Button B3Button;
        private System.Windows.Forms.Button B2Button;
        private System.Windows.Forms.Button B1Button;
        private System.Windows.Forms.Button A4Button;
        private System.Windows.Forms.Button A3Button;
        private System.Windows.Forms.Button A2Button;
        private System.Windows.Forms.Button A1Button;
        private System.Windows.Forms.Button F4Button;
        private System.Windows.Forms.Button F3Button;
        private System.Windows.Forms.Button F2Button;
        private System.Windows.Forms.Button F1Button;
        private System.Windows.Forms.PictureBox experimentImgBox;
        private System.Windows.Forms.Label contrastValueLabel;
        private System.Windows.Forms.TextBox contrastValueTextBox;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.Button medianButton;
    }
}

