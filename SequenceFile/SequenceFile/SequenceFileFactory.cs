using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Polenter.Serialization;
using System.IO;

namespace TriCheer.Phoenix.SeqManager.SeqFile
{
    public class SequenceFileFactory
    {
        public static ISequenceFile CreateSequenceFile()
        {
            return new SequenceFile();
        }

        public static ISequenceFile LoadSequenceFile(string filePath)
        {
            try
            {
                filePath = Path.GetFullPath(filePath);
                if (!File.Exists(filePath))
                {
                    return null;
                }
                SharpSerializer serializer = new SharpSerializer();
                SequenceFile seqFile = (SequenceFile)serializer.Deserialize(filePath);
                return seqFile;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool SaveSequenceFile(ISequenceFile seqFileInstance, string filePath)
        {
            SharpSerializer serializer = new SharpSerializer();
            string fullPath = string.Empty;
            try
            {
                fullPath = Path.GetFullPath(filePath);
                serializer.Serialize(seqFileInstance, fullPath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
