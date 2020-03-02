using System;

namespace Facade
{
    public class ScheduleServerImpl: IScheduleServer
    {
        public void StartBooting()
        {
            Console.WriteLine("Booting...");
        }

        public void ReadSystemConfigFile()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeContext()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeListeners()
        {
            throw new System.NotImplementedException();
        }

        public void CreateSystemObjects()
        {
            throw new System.NotImplementedException();
        }

        public void ReleaseProcesses()
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public void DestroySystemObjects()
        {
            throw new System.NotImplementedException();
        }

        public void DestroyListeners()
        {
            throw new System.NotImplementedException();
        }

        public void DestroyContext()
        {
            throw new System.NotImplementedException();
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down...");
        }
    }
}