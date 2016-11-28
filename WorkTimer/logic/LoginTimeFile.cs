using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WorkTimer
{
    public class LoginTimeFile
    {
        public static readonly String DefaultLoginFileDirectory = "C:\\Users\\ori\\Documents\\start";
        public static readonly String DefaultFilePrefix = "LT_";
        public static readonly String DefaultFileExtention = ".txt";

        private string fileName = null;
        private bool fileOfToday = false;

        private Boolean HaveFile
        {
            get { return ! String.IsNullOrEmpty(fileName); }
        }

        private Boolean HaveOutdatedFile
        {
            get { return HaveFile && !fileOfToday; }
        }

        public DateTime GetStartTime()
        {
            DateTime startTime = DateTime.Now;

            SearchFile();

            if (HaveFile)
            {
                string[] nameEntries = (Path.GetFileNameWithoutExtension(fileName)).Split('_');

                if (nameEntries.Length > 2)
                {
                    int hours = Convert.ToInt16(nameEntries[1]);
                    int minutes = Convert.ToInt16(nameEntries[2]);

                    if (hours >=0 && hours <= 23 && minutes >=0 && minutes <= 59) {
                        startTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, hours, minutes, 0 /* seconds */);
                    }
                }
            }

            return startTime;
        }

        public string GetStartAndEndString()
        {
            string startAndEndString = String.Empty;
             
            SearchFile();

            if (HaveFile)
            {
                string[] nameEntries = (Path.GetFileNameWithoutExtension(fileName)).Split('_');

                if (nameEntries.Length == 6)
                {
                    startAndEndString = String.Format("{0}:{1} - {2}:{3}", nameEntries[1], nameEntries[2], nameEntries[4], nameEntries[5]);
                }
            }

            return startAndEndString;
        }

        public void UpdateFile(WorkDayInterval loginTime, bool WhenOutDatedOnly)
        {
            SearchFile();

            if (WhenOutDatedOnly)
            {
                if (!HaveFile || HaveOutdatedFile)
                {
                    if (HaveFile) File.Delete(fileName);
                    createFile(loginTime);
                }
            }
            else
            {
                if (HaveFile) File.Delete(fileName);

                createFile(loginTime);
            }
        }

        private void SearchFile()
        {
            string[] FileEntries = Directory.GetFiles(DefaultLoginFileDirectory);
            string myFileName;

            fileName = null;
            fileOfToday = false;

            foreach (string fileNamePath in FileEntries)
            {
                myFileName = Path.GetFileName(fileNamePath);
                if (myFileName.StartsWith(DefaultFilePrefix) && myFileName.EndsWith(DefaultFileExtention))
                {
                    fileName = fileNamePath;
                    fileOfToday = DateTime.Now.Date == File.GetCreationTime(fileNamePath).Date;
                }
            }
        }

        private void createFile(WorkDayInterval loginTime)
        {
            DateTime endTime = loginTime.getEndTime();
            string newFileName = String.Format("{0}{1,2:00}_{2,2:00}__{3,2:00}_{4,2:00}{5}",
                DefaultFilePrefix,
                loginTime.startTime.Hour,
                loginTime.startTime.Minute,
                endTime.Hour,
                endTime.Minute,
                DefaultFileExtention);
            FileStream stream = File.Create(Path.Combine(DefaultLoginFileDirectory, newFileName));
            stream.Close();
        }
    }
}
