namespace Calculator
{
    partial class registerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            ageLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Province = new DataGridViewTextBoxColumn();
            District = new DataGridViewTextBoxColumn();
            registerFormBindingSource = new BindingSource(components);
            acceptButtonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autoScrollDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            autoSizeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            autoSizeModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autoValidateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            backColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formBorderStyleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cancelButtonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            controlBoxDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            helpButtonDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            iconDataGridViewImageColumn = new DataGridViewImageColumn();
            isMdiContainerDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            keyPreviewDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maximumSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mainMenuStripDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minimumSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maximizeBoxDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            minimizeBoxDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            opacityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rightToLeftLayoutDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            showInTaskbarDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            showIconDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeGripStyleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            topMostDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            transparencyKeyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            windowStateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autoScrollMarginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autoScrollMinSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessibleDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessibleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessibleRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allowDropDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            anchorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            backgroundImageDataGridViewImageColumn = new DataGridViewImageColumn();
            backgroundImageLayoutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            causesValidationDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            contextMenuStripDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cursorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataBindingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enabledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fontDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foreColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rightToLeftDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            useWaitCursorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            visibleDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            paddingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imeModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 1;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(85, 67);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(39, 20);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            ageLabel.Click += label2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(159, 67);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 114);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Province:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bagmati", "Gandaki" });
            comboBox1.Location = new Point(159, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 204);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Skills:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Java", "JavaScript" });
            checkedListBox1.Location = new Point(159, 204);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(202, 48);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 166);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "District";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(159, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(142, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 284);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Age, Province, District, acceptButtonDataGridViewTextBoxColumn, autoScrollDataGridViewCheckBoxColumn, autoSizeDataGridViewCheckBoxColumn, autoSizeModeDataGridViewTextBoxColumn, autoValidateDataGridViewTextBoxColumn, backColorDataGridViewTextBoxColumn, formBorderStyleDataGridViewTextBoxColumn, cancelButtonDataGridViewTextBoxColumn, controlBoxDataGridViewCheckBoxColumn, helpButtonDataGridViewCheckBoxColumn, iconDataGridViewImageColumn, isMdiContainerDataGridViewCheckBoxColumn, keyPreviewDataGridViewCheckBoxColumn, locationDataGridViewTextBoxColumn, maximumSizeDataGridViewTextBoxColumn, mainMenuStripDataGridViewTextBoxColumn, minimumSizeDataGridViewTextBoxColumn, maximizeBoxDataGridViewCheckBoxColumn, mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn, minimizeBoxDataGridViewCheckBoxColumn, opacityDataGridViewTextBoxColumn, rightToLeftLayoutDataGridViewCheckBoxColumn, showInTaskbarDataGridViewCheckBoxColumn, showIconDataGridViewCheckBoxColumn, sizeDataGridViewTextBoxColumn, sizeGripStyleDataGridViewTextBoxColumn, startPositionDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, topMostDataGridViewCheckBoxColumn, transparencyKeyDataGridViewTextBoxColumn, windowStateDataGridViewTextBoxColumn, autoScrollMarginDataGridViewTextBoxColumn, autoScrollMinSizeDataGridViewTextBoxColumn, accessibleDescriptionDataGridViewTextBoxColumn, accessibleNameDataGridViewTextBoxColumn, accessibleRoleDataGridViewTextBoxColumn, allowDropDataGridViewCheckBoxColumn, anchorDataGridViewTextBoxColumn, backgroundImageDataGridViewImageColumn, backgroundImageLayoutDataGridViewTextBoxColumn, causesValidationDataGridViewCheckBoxColumn, contextMenuStripDataGridViewTextBoxColumn, cursorDataGridViewTextBoxColumn, dataBindingsDataGridViewTextBoxColumn, dockDataGridViewTextBoxColumn, enabledDataGridViewCheckBoxColumn, fontDataGridViewTextBoxColumn, foreColorDataGridViewTextBoxColumn, rightToLeftDataGridViewTextBoxColumn, tagDataGridViewTextBoxColumn, useWaitCursorDataGridViewCheckBoxColumn, visibleDataGridViewCheckBoxColumn, paddingDataGridViewTextBoxColumn, imeModeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = registerFormBindingSource;
            dataGridView1.Location = new Point(506, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(690, 288);
            dataGridView1.TabIndex = 12;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // Province
            // 
            Province.HeaderText = "Province";
            Province.MinimumWidth = 6;
            Province.Name = "Province";
            Province.Width = 125;
            // 
            // District
            // 
            District.HeaderText = "District";
            District.MinimumWidth = 6;
            District.Name = "District";
            District.Width = 125;
            // 
            // registerFormBindingSource
            // 
            registerFormBindingSource.DataSource = typeof(registerForm);
            // 
            // acceptButtonDataGridViewTextBoxColumn
            // 
            acceptButtonDataGridViewTextBoxColumn.DataPropertyName = "AcceptButton";
            acceptButtonDataGridViewTextBoxColumn.HeaderText = "AcceptButton";
            acceptButtonDataGridViewTextBoxColumn.MinimumWidth = 6;
            acceptButtonDataGridViewTextBoxColumn.Name = "acceptButtonDataGridViewTextBoxColumn";
            acceptButtonDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoScrollDataGridViewCheckBoxColumn
            // 
            autoScrollDataGridViewCheckBoxColumn.DataPropertyName = "AutoScroll";
            autoScrollDataGridViewCheckBoxColumn.HeaderText = "AutoScroll";
            autoScrollDataGridViewCheckBoxColumn.MinimumWidth = 6;
            autoScrollDataGridViewCheckBoxColumn.Name = "autoScrollDataGridViewCheckBoxColumn";
            autoScrollDataGridViewCheckBoxColumn.Width = 125;
            // 
            // autoSizeDataGridViewCheckBoxColumn
            // 
            autoSizeDataGridViewCheckBoxColumn.DataPropertyName = "AutoSize";
            autoSizeDataGridViewCheckBoxColumn.HeaderText = "AutoSize";
            autoSizeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            autoSizeDataGridViewCheckBoxColumn.Name = "autoSizeDataGridViewCheckBoxColumn";
            autoSizeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // autoSizeModeDataGridViewTextBoxColumn
            // 
            autoSizeModeDataGridViewTextBoxColumn.DataPropertyName = "AutoSizeMode";
            autoSizeModeDataGridViewTextBoxColumn.HeaderText = "AutoSizeMode";
            autoSizeModeDataGridViewTextBoxColumn.MinimumWidth = 6;
            autoSizeModeDataGridViewTextBoxColumn.Name = "autoSizeModeDataGridViewTextBoxColumn";
            autoSizeModeDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoValidateDataGridViewTextBoxColumn
            // 
            autoValidateDataGridViewTextBoxColumn.DataPropertyName = "AutoValidate";
            autoValidateDataGridViewTextBoxColumn.HeaderText = "AutoValidate";
            autoValidateDataGridViewTextBoxColumn.MinimumWidth = 6;
            autoValidateDataGridViewTextBoxColumn.Name = "autoValidateDataGridViewTextBoxColumn";
            autoValidateDataGridViewTextBoxColumn.Width = 125;
            // 
            // backColorDataGridViewTextBoxColumn
            // 
            backColorDataGridViewTextBoxColumn.DataPropertyName = "BackColor";
            backColorDataGridViewTextBoxColumn.HeaderText = "BackColor";
            backColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            backColorDataGridViewTextBoxColumn.Name = "backColorDataGridViewTextBoxColumn";
            backColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // formBorderStyleDataGridViewTextBoxColumn
            // 
            formBorderStyleDataGridViewTextBoxColumn.DataPropertyName = "FormBorderStyle";
            formBorderStyleDataGridViewTextBoxColumn.HeaderText = "FormBorderStyle";
            formBorderStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            formBorderStyleDataGridViewTextBoxColumn.Name = "formBorderStyleDataGridViewTextBoxColumn";
            formBorderStyleDataGridViewTextBoxColumn.Width = 125;
            // 
            // cancelButtonDataGridViewTextBoxColumn
            // 
            cancelButtonDataGridViewTextBoxColumn.DataPropertyName = "CancelButton";
            cancelButtonDataGridViewTextBoxColumn.HeaderText = "CancelButton";
            cancelButtonDataGridViewTextBoxColumn.MinimumWidth = 6;
            cancelButtonDataGridViewTextBoxColumn.Name = "cancelButtonDataGridViewTextBoxColumn";
            cancelButtonDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlBoxDataGridViewCheckBoxColumn
            // 
            controlBoxDataGridViewCheckBoxColumn.DataPropertyName = "ControlBox";
            controlBoxDataGridViewCheckBoxColumn.HeaderText = "ControlBox";
            controlBoxDataGridViewCheckBoxColumn.MinimumWidth = 6;
            controlBoxDataGridViewCheckBoxColumn.Name = "controlBoxDataGridViewCheckBoxColumn";
            controlBoxDataGridViewCheckBoxColumn.Width = 125;
            // 
            // helpButtonDataGridViewCheckBoxColumn
            // 
            helpButtonDataGridViewCheckBoxColumn.DataPropertyName = "HelpButton";
            helpButtonDataGridViewCheckBoxColumn.HeaderText = "HelpButton";
            helpButtonDataGridViewCheckBoxColumn.MinimumWidth = 6;
            helpButtonDataGridViewCheckBoxColumn.Name = "helpButtonDataGridViewCheckBoxColumn";
            helpButtonDataGridViewCheckBoxColumn.Width = 125;
            // 
            // iconDataGridViewImageColumn
            // 
            iconDataGridViewImageColumn.DataPropertyName = "Icon";
            iconDataGridViewImageColumn.HeaderText = "Icon";
            iconDataGridViewImageColumn.MinimumWidth = 6;
            iconDataGridViewImageColumn.Name = "iconDataGridViewImageColumn";
            iconDataGridViewImageColumn.Width = 125;
            // 
            // isMdiContainerDataGridViewCheckBoxColumn
            // 
            isMdiContainerDataGridViewCheckBoxColumn.DataPropertyName = "IsMdiContainer";
            isMdiContainerDataGridViewCheckBoxColumn.HeaderText = "IsMdiContainer";
            isMdiContainerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isMdiContainerDataGridViewCheckBoxColumn.Name = "isMdiContainerDataGridViewCheckBoxColumn";
            isMdiContainerDataGridViewCheckBoxColumn.Width = 125;
            // 
            // keyPreviewDataGridViewCheckBoxColumn
            // 
            keyPreviewDataGridViewCheckBoxColumn.DataPropertyName = "KeyPreview";
            keyPreviewDataGridViewCheckBoxColumn.HeaderText = "KeyPreview";
            keyPreviewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            keyPreviewDataGridViewCheckBoxColumn.Name = "keyPreviewDataGridViewCheckBoxColumn";
            keyPreviewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // maximumSizeDataGridViewTextBoxColumn
            // 
            maximumSizeDataGridViewTextBoxColumn.DataPropertyName = "MaximumSize";
            maximumSizeDataGridViewTextBoxColumn.HeaderText = "MaximumSize";
            maximumSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            maximumSizeDataGridViewTextBoxColumn.Name = "maximumSizeDataGridViewTextBoxColumn";
            maximumSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainMenuStripDataGridViewTextBoxColumn
            // 
            mainMenuStripDataGridViewTextBoxColumn.DataPropertyName = "MainMenuStrip";
            mainMenuStripDataGridViewTextBoxColumn.HeaderText = "MainMenuStrip";
            mainMenuStripDataGridViewTextBoxColumn.MinimumWidth = 6;
            mainMenuStripDataGridViewTextBoxColumn.Name = "mainMenuStripDataGridViewTextBoxColumn";
            mainMenuStripDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimumSizeDataGridViewTextBoxColumn
            // 
            minimumSizeDataGridViewTextBoxColumn.DataPropertyName = "MinimumSize";
            minimumSizeDataGridViewTextBoxColumn.HeaderText = "MinimumSize";
            minimumSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            minimumSizeDataGridViewTextBoxColumn.Name = "minimumSizeDataGridViewTextBoxColumn";
            minimumSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // maximizeBoxDataGridViewCheckBoxColumn
            // 
            maximizeBoxDataGridViewCheckBoxColumn.DataPropertyName = "MaximizeBox";
            maximizeBoxDataGridViewCheckBoxColumn.HeaderText = "MaximizeBox";
            maximizeBoxDataGridViewCheckBoxColumn.MinimumWidth = 6;
            maximizeBoxDataGridViewCheckBoxColumn.Name = "maximizeBoxDataGridViewCheckBoxColumn";
            maximizeBoxDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn
            // 
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn.DataPropertyName = "MdiChildrenMinimizedAnchorBottom";
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn.HeaderText = "MdiChildrenMinimizedAnchorBottom";
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn.MinimumWidth = 6;
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn.Name = "mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn";
            mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn.Width = 125;
            // 
            // minimizeBoxDataGridViewCheckBoxColumn
            // 
            minimizeBoxDataGridViewCheckBoxColumn.DataPropertyName = "MinimizeBox";
            minimizeBoxDataGridViewCheckBoxColumn.HeaderText = "MinimizeBox";
            minimizeBoxDataGridViewCheckBoxColumn.MinimumWidth = 6;
            minimizeBoxDataGridViewCheckBoxColumn.Name = "minimizeBoxDataGridViewCheckBoxColumn";
            minimizeBoxDataGridViewCheckBoxColumn.Width = 125;
            // 
            // opacityDataGridViewTextBoxColumn
            // 
            opacityDataGridViewTextBoxColumn.DataPropertyName = "Opacity";
            opacityDataGridViewTextBoxColumn.HeaderText = "Opacity";
            opacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            opacityDataGridViewTextBoxColumn.Name = "opacityDataGridViewTextBoxColumn";
            opacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // rightToLeftLayoutDataGridViewCheckBoxColumn
            // 
            rightToLeftLayoutDataGridViewCheckBoxColumn.DataPropertyName = "RightToLeftLayout";
            rightToLeftLayoutDataGridViewCheckBoxColumn.HeaderText = "RightToLeftLayout";
            rightToLeftLayoutDataGridViewCheckBoxColumn.MinimumWidth = 6;
            rightToLeftLayoutDataGridViewCheckBoxColumn.Name = "rightToLeftLayoutDataGridViewCheckBoxColumn";
            rightToLeftLayoutDataGridViewCheckBoxColumn.Width = 125;
            // 
            // showInTaskbarDataGridViewCheckBoxColumn
            // 
            showInTaskbarDataGridViewCheckBoxColumn.DataPropertyName = "ShowInTaskbar";
            showInTaskbarDataGridViewCheckBoxColumn.HeaderText = "ShowInTaskbar";
            showInTaskbarDataGridViewCheckBoxColumn.MinimumWidth = 6;
            showInTaskbarDataGridViewCheckBoxColumn.Name = "showInTaskbarDataGridViewCheckBoxColumn";
            showInTaskbarDataGridViewCheckBoxColumn.Width = 125;
            // 
            // showIconDataGridViewCheckBoxColumn
            // 
            showIconDataGridViewCheckBoxColumn.DataPropertyName = "ShowIcon";
            showIconDataGridViewCheckBoxColumn.HeaderText = "ShowIcon";
            showIconDataGridViewCheckBoxColumn.MinimumWidth = 6;
            showIconDataGridViewCheckBoxColumn.Name = "showIconDataGridViewCheckBoxColumn";
            showIconDataGridViewCheckBoxColumn.Width = 125;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            sizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeGripStyleDataGridViewTextBoxColumn
            // 
            sizeGripStyleDataGridViewTextBoxColumn.DataPropertyName = "SizeGripStyle";
            sizeGripStyleDataGridViewTextBoxColumn.HeaderText = "SizeGripStyle";
            sizeGripStyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            sizeGripStyleDataGridViewTextBoxColumn.Name = "sizeGripStyleDataGridViewTextBoxColumn";
            sizeGripStyleDataGridViewTextBoxColumn.Width = 125;
            // 
            // startPositionDataGridViewTextBoxColumn
            // 
            startPositionDataGridViewTextBoxColumn.DataPropertyName = "StartPosition";
            startPositionDataGridViewTextBoxColumn.HeaderText = "StartPosition";
            startPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            startPositionDataGridViewTextBoxColumn.Name = "startPositionDataGridViewTextBoxColumn";
            startPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.MinimumWidth = 6;
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.Width = 125;
            // 
            // topMostDataGridViewCheckBoxColumn
            // 
            topMostDataGridViewCheckBoxColumn.DataPropertyName = "TopMost";
            topMostDataGridViewCheckBoxColumn.HeaderText = "TopMost";
            topMostDataGridViewCheckBoxColumn.MinimumWidth = 6;
            topMostDataGridViewCheckBoxColumn.Name = "topMostDataGridViewCheckBoxColumn";
            topMostDataGridViewCheckBoxColumn.Width = 125;
            // 
            // transparencyKeyDataGridViewTextBoxColumn
            // 
            transparencyKeyDataGridViewTextBoxColumn.DataPropertyName = "TransparencyKey";
            transparencyKeyDataGridViewTextBoxColumn.HeaderText = "TransparencyKey";
            transparencyKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            transparencyKeyDataGridViewTextBoxColumn.Name = "transparencyKeyDataGridViewTextBoxColumn";
            transparencyKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // windowStateDataGridViewTextBoxColumn
            // 
            windowStateDataGridViewTextBoxColumn.DataPropertyName = "WindowState";
            windowStateDataGridViewTextBoxColumn.HeaderText = "WindowState";
            windowStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            windowStateDataGridViewTextBoxColumn.Name = "windowStateDataGridViewTextBoxColumn";
            windowStateDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoScrollMarginDataGridViewTextBoxColumn
            // 
            autoScrollMarginDataGridViewTextBoxColumn.DataPropertyName = "AutoScrollMargin";
            autoScrollMarginDataGridViewTextBoxColumn.HeaderText = "AutoScrollMargin";
            autoScrollMarginDataGridViewTextBoxColumn.MinimumWidth = 6;
            autoScrollMarginDataGridViewTextBoxColumn.Name = "autoScrollMarginDataGridViewTextBoxColumn";
            autoScrollMarginDataGridViewTextBoxColumn.Width = 125;
            // 
            // autoScrollMinSizeDataGridViewTextBoxColumn
            // 
            autoScrollMinSizeDataGridViewTextBoxColumn.DataPropertyName = "AutoScrollMinSize";
            autoScrollMinSizeDataGridViewTextBoxColumn.HeaderText = "AutoScrollMinSize";
            autoScrollMinSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            autoScrollMinSizeDataGridViewTextBoxColumn.Name = "autoScrollMinSizeDataGridViewTextBoxColumn";
            autoScrollMinSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessibleDescriptionDataGridViewTextBoxColumn
            // 
            accessibleDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AccessibleDescription";
            accessibleDescriptionDataGridViewTextBoxColumn.HeaderText = "AccessibleDescription";
            accessibleDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            accessibleDescriptionDataGridViewTextBoxColumn.Name = "accessibleDescriptionDataGridViewTextBoxColumn";
            accessibleDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessibleNameDataGridViewTextBoxColumn
            // 
            accessibleNameDataGridViewTextBoxColumn.DataPropertyName = "AccessibleName";
            accessibleNameDataGridViewTextBoxColumn.HeaderText = "AccessibleName";
            accessibleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            accessibleNameDataGridViewTextBoxColumn.Name = "accessibleNameDataGridViewTextBoxColumn";
            accessibleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accessibleRoleDataGridViewTextBoxColumn
            // 
            accessibleRoleDataGridViewTextBoxColumn.DataPropertyName = "AccessibleRole";
            accessibleRoleDataGridViewTextBoxColumn.HeaderText = "AccessibleRole";
            accessibleRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            accessibleRoleDataGridViewTextBoxColumn.Name = "accessibleRoleDataGridViewTextBoxColumn";
            accessibleRoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // allowDropDataGridViewCheckBoxColumn
            // 
            allowDropDataGridViewCheckBoxColumn.DataPropertyName = "AllowDrop";
            allowDropDataGridViewCheckBoxColumn.HeaderText = "AllowDrop";
            allowDropDataGridViewCheckBoxColumn.MinimumWidth = 6;
            allowDropDataGridViewCheckBoxColumn.Name = "allowDropDataGridViewCheckBoxColumn";
            allowDropDataGridViewCheckBoxColumn.Width = 125;
            // 
            // anchorDataGridViewTextBoxColumn
            // 
            anchorDataGridViewTextBoxColumn.DataPropertyName = "Anchor";
            anchorDataGridViewTextBoxColumn.HeaderText = "Anchor";
            anchorDataGridViewTextBoxColumn.MinimumWidth = 6;
            anchorDataGridViewTextBoxColumn.Name = "anchorDataGridViewTextBoxColumn";
            anchorDataGridViewTextBoxColumn.Width = 125;
            // 
            // backgroundImageDataGridViewImageColumn
            // 
            backgroundImageDataGridViewImageColumn.DataPropertyName = "BackgroundImage";
            backgroundImageDataGridViewImageColumn.HeaderText = "BackgroundImage";
            backgroundImageDataGridViewImageColumn.MinimumWidth = 6;
            backgroundImageDataGridViewImageColumn.Name = "backgroundImageDataGridViewImageColumn";
            backgroundImageDataGridViewImageColumn.Width = 125;
            // 
            // backgroundImageLayoutDataGridViewTextBoxColumn
            // 
            backgroundImageLayoutDataGridViewTextBoxColumn.DataPropertyName = "BackgroundImageLayout";
            backgroundImageLayoutDataGridViewTextBoxColumn.HeaderText = "BackgroundImageLayout";
            backgroundImageLayoutDataGridViewTextBoxColumn.MinimumWidth = 6;
            backgroundImageLayoutDataGridViewTextBoxColumn.Name = "backgroundImageLayoutDataGridViewTextBoxColumn";
            backgroundImageLayoutDataGridViewTextBoxColumn.Width = 125;
            // 
            // causesValidationDataGridViewCheckBoxColumn
            // 
            causesValidationDataGridViewCheckBoxColumn.DataPropertyName = "CausesValidation";
            causesValidationDataGridViewCheckBoxColumn.HeaderText = "CausesValidation";
            causesValidationDataGridViewCheckBoxColumn.MinimumWidth = 6;
            causesValidationDataGridViewCheckBoxColumn.Name = "causesValidationDataGridViewCheckBoxColumn";
            causesValidationDataGridViewCheckBoxColumn.Width = 125;
            // 
            // contextMenuStripDataGridViewTextBoxColumn
            // 
            contextMenuStripDataGridViewTextBoxColumn.DataPropertyName = "ContextMenuStrip";
            contextMenuStripDataGridViewTextBoxColumn.HeaderText = "ContextMenuStrip";
            contextMenuStripDataGridViewTextBoxColumn.MinimumWidth = 6;
            contextMenuStripDataGridViewTextBoxColumn.Name = "contextMenuStripDataGridViewTextBoxColumn";
            contextMenuStripDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursorDataGridViewTextBoxColumn
            // 
            cursorDataGridViewTextBoxColumn.DataPropertyName = "Cursor";
            cursorDataGridViewTextBoxColumn.HeaderText = "Cursor";
            cursorDataGridViewTextBoxColumn.MinimumWidth = 6;
            cursorDataGridViewTextBoxColumn.Name = "cursorDataGridViewTextBoxColumn";
            cursorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataBindingsDataGridViewTextBoxColumn
            // 
            dataBindingsDataGridViewTextBoxColumn.DataPropertyName = "DataBindings";
            dataBindingsDataGridViewTextBoxColumn.HeaderText = "DataBindings";
            dataBindingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataBindingsDataGridViewTextBoxColumn.Name = "dataBindingsDataGridViewTextBoxColumn";
            dataBindingsDataGridViewTextBoxColumn.ReadOnly = true;
            dataBindingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dockDataGridViewTextBoxColumn
            // 
            dockDataGridViewTextBoxColumn.DataPropertyName = "Dock";
            dockDataGridViewTextBoxColumn.HeaderText = "Dock";
            dockDataGridViewTextBoxColumn.MinimumWidth = 6;
            dockDataGridViewTextBoxColumn.Name = "dockDataGridViewTextBoxColumn";
            dockDataGridViewTextBoxColumn.Width = 125;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            enabledDataGridViewCheckBoxColumn.MinimumWidth = 6;
            enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            enabledDataGridViewCheckBoxColumn.Width = 125;
            // 
            // fontDataGridViewTextBoxColumn
            // 
            fontDataGridViewTextBoxColumn.DataPropertyName = "Font";
            fontDataGridViewTextBoxColumn.HeaderText = "Font";
            fontDataGridViewTextBoxColumn.MinimumWidth = 6;
            fontDataGridViewTextBoxColumn.Name = "fontDataGridViewTextBoxColumn";
            fontDataGridViewTextBoxColumn.Width = 125;
            // 
            // foreColorDataGridViewTextBoxColumn
            // 
            foreColorDataGridViewTextBoxColumn.DataPropertyName = "ForeColor";
            foreColorDataGridViewTextBoxColumn.HeaderText = "ForeColor";
            foreColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            foreColorDataGridViewTextBoxColumn.Name = "foreColorDataGridViewTextBoxColumn";
            foreColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // rightToLeftDataGridViewTextBoxColumn
            // 
            rightToLeftDataGridViewTextBoxColumn.DataPropertyName = "RightToLeft";
            rightToLeftDataGridViewTextBoxColumn.HeaderText = "RightToLeft";
            rightToLeftDataGridViewTextBoxColumn.MinimumWidth = 6;
            rightToLeftDataGridViewTextBoxColumn.Name = "rightToLeftDataGridViewTextBoxColumn";
            rightToLeftDataGridViewTextBoxColumn.Width = 125;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            tagDataGridViewTextBoxColumn.MinimumWidth = 6;
            tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            tagDataGridViewTextBoxColumn.Width = 125;
            // 
            // useWaitCursorDataGridViewCheckBoxColumn
            // 
            useWaitCursorDataGridViewCheckBoxColumn.DataPropertyName = "UseWaitCursor";
            useWaitCursorDataGridViewCheckBoxColumn.HeaderText = "UseWaitCursor";
            useWaitCursorDataGridViewCheckBoxColumn.MinimumWidth = 6;
            useWaitCursorDataGridViewCheckBoxColumn.Name = "useWaitCursorDataGridViewCheckBoxColumn";
            useWaitCursorDataGridViewCheckBoxColumn.Width = 125;
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
            visibleDataGridViewCheckBoxColumn.HeaderText = "Visible";
            visibleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            visibleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // paddingDataGridViewTextBoxColumn
            // 
            paddingDataGridViewTextBoxColumn.DataPropertyName = "Padding";
            paddingDataGridViewTextBoxColumn.HeaderText = "Padding";
            paddingDataGridViewTextBoxColumn.MinimumWidth = 6;
            paddingDataGridViewTextBoxColumn.Name = "paddingDataGridViewTextBoxColumn";
            paddingDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeModeDataGridViewTextBoxColumn
            // 
            imeModeDataGridViewTextBoxColumn.DataPropertyName = "ImeMode";
            imeModeDataGridViewTextBoxColumn.HeaderText = "ImeMode";
            imeModeDataGridViewTextBoxColumn.MinimumWidth = 6;
            imeModeDataGridViewTextBoxColumn.Name = "imeModeDataGridViewTextBoxColumn";
            imeModeDataGridViewTextBoxColumn.Width = 125;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 522);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(ageLabel);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerFormBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label ageLabel;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn District;
        private DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private DataGridViewImageColumn iconDataGridViewImageColumn;
        private DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private BindingSource registerFormBindingSource;
    }
}
