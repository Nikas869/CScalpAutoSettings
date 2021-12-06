using System;
using System.IO;

namespace CScalpAutoSettings
{
    public static class MainService
    {
        private static string _xmlFilesSearchPattern = "*.xml";
        private static string _usdmFuturesSearchPattern = "*_FUT*.xml";
        private static string _coinmFuturesSearchPattern = "*_QFUT*.xml";

        public static bool Process(MainModel model)
        {
            var mvsPath = Path.Combine(model.FSRLauncherPath, "SubApps\\CScalp\\Data\\MVS");

            if (!Directory.Exists(mvsPath))
            {
                throw new ApplicationException($"Cannot find folder {mvsPath}");
            }

            var settingFiles = Directory.GetFiles(mvsPath, _xmlFilesSearchPattern);

            if (settingFiles.Length == 0)
            {
                throw new ApplicationException("There are no setting files");
            }

            return true;
        }
    }
}
