//
// System.Windows.Forms.Design.PanelDesigner
//
// Authors:
//	  Ivan N. Zlatev (contact i-nZ.net)
//
// (C) 2008 Ivan N. Zlatev

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Collections;

using System.Windows.Forms.Design;
namespace Mono.Design
{
	internal class PanelDesigner : ParentControlDesigner
	{
		
		public PanelDesigner ()
		{
		}

		public override void Initialize (IComponent component)
		{
			base.Initialize (component);
		}

		protected override void OnPaintAdornments (PaintEventArgs pe) 
		{
			base.OnPaintAdornments (pe);

			GraphicsState state = pe.Graphics.Save ();
			pe.Graphics.TranslateTransform (this.Control.ClientRectangle.X,
							this.Control.ClientRectangle.Y);
			ControlPaint.DrawBorder (pe.Graphics, Control.ClientRectangle, SystemColors.ControlDarkDark, 
						 ButtonBorderStyle.Dashed);
			pe.Graphics.Restore (state);
		}
	}
}
