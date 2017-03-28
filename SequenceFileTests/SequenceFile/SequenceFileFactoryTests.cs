using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriCheer.Phoenix.SeqManager.SeqFile;
using TriCheer.Phoenix.SeqManager.Adaptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TriCheer.Phoenix.SeqManager.SeqFile.Tests
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

            string filePath = "TestSequenceFile.xml";
            bool result = SequenceFileFactory.SaveSequenceFile(seqFile, filePath);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, File.Exists(filePath));
        }

        [TestMethod()]
        public void LoadSequenceFileTest()
        {
            string filePath = "TestSequenceFile.xml";
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
            IAdaptor adaptor = AdaptorFactory.CreateAdaptor(AdaptorTypes.DotnetAdaptor);
            adaptor.MethodName = "Test";
            adaptor.TestModuleName = "DotNetTest.dll";
            adaptor.Parameters.Add(new DotNetParameter());
            adaptor.Parameters.Add(new DotNetParameter("parameter1"));
            adaptor.Parameters.Add(new DotNetParameter("parameter2"));
            actionStep.Adaptor = adaptor;

            IStep subActionStep = StepFactory.CreateStep(StepTypes.Action);
            subActionStep.Name = "SubAction step test";
            subActionStep.Description = "this is a sub test action step";

            actionStep.Childs.Add(subActionStep);

            mainSequence.Childs.Add(actionStep);
            mainSequence.Childs.Add(subActionStep);
            mainSequence.Childs.Add(subActionStep);


            seqFile.MainSequence = mainSequence;
            return seqFile;
        }
    }
}