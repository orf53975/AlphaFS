/*  Copyright (C) 2008-2018 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphaFS.UnitTest
{
   public partial class TimestampsTest
   {
      // Pattern: <class>_<function>_<scenario>_<expected result>


      [TestMethod]
      public void AlphaFS_File_CopyTimestamps_LocalAndNetwork_Success()
      {
         AlphaFS_File_CopyTimestamps(false);
         AlphaFS_File_CopyTimestamps(true);
      }


      private void AlphaFS_File_CopyTimestamps(bool isNetwork)
      {
         using (var tempRoot = new TemporaryDirectory(isNetwork))
         {
            var file1 = tempRoot.CreateFileRandomizedAttributes();

            Thread.Sleep(1500);

            var file2 = tempRoot.CreateFileRandomizedAttributes();
            

            Console.WriteLine("Input File1 Path: [{0}]", file1.FullName);
            Console.WriteLine("Input File2 Path: [{0}]", file2.FullName);


            Assert.AreNotEqual(System.IO.File.GetCreationTime(file1.FullName), System.IO.File.GetCreationTime(file2.FullName));
            Assert.AreNotEqual(System.IO.File.GetLastAccessTime(file1.FullName), System.IO.File.GetLastAccessTime(file2.FullName));
            Assert.AreNotEqual(System.IO.File.GetLastWriteTime(file1.FullName), System.IO.File.GetLastWriteTime(file2.FullName));


            Alphaleonis.Win32.Filesystem.File.CopyTimestamps(file1.FullName, file2.FullName);


            UnitTestConstants.Dump(file1, -17);
            UnitTestConstants.Dump(file2, -17);


            Assert.AreEqual(System.IO.File.GetCreationTime(file1.FullName), System.IO.File.GetCreationTime(file2.FullName));
            Assert.AreEqual(System.IO.File.GetLastAccessTime(file1.FullName), System.IO.File.GetLastAccessTime(file2.FullName));
            Assert.AreEqual(System.IO.File.GetLastWriteTime(file1.FullName), System.IO.File.GetLastWriteTime(file2.FullName));
         }

         Console.WriteLine();
      }
   }
}
