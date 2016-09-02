﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Aloneguid.Support.Tests.Extensions
{
   [TestFixture]
   public class DictionaryExtensionsTest
   {
      public void AddRange_AnotherDictionary_Adds()
      {
         var d1 = new Dictionary<string, string>();
         d1.Add("1", "v1");

         var d2 = new Dictionary<string, string>();
         d2.Add("2", "v2");

         d1.AddRange(d2);

         Assert.IsTrue(d1.ContainsKey("2"));
      }
   }
}
