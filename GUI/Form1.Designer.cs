using Knapsack;

namespace GUI
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
            startButton = new Button();
            numberOfItemsTB = new TextBox();
            seedTB = new TextBox();
            capacityTB = new TextBox();
            numberOfItemsLabel = new Label();
            seedLabel = new Label();
            capacityLabel = new Label();
            instanceLabel = new Label();
            instanceTB = new TextBox();
            resultTB = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(35, 316);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "run";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // numberOfItemsTB
            // 
            numberOfItemsTB.Location = new Point(35, 95);
            numberOfItemsTB.Name = "numberOfItemsTB";
            numberOfItemsTB.Size = new Size(125, 27);
            numberOfItemsTB.TabIndex = 1;
            numberOfItemsTB.TextChanged += numberOfItems_TextChanged;
            // 
            // seedTB
            // 
            seedTB.Location = new Point(35, 174);
            seedTB.Name = "seedTB";
            seedTB.Size = new Size(125, 27);
            seedTB.TabIndex = 2;
            seedTB.TextChanged += seedTB_TextChanged;
            // 
            // capacityTB
            // 
            capacityTB.Location = new Point(35, 250);
            capacityTB.Name = "capacityTB";
            capacityTB.Size = new Size(125, 27);
            capacityTB.TabIndex = 3;
            capacityTB.TextChanged += capacityTB_TextChanged;
            // 
            // numberOfItemsLabel
            // 
            numberOfItemsLabel.AutoSize = true;
            numberOfItemsLabel.Location = new Point(35, 72);
            numberOfItemsLabel.Name = "numberOfItemsLabel";
            numberOfItemsLabel.Size = new Size(118, 20);
            numberOfItemsLabel.TabIndex = 4;
            numberOfItemsLabel.Text = "number of items";
            // 
            // seedLabel
            // 
            seedLabel.AutoSize = true;
            seedLabel.Location = new Point(35, 151);
            seedLabel.Name = "seedLabel";
            seedLabel.Size = new Size(40, 20);
            seedLabel.TabIndex = 5;
            seedLabel.Text = "seed";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(35, 227);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(64, 20);
            capacityLabel.TabIndex = 6;
            capacityLabel.Text = "capacity";
            // 
            // instanceLabel
            // 
            instanceLabel.AutoSize = true;
            instanceLabel.Location = new Point(265, 72);
            instanceLabel.Name = "instanceLabel";
            instanceLabel.Size = new Size(63, 20);
            instanceLabel.TabIndex = 7;
            instanceLabel.Text = "instance";
            // 
            // instanceTB
            // 
            instanceTB.Location = new Point(265, 95);
            instanceTB.Multiline = true;
            instanceTB.Name = "instanceTB";
            instanceTB.ReadOnly = true;
            instanceTB.Size = new Size(244, 441);
            instanceTB.TabIndex = 8;
            instanceTB.BorderStyle = BorderStyle.FixedSingle;
            // 
            // resultTB
            // 
            resultTB.Location = new Point(35, 408);
            resultTB.Multiline = true;
            resultTB.Name = "resultTB";
            resultTB.ReadOnly = true;
            resultTB.Size = new Size(204, 128);
            resultTB.TabIndex = 9;
            resultTB.BorderStyle = BorderStyle.FixedSingle;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(35, 385);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(45, 20);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 548);
            Controls.Add(resultLabel);
            Controls.Add(resultTB);
            Controls.Add(instanceTB);
            Controls.Add(instanceLabel);
            Controls.Add(capacityLabel);
            Controls.Add(seedLabel);
            Controls.Add(numberOfItemsLabel);
            Controls.Add(capacityTB);
            Controls.Add(seedTB);
            Controls.Add(numberOfItemsTB);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Knapsack";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private TextBox numberOfItemsTB;
        private TextBox seedTB;
        private TextBox capacityTB;
        private Label numberOfItemsLabel;
        private Label seedLabel;
        private Label capacityLabel;
        private Label instanceLabel;
        private TextBox instanceTB;
        private TextBox resultTB;
        private Label resultLabel;
    }
}
