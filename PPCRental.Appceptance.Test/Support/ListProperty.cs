using System.Collections.Generic;
using PPCRental.Models;
using FluentAssertions;

namespace PPCRental.Appceptance.Test.Support
{
    public class ListProperty : Dictionary<string,PROPERTY>
    {
        public PROPERTY GetById(string bookId)
        {
            return this[bookId.Trim()].Should().NotBeNull()
                                      .And.Subject.Should().BeOfType<PROPERTY>().Which;
        }
    }
}
