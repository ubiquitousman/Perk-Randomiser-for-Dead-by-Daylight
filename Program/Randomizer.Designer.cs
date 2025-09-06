using System.Windows.Forms;

namespace DBDRandomizer
{
    partial class Randomizer
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
            // Resource manager for icons, images, etc.
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));

            // --- Instantiate controls ---
            // Top menu strip and menu items
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyNewPerksEveryRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // Main tab control and two tabs
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.suvivorTabPage = new System.Windows.Forms.TabPage();
            this.killerTabPage = new System.Windows.Forms.TabPage();

            // Survivor tab controls: list, columns, labels, buttons, images, etc.
            this.survivorPerkList = new System.Windows.Forms.ListView();
            this.perkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.survivorSelectNoneButton = new System.Windows.Forms.Button();
            this.survivorSelectAllButton = new System.Windows.Forms.Button();
            this.survivorRandomizeButton = new System.Windows.Forms.Button();
            this.label2Static = new System.Windows.Forms.Label();
            this.label2Number = new System.Windows.Forms.LinkLabel();
            this.survivorPerkLabel4 = new System.Windows.Forms.Label();
            this.survivorPerkImage4 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel3 = new System.Windows.Forms.Label();
            this.survivorPerkImage3 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel2 = new System.Windows.Forms.Label();
            this.survivorPerkImage2 = new System.Windows.Forms.PictureBox();
            this.survivorPerkLabel1 = new System.Windows.Forms.Label();
            this.survivorPerkImage1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();

            // Killer tab controls: labels, images, buttons, list, etc.
            this.killerPerkLabel4 = new System.Windows.Forms.Label();
            this.killerPerkImage4 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel3 = new System.Windows.Forms.Label();
            this.killerPerkImage3 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel2 = new System.Windows.Forms.Label();
            this.killerPerkImage2 = new System.Windows.Forms.PictureBox();
            this.killerPerkLabel1 = new System.Windows.Forms.Label();
            this.killerPerkImage1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.killerRandomizeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.killerSelectNoneButton = new System.Windows.Forms.Button();
            this.killerSelectAllButton = new System.Windows.Forms.Button();
            this.killerPerkList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();

            // --- Suspend layout while we set properties (keeps UI snappy during initialization) ---
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.suvivorTabPage.SuspendLayout();
            this.killerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage1)).BeginInit();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            // Top menu bar: contains Options, Reset All, Quit
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.optionsToolStripMenuItem,
                this.resetAllToolStripMenuItem,
                this.quitToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // optionsToolStripMenuItem
            // 
            // Options menu with a single toggle item: Only New Perks Every Roll
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.onlyNewPerksEveryRollToolStripMenuItem
            });
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "&Options";

            // 
            // onlyNewPerksEveryRollToolStripMenuItem
            // 
            // Toggle: if checked, randomizer avoids previously shown perks
            this.onlyNewPerksEveryRollToolStripMenuItem.CheckOnClick = true;
            this.onlyNewPerksEveryRollToolStripMenuItem.Name = "onlyNewPerksEveryRollToolStripMenuItem";
            this.onlyNewPerksEveryRollToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.onlyNewPerksEveryRollToolStripMenuItem.Text = "Only New Perks Every Roll";
            this.onlyNewPerksEveryRollToolStripMenuItem.Click += new System.EventHandler(this.onlyNewPerksEveryRollToolStripMenuItem_Click);

            // 
            // resetAllToolStripMenuItem
            // 
            // Reset all selections to default
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(100, 29); // adjust width if needed
            this.resetAllToolStripMenuItem.Text = "&Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);

            // 
            // quitToolStripMenuItem
            // 
            // Exit application
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);

            // 
            // tabControl1
            // 
            // Tab control that holds Survivor Perks and Killer Perks tabs
            this.tabControl1.Controls.Add(this.suvivorTabPage);
            this.tabControl1.Controls.Add(this.killerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 663);
            this.tabControl1.TabIndex = 1;

            // 
            // suvivorTabPage
            // 
            // Survivor Perks tab: compose the controls
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel4);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage4);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel3);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage3);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel2);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage2);
            this.suvivorTabPage.Controls.Add(this.survivorPerkLabel1);
            this.suvivorTabPage.Controls.Add(this.survivorPerkImage1);
            this.suvivorTabPage.Controls.Add(this.label3);
            this.suvivorTabPage.Controls.Add(this.survivorRandomizeButton);
            this.suvivorTabPage.Controls.Add(this.label2Static);
            this.suvivorTabPage.Controls.Add(this.label2Number);
            this.suvivorTabPage.Controls.Add(this.survivorSelectNoneButton);
            this.suvivorTabPage.Controls.Add(this.survivorSelectAllButton);
            this.suvivorTabPage.Controls.Add(this.survivorPerkList);
            this.suvivorTabPage.Controls.Add(this.label1);
            this.suvivorTabPage.Location = new System.Drawing.Point(4, 29);
            this.suvivorTabPage.Name = "suvivorTabPage";
            this.suvivorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.suvivorTabPage.Size = new System.Drawing.Size(1374, 630);
            this.suvivorTabPage.TabIndex = 0;
            this.suvivorTabPage.Text = "Survivor Perks";
            this.suvivorTabPage.UseVisualStyleBackColor = true;

            // 
            // killerTabPage
            // 
            // Killer Perks tab: compose killer side controls
            this.killerTabPage.Controls.Add(this.killerPerkLabel4);
            this.killerTabPage.Controls.Add(this.killerPerkImage4);
            this.killerTabPage.Controls.Add(this.killerPerkLabel3);
            this.killerTabPage.Controls.Add(this.killerPerkImage3);
            this.killerTabPage.Controls.Add(this.killerPerkLabel2);
            this.killerTabPage.Controls.Add(this.killerPerkImage2);
            this.killerTabPage.Controls.Add(this.killerPerkLabel1);
            this.killerTabPage.Controls.Add(this.killerPerkImage1);
            this.killerTabPage.Controls.Add(this.label8);
            this.killerTabPage.Controls.Add(this.killerRandomizeButton);
            this.killerTabPage.Controls.Add(this.label9);
            this.killerTabPage.Controls.Add(this.killerSelectNoneButton);
            this.killerTabPage.Controls.Add(this.killerSelectAllButton);
            this.killerTabPage.Controls.Add(this.killerPerkList);
            this.killerTabPage.Controls.Add(this.label10);
            this.killerTabPage.Location = new System.Drawing.Point(4, 29);
            this.killerTabPage.Name = "killerTabPage";
            this.killerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.killerTabPage.Size = new System.Drawing.Size(1374, 630);
            this.killerTabPage.TabIndex = 1;
            this.killerTabPage.Text = "Killer Perks";
            this.killerTabPage.UseVisualStyleBackColor = true;

            // 
            // survivorPerkList
            // 
            // ListView containing survivor perks (with checkboxes)
            this.survivorPerkList.BackColor = System.Drawing.SystemColors.Window;
            this.survivorPerkList.CheckBoxes = true;
            this.survivorPerkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.perkName});
            this.survivorPerkList.FullRowSelect = true;
            this.survivorPerkList.Location = new System.Drawing.Point(9, 44);
            this.survivorPerkList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkList.Name = "survivorPerkList";
            this.survivorPerkList.Size = new System.Drawing.Size(470, 426);
            this.survivorPerkList.TabIndex = 5;
            this.survivorPerkList.UseCompatibleStateImageBehavior = false;
            this.survivorPerkList.View = System.Windows.Forms.View.SmallIcon;

            // 
            // perkName
            // 
            this.perkName.Text = "Perk";
            this.perkName.Width = 1000;

            // 
            // label1
            // 
            // Instruction label 1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Select available perks:";

            // 
            // survivorSelectNoneButton
            // 
            // Deselect all survivor perks button
            this.survivorSelectNoneButton.Location = new System.Drawing.Point(243, 480);
            this.survivorSelectNoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorSelectNoneButton.Name = "survivorSelectNoneButton";
            this.survivorSelectNoneButton.Size = new System.Drawing.Size(234, 35);
            this.survivorSelectNoneButton.TabIndex = 7;
            this.survivorSelectNoneButton.Text = "Deselect All";
            this.survivorSelectNoneButton.UseVisualStyleBackColor = true;
            this.survivorSelectNoneButton.Click += new System.EventHandler(this.survivorSelectNoneButton_Click);

            // 
            // survivorSelectAllButton
            // 
            // Select all survivor perks button
            this.survivorSelectAllButton.Location = new System.Drawing.Point(9, 480);
            this.survivorSelectAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorSelectAllButton.Name = "survivorSelectAllButton";
            this.survivorSelectAllButton.Size = new System.Drawing.Size(225, 35);
            this.survivorSelectAllButton.TabIndex = 6;
            this.survivorSelectAllButton.Text = "Select All";
            this.survivorSelectAllButton.UseVisualStyleBackColor = true;
            this.survivorSelectAllButton.Click += new System.EventHandler(this.survivorSelectAllButton_Click);

            // 
            // survivorRandomizeButton
            // 
            // Large button to perform randomization for survivors
            this.survivorRandomizeButton.Location = new System.Drawing.Point(487, 44);
            this.survivorRandomizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorRandomizeButton.Name = "survivorRandomizeButton";
            this.survivorRandomizeButton.Size = new System.Drawing.Size(340, 466);
            this.survivorRandomizeButton.TabIndex = 9;
            this.survivorRandomizeButton.Text = "Randomise Perks!";
            this.survivorRandomizeButton.UseVisualStyleBackColor = true;
            this.survivorRandomizeButton.Click += new System.EventHandler(this.survivorRandomizeButton_Click);

            // 
            // label2
            // 
            // Static part of the label (survivor)
            this.label2Static.AutoSize = true;
            this.label2Static.Location = new System.Drawing.Point(487, 19);
            this.label2Static.Name = "label2Static";
            this.label2Static.Size = new System.Drawing.Size(200, 20);
            this.label2Static.Text = "2. Randomise selection";

            // Dynamic number label [X] (survivor)
            this.label2Number.AutoSize = true;
            this.label2Number.Location = new System.Drawing.Point(660, 19);
            this.label2Number.Name = "label2Number";
            this.label2Number.Size = new System.Drawing.Size(30, 20);
            this.label2Number.TabStop = true;
            this.label2Number.Text = "[4]";
            this.label2Number.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label2_LinkClicked);

            // 
            // survivorPerkCountTextbox
            // 
            // Hidden textbox used to edit the number of perks to randomize (survivor)
            // Instantiate first
            this.survivorPerkCountTextbox = new System.Windows.Forms.TextBox();

            // Now set properties
            this.survivorPerkCountTextbox.Location = new System.Drawing.Point(665, 17);
            this.survivorPerkCountTextbox.Name = "survivorPerkCountTextbox";
            this.survivorPerkCountTextbox.Size = new System.Drawing.Size(30, 27);
            this.survivorPerkCountTextbox.Visible = false;

            // Hook up events for the textbox
            this.survivorPerkCountTextbox.Leave += new System.EventHandler(this.survivorPerkCountTextbox_Leave);
            this.survivorPerkCountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.survivorPerkCountTextbox_KeyDown);
            this.survivorPerkCountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.survivorPerkCountTextbox_KeyPress);

            // Add to Survivor tab
            this.suvivorTabPage.Controls.Add(this.survivorPerkCountTextbox);

            // 
            // label9Static (Killer tab static label)
            // 
            // Static label for killer tab's randomize section
            this.label9Static = new System.Windows.Forms.Label();
            this.label9Static.AutoSize = true;
            this.label9Static.Location = new System.Drawing.Point(487, 19);
            this.label9Static.Name = "label9Static";
            this.label9Static.Size = new System.Drawing.Size(123, 20);
            this.label9Static.Text = "2. Randomise selection";

            // 
            // label9Number (Killer tab dynamic link label)
            // 
            // Dynamic number label for killer tab
            this.label9Number = new System.Windows.Forms.LinkLabel();
            this.label9Number.AutoSize = true;
            this.label9Number.Location = new System.Drawing.Point(660, 19);
            this.label9Number.Name = "label9Number";
            this.label9Number.Size = new System.Drawing.Size(30, 20);
            this.label9Number.TabStop = true;
            this.label9Number.Text = "[4]";
            this.label9Number.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label9Number_LinkClicked);

            // 
            // killerPerkCountTextbox
            // 
            // Hidden textbox used to edit the number for killer randomization
            this.killerPerkCountTextbox = new System.Windows.Forms.TextBox();
            this.killerPerkCountTextbox.Location = new System.Drawing.Point(665, 17);
            this.killerPerkCountTextbox.Name = "killerPerkCountTextbox";
            this.killerPerkCountTextbox.Size = new System.Drawing.Size(30, 27);
            this.killerPerkCountTextbox.Visible = false;

            // Hook up events
            this.killerPerkCountTextbox.Leave += new System.EventHandler(this.killerPerkCountTextbox_Leave);
            this.killerPerkCountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.killerPerkCountTextbox_KeyDown);
            this.killerPerkCountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.killerPerkCountTextbox_KeyPress);

            // Add killer controls to Killer tab
            this.killerTabPage.Controls.Add(this.label9Static);
            this.killerTabPage.Controls.Add(this.label9Number);
            this.killerTabPage.Controls.Add(this.killerPerkCountTextbox);
            this.label9Number.BringToFront();

            // 
            // survivorPerkLabel4
            // 
            // Label that will show the 4th survivor perk name (initially empty)
            this.survivorPerkLabel4.AutoSize = true;
            this.survivorPerkLabel4.Location = new System.Drawing.Point(939, 402);
            this.survivorPerkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel4.Name = "survivorPerkLabel4";
            this.survivorPerkLabel4.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel4.TabIndex = 23;

            // 
            // survivorPerkImage4
            // 
            // Picture box for survivor perk 4
            this.survivorPerkImage4.Location = new System.Drawing.Point(835, 367);
            this.survivorPerkImage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage4.Name = "survivorPerkImage4";
            this.survivorPerkImage4.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage4.TabIndex = 22;
            this.survivorPerkImage4.TabStop = false;

            // 
            // survivorPerkLabel3
            // 
            this.survivorPerkLabel3.AutoSize = true;
            this.survivorPerkLabel3.Location = new System.Drawing.Point(939, 294);
            this.survivorPerkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel3.Name = "survivorPerkLabel3";
            this.survivorPerkLabel3.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel3.TabIndex = 21;

            // 
            // survivorPerkImage3
            // 
            this.survivorPerkImage3.Location = new System.Drawing.Point(835, 259);
            this.survivorPerkImage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage3.Name = "survivorPerkImage3";
            this.survivorPerkImage3.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage3.TabIndex = 20;
            this.survivorPerkImage3.TabStop = false;

            // 
            // survivorPerkLabel2
            // 
            this.survivorPerkLabel2.AutoSize = true;
            this.survivorPerkLabel2.Location = new System.Drawing.Point(939, 187);
            this.survivorPerkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel2.Name = "survivorPerkLabel2";
            this.survivorPerkLabel2.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel2.TabIndex = 19;

            // 
            // survivorPerkImage2
            // 
            this.survivorPerkImage2.Location = new System.Drawing.Point(835, 151);
            this.survivorPerkImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage2.Name = "survivorPerkImage2";
            this.survivorPerkImage2.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage2.TabIndex = 18;
            this.survivorPerkImage2.TabStop = false;

            // 
            // survivorPerkLabel1
            // 
            this.survivorPerkLabel1.AutoSize = true;
            this.survivorPerkLabel1.Location = new System.Drawing.Point(939, 79);
            this.survivorPerkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.survivorPerkLabel1.Name = "survivorPerkLabel1";
            this.survivorPerkLabel1.Size = new System.Drawing.Size(0, 20);
            this.survivorPerkLabel1.TabIndex = 17;

            // 
            // survivorPerkImage1
            // 
            this.survivorPerkImage1.Location = new System.Drawing.Point(835, 44);
            this.survivorPerkImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.survivorPerkImage1.Name = "survivorPerkImage1";
            this.survivorPerkImage1.Size = new System.Drawing.Size(96, 98);
            this.survivorPerkImage1.TabIndex = 16;
            this.survivorPerkImage1.TabStop = false;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "3. Your perks:";

            // 
            // killerPerkLabel4
            // 
            // Killer perk label #4 (initially empty)
            this.killerPerkLabel4.AutoSize = true;
            this.killerPerkLabel4.Location = new System.Drawing.Point(939, 402);
            this.killerPerkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel4.Name = "killerPerkLabel4";
            this.killerPerkLabel4.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel4.TabIndex = 38;

            // 
            // killerPerkImage4
            // 
            this.killerPerkImage4.Location = new System.Drawing.Point(835, 367);
            this.killerPerkImage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage4.Name = "killerPerkImage4";
            this.killerPerkImage4.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage4.TabIndex = 37;
            this.killerPerkImage4.TabStop = false;

            // 
            // killerPerkLabel3
            // 
            this.killerPerkLabel3.AutoSize = true;
            this.killerPerkLabel3.Location = new System.Drawing.Point(939, 294);
            this.killerPerkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel3.Name = "killerPerkLabel3";
            this.killerPerkLabel3.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel3.TabIndex = 36;

            // 
            // killerPerkImage3
            // 
            this.killerPerkImage3.Location = new System.Drawing.Point(835, 259);
            this.killerPerkImage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage3.Name = "killerPerkImage3";
            this.killerPerkImage3.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage3.TabIndex = 35;
            this.killerPerkImage3.TabStop = false;

            // 
            // killerPerkLabel2
            // 
            this.killerPerkLabel2.AutoSize = true;
            this.killerPerkLabel2.Location = new System.Drawing.Point(939, 187);
            this.killerPerkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel2.Name = "killerPerkLabel2";
            this.killerPerkLabel2.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel2.TabIndex = 34;

            // 
            // killerPerkImage2
            // 
            this.killerPerkImage2.Location = new System.Drawing.Point(835, 151);
            this.killerPerkImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage2.Name = "killerPerkImage2";
            this.killerPerkImage2.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage2.TabIndex = 33;
            this.killerPerkImage2.TabStop = false;

            // 
            // killerPerkLabel1
            // 
            this.killerPerkLabel1.AutoSize = true;
            this.killerPerkLabel1.Location = new System.Drawing.Point(939, 79);
            this.killerPerkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.killerPerkLabel1.Name = "killerPerkLabel1";
            this.killerPerkLabel1.Size = new System.Drawing.Size(0, 20);
            this.killerPerkLabel1.TabIndex = 32;

            // 
            // killerPerkImage1
            // 
            this.killerPerkImage1.Location = new System.Drawing.Point(835, 44);
            this.killerPerkImage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkImage1.Name = "killerPerkImage1";
            this.killerPerkImage1.Size = new System.Drawing.Size(96, 98);
            this.killerPerkImage1.TabIndex = 31;
            this.killerPerkImage1.TabStop = false;

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(830, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "3. Your perks:";

            // 
            // killerRandomizeButton
            // 
            // Large button to perform randomization for killer perks
            this.killerRandomizeButton.Location = new System.Drawing.Point(487, 44);
            this.killerRandomizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerRandomizeButton.Name = "killerRandomizeButton";
            this.killerRandomizeButton.Size = new System.Drawing.Size(340, 466);
            this.killerRandomizeButton.TabIndex = 29;
            this.killerRandomizeButton.Text = "Randomise Perks!";
            this.killerRandomizeButton.UseVisualStyleBackColor = true;
            this.killerRandomizeButton.Click += new System.EventHandler(this.killerRandomizeButton_Click);

            // 
            // killerSelectNoneButton
            // 
            // Deselect all killer perks button
            this.killerSelectNoneButton.Location = new System.Drawing.Point(243, 480);
            this.killerSelectNoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerSelectNoneButton.Name = "killerSelectNoneButton";
            this.killerSelectNoneButton.Size = new System.Drawing.Size(234, 35);
            this.killerSelectNoneButton.TabIndex = 27;
            this.killerSelectNoneButton.Text = "Deselect All";
            this.killerSelectNoneButton.UseVisualStyleBackColor = true;
            this.killerSelectNoneButton.Click += new System.EventHandler(this.killerSelectNoneButton_Click);

            // 
            // killerSelectAllButton
            // 
            // Select all killer perks button
            this.killerSelectAllButton.Location = new System.Drawing.Point(9, 480);
            this.killerSelectAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerSelectAllButton.Name = "killerSelectAllButton";
            this.killerSelectAllButton.Size = new System.Drawing.Size(225, 35);
            this.killerSelectAllButton.TabIndex = 26;
            this.killerSelectAllButton.Text = "Select All";
            this.killerSelectAllButton.UseVisualStyleBackColor = true;
            this.killerSelectAllButton.Click += new System.EventHandler(this.killerSelectAllButton_Click);

            // 
            // killerPerkList
            // 
            // ListView containing killer perks (with checkboxes)
            this.killerPerkList.BackColor = System.Drawing.SystemColors.Window;
            this.killerPerkList.CheckBoxes = true;
            this.killerPerkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.killerPerkList.FullRowSelect = true;
            this.killerPerkList.Location = new System.Drawing.Point(9, 44);
            this.killerPerkList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killerPerkList.Name = "killerPerkList";
            this.killerPerkList.Size = new System.Drawing.Size(470, 426);
            this.killerPerkList.TabIndex = 25;
            this.killerPerkList.UseCompatibleStateImageBehavior = false;
            this.killerPerkList.View = System.Windows.Forms.View.SmallIcon;

            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Perk";
            this.columnHeader1.Width = 1000;

            // 
            // label10
            // 
            // Instruction label "1. Select available perks:" for killer
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "1. Select available perks:";

            // 
            // Randomizer (Form properties)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 594);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            //this.MaximumSize = new System.Drawing.Size(1315, 650);
            //this.MinimumSize = new System.Drawing.Size(1315, 650);
            this.Name = "Dead by Daylight Randomiser Tool | v2025.3";
            this.Text = "Dead by Daylight Randomiser Tool | v2025.3";
            this.Load += new System.EventHandler(this.Randomizer_Load);

            // --- Resume layout and end initialization ---
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.suvivorTabPage.ResumeLayout(false);
            this.suvivorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.survivorPerkImage4)).EndInit();
            this.killerTabPage.ResumeLayout(false);
            this.killerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killerPerkImage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Designer Variables

        // --- Fields (controls) declarations ---
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem onlyNewPerksEveryRollToolStripMenuItem;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;

        private TabControl tabControl1;
        private TabPage suvivorTabPage;
        private TabPage killerTabPage;

        private ListView survivorPerkList;
        private ColumnHeader perkName;
        private Label label1;
        private Button survivorSelectAllButton;
        private Button survivorSelectNoneButton;
        private Button survivorRandomizeButton;
        private Label label2Static;
        private LinkLabel label2Number;
        private Label label3;
        private TextBox survivorPerkCountTextbox;
        private Label[] survivorPerkLabels;
        private PictureBox[] survivorPerkImages;
        private Label survivorPerkLabel1;
        private Label survivorPerkLabel2;
        private Label survivorPerkLabel3;
        private Label survivorPerkLabel4;
        private PictureBox survivorPerkImage1;
        private PictureBox survivorPerkImage2;
        private PictureBox survivorPerkImage3;
        private PictureBox survivorPerkImage4;

        private ListView killerPerkList;
        private ColumnHeader columnHeader1;
        private Button killerSelectAllButton;
        private Button killerSelectNoneButton;
        private Button killerRandomizeButton;
        private Label label8;
        private Label label9Static;
        private Label label9;
        private Label label10;
        private LinkLabel label9Number;
        private TextBox killerPerkCountTextbox;
        private Label[] killerPerkLabels;
        private PictureBox[] killerPerkImages;
        private Label killerPerkLabel1;
        private Label killerPerkLabel2;
        private Label killerPerkLabel3;
        private Label killerPerkLabel4;
        private PictureBox killerPerkImage1;
        private PictureBox killerPerkImage2;
        private PictureBox killerPerkImage3;
        private PictureBox killerPerkImage4;

        #endregion
    }
}
