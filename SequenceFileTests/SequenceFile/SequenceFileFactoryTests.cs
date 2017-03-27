using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriCheer.Phoenix.SequenceFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TriCheer.Phoenix.SequenceFile.Tests
{
    [TestClass()]
    public class SequenceFileFactoryTests
    {
        [TestMethod()]
        public void CreateSequenceFileTest()
        {
            ISequenceFile seqFile = SequenceFileFactory.CreateSequenceFile();
            Assert.IsNotNull(seqFile);
        }

        [TestMethod()]
        public void SaveSequenceFileTest()
        {
            SequenceFile seqFile = GenerateTestSequenceFile();

            string filePath = "TestSequenceFile.pseq";
            bool result = SequenceFileFactory.SaveSequenceFile(seqFile, filePath);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, File.Exists(filePath));
        }

        [TestMethod()]
        public void LoadSequenceFileTest()
        {
            string filePath = "TestSequenceFile.pseq";
            ISequenceFile seqFile = SequenceFileFactory.LoadSequenceFile(filePath);

            Assert.IsNotNull(seqFile);
        }

        SequenceFile GenerateTestSequenceFile()
        {
            SequenceFile seqFile = new SequenceFile();
            seqFile.Name = "TestSequenceFile";
            seqFile.Description = "This is a test sequenceFile.";
            seqFile.Comment = "Nothing";
            seqFile.Version.MarjorVersion = "1";

            ISequence mainSequence = SequenceFactory.CreateSequence(SequenceTypes.Normal);
            mainSequence.Name = "MainSequence";
            mainSequence.Description = "Main sequence for test.";
            mainSequence.EnableLogging = false;
            mainSequence.TestTimeout = 3000;
            mainSequence.BreakPoint = true;

            IStep actionStep = StepFactory.CreateStep(StepTypes.Action);
            actionStep.Name = "Action step test";
            actionStep.Description = "this is a test action step";
            mainSequence.Childs.Add(actionStep);

            seqFile.MainSequence = mainSequence;
            return seqFile;
        }
    }
}