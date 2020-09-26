using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleAxe_FOV_Changer
{
    public static class FOV
    {
        static string getCfgFile()
        {
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
            string path = local + cfgFile;
            return path;
        }

        public static string getOpenFolderPath()
        {
            string local2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile2 = @"\FortniteGame\Saved\Config\WindowsClient\";
            string path2 = local2 + cfgFile2;
            return path2;
        }

        public static string applyFOV(string fovOption, Boolean readOnly)
        {
            string txtRec = "0";
            IniData config;
            FileIniDataParser parser;
            string path;
            try
            {
                path = getCfgFile();
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
                parser = new FileIniDataParser();
                config = parser.ReadFile(path);
            } catch (Exception e)
            {
                return "1";
            }

            if (string.IsNullOrEmpty(fovOption))
            {
                // Send for null or empty
                return "0";
            }
            else if (fovOption == "100")
            {
                txtRec = "1920 x 810";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "810";
            }
            else if (fovOption == "90")
            {
                txtRec = "1920 x 945";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "945";
            }

            else if (fovOption == "110")
            {
                txtRec = "1920 x 675";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "675";
            }

            else if (fovOption == "120")
            {
                txtRec = "1920 x 540";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "540";
            }


            //Overwrite it
            parser.WriteFile(path, config);


            if (readOnly)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly);
            }

            return txtRec;
        }

        public static void backupFOV()
        {
            string filePath = getCfgFile();

            File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.ReadOnly);
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string root = exePath + @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
            File.Replace(root + "GameUserSettings.ini", filePath, filePath + ".backup");
        }
    }
}
