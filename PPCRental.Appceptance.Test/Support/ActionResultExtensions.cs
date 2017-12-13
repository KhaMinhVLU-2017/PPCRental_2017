﻿using System.Web.Mvc;
using FluentAssertions;

namespace PPCRental.Appceptance.Test.Support
{
    public static class ActionResultExtensions
    {
        public static TModel Model<TModel>(this ActionResult result)
        {
            return result.Should().NotBeNull()
                         .And.Subject.Should().BeAssignableTo<ViewResult>()
                         .Which.ViewData.Model.Should().NotBeNull()
                         .And.Subject.Should().BeAssignableTo<TModel>()
                         .Subject;
        }
    }
}
