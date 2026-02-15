using System.Security.Cryptography;
using System.Text;
using TReader.Data;
using TReader.Metadata;
using TReader.Type;
using TReader.Plr;
using System.Runtime.InteropServices;
using System.Reflection;
class Program
{
    static void Main()
    {

        Console.WriteLine("This app presumes your player files are local not in cloud.");
        Console.WriteLine("Enter the player file name (e.g., YourPlayerName.plr):");
        string fileName = Console.ReadLine();
        
        string basePath;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // %USERPROFILE%\Documents\My Games\Terraria\Players
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            basePath = Path.Combine(userProfile, "Documents", "My Games", "Terraria", "Players");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            // ~/Library/Application Support/Terraria/Players
            string home = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            basePath = Path.Combine(home, "Library", "Application Support", "Terraria", "Players");
        }
        else
        {
            Console.WriteLine("Unsupported OS!");
            return;
        }

        string path = Path.Combine(basePath, fileName);

        byte[] ENCRYPTION_KEY = new UnicodeEncoding().GetBytes("h3y_gUyZ");

        PlayerFileData playerFileData = new PlayerFileData(path);
        Player player = new Player(); 

        bool flag = false;
        try
        {
            Aes aes = Aes.Create();
            using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(path)))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(ENCRYPTION_KEY, ENCRYPTION_KEY), 0))
                {
                    using (BinaryReader binaryReader = new BinaryReader(cryptoStream))
                    {
                        int num = binaryReader.ReadInt32();
                        if (num >= 135)
                        {
                            playerFileData.Metadata = FileMetadata.Read(binaryReader, FileType.Player);
                        }
                        Player.Deserialize(playerFileData, player, binaryReader, num, out flag);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
