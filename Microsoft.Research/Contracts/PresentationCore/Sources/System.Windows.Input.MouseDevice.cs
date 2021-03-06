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

// File System.Windows.Input.MouseDevice.cs
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


namespace System.Windows.Input
{
  abstract public partial class MouseDevice : InputDevice
  {
    #region Methods and constructors
    public bool Capture(System.Windows.IInputElement element)
    {
      return default(bool);
    }

    public bool Capture(System.Windows.IInputElement element, CaptureMode captureMode)
    {
      return default(bool);
    }

    protected MouseButtonState GetButtonState(MouseButton mouseButton)
    {
      return default(MouseButtonState);
    }

    protected System.Windows.Point GetClientPosition(System.Windows.PresentationSource presentationSource)
    {
      return default(System.Windows.Point);
    }

    protected System.Windows.Point GetClientPosition()
    {
      return default(System.Windows.Point);
    }

    public System.Windows.Point GetPosition(System.Windows.IInputElement relativeTo)
    {
      return default(System.Windows.Point);
    }

    protected System.Windows.Point GetScreenPosition()
    {
      return default(System.Windows.Point);
    }

    internal MouseDevice()
    {
    }

    public bool SetCursor(Cursor cursor)
    {
      return default(bool);
    }

    public void Synchronize()
    {
    }

    public void UpdateCursor()
    {
    }
    #endregion

    #region Properties and indexers
    public override System.Windows.PresentationSource ActiveSource
    {
      get
      {
        return default(System.Windows.PresentationSource);
      }
    }

    public System.Windows.IInputElement Captured
    {
      get
      {
        return default(System.Windows.IInputElement);
      }
    }

    public System.Windows.IInputElement DirectlyOver
    {
      get
      {
        return default(System.Windows.IInputElement);
      }
    }

    public MouseButtonState LeftButton
    {
      get
      {
        return default(MouseButtonState);
      }
    }

    public MouseButtonState MiddleButton
    {
      get
      {
        return default(MouseButtonState);
      }
    }

    public Cursor OverrideCursor
    {
      get
      {
        return default(Cursor);
      }
      set
      {
      }
    }

    public MouseButtonState RightButton
    {
      get
      {
        return default(MouseButtonState);
      }
    }

    public override System.Windows.IInputElement Target
    {
      get
      {
        return default(System.Windows.IInputElement);
      }
    }

    public MouseButtonState XButton1
    {
      get
      {
        return default(MouseButtonState);
      }
    }

    public MouseButtonState XButton2
    {
      get
      {
        return default(MouseButtonState);
      }
    }
    #endregion
  }
}
