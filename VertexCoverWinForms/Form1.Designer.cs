namespace VertexCoverWinForms
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
            this.GraphVisualBox = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.GreedyButton = new System.Windows.Forms.Button();
            this.ApproxButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GreedyResult = new System.Windows.Forms.TextBox();
            this.ApproxResult = new System.Windows.Forms.TextBox();
            this.VertexList = new System.Windows.Forms.TextBox();
            this.ApproxIterations = new System.Windows.Forms.TextBox();
            this.GreedyIterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.SaveUmova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GraphVisualBox
            // 
            this.GraphVisualBox.ArrowheadLength = 10D;
            this.GraphVisualBox.AsyncLayout = false;
            this.GraphVisualBox.AutoScroll = true;
            this.GraphVisualBox.BackColor = System.Drawing.SystemColors.Control;
            this.GraphVisualBox.BackwardEnabled = false;
            this.GraphVisualBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphVisualBox.BuildHitTree = false;
            this.GraphVisualBox.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.MDS;
            this.GraphVisualBox.EdgeInsertButtonVisible = true;
            this.GraphVisualBox.FileName = "";
            this.GraphVisualBox.ForwardEnabled = false;
            this.GraphVisualBox.Graph = null;
            this.GraphVisualBox.InsertingEdge = false;
            this.GraphVisualBox.LayoutAlgorithmSettingsButtonVisible = true;
            this.GraphVisualBox.LayoutEditingEnabled = true;
            this.GraphVisualBox.Location = new System.Drawing.Point(12, 12);
            this.GraphVisualBox.LooseOffsetForRouting = 0.25D;
            this.GraphVisualBox.MouseHitDistance = 0.05D;
            this.GraphVisualBox.Name = "GraphVisualBox";
            this.GraphVisualBox.NavigationVisible = true;
            this.GraphVisualBox.NeedToCalculateLayout = true;
            this.GraphVisualBox.OffsetForRelaxingInRouting = 0.6D;
            this.GraphVisualBox.PaddingForEdgeRouting = 8D;
            this.GraphVisualBox.PanButtonPressed = false;
            this.GraphVisualBox.SaveAsImageEnabled = true;
            this.GraphVisualBox.SaveAsMsaglEnabled = true;
            this.GraphVisualBox.SaveButtonVisible = true;
            this.GraphVisualBox.SaveGraphButtonVisible = true;
            this.GraphVisualBox.SaveInVectorFormatEnabled = true;
            this.GraphVisualBox.Size = new System.Drawing.Size(475, 335);
            this.GraphVisualBox.TabIndex = 0;
            this.GraphVisualBox.TightOffsetForRouting = 0.125D;
            this.GraphVisualBox.ToolBarIsVisible = false;
            this.GraphVisualBox.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("GraphVisualBox.Transform")));
            this.GraphVisualBox.UndoRedoButtonsVisible = true;
            this.GraphVisualBox.WindowZoomButtonPressed = false;
            this.GraphVisualBox.ZoomF = 1D;
            this.GraphVisualBox.ZoomWindowThreshold = 0.05D;
            // 
            // GreedyButton
            // 
            this.GreedyButton.Location = new System.Drawing.Point(21, 364);
            this.GreedyButton.Name = "GreedyButton";
            this.GreedyButton.Size = new System.Drawing.Size(184, 32);
            this.GreedyButton.TabIndex = 1;
            this.GreedyButton.Text = "Жадібний метод";
            this.GreedyButton.UseVisualStyleBackColor = true;
            this.GreedyButton.Click += new System.EventHandler(this.GreedyButton_Click);
            // 
            // ApproxButton
            // 
            this.ApproxButton.Location = new System.Drawing.Point(291, 364);
            this.ApproxButton.Name = "ApproxButton";
            this.ApproxButton.Size = new System.Drawing.Size(184, 32);
            this.ApproxButton.TabIndex = 2;
            this.ApproxButton.Text = "Приблизний метод";
            this.ApproxButton.UseVisualStyleBackColor = true;
            this.ApproxButton.Click += new System.EventHandler(this.ApproxButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(669, 446);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(157, 44);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Створити граф";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(506, 446);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(157, 44);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Зберегти результат";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GreedyResult
            // 
            this.GreedyResult.Enabled = false;
            this.GreedyResult.Location = new System.Drawing.Point(21, 417);
            this.GreedyResult.Name = "GreedyResult";
            this.GreedyResult.Size = new System.Drawing.Size(184, 26);
            this.GreedyResult.TabIndex = 5;
            // 
            // ApproxResult
            // 
            this.ApproxResult.Enabled = false;
            this.ApproxResult.Location = new System.Drawing.Point(291, 417);
            this.ApproxResult.Name = "ApproxResult";
            this.ApproxResult.Size = new System.Drawing.Size(184, 26);
            this.ApproxResult.TabIndex = 6;
            // 
            // VertexList
            // 
            this.VertexList.Location = new System.Drawing.Point(506, 12);
            this.VertexList.Multiline = true;
            this.VertexList.Name = "VertexList";
            this.VertexList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VertexList.Size = new System.Drawing.Size(320, 308);
            this.VertexList.TabIndex = 7;
            this.VertexList.Text = "Введіть список суміжних вершин для створення графу";
            // 
            // ApproxIterations
            // 
            this.ApproxIterations.Enabled = false;
            this.ApproxIterations.Location = new System.Drawing.Point(291, 466);
            this.ApproxIterations.Name = "ApproxIterations";
            this.ApproxIterations.Size = new System.Drawing.Size(184, 26);
            this.ApproxIterations.TabIndex = 9;
            // 
            // GreedyIterations
            // 
            this.GreedyIterations.Enabled = false;
            this.GreedyIterations.Location = new System.Drawing.Point(21, 466);
            this.GreedyIterations.Name = "GreedyIterations";
            this.GreedyIterations.Size = new System.Drawing.Size(184, 26);
            this.GreedyIterations.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Список вершин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Кількість ітерацій";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Список вершин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Кількість ітерацій";
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(506, 388);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(157, 41);
            this.Download.TabIndex = 14;
            this.Download.Text = "Завантажити умову";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // SaveUmova
            // 
            this.SaveUmova.Location = new System.Drawing.Point(669, 388);
            this.SaveUmova.Name = "SaveUmova";
            this.SaveUmova.Size = new System.Drawing.Size(157, 41);
            this.SaveUmova.TabIndex = 15;
            this.SaveUmova.Text = "Сберегти умову";
            this.SaveUmova.UseVisualStyleBackColor = true;
            this.SaveUmova.Click += new System.EventHandler(this.SaveUmova_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 504);
            this.Controls.Add(this.SaveUmova);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApproxIterations);
            this.Controls.Add(this.GreedyIterations);
            this.Controls.Add(this.VertexList);
            this.Controls.Add(this.ApproxResult);
            this.Controls.Add(this.GreedyResult);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ApproxButton);
            this.Controls.Add(this.GreedyButton);
            this.Controls.Add(this.GraphVisualBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VertexCover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer GraphVisualBox;
        private Button GreedyButton;
        private Button ApproxButton;
        private Button CreateButton;
        private Button SaveButton;
        private TextBox GreedyResult;
        private TextBox ApproxResult;
        private TextBox VertexList;
        private TextBox ApproxIterations;
        private TextBox GreedyIterations;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button Download;
        private Button SaveUmova;
    }
}