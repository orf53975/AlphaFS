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
using System.IO;
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   public static partial class Directory
   {
      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      [SecurityCritical]
      public static void Decompress(string path)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decompress(string path, PathFormat pathFormat)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, false, pathFormat);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions options)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, false, pathFormat);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationFilters filters)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, false, pathFormat);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
      {
         CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, false, pathFormat);
      }
      



      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, false, pathFormat);
      }

      
      
      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, false, pathFormat);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items (non recursive).</remarks>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, false, pathFormat);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="options"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="filters">The specification of custom filters to be used in the process.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
      {
         CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, false, pathFormat);
      }
   }
}
