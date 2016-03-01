using System;
using behaviac;

namespace test_cs
{
    /// <summary>
    /// 注意：因为workspace使用的是从CallingAssembly中读取类型，所以定义在这个exe工程中的类型不会被导出
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ExportMetas();
            Console.WriteLine("done");
            Console.ReadLine();
        }

        static void ExportMetas()
        {
            BaseTimer.Instance = new BaseTimer();
            BaseLogger.Instance = new BaseLogger();

            //< write log file
            Config.IsLogging = true;
            //behaviac.Config.IsSocketing = false;

            Workspace.Instance.FilePath = @"D:\project-learn\behaviac\integration\test_cs\behaviac_generated\";
            Workspace.Instance.FileFormat = Workspace.EFileFormat.EFF_xml;

            //register names
            //behaviac.Agent.RegisterInstanceName<GameLevelCommon>("GameLevel");
            //behaviac.Agent.RegisterInstanceName<FirstAgent>();
            Workspace.Instance.ExportMetas("FirstAgentMeta.xml");

            Debug.Log("Behaviac meta data export over.");
            Agent.SetIdMask(0xffffffff);
        }
    }
}
