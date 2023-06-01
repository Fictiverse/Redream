using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Redream
{
    internal class ColorTrackBarDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        public ColorTrackBarDesigner()
        { }

        // clean up some unnecessary properties
        protected override void PostFilterProperties(IDictionary Properties)
        {
            Properties.Remove("AllowDrop");
            Properties.Remove("BackgroundImage");
            Properties.Remove("ContextMenu");
            Properties.Remove("FlatStyle");
            Properties.Remove("Image");
            Properties.Remove("ImageAlign");
            Properties.Remove("ImageIndex");
            Properties.Remove("ImageList");
            Properties.Remove("Text");
            Properties.Remove("TextAlign");
            Properties.Remove("BackColor");
            Properties.Remove("Font");
            Properties.Remove("ForeColor");
            Properties.Remove("Cursor");
        }
        protected override void PostFilterEvents(IDictionary events)
        {
            //actions
            events.Remove("Click");
            events.Remove("DoubleClick");
            //appearence
            events.Remove("Paint");
            //behavior
            events.Remove("ChangeUICues");
            events.Remove("ImeModeChanged");
            events.Remove("QueryAccessibilityHelp");
            events.Remove("StyleChanged");
            events.Remove("SystemColorsChanged");
            //Drag Drop
            events.Remove("DragDrop");
            events.Remove("DragEnter");
            events.Remove("DragLeave");
            events.Remove("DragOver");
            events.Remove("GiveFeedback");
            events.Remove("QueryContinueDrag");
            events.Remove("DragDrop");
            //layout
            events.Remove("Layout");
            events.Remove("Move");
            events.Remove("Resize");
            //PropertyChanged
            events.Remove("BackColorChanged");
            events.Remove("BackgroundImageChanged");
            events.Remove("BindingContextChanged");
            events.Remove("CausesValidationChanged");
            events.Remove("CursorChanged");
            events.Remove("FontChanged");
            events.Remove("ForeColorChanged");
            events.Remove("RightToLeftChanged");
            events.Remove("SizeChanged");
            events.Remove("TextChanged");

            base.PostFilterEvents(events);
        }

    }
}