using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UniDB;
using WaterSimDCDC;

namespace WaterSimDCDC.Tools
{
    /// <summary>   Simulation writer. </summary>
    public class SimWriter
    {
        WaterSimManager_SIO FWS = null;
        SimulationResults FSimResult = null;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="WaterSimManager">  Manager for water simulation. </param>
        ///-------------------------------------------------------------------------------------------------

        public SimWriter(WaterSimManager_SIO WaterSimManager)
        {
            FWS = WaterSimManager;
            FSimResult = FWS.SimulationRunResults;
        }


        string GetDataString(int[] DataArray, int[] ParmIDs, string[] UseFields, UniDB.Tools.DataFormat DF, int ColWidth)
        {
            string DataStr = "";
            bool UseAll = false;
            // if there are results
            if (FSimResult != null)
            {
                // check to see if any fields were defined, if not do all
                if ((UseFields == null) || (UseFields.Length == 0))
                {
                    UseAll = true;
                }
                // otherwise set them to upper case
                else
                {
                    for (int i = 0; i < UseFields.Length; i++)
                    {
                        UseFields[i] = UseFields[i].ToUpper();
                    }
                }
                // for each parameter
                List<int> DataList = new List<int>();
                for (int DataIndex = 0;DataIndex < DataArray.Length; DataIndex++) 
                //foreach (int ParmID in FieldIDs)
                {
                    // get the modelparameter
                    ModelParameterClass MP = FWS.ParamManager.Model_Parameter(ParmIDs[DataIndex]);
                    // if found
                    if (MP != null)
                    {
                        // get the fieldname
                        string FldStr = MP.Fieldname.ToUpper();
                        // test if we are to use this
                        if ((UseAll) || UseFields.Contains(FldStr))
                        {
                            DataList.Add(DataArray[DataIndex]);
                        }
                    }
                }
                DataStr = UniDB.Tools.PutDataInTextLine(DataList.ToArray(), DF, ColWidth);

            }
            return DataStr;
        }

        string GetFields(int[] FieldIDs, string[] UseFields, UniDB.Tools.DataFormat DF, int ColWidth)
        {
            string fieldsStr = "";
            bool UseAll = false;
            // if there are results
            if (FSimResult != null)
            {
                // check to see if any fields were defined, if not do all
                if ((UseFields == null) || (UseFields.Length == 0))
                {
                    UseAll = true;
                }
                // otherwise set them to upper case
                else
                {
                    for (int i = 0; i < UseFields.Length; i++)
                    {
                        UseFields[i] = UseFields[i].ToUpper();
                    }
                }
                // for each parameter
                List<string> Fieldnames = new List<string>(); 
                foreach (int ParmID in FieldIDs)
                {
                    // get the modelparameter
                    ModelParameterClass MP = FWS.ParamManager.Model_Parameter(ParmID);
                    // if found
                    if (MP != null)
                    {
                        // get the fieldname
                        string FldStr = MP.Fieldname.ToUpper();
                        // test if we are to use this
                        if ((UseAll) || UseFields.Contains(FldStr))
                        {
                            Fieldnames.Add(FldStr);
                        }
                    }
                }
                fieldsStr = UniDB.Tools.PutDataInTextLine(Fieldnames.ToArray(), DF, ColWidth);

            }
            return fieldsStr;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Exports the given file. </summary>
        ///
        /// <param name="Filename">     Filename of the file to write to. </param>
        /// <param name="TheFormat">    the format to use when write to the file. </param>
        /// <param name="Colwidth">     The colwidth of the column if DataFormat.FixedWidth </param>
        /// <param name="WriteHeader">  true to write header usng fieldnames. </param>
        /// <param name="ErrMessage">   [out] Message describing the error. </param>
        /// <param name="UseFields">    The use fields an array of fieldnames to write to the file. if null or 0 length all fields written. </param>
        ///
        /// <returns>   true if it succeeds, false if it fails. </returns>
        ///-------------------------------------------------------------------------------------------------

        public bool ExportText(string Filename, string ScenarioName, UniDB.Tools.DataFormat TheFormat, int Colwidth, bool WriteHeader, out string ErrMessage, string[] UseFields)
        {
            bool writeResult = false;
            ErrMessage = "";
            if (FSimResult != null)
            {
                try
                {
                    using (StreamWriter SW = new StreamWriter(Filename))
                    {
                        // Write HEader
                        if (WriteHeader)
                        {

                            string[] BaseFields = new string[5] {"ID","SCN_NAME","SIMYEAR","PRVDCODE","PRVDLABEL"};

                            string HeaderStr = UniDB.Tools.PutDataInTextLine(BaseFields,TheFormat, Colwidth);
                            // Do Base Inputs
                            string BaseInStr = "";
                            if (FSimResult[0].Inputs.BaseInputModelParam.Length > 0)
                            {
                                BaseInStr = GetFields(FSimResult[0].Inputs.BaseInputModelParam, UseFields, TheFormat, Colwidth);
                            }
                            // DO Provider Inputs
                            string ProviderInStr = "";
                            if (FSimResult[0].Inputs.ProviderInputModelParam.Length > 0)
                            {
                                ProviderInStr = GetFields(FSimResult[0].Inputs.ProviderInputModelParam, UseFields, TheFormat, Colwidth);
                            }
                            // Do Base Outputs
                            string BaseOutStr = "";
                            if (FSimResult[0].Outputs.BaseOutputModelParam.Length > 0)
                            {

                                BaseOutStr = GetFields(FSimResult[0].Outputs.BaseOutputModelParam, UseFields, TheFormat, Colwidth);
                            }
                            // Do Provider Outputs
                            string ProviderOutStr = "";
                            if (FSimResult[0].Outputs.ProviderOutputModelParam.Length>0)
                            {
                                ProviderOutStr = GetFields(FSimResult[0].Outputs.ProviderOutputModelParam, UseFields, TheFormat, Colwidth);
                            }

                            string[] AllStrings = new string[5];
                            AllStrings[0] = HeaderStr;
                            AllStrings[1] = BaseInStr;
                            AllStrings[2] = ProviderInStr;
                            AllStrings[3] = BaseOutStr;
                            AllStrings[4] = ProviderOutStr;

                            string OutStr = UniDB.Tools.PutDataInTextLine(AllStrings, TheFormat, Colwidth);
                            SW.WriteLine(OutStr);
                        }
                        // Write Data
                        Int64 ID = UniDB.Tools.CreatePrimaryIDIntSeed();

                        foreach (AnnualSimulationResults ASR in FSimResult.GetAllYears())
                        {
                            foreach (eProvider ep in ProviderClass.providers())
                            {
                                string[] BaseData = new string[5];
                                BaseData[0] = ID.ToString();
                                BaseData[1] = ScenarioName;
                                BaseData[2] = ASR.year.ToString();
                                BaseData[3] = ProviderClass.FieldName(ep);
                                BaseData[4] = ProviderClass.Label(ep);


                                string DataStr = UniDB.Tools.PutDataInTextLine(BaseData, TheFormat, Colwidth);

                                // Do Base Inputs
                                string DataBaseInStr =  "";
                                if (ASR.Inputs.BaseInputModelParam.Length >0)
                                {
                                    DataBaseInStr = GetDataString(ASR.Inputs.BaseInput.Values, ASR.Inputs.BaseInputModelParam, UseFields, TheFormat, Colwidth);
                                }
                                // DO Provider Inputs
                                string DataProviderInStr = "";
                                if (ASR.Inputs.ProviderInputModelParam.Length > 0)
                                {
                                    if (ASR.Inputs.ProviderInput.Values.Length > 0)
                                    {
                                        DataProviderInStr = GetDataString(ASR.Inputs.ProviderInput.Values[(int)ep].Values, ASR.Inputs.ProviderInputModelParam, UseFields, TheFormat, Colwidth);
                                    }
                                }
                                // Do Base Outputs
                                string DataBaseOutStr = "";
                                if (ASR.Outputs.BaseOutputModelParam.Length > 0)
                                {
                                    DataBaseOutStr = GetDataString(ASR.Outputs.BaseOutput.Values, ASR.Outputs.BaseOutputModelParam, UseFields, TheFormat, Colwidth);
                                }
                                // Do Provider Outputs
                                string DataProviderOutStr = "";
                                if (ASR.Outputs.ProviderOutputModelParam.Length > 0)
                                {
                                    if (ASR.Outputs.ProviderOutput.Values.Length > 0)
                                    {
                                        DataProviderOutStr = GetDataString(ASR.Outputs.ProviderOutput.Values[(int)ep].Values, ASR.Outputs.ProviderOutputModelParam, UseFields, TheFormat, Colwidth);
                                    }
                                }
                                string[] AllStrings = new string[5];
                                AllStrings[0] = DataStr;
                                AllStrings[1] = DataBaseInStr;
                                AllStrings[2] = DataProviderInStr;
                                AllStrings[3] = DataBaseOutStr;
                                AllStrings[4] = DataProviderOutStr;

                                string OutStr = UniDB.Tools.PutDataInTextLine(AllStrings, TheFormat, Colwidth);

                                SW.WriteLine(OutStr);
                                ID++;
                            }
                        }
                    }
                    writeResult = true;
                }
                catch (Exception ex)
                {
                    ErrMessage = ex.Message;
                }
            }
            return writeResult;
        }
    }
}
