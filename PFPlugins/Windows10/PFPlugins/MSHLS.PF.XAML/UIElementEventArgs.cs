﻿/*********************************************************************************************************************
Microsft HLS SDK for Windows

Copyright (c) Microsoft Corporation

All rights reserved.

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy,
modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

***********************************************************************************************************************/
// <copyright file="UIElementEventArgs.cs" company="Microsoft Corporation">
// Copyright (c) 2013 Microsoft Corporation All Rights Reserved
// </copyright>
// <author>Michael S. Scherotter</author>
// <email>mischero@microsoft.com</email>
// <date>2013-11-06</date>
// <summary>UI Element event arguments</summary>

namespace Microsoft.PlayerFramework.CC608
{
    using System;
    using Windows.UI.Xaml;

    /// <summary>
    /// UI Element event arguments
    /// </summary>
    public class UIElementEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the UIElementEventArgs class.
        /// </summary>
        /// <param name="uiElement">the UI Element</param>
        public UIElementEventArgs(UIElement uiElement)
        {
            this.UIElement = uiElement;
        }

        /// <summary>
        /// Gets the UI Element
        /// </summary>
        public UIElement UIElement { get; private set; }
    }
}
