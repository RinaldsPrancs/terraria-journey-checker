using System;
using TReader.Type;

namespace TReader.Metadata
{
    public class FileMetadata
    {
        private FileMetadata()
        {
        }

        public FileType Type;
        public bool IsFavorite;
        public uint Revision;

        public static FileMetadata Read(BinaryReader reader, FileType expectedType)
        {
            FileMetadata fileMetadata = new FileMetadata();
            fileMetadata.Read(reader);
            if (fileMetadata.Type != expectedType)
            {
                throw new FormatException(string.Concat(new string[]
                {
                    "Error in expected type",
                    
                }));
            }
            return fileMetadata;
        }

        private void Read(BinaryReader reader)
        {
            ulong num = reader.ReadUInt64();
            if ((num & 72057594037927935UL) != 27981915666277746UL)
            {
                throw new FormatException("Expected Re-Logic file format.");
            }
            byte b = (byte)(num >> 56 & 255UL);
            FileType fileType = FileType.None;
            FileType[] array = (FileType[])Enum.GetValues(typeof(FileType));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == (FileType)b)
                {
                    fileType = array[i];
                    break;
                }
            }
            if (fileType == FileType.None)
            {
                throw new FormatException("Found invalid file type.");
            }
            this.Type = fileType;
            this.Revision = reader.ReadUInt32();
            ulong num2 = reader.ReadUInt64();
            this.IsFavorite = ((num2 & 1UL) == 1UL);
        }

    }
}