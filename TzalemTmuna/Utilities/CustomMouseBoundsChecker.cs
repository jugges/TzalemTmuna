using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TzalemTmuna.Utilities
{
    class CustomMouseBoundsChecker : IMessageFilter
    {
        //private const int WM_NCMOUSEMOVE = 0x00A0;
        private int lastHovered = -1;
        private const int WM_MOUSEMOVE = 0x200;
        //private const int WM_NCMOUSELEAVE = 0x02A2;
        //private const int WM_MOUSELEAVE = 0x02A3;

        //Idea taken from:
        // http://netcode.ru/dotnet/?lang=&katID=30&skatID=283&artID=7862
        // └── private MetroFramework.Forms.MetroForm formFader;
        private List<IMouseBoundable> controls;

        public CustomMouseBoundsChecker(List<IMouseBoundable> controls)
        {
            this.controls = controls;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_MOUSEMOVE)
            {
                CheckMouseBounds();
            }
            return false; // dont actually filter the message
        }

        /// <summary>
        /// Checks if the current cursor position is contained within the bounds of the
        /// form and sets MouseInBounds which in turn fires event MouseBoundsChanged
        /// </summary>
        /// <param name="mouseMove"></param>
        private void CheckMouseBounds()
        {
            //Check if last hovered control is not still hovered
            if (!(lastHovered != -1 && controls[lastHovered].ClientRectangle.Contains(controls[lastHovered].PointToClient(Cursor.Position))))
            {
                //flag for checking if mouse is hovering a control or not
                bool hovering = false;
                //Check each control in array if mouse is in its bounds
                for (int i = 0; i < controls.Count; i++)
                {
                    if (lastHovered != i && controls[i].ClientRectangle.Contains(controls[i].PointToClient(Cursor.Position)))
                    {
                        //Found the control mouse is hovering!
                        hovering = true;
                        //Set hovered control's menu visibility
                        controls[i].ToggleMenu();
                        //Toggle off last hovered control
                        if (lastHovered != -1)
                        {
                            controls[lastHovered].ToggleMenu();
                        }
                        //Set lastHovered to control hovered now
                        lastHovered = i;
                        //OLD: WE DON'T BREAK BECAUSE WE SCOUR THE CONTROLS FOR LAST HOVERED
                        //Stop searching for hovered control because we already found it
                        break;
                    }
                }
                //Toggle off last hovered control
                if (lastHovered != -1 && !hovering)
                {
                    controls[lastHovered].ToggleMenu();
                    lastHovered = -1;
                }
            }
        }
    }
}
