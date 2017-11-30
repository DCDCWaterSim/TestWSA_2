namespace TestModel
{
    partial class Form1
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
            this.Invoke_Model = new System.Windows.Forms.Button();
            this.listBoxParmValues = new System.Windows.Forms.ListBox();
            this.textBox_popGrowthRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UConservation = new System.Windows.Forms.TextBox();
            this.AConservation = new System.Windows.Forms.TextBox();
            this.PConservation = new System.Windows.Forms.TextBox();
            this.UCONS = new System.Windows.Forms.Label();
            this.ACONS = new System.Windows.Forms.Label();
            this.PCONS = new System.Windows.Forms.Label();
            this.SM = new System.Windows.Forms.TextBox();
            this.GM = new System.Windows.Forms.TextBox();
            this.RM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_drought = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_endYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_AgGrowthRate = new System.Windows.Forms.TextBox();
            this.agGrowthRate = new System.Windows.Forms.Label();
            this.textBox_LakeWater = new System.Windows.Forms.TextBox();
            this.textBox_LWM = new System.Windows.Forms.Label();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.TheState = new System.Windows.Forms.Label();
            this.textBox_desal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_policyStartYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sankeyGraph1 = new ConsumerResourceModelFramework.SankeyGraph();
            this.IConservation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Invoke_Model
            // 
            this.Invoke_Model.Location = new System.Drawing.Point(12, 11);
            this.Invoke_Model.Name = "Invoke_Model";
            this.Invoke_Model.Size = new System.Drawing.Size(118, 37);
            this.Invoke_Model.TabIndex = 0;
            this.Invoke_Model.Text = "Run";
            this.Invoke_Model.UseVisualStyleBackColor = true;
            this.Invoke_Model.Click += new System.EventHandler(this.Invoke_Model_Click);
            // 
            // listBoxParmValues
            // 
            this.listBoxParmValues.FormattingEnabled = true;
            this.listBoxParmValues.Location = new System.Drawing.Point(490, 11);
            this.listBoxParmValues.Name = "listBoxParmValues";
            this.listBoxParmValues.Size = new System.Drawing.Size(401, 381);
            this.listBoxParmValues.TabIndex = 1;
            // 
            // textBox_popGrowthRate
            // 
            this.textBox_popGrowthRate.Location = new System.Drawing.Point(30, 88);
            this.textBox_popGrowthRate.Name = "textBox_popGrowthRate";
            this.textBox_popGrowthRate.Size = new System.Drawing.Size(64, 20);
            this.textBox_popGrowthRate.TabIndex = 3;
            this.textBox_popGrowthRate.TextChanged += new System.EventHandler(this.textBox_popGrowthRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pop GR";
            // 
            // UConservation
            // 
            this.UConservation.Location = new System.Drawing.Point(152, 15);
            this.UConservation.Name = "UConservation";
            this.UConservation.Size = new System.Drawing.Size(89, 20);
            this.UConservation.TabIndex = 9;
            // 
            // AConservation
            // 
            this.AConservation.Location = new System.Drawing.Point(152, 42);
            this.AConservation.Name = "AConservation";
            this.AConservation.Size = new System.Drawing.Size(89, 20);
            this.AConservation.TabIndex = 10;
            // 
            // PConservation
            // 
            this.PConservation.Location = new System.Drawing.Point(152, 69);
            this.PConservation.Name = "PConservation";
            this.PConservation.Size = new System.Drawing.Size(89, 20);
            this.PConservation.TabIndex = 11;
            // 
            // UCONS
            // 
            this.UCONS.AutoSize = true;
            this.UCONS.Location = new System.Drawing.Point(260, 15);
            this.UCONS.Name = "UCONS";
            this.UCONS.Size = new System.Drawing.Size(111, 13);
            this.UCONS.TabIndex = 12;
            this.UCONS.Text = "Urban Cons (50 - 100)";
            // 
            // ACONS
            // 
            this.ACONS.AutoSize = true;
            this.ACONS.Location = new System.Drawing.Point(263, 42);
            this.ACONS.Name = "ACONS";
            this.ACONS.Size = new System.Drawing.Size(53, 13);
            this.ACONS.TabIndex = 13;
            this.ACONS.Text = "Ag Consv";
            // 
            // PCONS
            // 
            this.PCONS.AutoSize = true;
            this.PCONS.Location = new System.Drawing.Point(260, 69);
            this.PCONS.Name = "PCONS";
            this.PCONS.Size = new System.Drawing.Size(64, 13);
            this.PCONS.TabIndex = 14;
            this.PCONS.Text = "Power Cons";
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(152, 149);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(89, 20);
            this.SM.TabIndex = 15;
            // 
            // GM
            // 
            this.GM.Location = new System.Drawing.Point(152, 178);
            this.GM.Name = "GM";
            this.GM.Size = new System.Drawing.Size(88, 20);
            this.GM.TabIndex = 16;
            // 
            // RM
            // 
            this.RM.Location = new System.Drawing.Point(152, 212);
            this.RM.Name = "RM";
            this.RM.Size = new System.Drawing.Size(87, 20);
            this.RM.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SURFM (80 - 140)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "GWM (80 -140)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "RM (0 - 100)";
            // 
            // textBox_drought
            // 
            this.textBox_drought.Location = new System.Drawing.Point(28, 148);
            this.textBox_drought.Name = "textBox_drought";
            this.textBox_drought.Size = new System.Drawing.Size(66, 20);
            this.textBox_drought.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Drought (50 - 150)";
            // 
            // textBox_endYear
            // 
            this.textBox_endYear.Location = new System.Drawing.Point(30, 314);
            this.textBox_endYear.Name = "textBox_endYear";
            this.textBox_endYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_endYear.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "End Year";
            // 
            // textBox_AgGrowthRate
            // 
            this.textBox_AgGrowthRate.Location = new System.Drawing.Point(152, 314);
            this.textBox_AgGrowthRate.Name = "textBox_AgGrowthRate";
            this.textBox_AgGrowthRate.Size = new System.Drawing.Size(89, 20);
            this.textBox_AgGrowthRate.TabIndex = 25;
            // 
            // agGrowthRate
            // 
            this.agGrowthRate.AutoSize = true;
            this.agGrowthRate.Location = new System.Drawing.Point(269, 314);
            this.agGrowthRate.Name = "agGrowthRate";
            this.agGrowthRate.Size = new System.Drawing.Size(131, 13);
            this.agGrowthRate.TabIndex = 26;
            this.agGrowthRate.Text = "Ag Growth Rate (50 - 150)";
            this.agGrowthRate.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_LakeWater
            // 
            this.textBox_LakeWater.Location = new System.Drawing.Point(152, 260);
            this.textBox_LakeWater.Name = "textBox_LakeWater";
            this.textBox_LakeWater.Size = new System.Drawing.Size(89, 20);
            this.textBox_LakeWater.TabIndex = 27;
            // 
            // textBox_LWM
            // 
            this.textBox_LWM.AutoSize = true;
            this.textBox_LWM.Location = new System.Drawing.Point(266, 260);
            this.textBox_LWM.Name = "textBox_LWM";
            this.textBox_LWM.Size = new System.Drawing.Size(81, 13);
            this.textBox_LWM.TabIndex = 28;
            this.textBox_LWM.Text = "LWM (80 - 140)";
            // 
            // textBox_state
            // 
            this.textBox_state.Location = new System.Drawing.Point(152, 368);
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(100, 20);
            this.textBox_state.TabIndex = 29;
            // 
            // TheState
            // 
            this.TheState.AutoSize = true;
            this.TheState.Location = new System.Drawing.Point(160, 349);
            this.TheState.Name = "TheState";
            this.TheState.Size = new System.Drawing.Size(32, 13);
            this.TheState.TabIndex = 30;
            this.TheState.Text = "State";
            // 
            // textBox_desal
            // 
            this.textBox_desal.Location = new System.Drawing.Point(152, 286);
            this.textBox_desal.Name = "textBox_desal";
            this.textBox_desal.Size = new System.Drawing.Size(87, 20);
            this.textBox_desal.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Desal ( 0 - 100)";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // textBox_policyStartYear
            // 
            this.textBox_policyStartYear.Location = new System.Drawing.Point(28, 368);
            this.textBox_policyStartYear.Name = "textBox_policyStartYear";
            this.textBox_policyStartYear.Size = new System.Drawing.Size(100, 20);
            this.textBox_policyStartYear.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Policy Start Yr";
            // 
            // sankeyGraph1
            // 
            this.sankeyGraph1.FlowBarDrawOrder = ConsumerResourceModelFramework.SankeyGraph.DrawOrder.doBottomUp;
            this.sankeyGraph1.Location = new System.Drawing.Point(12, 394);
            this.sankeyGraph1.Name = "sankeyGraph1";
            this.sankeyGraph1.NegativeColor = System.Drawing.Color.Red;
            this.sankeyGraph1.Network = null;
            this.sankeyGraph1.NetworkBackground = System.Drawing.Color.Black;
            this.sankeyGraph1.PositiveColor = System.Drawing.Color.YellowGreen;
            this.sankeyGraph1.Size = new System.Drawing.Size(613, 350);
            this.sankeyGraph1.TabIndex = 2;
            // 
            // IConservation
            // 
            this.IConservation.Location = new System.Drawing.Point(152, 96);
            this.IConservation.Name = "IConservation";
            this.IConservation.Size = new System.Drawing.Size(88, 20);
            this.IConservation.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Industrial Conserv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 781);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IConservation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_policyStartYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_desal);
            this.Controls.Add(this.TheState);
            this.Controls.Add(this.textBox_state);
            this.Controls.Add(this.textBox_LWM);
            this.Controls.Add(this.textBox_LakeWater);
            this.Controls.Add(this.agGrowthRate);
            this.Controls.Add(this.textBox_AgGrowthRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_endYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_drought);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RM);
            this.Controls.Add(this.GM);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.PCONS);
            this.Controls.Add(this.ACONS);
            this.Controls.Add(this.UCONS);
            this.Controls.Add(this.PConservation);
            this.Controls.Add(this.AConservation);
            this.Controls.Add(this.UConservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_popGrowthRate);
            this.Controls.Add(this.sankeyGraph1);
            this.Controls.Add(this.listBoxParmValues);
            this.Controls.Add(this.Invoke_Model);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Invoke_Model;
        private System.Windows.Forms.ListBox listBoxParmValues;
        private ConsumerResourceModelFramework.SankeyGraph sankeyGraph1;
        private System.Windows.Forms.TextBox textBox_popGrowthRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UConservation;
        private System.Windows.Forms.TextBox AConservation;
        private System.Windows.Forms.TextBox PConservation;
        private System.Windows.Forms.Label UCONS;
        private System.Windows.Forms.Label ACONS;
        private System.Windows.Forms.Label PCONS;
        private System.Windows.Forms.TextBox SM;
        private System.Windows.Forms.TextBox GM;
        private System.Windows.Forms.TextBox RM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_drought;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_endYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_AgGrowthRate;
        private System.Windows.Forms.Label agGrowthRate;
        private System.Windows.Forms.TextBox textBox_LakeWater;
        private System.Windows.Forms.Label textBox_LWM;
        private System.Windows.Forms.TextBox textBox_state;
        private System.Windows.Forms.Label TheState;
        private System.Windows.Forms.TextBox textBox_desal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_policyStartYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IConservation;
        private System.Windows.Forms.Label label9;
    }
}

