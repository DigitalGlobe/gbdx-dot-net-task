using System;
using Newtonsoft.Json;
using System.IO;

namespace DotNetSampleTask
{
    class TaskInput
    {
        public string inputstring {get; set;}
    };

    class TaskOutput
    {
        public string dependency_output {get; set;}
    };

    class TaskStatus
    {
        public string status {get; set;}
        public string reason {get; set;}
    };
    
    class DotNetSampleTask
    {
        static void Main(string[] args)
        {
            var taskInput = JsonConvert.DeserializeObject<TaskInput>(File.ReadAllText(@"/mnt/work/input/ports.json"));
            System.Console.WriteLine("Got input string:{0}", taskInput.inputstring);

            var taskOutput = new TaskOutput { dependency_output = "This is a string port output." };
            File.WriteAllText(@"/mnt/work/output/ports.json", JsonConvert.SerializeObject(taskOutput));

            var taskStatus = new TaskStatus { status = "success", reason = "Got: " + taskInput.inputstring };
            File.WriteAllText(@"/mnt/work/status.json", JsonConvert.SerializeObject(taskStatus));
        }
    }
}
