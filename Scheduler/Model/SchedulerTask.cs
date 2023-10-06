using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGraphicLibrary.Scheduler.Model
{
    public class SchedulerTask
    {
        public SchedulerTask() { }

        public string TaskName { get; set; }
        public string TaskGroup { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
