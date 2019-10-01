namespace FicheDePosteGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionTestButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.GenerateTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.DPSIdLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DPSIdTextBox = new System.Windows.Forms.TextBox();
            this.TeamNumberTextBox = new System.Windows.Forms.TextBox();
            this.MealCheckBox = new System.Windows.Forms.CheckBox();
            this.LocalCheckBox = new System.Windows.Forms.CheckBox();
            this.TeamNumberLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PapsCheckBox = new System.Windows.Forms.CheckBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MealDietPageTab = new System.Windows.Forms.TabPage();
            this.DietProgressBar = new System.Windows.Forms.ProgressBar();
            this.generateDietSheetButton = new System.Windows.Forms.Button();
            this.DietFileLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dietReferenceButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MatchingTabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamNumberPdfTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MealPdfTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalPdfTextBox = new System.Windows.Forms.TextBox();
            this.PapsPdfTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TimePdfTextBox = new System.Windows.Forms.TextBox();
            this.TimeExcelTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DatePdfTextBox = new System.Windows.Forms.TextBox();
            this.DateExcelTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlacePdfTextBox = new System.Windows.Forms.TextBox();
            this.PlaceExcelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EventPdfTextBox = new System.Windows.Forms.TextBox();
            this.EventExcelTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrganizerPdfTextBox = new System.Windows.Forms.TextBox();
            this.OrganizerExcelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openDietReferenceFile = new System.Windows.Forms.OpenFileDialog();
            this.SettingsTabPage.SuspendLayout();
            this.GenerateTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.MealDietPageTab.SuspendLayout();
            this.MatchingTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.saveSettingsButton);
            this.SettingsTabPage.Controls.Add(this.ConnectionStatusLabel);
            this.SettingsTabPage.Controls.Add(this.ConnectionTestButton);
            this.SettingsTabPage.Controls.Add(this.PasswordLabel);
            this.SettingsTabPage.Controls.Add(this.LoginLabel);
            this.SettingsTabPage.Controls.Add(this.PasswordTextBox);
            this.SettingsTabPage.Controls.Add(this.LoginTextBox);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(401, 214);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Options";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveSettingsButton.Location = new System.Drawing.Point(9, 162);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(384, 31);
            this.saveSettingsButton.TabIndex = 6;
            this.saveSettingsButton.Text = "Sauvegarder";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(290, 111);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(53, 13);
            this.ConnectionStatusLabel.TabIndex = 5;
            this.ConnectionStatusLabel.Text = "Non testé";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionTestButton
            // 
            this.ConnectionTestButton.Location = new System.Drawing.Point(9, 106);
            this.ConnectionTestButton.Name = "ConnectionTestButton";
            this.ConnectionTestButton.Size = new System.Drawing.Size(120, 23);
            this.ConnectionTestButton.TabIndex = 4;
            this.ConnectionTestButton.Text = "Tester la connexion";
            this.ConnectionTestButton.UseVisualStyleBackColor = true;
            this.ConnectionTestButton.Click += new System.EventHandler(this.ConnectionTestButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 65);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(6, 16);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(53, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Identifiant";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(239, 62);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(154, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(239, 16);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(154, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // GenerateTabPage
            // 
            this.GenerateTabPage.Controls.Add(this.label1);
            this.GenerateTabPage.Controls.Add(this.DPSIdLabel);
            this.GenerateTabPage.Controls.Add(this.ProgressBar);
            this.GenerateTabPage.Controls.Add(this.DPSIdTextBox);
            this.GenerateTabPage.Controls.Add(this.TeamNumberTextBox);
            this.GenerateTabPage.Controls.Add(this.MealCheckBox);
            this.GenerateTabPage.Controls.Add(this.LocalCheckBox);
            this.GenerateTabPage.Controls.Add(this.TeamNumberLabel);
            this.GenerateTabPage.Controls.Add(this.GenerateButton);
            this.GenerateTabPage.Controls.Add(this.PapsCheckBox);
            this.GenerateTabPage.Location = new System.Drawing.Point(4, 22);
            this.GenerateTabPage.Name = "GenerateTabPage";
            this.GenerateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GenerateTabPage.Size = new System.Drawing.Size(401, 214);
            this.GenerateTabPage.TabIndex = 0;
            this.GenerateTabPage.Text = "Générer";
            this.GenerateTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Autres paramètres : ";
            // 
            // DPSIdLabel
            // 
            this.DPSIdLabel.AutoSize = true;
            this.DPSIdLabel.Location = new System.Drawing.Point(8, 19);
            this.DPSIdLabel.Name = "DPSIdLabel";
            this.DPSIdLabel.Size = new System.Drawing.Size(44, 13);
            this.DPSIdLabel.TabIndex = 6;
            this.DPSIdLabel.Text = "N° DPS";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(11, 188);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(382, 20);
            this.ProgressBar.TabIndex = 11;
            this.ProgressBar.UseWaitCursor = true;
            // 
            // DPSIdTextBox
            // 
            this.DPSIdTextBox.Location = new System.Drawing.Point(239, 16);
            this.DPSIdTextBox.Name = "DPSIdTextBox";
            this.DPSIdTextBox.Size = new System.Drawing.Size(154, 20);
            this.DPSIdTextBox.TabIndex = 1;
            this.DPSIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TeamNumberTextBox
            // 
            this.TeamNumberTextBox.Location = new System.Drawing.Point(239, 62);
            this.TeamNumberTextBox.Name = "TeamNumberTextBox";
            this.TeamNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.TeamNumberTextBox.TabIndex = 3;
            this.TeamNumberTextBox.Text = "0";
            this.TeamNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MealCheckBox
            // 
            this.MealCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MealCheckBox.AutoSize = true;
            this.MealCheckBox.Location = new System.Drawing.Point(293, 106);
            this.MealCheckBox.Name = "MealCheckBox";
            this.MealCheckBox.Size = new System.Drawing.Size(48, 23);
            this.MealCheckBox.TabIndex = 9;
            this.MealCheckBox.Text = "Repas";
            this.MealCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MealCheckBox.UseVisualStyleBackColor = true;
            // 
            // LocalCheckBox
            // 
            this.LocalCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LocalCheckBox.AutoSize = true;
            this.LocalCheckBox.Location = new System.Drawing.Point(350, 106);
            this.LocalCheckBox.Name = "LocalCheckBox";
            this.LocalCheckBox.Size = new System.Drawing.Size(43, 23);
            this.LocalCheckBox.TabIndex = 10;
            this.LocalCheckBox.Text = "Local";
            this.LocalCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LocalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TeamNumberLabel
            // 
            this.TeamNumberLabel.AutoSize = true;
            this.TeamNumberLabel.Location = new System.Drawing.Point(8, 65);
            this.TeamNumberLabel.Name = "TeamNumberLabel";
            this.TeamNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.TeamNumberLabel.TabIndex = 7;
            this.TeamNumberLabel.Text = "Nombre d\'équipe";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.ForestGreen;
            this.GenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenerateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.GenerateButton.Location = new System.Drawing.Point(11, 153);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(382, 29);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Générer";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PapsCheckBox
            // 
            this.PapsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PapsCheckBox.AutoSize = true;
            this.PapsCheckBox.Location = new System.Drawing.Point(239, 106);
            this.PapsCheckBox.Name = "PapsCheckBox";
            this.PapsCheckBox.Size = new System.Drawing.Size(45, 23);
            this.PapsCheckBox.TabIndex = 8;
            this.PapsCheckBox.Text = "PAPS";
            this.PapsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PapsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.GenerateTabPage);
            this.TabControl.Controls.Add(this.MealDietPageTab);
            this.TabControl.Controls.Add(this.SettingsTabPage);
            this.TabControl.Controls.Add(this.MatchingTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(409, 240);
            this.TabControl.TabIndex = 12;
            // 
            // MealDietPageTab
            // 
            this.MealDietPageTab.Controls.Add(this.DietProgressBar);
            this.MealDietPageTab.Controls.Add(this.generateDietSheetButton);
            this.MealDietPageTab.Controls.Add(this.DietFileLabel);
            this.MealDietPageTab.Controls.Add(this.label16);
            this.MealDietPageTab.Controls.Add(this.label15);
            this.MealDietPageTab.Controls.Add(this.label14);
            this.MealDietPageTab.Controls.Add(this.dietReferenceButton);
            this.MealDietPageTab.Controls.Add(this.endDatePicker);
            this.MealDietPageTab.Controls.Add(this.startDatePicker);
            this.MealDietPageTab.Location = new System.Drawing.Point(4, 22);
            this.MealDietPageTab.Name = "MealDietPageTab";
            this.MealDietPageTab.Size = new System.Drawing.Size(401, 214);
            this.MealDietPageTab.TabIndex = 3;
            this.MealDietPageTab.Text = "Régime Alimentaire";
            this.MealDietPageTab.UseVisualStyleBackColor = true;
            // 
            // DietProgressBar
            // 
            this.DietProgressBar.Location = new System.Drawing.Point(11, 186);
            this.DietProgressBar.Name = "DietProgressBar";
            this.DietProgressBar.Size = new System.Drawing.Size(382, 20);
            this.DietProgressBar.TabIndex = 12;
            this.DietProgressBar.UseWaitCursor = true;
            // 
            // generateDietSheetButton
            // 
            this.generateDietSheetButton.BackColor = System.Drawing.Color.ForestGreen;
            this.generateDietSheetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generateDietSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.generateDietSheetButton.FlatAppearance.BorderSize = 0;
            this.generateDietSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateDietSheetButton.ForeColor = System.Drawing.SystemColors.Window;
            this.generateDietSheetButton.Location = new System.Drawing.Point(11, 151);
            this.generateDietSheetButton.Name = "generateDietSheetButton";
            this.generateDietSheetButton.Size = new System.Drawing.Size(382, 29);
            this.generateDietSheetButton.TabIndex = 7;
            this.generateDietSheetButton.Text = "Générer";
            this.generateDietSheetButton.UseVisualStyleBackColor = false;
            this.generateDietSheetButton.Click += new System.EventHandler(this.generateDietSheetButton_Click);
            // 
            // DietFileLabel
            // 
            this.DietFileLabel.AutoSize = true;
            this.DietFileLabel.Location = new System.Drawing.Point(56, 124);
            this.DietFileLabel.Name = "DietFileLabel";
            this.DietFileLabel.Size = new System.Drawing.Size(41, 13);
            this.DietFileLabel.TabIndex = 6;
            this.DietFileLabel.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fichier de référence";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Date de fin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Date de début";
            // 
            // dietReferenceButton
            // 
            this.dietReferenceButton.Location = new System.Drawing.Point(318, 97);
            this.dietReferenceButton.Name = "dietReferenceButton";
            this.dietReferenceButton.Size = new System.Drawing.Size(75, 23);
            this.dietReferenceButton.TabIndex = 2;
            this.dietReferenceButton.Text = "Ouvrir";
            this.dietReferenceButton.UseVisualStyleBackColor = true;
            this.dietReferenceButton.Click += new System.EventHandler(this.dietReferenceButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(193, 56);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(193, 18);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // MatchingTabPage
            // 
            this.MatchingTabPage.Controls.Add(this.label11);
            this.MatchingTabPage.Controls.Add(this.label12);
            this.MatchingTabPage.Controls.Add(this.label13);
            this.MatchingTabPage.Controls.Add(this.label4);
            this.MatchingTabPage.Controls.Add(this.TeamNumberPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.label10);
            this.MatchingTabPage.Controls.Add(this.MealPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.label3);
            this.MatchingTabPage.Controls.Add(this.LocalPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.PapsPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.label9);
            this.MatchingTabPage.Controls.Add(this.TimePdfTextBox);
            this.MatchingTabPage.Controls.Add(this.TimeExcelTextBox);
            this.MatchingTabPage.Controls.Add(this.label8);
            this.MatchingTabPage.Controls.Add(this.DatePdfTextBox);
            this.MatchingTabPage.Controls.Add(this.DateExcelTextBox);
            this.MatchingTabPage.Controls.Add(this.label7);
            this.MatchingTabPage.Controls.Add(this.PlacePdfTextBox);
            this.MatchingTabPage.Controls.Add(this.PlaceExcelTextBox);
            this.MatchingTabPage.Controls.Add(this.label6);
            this.MatchingTabPage.Controls.Add(this.EventPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.EventExcelTextBox);
            this.MatchingTabPage.Controls.Add(this.label5);
            this.MatchingTabPage.Controls.Add(this.OrganizerPdfTextBox);
            this.MatchingTabPage.Controls.Add(this.OrganizerExcelTextBox);
            this.MatchingTabPage.Controls.Add(this.label2);
            this.MatchingTabPage.Location = new System.Drawing.Point(4, 22);
            this.MatchingTabPage.Name = "MatchingTabPage";
            this.MatchingTabPage.Size = new System.Drawing.Size(401, 214);
            this.MatchingTabPage.TabIndex = 2;
            this.MatchingTabPage.Text = "Correspondances";
            this.MatchingTabPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(6, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(387, 2);
            this.label11.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pdf";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Excel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Local";
            // 
            // TeamNumberPdfTextBox
            // 
            this.TeamNumberPdfTextBox.Location = new System.Drawing.Point(293, 159);
            this.TeamNumberPdfTextBox.Name = "TeamNumberPdfTextBox";
            this.TeamNumberPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.TeamNumberPdfTextBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Equipe";
            // 
            // MealPdfTextBox
            // 
            this.MealPdfTextBox.Location = new System.Drawing.Point(69, 185);
            this.MealPdfTextBox.Name = "MealPdfTextBox";
            this.MealPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.MealPdfTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Repas";
            // 
            // LocalPdfTextBox
            // 
            this.LocalPdfTextBox.Location = new System.Drawing.Point(293, 185);
            this.LocalPdfTextBox.Name = "LocalPdfTextBox";
            this.LocalPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.LocalPdfTextBox.TabIndex = 22;
            // 
            // PapsPdfTextBox
            // 
            this.PapsPdfTextBox.Location = new System.Drawing.Point(69, 159);
            this.PapsPdfTextBox.Name = "PapsPdfTextBox";
            this.PapsPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.PapsPdfTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Paps";
            // 
            // TimePdfTextBox
            // 
            this.TimePdfTextBox.Location = new System.Drawing.Point(293, 127);
            this.TimePdfTextBox.Name = "TimePdfTextBox";
            this.TimePdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimePdfTextBox.TabIndex = 16;
            // 
            // TimeExcelTextBox
            // 
            this.TimeExcelTextBox.Location = new System.Drawing.Point(187, 127);
            this.TimeExcelTextBox.Name = "TimeExcelTextBox";
            this.TimeExcelTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeExcelTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Horaire";
            // 
            // DatePdfTextBox
            // 
            this.DatePdfTextBox.Location = new System.Drawing.Point(293, 101);
            this.DatePdfTextBox.Name = "DatePdfTextBox";
            this.DatePdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.DatePdfTextBox.TabIndex = 13;
            // 
            // DateExcelTextBox
            // 
            this.DateExcelTextBox.Location = new System.Drawing.Point(187, 101);
            this.DateExcelTextBox.Name = "DateExcelTextBox";
            this.DateExcelTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateExcelTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date";
            // 
            // PlacePdfTextBox
            // 
            this.PlacePdfTextBox.Location = new System.Drawing.Point(293, 75);
            this.PlacePdfTextBox.Name = "PlacePdfTextBox";
            this.PlacePdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlacePdfTextBox.TabIndex = 10;
            // 
            // PlaceExcelTextBox
            // 
            this.PlaceExcelTextBox.Location = new System.Drawing.Point(187, 75);
            this.PlaceExcelTextBox.Name = "PlaceExcelTextBox";
            this.PlaceExcelTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlaceExcelTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lieu";
            // 
            // EventPdfTextBox
            // 
            this.EventPdfTextBox.Location = new System.Drawing.Point(293, 49);
            this.EventPdfTextBox.Name = "EventPdfTextBox";
            this.EventPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.EventPdfTextBox.TabIndex = 7;
            // 
            // EventExcelTextBox
            // 
            this.EventExcelTextBox.Location = new System.Drawing.Point(187, 49);
            this.EventExcelTextBox.Name = "EventExcelTextBox";
            this.EventExcelTextBox.Size = new System.Drawing.Size(100, 20);
            this.EventExcelTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manifestation";
            // 
            // OrganizerPdfTextBox
            // 
            this.OrganizerPdfTextBox.Location = new System.Drawing.Point(293, 23);
            this.OrganizerPdfTextBox.Name = "OrganizerPdfTextBox";
            this.OrganizerPdfTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrganizerPdfTextBox.TabIndex = 2;
            // 
            // OrganizerExcelTextBox
            // 
            this.OrganizerExcelTextBox.Location = new System.Drawing.Point(187, 23);
            this.OrganizerExcelTextBox.Name = "OrganizerExcelTextBox";
            this.OrganizerExcelTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrganizerExcelTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Organisateur";
            // 
            // openDietReferenceFile
            // 
            this.openDietReferenceFile.DefaultExt = "xlsx";
            this.openDietReferenceFile.Filter = "\"Excel Files|*.xls;*.xlsx;*.xlsm\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(409, 240);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur Fiche de Poste";
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.GenerateTabPage.ResumeLayout(false);
            this.GenerateTabPage.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.MealDietPageTab.ResumeLayout(false);
            this.MealDietPageTab.PerformLayout();
            this.MatchingTabPage.ResumeLayout(false);
            this.MatchingTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.Button ConnectionTestButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TabPage GenerateTabPage;
        private System.Windows.Forms.Label DPSIdLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox DPSIdTextBox;
        private System.Windows.Forms.TextBox TeamNumberTextBox;
        private System.Windows.Forms.CheckBox MealCheckBox;
        private System.Windows.Forms.CheckBox LocalCheckBox;
        private System.Windows.Forms.Label TeamNumberLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox PapsCheckBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage MatchingTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrganizerPdfTextBox;
        private System.Windows.Forms.TextBox OrganizerExcelTextBox;
        private System.Windows.Forms.TextBox TimePdfTextBox;
        private System.Windows.Forms.TextBox TimeExcelTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DatePdfTextBox;
        private System.Windows.Forms.TextBox DateExcelTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PlacePdfTextBox;
        private System.Windows.Forms.TextBox PlaceExcelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EventPdfTextBox;
        private System.Windows.Forms.TextBox EventExcelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PapsPdfTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TeamNumberPdfTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MealPdfTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LocalPdfTextBox;
        private System.Windows.Forms.TabPage MealDietPageTab;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button dietReferenceButton;
        private System.Windows.Forms.OpenFileDialog openDietReferenceFile;
        private System.Windows.Forms.Label DietFileLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar DietProgressBar;
        private System.Windows.Forms.Button generateDietSheetButton;
    }
}

