using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaterSimDCDC;
using WaterSimDCDC.Tools;
using WaterSimDCDC.America;
using ConsumerResourceModelFramework;
//using WaterSimDCDC.Processes;

namespace TestModel
{
    public partial class Form1 : Form
    {
        WaterSimManager_SIO ws;
       // internal StreamWriter sw;
        DateTime now = DateTime.Now;

        string LogFilename = "";
        //string CurrentState = "Florida";
        int state = 5;
        //string CurrentState = "Wyoming";
      //  WaterSimDCDC.Processes.AlterWaterManagementFeedbackProcess WM;
        public Form1()
        {
            InitializeComponent();
            string path = System.IO.Directory.GetCurrentDirectory();
            ws = new WaterSimManager_SIO(path, TempDirectoryName);
            //
            // 0=Florida, 1="Idaho", 2= "Illinois", 3="Minnesota", 4="Wyoming", 5="Arizona", 6="Colorado", 7="Nevada", 8="California", 9="Utah", 10=New Mexico"

            // 0=Florida, 1="Idaho", 2= "Illinois", 3="Minnesota", 4="Wyoming", 5="Arizona", 6="Colorado", 7="Nevada", 8="California", 9="Utah",
            // 10="New Mexico", 11="Alabama", 12="Kansas", 13="Tennessee", 14="Virginia"
            //
            state = ws.ParamManager.Model_Parameter("ST").Value = 5 ;
           // WM = new AlterWaterManagementFeedbackProcess("Alter Water Management");
            //
            sankeyGraph1.Network = ws.TheCRFNetwork;// 
            ws.TheCRFNetwork.CallBackMethod = sankwycallback;
            ws.Simulation_Start_Year = 2015;
            //ws.Simulation_End_Year = 2050;
            LogFilename = string.Concat(path + "\\" + "Output" + "\\" + "Output_" + now.Month.ToString()
             + now.Day.ToString() + now.Minute.ToString() + now.Second.ToString()
              + "_" );       
        }

        private void Invoke_Model_Click(object sender, EventArgs e)
        {
            RunModel();
            sankeyGraph1.ResetGraph();
        }

        #region Website directory faking
        private static string DataDirectoryName
        {
            get
            {
                return @"App_Data\";
            }
        }

        private static string TempDirectoryName
        {
            set
            {
                string dir = value;
                string.Concat(@"WaterSmith_Output\", dir);
            }
            get
            {
                // Make a common for testing
                return @"WaterSmith_Output\";
                // Make the temp directory name unique for each access to avoid client clashes
                //return +System.Guid.NewGuid().ToString() + @"\";
            }
        }
        private static void CreateDirectory(string directoryName)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(directoryName);
            if (!dir.Exists)
            {
                dir.Create();
            }
        }
        #endregion

        void ShowWSData()
        {
            listBoxParmValues.Items.Clear();

            foreach (int Index in ws.ParamManager.eModelParameters())
            {
                int tempint = ws.ParamManager.Model_Parameter(Index).Value;
                string Label = ws.ParamManager.Model_Parameter(Index).Label;
                listBoxParmValues.Items.Add((Label + ": ").PadRight(40) + tempint.ToString("N0"));
            }
        }

        private void textBox_popGrowthRate_TextChanged(object sender, EventArgs e)
        {
            //int anInteger;
            //anInteger = Convert.ToInt32(textBox_popGrowthRate.Text);
            //ws.ParamManager.Model_Parameter("POPGR").Value = Convert.ToInt32(textBox_popGrowthRate.Text);
        }

        void sankwycallback()
        {
            sankeyGraph1.ResetGraph();
        }
        void initializeAnnualModel()
        {
            if (SM.Text != "")
           ws.ParamManager.Model_Parameter("SWM").Value = Convert.ToInt32(SM.Text);
            if (GM.Text != "")
            ws.ParamManager.Model_Parameter("GWM").Value = Convert.ToInt32(GM.Text);
            if (RM.Text != "")
                ws.ParamManager.Model_Parameter("RECM").Value = Convert.ToInt32(RM.Text);
            if (textBox_state.Text != "")
                ws.ParamManager.Model_Parameter("ST").Value = Convert.ToInt32(textBox_state.Text);


        }

        int ScenarioCount = 0;
        public void RunModel()
        {
            ws.Simulation_Initialize();
            //
            if(textBox_popGrowthRate.Text != "")
            ws.ParamManager.Model_Parameter("POPGR").Value = Convert.ToInt32(textBox_popGrowthRate.Text);
            if (UConservation.Text != "")
            ws.ParamManager.Model_Parameter("UCON").Value = Convert.ToInt32(UConservation.Text);
            if (AConservation.Text != "")
            ws.ParamManager.Model_Parameter("ACON").Value = Convert.ToInt32(AConservation.Text);
           // ws.ParamManager.Model_Parameter("AGCON").Value = Convert.ToInt32(AConservation.Text);
            if (PConservation.Text != "")
            ws.ParamManager.Model_Parameter("PCON").Value = Convert.ToInt32(PConservation.Text);

            if (IConservation.Text != "")
                ws.ParamManager.Model_Parameter("ICON").Value = Convert.ToInt32(IConservation.Text);

            if (SM.Text != "")
            ws.ParamManager.Model_Parameter("SWM").Value = Convert.ToInt32(SM.Text);
            if (GM.Text != "")
            ws.ParamManager.Model_Parameter("GWM").Value = Convert.ToInt32(GM.Text);
            if (RM.Text != "")
            ws.ParamManager.Model_Parameter("RECM").Value = Convert.ToInt32(RM.Text);
            //
            if (textBox_drought.Text != "")
                ws.ParamManager.Model_Parameter("DC").Value = Convert.ToInt32(textBox_drought.Text);
            //
            if (textBox_AgGrowthRate.Text != "")
                ws.ParamManager.Model_Parameter("AGGR").Value = Convert.ToInt32(textBox_AgGrowthRate.Text);
            //
            if (textBox_LakeWater.Text != "")
                ws.ParamManager.Model_Parameter("LWM").Value = Convert.ToInt32(textBox_LakeWater.Text);
            //
            //
            if (textBox_desal.Text != "")
                ws.ParamManager.Model_Parameter("DESAL").Value = Convert.ToInt32(textBox_desal.Text);
            //
         
            if (textBox_state.Text != "")
                ws.ParamManager.Model_Parameter("ST").Value = Convert.ToInt32(textBox_state.Text);

            //
           // ws.Simulation_End_Year = 2050;
            if (textBox_endYear.Text != "")
                ws.Simulation_End_Year = Convert.ToInt32(textBox_endYear.Text);
            //
            if (textBox_policyStartYear.Text != "")
                ws.ParamManager.Model_Parameter("PST").Value = Convert.ToInt32(textBox_policyStartYear.Text);
 

            //
           // ws.ProcessManager.AddProcess(WM);

            ws.Simulation_AllYears();
            ws.Simulation_Stop();
            SimulationResults SR = ws.SimulationRunResults;

            SimWriter SimWrite = new SimWriter(ws);
            string AnErrMessage = "";
            bool showoutputs = true;
            if (showoutputs)
            {
                if (!SimWrite.ExportText(LogFilename + ScenarioCount.ToString() + ".csv", "Scenario" + ScenarioCount.ToString(), UniDB.Tools.DataFormat.CommaDelimited, 0, true, out AnErrMessage, null))
                {
                }
                ShowWSData();
            }
            else
            {
            }
            ScenarioCount++;
        }

        public void StreamW(string TheLine)
        {
            using (StreamWriter SW = new StreamWriter(LogFilename))
            {
                //string filename = string.Concat(path + "\\" + "Output" + "\\" + "Output_" + now.Month.ToString()
                //    + now.Day.ToString() + now.Minute.ToString() + now.Second.ToString()
                //    + "_" + ".csv");
                SW.WriteLine(TheLine);     
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
