
using TReader.Data;
using System.Reflection;

namespace TReader.Plr
{
    public class Player
    {
        public int[] buffType = new int[44];

        public static short Count = 6145;
        public static void Deserialize(PlayerFileData data, Player newPlayer, BinaryReader fileIO, int release, out bool gotToReadName)
        {
            gotToReadName = false;
            var name = fileIO.ReadString();
            Console.WriteLine(name);
            gotToReadName = true;
            if (release >= 10)
            {
                if (release >= 17)
                {
                    fileIO.ReadByte();
                }
                else if (fileIO.ReadBoolean())
                {
                }
            }
            if (release >= 138)
            {
                fileIO.ReadInt64();
            }

            fileIO.ReadInt32();

            if (release >= 82)
            {
                fileIO.ReadByte();
            }
            if (release >= 283)
            {
                fileIO.ReadByte();
            }
            if (release >= 124)
            {
                fileIO.ReadByte();

                fileIO.ReadByte();

            }
            else if (release >= 83)
            {
                fileIO.ReadByte();

            }


            if (release >= 119)
            {
                fileIO.ReadByte();
            }

            if (release <= 17)
            {

            }
            else if (release < 107)
            {
                fileIO.ReadBoolean();
            }
            else
            {
                fileIO.ReadByte();
            }

            fileIO.ReadInt32();
            fileIO.ReadInt32();
            fileIO.ReadInt32();
            fileIO.ReadInt32();

            if (release >= 125)
            {
                fileIO.ReadBoolean();
            }
            if (release >= 229)
            {
                fileIO.ReadBoolean();
                fileIO.ReadBoolean();
                if (release >= 256)
                {
                    fileIO.ReadBoolean();
                }
                if (release >= 260)
                {
                    fileIO.ReadBoolean();
                    fileIO.ReadBoolean();
                    fileIO.ReadBoolean();
                    fileIO.ReadBoolean();
                    fileIO.ReadBoolean();
                    fileIO.ReadBoolean();
                }
            }
            if (release >= 182)
            {
                fileIO.ReadBoolean();
            }
            if (release >= 128)
            {
                fileIO.ReadInt32();
            }
            if (release >= 254)
            {
                fileIO.ReadInt32();
            }
            if (release >= 254)
            {
                fileIO.ReadInt32();
            }
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();
            fileIO.ReadByte(); fileIO.ReadByte(); fileIO.ReadByte();

            if (release >= 38)
            {
                if (release < 124)
                {
                    int num = 11;
                    if (release >= 81)
                    {
                        num = 16;
                    }
                    for (int l = 0; l < num; l++)
                    {
                        int num2 = l;
                        if (num2 >= 8)
                        {
                            num2 += 2;
                        }
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                else
                {
                    int num3 = 20;
                    for (int m = 0; m < num3; m++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                if (release >= 47)
                {
                    int num4 = 3;
                    if (release >= 81)
                    {
                        num4 = 8;
                    }
                    if (release >= 124)
                    {
                        num4 = 10;
                    }
                    for (int n = 0; n < num4; n++)
                    {
                        int num5 = n;
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                if (release >= 58)
                {
                    for (int num6 = 0; num6 < 58; num6++)
                    {
                        int num7 = fileIO.ReadInt32();
                        if (num7 >= (int)Count)
                        {
                            fileIO.ReadInt32();
                            fileIO.ReadByte();
                            if (release >= 114)
                            {
                                fileIO.ReadBoolean();
                            }
                        }
                        else
                        {

                            fileIO.ReadInt32();
                            fileIO.ReadByte();
                            if (release >= 114)
                            {
                                fileIO.ReadBoolean();
                            }
                        }
                    }
                }
                else
                {
                    for (int num8 = 0; num8 < 48; num8++)
                    {
                        int num9 = fileIO.ReadInt32();
                        if (num9 >= (int)Count)
                        {
                            fileIO.ReadInt32();
                            fileIO.ReadByte();
                        }
                        else
                        {

                            fileIO.ReadInt32();
                            fileIO.ReadByte();
                        }
                    }
                }
                if (release >= 117)
                {
                    if (release < 136)
                    {
                        for (int num10 = 0; num10 < 5; num10++)
                        {
                            if (num10 != 1)
                            {
                                int num11 = fileIO.ReadInt32();
                                if (num11 >= (int)Count)
                                {

                                    fileIO.ReadByte();
                                }
                                else
                                {

                                    fileIO.ReadByte();
                                }
                                num11 = fileIO.ReadInt32();
                                if (num11 >= (int)Count)
                                {

                                    fileIO.ReadByte();
                                }
                                else
                                {

                                    fileIO.ReadByte();
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int num12 = 0; num12 < 5; num12++)
                        {
                            int num13 = fileIO.ReadInt32();
                            if (num13 >= (int)Count)
                            {

                                fileIO.ReadByte();
                            }
                            else
                            {

                                fileIO.ReadByte();
                            }
                            num13 = fileIO.ReadInt32();
                            if (num13 >= (int)Count)
                            {

                                fileIO.ReadByte();
                            }
                            else
                            {

                                fileIO.ReadByte();
                            }
                        }
                    }
                }


                if (release >= 58)
                {
                    for (int num14 = 0; num14 < 40; num14++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                    for (int num15 = 0; num15 < 40; num15++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                else
                {
                    for (int num16 = 0; num16 < 20; num16++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                    for (int num17 = 0; num17 < 20; num17++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                if (release >= 182)
                {
                    for (int num18 = 0; num18 < 40; num18++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                    }
                }
                if (release >= 198)
                {
                    for (int num19 = 0; num19 < 40; num19++)
                    {
                        fileIO.ReadInt32();
                        fileIO.ReadInt32();
                        fileIO.ReadByte();
                        if (release >= 255)
                        {
                            fileIO.ReadBoolean();
                        }
                    }
                }
                if (release >= 199)
                {
                    fileIO.ReadByte();
                }
            }
            else
            {

                for (int num20 = 0; num20 < 8; num20++)
                {
                    fileIO.ReadString();
                    if (release >= 36)
                    {
                        fileIO.ReadByte();
                    }
                }
                if (release >= 6)
                {
                    for (int num21 = 10; num21 < 13; num21++)
                    {
                        fileIO.ReadString();
                        if (release >= 36)
                        {
                            fileIO.ReadByte();
                        }
                    }
                }
                for (int num22 = 0; num22 < 44; num22++)
                {
                    fileIO.ReadString();
                    fileIO.ReadInt32();
                    if (release >= 36)
                    {
                        fileIO.ReadByte();
                    }
                }
                if (release >= 15)
                {
                    for (int num23 = 44; num23 < 48; num23++)
                    {
                        fileIO.ReadString();
                        fileIO.ReadInt32();
                        if (release >= 36)
                        {
                            fileIO.ReadByte();
                        }
                    }
                }

                for (int num24 = 0; num24 < 20; num24++)
                {
                    fileIO.ReadString();
                    fileIO.ReadInt32();
                    if (release >= 36)
                    {
                        fileIO.ReadByte();
                    }
                }
                if (release >= 20)
                {
                    for (int num25 = 0; num25 < 20; num25++)
                    {
                        fileIO.ReadString();
                        fileIO.ReadInt32();
                        if (release >= 36)
                        {
                            fileIO.ReadByte();
                        }
                    }
                }
            }
            if (release < 58)
            {
                for (int num26 = 40; num26 < 48; num26++)
                {

                }
            }

            if (release >= 11)
            {
                int num27 = 22;
                if (release < 74)
                {
                    num27 = 10;
                }
                if (release >= 252)
                {
                    num27 = 44;
                }
                for (int num28 = 0; num28 < num27; num28++)
                {
                    newPlayer.buffType[num28] = fileIO.ReadInt32();
                    fileIO.ReadInt32();

                    if (newPlayer.buffType[num28] == 0)
                    {
                        num28--;
                        num27--;
                    }
                }
            }
            for (int num29 = 0; num29 < 200; num29++)
            {
                int num30 = fileIO.ReadInt32();
                if (num30 == -1)
                {
                    break;
                }

                fileIO.ReadInt32();
                fileIO.ReadInt32();
                fileIO.ReadString();
            }
            if (release >= 16)
            {
                fileIO.ReadBoolean();
            }
            if (release >= 115)
            {
                int num31 = 13;
                for (int num32 = 0; num32 < num31; num32++)
                {
                    fileIO.ReadBoolean();
                }
            }
            if (release >= 98)
            {
                fileIO.ReadInt32();
            }
            if (release >= 162)
            {
                for (int num33 = 0; num33 < 4; num33++)
                {
                    fileIO.ReadInt32();
                }
            }
            if (release >= 164)
            {
                int num34 = 8;
                if (release >= 167)
                {
                    num34 = 10;
                }
                if (release >= 197)
                {
                    num34 = 11;
                }
                if (release >= 230)
                {
                    num34 = 12;
                }
                for (int num35 = 0; num35 < num34; num35++)
                {
                    fileIO.ReadInt32();
                }
                if (release < 210)
                {

                }
                if (release < 249)
                {


                }
            }
            if (release >= 181)
            {
                fileIO.ReadInt32();
            }
            if (release >= 200)
            {
                var dead = fileIO.ReadBoolean();
                if (dead)
                {
                    fileIO.ReadInt32();
                }
            }

            if (release >= 202)
            {
                fileIO.ReadInt64();
            }
            if (release >= 206)
            {
                fileIO.ReadInt32();
            }
            if (release >= 218)
            {
                // LOAD .PLR DATA
                Load(fileIO, release);
            }
        }

        public static void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
        {
            Dictionary<string, int> myResearch = new Dictionary<string, int>();
            if (gameVersionSaveWasMadeOn >= 282)
            {
                reader.ReadBoolean();
            }

            int num = reader.ReadInt32();

            // populate dictionary with .plr research progress
            for (int i = 0; i < num; i++)
            {
                string key = reader.ReadString();
                // Console.WriteLine(key);
                int value = reader.ReadInt32();
                // Console.WriteLine(value);
                myResearch[key] = value;
            }



            Dictionary<string, int> sacrifices = new Dictionary<string, int>();

            // Mapping of letters to values
            Dictionary<string, int> letterToValue = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "A", 50 },
            { "B", 25 },
            { "C", 5 },
            { "D", 1 },
            { "E", -1 },
            { "F", 2 },
            { "G", 3 },
            { "H", 10 },
            { "I", 15 },
            { "J", 30 },
            { "K", 99 },
            { "L", 100 },
            { "M", 200 },
            { "N", 20 },
            { "O", 400 }
        };
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = "TReader.Sacrifices.tsv";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader2 = new StreamReader(stream))
            {
                string line;
                while ((line = reader2.ReadLine()) != null)
                {
                    string trimmed = line.Trim();
                    if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("//"))
                        continue;

                    string[] split = trimmed.Split('\t');

                    if (split.Length < 2)
                        continue;

                    string key = split[0];
                    string letter = split[1];

                    if (!letterToValue.TryGetValue(letter, out int value))
                    {
                        throw new Exception($"Unknown category letter '{letter}' for item '{key}'");
                    }

                    if (value == -1)
                    {
                        // Invalid category, skip
                        continue;
                    }

                    // Add to dictionary
                    sacrifices[key] = value;
                }
            }

            Dictionary<string, int> needToResearch = new Dictionary<string, int>();
            int researchedItemCount = 0;

            foreach (var kvp in sacrifices)
            {
                string itemName = kvp.Key;
                int totalNeeded = kvp.Value;

                myResearch.TryGetValue(itemName, out int currentCount);

                if (currentCount >= totalNeeded)
                {
                    // Fully researched
                    researchedItemCount++;
                }
                else
                {
                    // Not fully researched
                    int remaining = totalNeeded - currentCount;
                    needToResearch[itemName] = remaining;
                }
            }
            Console.WriteLine($"All items: {sacrifices.Count}");
            Console.WriteLine($"Fully researched items: {researchedItemCount}");
            Console.WriteLine("Items still needed to research: " + needToResearch.Count);


            double progress = (double)researchedItemCount * 100 / sacrifices.Count;
            Console.WriteLine($"Items Reseached: {progress:F2} %");

            Console.WriteLine("Press any key to display items that still need to be researched...");
            Console.ReadKey();

            foreach (KeyValuePair<string, int> kvp in needToResearch)
            {
                string key = kvp.Key;
                int value = kvp.Value;
                Console.WriteLine($"{key} {value}x");
            }

        }
    }
}