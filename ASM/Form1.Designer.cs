namespace ASM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CreateMap = new Button();
            CreateNode = new Button();
            CreateTest = new Button();
            GraphAndStat = new Button();
            Indicators = new Button();
            Settings = new Button();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // CreateMap
            // 
            CreateMap.Image = (Image)resources.GetObject("CreateMap.Image");
            CreateMap.ImageAlign = ContentAlignment.TopCenter;
            CreateMap.Location = new Point(4, 5);
            CreateMap.Name = "CreateMap";
            CreateMap.Size = new Size(80, 108);
            CreateMap.TabIndex = 0;
            CreateMap.Text = "Создать карту";
            CreateMap.TextAlign = ContentAlignment.BottomCenter;
            CreateMap.UseVisualStyleBackColor = true;
            CreateMap.Click += CreateMap_Click;
            // 
            // CreateNode
            // 
            CreateNode.Image = (Image)resources.GetObject("CreateNode.Image");
            CreateNode.ImageAlign = ContentAlignment.TopCenter;
            CreateNode.Location = new Point(90, 5);
            CreateNode.Name = "CreateNode";
            CreateNode.Size = new Size(80, 108);
            CreateNode.TabIndex = 1;
            CreateNode.Text = "Добавить устройство";
            CreateNode.TextAlign = ContentAlignment.BottomCenter;
            CreateNode.UseVisualStyleBackColor = true;
            CreateNode.Click += CreateNode_Click;
            // 
            // CreateTest
            // 
            CreateTest.Image = (Image)resources.GetObject("CreateTest.Image");
            CreateTest.ImageAlign = ContentAlignment.TopCenter;
            CreateTest.Location = new Point(176, 5);
            CreateTest.Name = "CreateTest";
            CreateTest.Size = new Size(90, 108);
            CreateTest.TabIndex = 2;
            CreateTest.Text = "Модуль мониторинга";
            CreateTest.TextAlign = ContentAlignment.BottomCenter;
            CreateTest.UseVisualStyleBackColor = true;
            CreateTest.Click += CreateTest_Click;
            // 
            // GraphAndStat
            // 
            GraphAndStat.Image = (Image)resources.GetObject("GraphAndStat.Image");
            GraphAndStat.ImageAlign = ContentAlignment.TopCenter;
            GraphAndStat.Location = new Point(272, 5);
            GraphAndStat.Name = "GraphAndStat";
            GraphAndStat.Size = new Size(90, 108);
            GraphAndStat.TabIndex = 3;
            GraphAndStat.Text = "Модуль анализа";
            GraphAndStat.TextAlign = ContentAlignment.BottomCenter;
            GraphAndStat.UseVisualStyleBackColor = true;
            GraphAndStat.Click += GraphAndStat_Click;
            // 
            // Indicators
            // 
            Indicators.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Indicators.Image = (Image)resources.GetObject("Indicators.Image");
            Indicators.ImageAlign = ContentAlignment.TopCenter;
            Indicators.Location = new Point(368, 5);
            Indicators.Name = "Indicators";
            Indicators.Size = new Size(84, 108);
            Indicators.TabIndex = 4;
            Indicators.Text = "Индикаторы            ";
            Indicators.TextAlign = ContentAlignment.BottomCenter;
            Indicators.UseVisualStyleBackColor = true;
            Indicators.Click += Indicators_Click;
            // 
            // Settings
            // 
            Settings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Settings.Image = (Image)resources.GetObject("Settings.Image");
            Settings.ImageAlign = ContentAlignment.TopCenter;
            Settings.Location = new Point(458, 5);
            Settings.Name = "Settings";
            Settings.Size = new Size(84, 108);
            Settings.TabIndex = 5;
            Settings.Text = "Настройки         ";
            Settings.TextAlign = ContentAlignment.BottomCenter;
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += Settings_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(539, 344);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Карта организации №1";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(547, 372);
            tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(542, 344);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Карта организации №2";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CreateMap);
            splitContainer1.Panel1.Controls.Add(CreateTest);
            splitContainer1.Panel1.Controls.Add(CreateNode);
            splitContainer1.Panel1.Controls.Add(GraphAndStat);
            splitContainer1.Panel1.Controls.Add(Indicators);
            splitContainer1.Panel1.Controls.Add(Settings);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(547, 527);
            splitContainer1.SplitterDistance = 115;
            splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Size = new Size(547, 408);
            splitContainer2.SplitterDistance = 372;
            splitContainer2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(547, 32);
            label1.TabIndex = 0;
            label1.Text = "Всего узлов:    0           Состояние ОК:    0          Обнаружена проблема:    0          Отключены:    0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 527);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "АСМ";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CreateMap;
        private Button CreateNode;
        private Button CreateTest;
        private Button GraphAndStat;
        private Button Indicators;
        private Button Settings;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private TabPage tabPage2;
    }
}