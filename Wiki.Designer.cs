namespace Wiki_Prototype_Application
{
    partial class Wiki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonInitialise = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.rbLinear = new System.Windows.Forms.RadioButton();
            this.rbNonLinear = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(21, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.buttonAdd, "Adds the Data Structure information");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(657, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 38);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.buttonSearch, "Searches the array by Data Structurrrer Name, using your search input");
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(657, 6);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(108, 40);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.buttonSort, "Sorts the list ");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(21, 380);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(114, 41);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.toolTip1.SetToolTip(this.buttonOpen, "Opens a binary file");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(175, 380);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 41);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Saves the array to definitions.dat");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(159, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(125, 38);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.buttonEdit, "Enacts the changes made to the selected data structure");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(657, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 41);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.buttonDelete, "Deletes the selected Data Structure");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 76);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Text = "Name";
            this.textBoxName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseDoubleClick);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(21, 117);
            this.textBoxCategory.Multiline = true;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(172, 20);
            this.textBoxCategory.TabIndex = 8;
            this.textBoxCategory.Text = "Category";
            this.textBoxCategory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCategory_MouseDoubleClick);
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(21, 158);
            this.textBoxStructure.Multiline = true;
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(261, 20);
            this.textBoxStructure.TabIndex = 9;
            this.textBoxStructure.Text = "Structure";
            this.textBoxStructure.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxStructure_MouseDoubleClick);
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Location = new System.Drawing.Point(23, 199);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.Size = new System.Drawing.Size(261, 163);
            this.textBoxDefinition.TabIndex = 10;
            this.textBoxDefinition.Text = "Definition";
            this.textBoxDefinition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDefinition_MouseDoubleClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(336, 62);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(284, 18);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDefinition_MouseDoubleClick);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(336, 98);
            this.listBoxDisplay.MultiColumn = true;
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(429, 264);
            this.listBoxDisplay.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wiki Prototype Application";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(497, 380);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(123, 41);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Resets the array information");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInitialise
            // 
            this.buttonInitialise.Location = new System.Drawing.Point(336, 380);
            this.buttonInitialise.Name = "buttonInitialise";
            this.buttonInitialise.Size = new System.Drawing.Size(122, 41);
            this.buttonInitialise.TabIndex = 15;
            this.buttonInitialise.Text = "Initialise";
            this.toolTip1.SetToolTip(this.buttonInitialise, "Loads the definitions file");
            this.buttonInitialise.UseVisualStyleBackColor = true;
            this.buttonInitialise.Click += new System.EventHandler(this.buttonInitialise_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "",
            "Array",
            "List",
            "Tree",
            "Graphs",
            "Abstract",
            "Hash"});
            this.comboBoxCategory.Location = new System.Drawing.Point(21, 117);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCategory.TabIndex = 16;
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.rbLinear);
            this.groupBoxStructure.Controls.Add(this.rbNonLinear);
            this.groupBoxStructure.Location = new System.Drawing.Point(21, 143);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(263, 50);
            this.groupBoxStructure.TabIndex = 17;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // rbLinear
            // 
            this.rbLinear.AutoSize = true;
            this.rbLinear.Location = new System.Drawing.Point(42, 19);
            this.rbLinear.Name = "rbLinear";
            this.rbLinear.Size = new System.Drawing.Size(54, 17);
            this.rbLinear.TabIndex = 1;
            this.rbLinear.TabStop = true;
            this.rbLinear.Text = "Linear";
            this.rbLinear.UseVisualStyleBackColor = true;
            // 
            // rbNonLinear
            // 
            this.rbNonLinear.AutoSize = true;
            this.rbNonLinear.Location = new System.Drawing.Point(154, 19);
            this.rbNonLinear.Name = "rbNonLinear";
            this.rbNonLinear.Size = new System.Drawing.Size(77, 17);
            this.rbNonLinear.TabIndex = 0;
            this.rbNonLinear.TabStop = true;
            this.rbNonLinear.Text = "Non-Linear";
            this.rbNonLinear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(216, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category";
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(336, 98);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(429, 264);
            this.listViewDisplay.TabIndex = 19;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            this.listViewDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDisplay_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 100;
            // 
            // Wiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxStructure);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonInitialise);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxDefinition);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Wiki";
            this.Text = "Wiki";
            this.Load += new System.EventHandler(this.Wiki_Load);
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonInitialise;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxStructure;
        private System.Windows.Forms.RadioButton rbLinear;
        private System.Windows.Forms.RadioButton rbNonLinear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

