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
using System.Windows.Forms;

namespace WeifenLuo.WinFormsUI.Docking
{
    internal class EmptyDockContent : Form, IDockContent
    {
        public static readonly IDockContent Instance = new EmptyDockContent();

        private EmptyDockContent()
        {
            DockHandler = new DockContentHandler(this);
        }

        public void ApplyTheme()
        {
        }

        public DockContentHandler DockHandler { get; }

        public void OnActivated(EventArgs e)
        {
        }

        public void OnDeactivate(EventArgs e)
        {
        }
    }
}