using System;
using TReader.Metadata;

namespace TReader.Data {
    public class PlayerFileData
{
    public string Path { get; set; }

    public FileMetadata? Metadata { get; set; }   // ← add the ?

    public PlayerFileData(string path)
    {
        Path = path;
        // Metadata stays null until you load it
    }

}
}