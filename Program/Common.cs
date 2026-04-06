using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBDRandomizer
{
    class Common
    {
        public class SavedSetup
        {
            public List<string> SurvivorCheckedPerks { get; set; } = new List<string>();
            public List<string> KillerCheckedPerks { get; set; } = new List<string>();
            public int SurvivorPerkCount { get; set; } = 4;
            public int KillerPerkCount { get; set; } = 4;
            public bool OnlyNewPerksEveryRoll { get; set; } = false;
        }
        private static string FormatPerkName(string rawName)
        {
            string[] colonPrefixes =
            {
                "Boon",
                "Hex",
                "Invocation",
                "Scourge Hook",
                "Teamwork"
            };

            foreach (string prefix in colonPrefixes)
            {
                if (rawName.StartsWith(prefix + " ") && !rawName.StartsWith(prefix + ":"))
                {
                    return rawName.Replace(prefix + " ", prefix + ": ");
                }
            }
            return rawName;
        }
        public static void LoadImages(string location, ListView list)
        {
            var perkImages = Directory.EnumerateFiles(location);
            foreach (string perk in perkImages)
            {
                var perkName = perk.Replace('_', ' ');
                perkName = perkName.Replace(location, "");
                perkName = perkName.Substring(0, perkName.LastIndexOf('.'));
                perkName = FormatPerkName(perkName);

                ListViewItem listItem = new ListViewItem(perkName);

                Image perkImage = Image.FromFile(perk);
                list.SmallImageList.Images.Add(perkName, perkImage);
                listItem.ImageIndex = list.SmallImageList.Images.Count - 1;

                list.Items.Add(listItem);
            }
        }

        public class Perk
        {
            public Image Img { get; set; }
            public string Name { get; set; }
        }

        private static List<string> previousPerks = new List<string>();
        private static readonly string SavedSetupFilePath = Path.Combine(Application.StartupPath, "savedsetup.txt");

        public static List<Perk> RandomizePerks(int count, ListView list, bool uniquePerks)
        {
            Random r = new Random();
            int picksLeft = count;

            List<Perk> allPerks = new List<Perk>();
            List<Perk> selectedPerks = new List<Perk>();

            // If there weren't previous perks, don't bother checking
            if (previousPerks == null)
            {
                uniquePerks = false;
            }

            // If there aren't enough perks selected to have a full set, ignore this
            if (previousPerks.Count + count > list.CheckedItems.Count)
            {
                uniquePerks = false;
            }

            foreach (ListViewItem perk in list.CheckedItems)
            {
                Image img = list.SmallImageList.Images[perk.ImageIndex];
                string name = perk.Text;

                // Filter out perks that were selected the previous roll, if that's asked for
                if (uniquePerks == false || !previousPerks.Contains(name))
                {
                    allPerks.Add(new Perk { Img = img, Name = name });
                }
            }

            previousPerks.Clear();

            while (allPerks.Count > 0 && picksLeft > 0)
            {
                int nextIndex = r.Next(allPerks.Count);
                Perk nextPerk = allPerks[nextIndex];
                selectedPerks.Add(nextPerk);
                previousPerks.Add(nextPerk.Name);
                allPerks.RemoveAt(nextIndex);

                picksLeft -= 1;
            }

            return selectedPerks;
        }

        public static void SaveSetup(SavedSetup setup)
        {
            List<string> lines = new List<string>();

            lines.Add("SURVIVOR_COUNT=" + setup.SurvivorPerkCount);
            lines.Add("KILLER_COUNT=" + setup.KillerPerkCount);
            lines.Add("ONLY_NEW=" + setup.OnlyNewPerksEveryRoll);

            lines.Add("SURVIVOR:");
            foreach (string perk in setup.SurvivorCheckedPerks)
            {
                lines.Add(perk);
            }

            lines.Add("KILLER:");
            foreach (string perk in setup.KillerCheckedPerks)
            {
                lines.Add(perk);
            }

            File.WriteAllLines(SavedSetupFilePath, lines);
        }

        public static SavedSetup LoadSetup()
        {
            if (!File.Exists(SavedSetupFilePath))
            {
                return null;
            }

            string[] lines = File.ReadAllLines(SavedSetupFilePath);
            SavedSetup setup = new SavedSetup();

            bool readingSurvivor = false;
            bool readingKiller = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("SURVIVOR_COUNT="))
                {
                    int value;
                    if (int.TryParse(line.Replace("SURVIVOR_COUNT=", ""), out value))
                    {
                        setup.SurvivorPerkCount = value;
                    }
                }
                else if (line.StartsWith("KILLER_COUNT="))
                {
                    int value;
                    if (int.TryParse(line.Replace("KILLER_COUNT=", ""), out value))
                    {
                        setup.KillerPerkCount = value;
                    }
                }
                else if (line.StartsWith("ONLY_NEW="))
                {
                    bool value;
                    if (bool.TryParse(line.Replace("ONLY_NEW=", ""), out value))
                    {
                        setup.OnlyNewPerksEveryRoll = value;
                    }
                }
                else if (line == "SURVIVOR:")
                {
                    readingSurvivor = true;
                    readingKiller = false;
                }
                else if (line == "KILLER:")
                {
                    readingSurvivor = false;
                    readingKiller = true;
                }
                else
                {
                    if (readingSurvivor && line != "")
                    {
                        setup.SurvivorCheckedPerks.Add(line);
                    }
                    else if (readingKiller && line != "")
                    {
                        setup.KillerCheckedPerks.Add(line);
                    }
                }
            }

            return setup;
        }

        public static void ClearSavedSetup()
        {
            if (File.Exists(SavedSetupFilePath))
            {
                File.Delete(SavedSetupFilePath);
            }
        }
    }
}
