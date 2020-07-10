//  ****************************************************************************
//  Ranplan Wireless Network Design Ltd.
//  __________________
//   All Rights Reserved. [2020]
// 
//  NOTICE:
//  All information contained herein is, and remains the property of
//  Ranplan Wireless Network Design Ltd. and its suppliers, if any.
//  The intellectual and technical concepts contained herein are proprietary
//  to Ranplan Wireless Network Design Ltd. and its suppliers and may be
//  covered by U.S. and Foreign Patents, patents in process, and are protected
//  by trade secret or copyright law.
//  Dissemination of this information or reproduction of this material
//  is strictly forbidden unless prior written permission is obtained
//  from Ranplan Wireless Network Design Ltd.
// ****************************************************************************

using System;

namespace WeifenLuo.WinFormsUI.Docking
{
    public class InvalidDockPortionException : Exception
    {
        public string DockBottomPortionName { get; }
        public double Value { get; }
        public override string Message { get; } = "The value must be greater than zero.";

        public InvalidDockPortionException(string dockBottomPortionName, double value)
        {
            DockBottomPortionName = dockBottomPortionName;
            Value = value;
        }
    }
}