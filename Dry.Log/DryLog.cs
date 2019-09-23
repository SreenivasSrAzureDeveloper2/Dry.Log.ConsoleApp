using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dry.Log
{
    public class DryLog : IDryLog
    {
        string _fileName;
        int _isType;
        public DryLog(string fileName, DryLogChoice type)
        {
            _isType = (int)type;
            _fileName = fileName;
        }
        public void Debug(string message, string statuCode)
        {
            Base(message, statuCode, "Debug");
        }
        public void Fatal(string message, string statuCode)
        {
            Base(message, statuCode, "Fatal");
        }
        public void Info(string message, string statuCode)
        {
            Base(message, statuCode, "Info");
        }
        private void Base(string message, string statuCode, string type)
        {
            if (_isType == 0)
                FileLog(_fileName, message, DateTime.UtcNow.ToString(), statuCode, type);
            else if (_isType == 1)
                SqlLog(_fileName, message, DateTime.UtcNow.ToString(), statuCode, type);
            else if (_isType == 2)
                ElasticLog(_fileName, message, DateTime.UtcNow.ToString(), statuCode, type);
            else if (_isType == 3)
                AzureLog(_fileName, message, DateTime.UtcNow.ToString(), statuCode, type);
            else if (_isType == 4)
                ExcelLog(_fileName, message, DateTime.UtcNow.ToString(), statuCode, type);
        }


        private void FileLog(string fileName, string message, string date, string statuCode, string type)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}",
                Path.Combine(fileName), "log_" + DateTime.UtcNow.Date.ToString("dd-MMM-yyyy") + ".txt"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(string.Format("ErrorMessage: {0} $$ DateStamp: {1} $$ StatuCode: {2} $$ LogType: {3}",
                message, date, statuCode, type));
            objStreamWriter.Close();
            objFilestream.Close();
        }
        private void SqlLog(string fileName, string message, string date, string statuCode, string type)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}",
                Path.Combine(fileName), "log_" + DateTime.UtcNow.Date.ToString("dd-MMM-yyyy") + ".txt"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(string.Format("ErrorMessage: {0} $$ DateStamp: {1} $$ StatuCode: {2} $$ LogType: {3}",
                message, date, statuCode, type));
            objStreamWriter.Close();
            objFilestream.Close();
        }
        private void ElasticLog(string fileName, string message, string date, string statuCode, string type)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}",
                Path.Combine(fileName), "log_" + DateTime.UtcNow.Date.ToString("dd-MMM-yyyy") + ".txt"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(string.Format("ErrorMessage: {0} $$ DateStamp: {1} $$ StatuCode: {2} $$ LogType: {3}",
                message, date, statuCode, type));
            objStreamWriter.Close();
            objFilestream.Close();
        }
        private void AzureLog(string fileName, string message, string date, string statuCode, string type)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}",
                Path.Combine(fileName), "log_" + DateTime.UtcNow.Date.ToString("dd-MMM-yyyy") + ".txt"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(string.Format("ErrorMessage: {0} $$ DateStamp: {1} $$ StatuCode: {2} $$ LogType: {3}",
                message, date, statuCode, type));
            objStreamWriter.Close();
            objFilestream.Close();
        }
        private void ExcelLog(string fileName, string message, string date, string statuCode, string type)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}",
                Path.Combine(fileName), "log_" + DateTime.UtcNow.Date.ToString("dd-MMM-yyyy") + ".xlsx"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(string.Format("ErrorMessage: {0} $$ DateStamp: {1} $$ StatuCode: {2} $$ LogType: {3}",
                message, date, statuCode, type));
            objStreamWriter.Close();
            objFilestream.Close();
        }
    }
}
