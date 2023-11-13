using AMBU_Component;
using System.Collections.Generic;
using System;
using WindowsFormsApp3.dataStruct;

namespace WindowsFormsApp3.Tools
{
    class DeltaTCP : IDisposable
    {
        readonly AMBUModbusTCP _ModbusTcp;
        private int inputCount;
        private int outputCount;
        public List<bool[]> XList
        {
            get
            {
                object obj = new object();
                lock (obj)
                {
                    return xList;
                }
            }
            set
            {
                object obj = new object();
                lock (obj)
                {
                    xList = value;
                }
            }
        }
        private List<bool[]> xList;
        public List<bool[]> YList
        {
            get
            {
                object obj = new object();
                lock (obj)
                {
                    return yList;
                }
            }
            set
            {
                object obj = new object();
                lock (obj)
                {
                    yList = value;
                }
            }
        }
        private List<bool[]> yList;

        public List<DStatus> DList
        {
            get
            {
                object obj = new object();
                lock (obj)
                {
                    return dList;
                }
            }
            set
            {
                object obj = new object();
                lock (obj)
                {
                    dList = value;
                }
            }
        }
        private List<DStatus> dList;

        public List<IoStatus> MList
        {
            get
            {
                object obj = new object();
                lock (obj)
                {
                    return mList;
                }
            }
            set
            {
                object obj = new object();
                lock (obj)
                {
                    mList = value;
                }
            }
        }
        private List<IoStatus> mList;

        public DeltaTCP(int Port, string IP)
        {
            _ModbusTcp = new AMBUModbusTCP(Port, IP);
            dList = new List<DStatus>();
            mList = new List<IoStatus>();
        }

        public void AddDList(string Title, int Addr)
        {
            dList.Add(new DStatus() { title = Title, address = Addr, status = 0 });
        }

        public void AddMList(string Title, int Addr)
        {
            mList.Add(new IoStatus() { title = Title, address = Addr });
        }

        public void SettingModule(int InputCount, int OutputCount)
        {
            inputCount = InputCount;
            outputCount = OutputCount;
            XList = new List<bool[]>();
            YList = new List<bool[]>();
            for (int i = 0; i < InputCount; i++)
            {
                XList.Add(new bool[16]);
            }
            for (int i = 0; i < OutputCount; i++)
            {
                YList.Add(new bool[16]);
            }
        }

        public void Scan()
        {
            if (_ModbusTcp.connected)
            {
                for (int i = 0; i < inputCount; i++)
                {
                    bool[] arrs = new bool[16];
                    ReadInputModule(i, ref arrs);
                    XList[i] =arrs;
                }
                for (int i = 0; i < outputCount; i++)
                {
                    WriteOutPutModule(i, YList[i]);
                }
                for (int i = 0; i < dList.Count; i++)
                {
                    DStatus s = dList[i];
                    s.status = ReadDBuffer(dList[i]);
                    dList[i] = s;
                }
                for (int i = 0; i < mList.Count; i++)
                {
                    IoStatus ss = mList[i];
                    ss.status = ReadMStatus(ss);
                    mList[i] = ss;
                }
            }
        }

        private void ReadInputModule(int Module, ref bool[] BitArray)
        {
            BitArray = new bool[16];
            int _addr = 0x6000 + Module*16;
            _ModbusTcp.ReadCoils(_addr, 16, ref BitArray);
        }

        private void WriteOutPutModule(int Module, bool[] BitArray)
        {
            int _addr = 0xA000 + Module;
            Int16 _output = transBoolArrayToInt(BitArray);
            _ModbusTcp.WriteSingleInt16(_addr, _output);
        }
        private int ReadDBuffer(DStatus Obj)
        {
            int[] ret = new int[1];
            _ModbusTcp.ReadMultipleInt32(Obj.address, 1, ref ret);
            return ret[0];
        }

        private bool ReadMStatus(IoStatus M)
        {
            bool[] b = new bool[1];
            _ModbusTcp.ReadCoils(M.address, 1, ref b);
            return b[0];
        }

        private Int16 transBoolArrayToInt(bool[] array)
        {
            Int16 result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    result |= (Int16)(1 << i);
                }
            }
            return result;
        }

        public void Dispose()
        {
            _ModbusTcp.Dispose();
        }
    }
}
