using NUnit.Framework;
using System.IO;
using System;

namespace webApi
{
    public class Tests
    {

        [Test]
        public void TestMethod_Upload()
        {
            dropbox pr = new dropbox(); // Creating a class Object  
            pr.UploadAFile("test.txt");
        }
        [Test]
        public void TestMethod_GetMetadata()
        {
            dropbox pr = new dropbox(); // Creating a class Object  
            pr.GetFileMetadata();
        }
        [Test]
        public void TestMethod_Delete()
        {
            dropbox pr = new dropbox(); // Creating a class Object  
            pr.DeleteFile();
        }
    }
}