using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behaviac
{
    public class BaseLogger
    {
        public virtual void Log(string message)
        {
            //UnityEngine.Debug.Log(message);
            Console.WriteLine(message);
        }

        public virtual void LogWarning(string message)
        {
            //UnityEngine.Debug.LogWarning(message);
            Console.WriteLine("Warn: " + message);
        }

        public virtual void LogError(string message)
        {
            //UnityEngine.Debug.LogError(message);
            Console.WriteLine("Error: " + message);
        }

        public virtual void LogError(Exception ex)
        {
            //UnityEngine.Debug.LogError(ex.Message);
            Console.WriteLine("Error: " + ex);
        }

        public static readonly BaseLogger ConsoleLogger = new BaseLogger();
        public static BaseLogger Instance { get; set; }
    }

    public class BaseTimer
    {
        public virtual int FrameSinceStartup
        {
            get
            {
                //return (m_frameSinceStartup < 0) ? Time.frameCount : m_frameSinceStartup;
                return 0;
            }
            set { }
        }

        public virtual int TimeSinceStartup
        {
            get
            {
                //return Time.realtimeSinceStartup;
                return 0;
            }
        }

        public static BaseTimer Instance { get; set; }
    }
}
