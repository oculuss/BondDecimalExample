
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.10.1.0
//   File : Event_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace BondExampleB.Global
{
    using System.Collections.Generic;

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.10.1.0")]
    public partial class Event
    {
        [global::Bond.Id(0)]
        public string id { get; set; }

        [global::Bond.Id(1)]
        public global::Bond.IBonded<Payload> Payload { get; set; }

        public Event()
            : this("BondExampleB.Global.Event", "Event")
        {}

        protected Event(string fullName, string name)
        {
            id = "";
            Payload = global::Bond.Bonded<Payload>.Empty;
        }
    }
} // BondExampleB.Global
