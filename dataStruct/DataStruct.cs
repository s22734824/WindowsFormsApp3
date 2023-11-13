using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.dataStruct
{
    public struct DStatus
    {
        public string title;
        public int address;
        public int status;
    }

    public struct IoStatus
    {
        public string title;
        public int address;
        public bool status;
    };

    public enum IOModelType
    {
        Input,
        Output,
    }

    public struct IoModel
    {
        public string title;
        public IOModelType ModelType;
        public IoStatus[] ioStatuses; 
    };
}
