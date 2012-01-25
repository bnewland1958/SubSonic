/*
 * SubSonic - http://subsonicproject.com
 * 
 * The contents of this file are subject to the Mozilla Public
 * License Version 1.1 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a copy of
 * the License at http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an 
 * "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
 * implied. See the License for the specific language governing
 * rights and limitations under the License.
*/

using MbUnit.Framework;

namespace SubSonic.Tests.MsAccess
{
    /// <summary>
    /// Summary for the AssemblyFixture class
    /// </summary>
    public static class AssemblyFixture
    {
        /// <summary>
        /// Sets the up.
        /// </summary>
        [SetUp]
        public static void SetUp()
        {
            DataService.GetTableSchema("Products", "NorthwindAccess");
            DataService.GetTableSchema("Categories", "NorthwindAccess");
        }

        /// <summary>
        /// Tears down.
        /// </summary>
        [TearDown]
        public static void TearDown() {}
    }
}