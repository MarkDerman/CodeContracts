// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Diagnostics.Eventing.EventProviderTraceListener.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Diagnostics.Eventing
{
  public partial class EventProviderTraceListener : System.Diagnostics.TraceListener
  {
    #region Methods and constructors
    public override void Close()
    {
    }

    public EventProviderTraceListener(string providerId, string name, string delimiter)
    {
      Contract.Requires(providerId != null);
      Contract.Ensures(1 <= delimiter.Length);
    }

    public EventProviderTraceListener(string providerId)
    {
      Contract.Requires(providerId != null);
    }

    public EventProviderTraceListener(string providerId, string name)
    {
      Contract.Requires(providerId != null);
    }

    public override void Fail(string message, string detailMessage)
    {
    }

    public sealed override void Flush()
    {
    }

    protected override string[] GetSupportedAttributes()
    {
      return default(string[]);
    }

    public sealed override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, Object data)
    {
    }

    public sealed override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, Object[] data)
    {
    }

    public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, Object[] args)
    {
    }

    public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id)
    {
    }

    public sealed override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message)
    {
    }

    public sealed override void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
    {
    }

    public sealed override void Write(string message)
    {
    }

    public sealed override void WriteLine(string message)
    {
    }
    #endregion

    #region Properties and indexers
    public string Delimiter
    {
      get
      {
        return default(string);
      }
      set
      {
        Contract.Ensures(1 <= value.Length);
      }
    }

    public override sealed bool IsThreadSafe
    {
      get
      {
        return default(bool);
      }
    }
    #endregion
  }
}
