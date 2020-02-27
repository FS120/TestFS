﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace zoomreport2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("1142a8fd-e4b0-447a-9c90-f4a749554df0", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the zoomreport2Repository repository.
        /// </summary>
        public static zoomreport2Repository repo = zoomreport2Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL' at 4;4.", repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAILInfo, new RecordItemIndex(0));
            repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL.Click(new Location(Ctl00DollarphCenterDollartxtEMAIL_Screenshot1, "4;4", Ctl00DollarphCenterDollartxtEMAIL_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'firdous' with focus on 'PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL'.", repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAILInfo, new RecordItemIndex(1));
            repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL.PressKeys("firdous");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '.sayyed{LShiftKey down}@{LShiftKey up}zensoftservices.com' with focus on 'PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL'.", repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAILInfo, new RecordItemIndex(2));
            repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAIL.PressKeys(".sayyed{LShiftKey down}@{LShiftKey up}zensoftservices.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollarbtnSubmitx' at 10;4.", repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollarbtnSubmitxInfo, new RecordItemIndex(3));
            repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollarbtnSubmitx.Click(new Location(Ctl00DollarphCenterDollarbtnSubmitx_Screenshot1, "10;4", Ctl00DollarphCenterDollarbtnSubmitx_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PricewaterhouseCoopersInternationalLim1.FormFormGroup' at 4;4.", repo.PricewaterhouseCoopersInternationalLim1.FormFormGroupInfo, new RecordItemIndex(4));
            repo.PricewaterhouseCoopersInternationalLim1.FormFormGroup.Click(new Location(FormFormGroup_Screenshot1, "4;4", FormFormGroup_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'pWc{LShiftKey down}@{LShiftKey up}!23456' with focus on 'PricewaterhouseCoopersInternationalLim1.PricewaterhouseCoopersInternationalLim'.", repo.PricewaterhouseCoopersInternationalLim1.PricewaterhouseCoopersInternationalLimInfo, new RecordItemIndex(5));
            repo.PricewaterhouseCoopersInternationalLim1.PricewaterhouseCoopersInternationalLim.EnsureVisible();
            Keyboard.Press("pWc{LShiftKey down}@{LShiftKey up}!23456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PricewaterhouseCoopersInternationalLim1.Ctl00DollarphCenterDollarbtnSubmit' at 6;4.", repo.PricewaterhouseCoopersInternationalLim1.Ctl00DollarphCenterDollarbtnSubmitInfo, new RecordItemIndex(6));
            repo.PricewaterhouseCoopersInternationalLim1.Ctl00DollarphCenterDollarbtnSubmit.Click(new Location(Ctl00DollarphCenterDollarbtnSubmit_Screenshot1, "6;4", Ctl00DollarphCenterDollarbtnSubmit_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Workbench.Workbench' at 8;7.", repo.Workbench.WorkbenchInfo, new RecordItemIndex(7));
            repo.Workbench.Workbench.Click(new Location(Workbench_Screenshot1, "8;7", Workbench_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Workbench.SharedReportsInputSearch' at 5;5.", repo.Workbench.SharedReportsInputSearchInfo, new RecordItemIndex(8));
            repo.Workbench.SharedReportsInputSearch.Click(new Location(SharedReportsInputSearch_Screenshot1, "5;5", SharedReportsInputSearch_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'league' with focus on 'Workbench.SharedReportsInputSearch'.", repo.Workbench.SharedReportsInputSearchInfo, new RecordItemIndex(9));
            repo.Workbench.SharedReportsInputSearch.PressKeys("league");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 's' with focus on 'Workbench.SharedReportsInputSearch'.", repo.Workbench.SharedReportsInputSearchInfo, new RecordItemIndex(10));
            repo.Workbench.SharedReportsInputSearch.PressKeys("s");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Workbench.LeaguesAndTeams' at 16;5.", repo.Workbench.LeaguesAndTeamsInfo, new RecordItemIndex(11));
            repo.Workbench.LeaguesAndTeams.Click(new Location(LeaguesAndTeams_Screenshot1, "16;5", LeaguesAndTeams_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=623,Height=496}) on item 'Workbench.SomeCanvasTag'.", repo.Workbench.SomeCanvasTagInfo, new RecordItemIndex(12));
            Validate.ContainsImage(repo.Workbench.SomeCanvasTagInfo, SomeCanvasTag_Screenshot1, SomeCanvasTag_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Workbench.SomeCanvasTag' at 4;4.", repo.Workbench.SomeCanvasTagInfo, new RecordItemIndex(13));
            repo.Workbench.SomeCanvasTag.Click(new Location(SomeCanvasTag_Screenshot1_2, "4;4", SomeCanvasTag_Screenshot1_2_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=623,Height=496}) on item 'Workbench.SomeCanvasTag'.", repo.Workbench.SomeCanvasTagInfo, new RecordItemIndex(14));
            Validate.ContainsImage(repo.Workbench.SomeCanvasTagInfo, SomeCanvasTag_Screenshot2, SomeCanvasTag_Screenshot2_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Ctl00DollarphCenterDollartxtEMAIL_Screenshot1
        { get { return repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollartxtEMAILInfo.GetScreenshot1(new Rectangle(76, 14, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Ctl00DollarphCenterDollartxtEMAIL_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Ctl00DollarphCenterDollarbtnSubmitx_Screenshot1
        { get { return repo.PricewaterhouseCoopersInternationalLim.Ctl00DollarphCenterDollarbtnSubmitxInfo.GetScreenshot1(new Rectangle(31, 14, 18, 11)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Ctl00DollarphCenterDollarbtnSubmitx_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage FormFormGroup_Screenshot1
        { get { return repo.PricewaterhouseCoopersInternationalLim1.FormFormGroupInfo.GetScreenshot1(new Rectangle(114, 177, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions FormFormGroup_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Ctl00DollarphCenterDollarbtnSubmit_Screenshot1
        { get { return repo.PricewaterhouseCoopersInternationalLim1.Ctl00DollarphCenterDollarbtnSubmitInfo.GetScreenshot1(new Rectangle(50, 12, 10, 10)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Ctl00DollarphCenterDollarbtnSubmit_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Workbench_Screenshot1
        { get { return repo.Workbench.WorkbenchInfo.GetScreenshot1(new Rectangle(1064, 16, 20, 11)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Workbench_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage SharedReportsInputSearch_Screenshot1
        { get { return repo.Workbench.SharedReportsInputSearchInfo.GetScreenshot1(new Rectangle(407, 10, 10, 10)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions SharedReportsInputSearch_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage LeaguesAndTeams_Screenshot1
        { get { return repo.Workbench.LeaguesAndTeamsInfo.GetScreenshot1(new Rectangle(62, 6, 24, 10)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions LeaguesAndTeams_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage SomeCanvasTag_Screenshot1
        { get { return repo.Workbench.SomeCanvasTagInfo.GetScreenshot1(new Rectangle(0, 0, 623, 496)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions SomeCanvasTag_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage SomeCanvasTag_Screenshot1_2
        { get { return repo.Workbench.SomeCanvasTagInfo.GetScreenshot1(new Rectangle(448, 219, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions SomeCanvasTag_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage SomeCanvasTag_Screenshot2
        { get { return repo.Workbench.SomeCanvasTagInfo.GetScreenshot2(new Rectangle(0, 0, 623, 496)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions SomeCanvasTag_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}