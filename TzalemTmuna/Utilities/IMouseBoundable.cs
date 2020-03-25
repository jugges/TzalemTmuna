using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TzalemTmuna.Utilities
{
    public interface IMouseBoundable
    {
        void ToggleMenu();

        Rectangle ClientRectangle { get; }

        Point PointToClient(Point p);
    }
}
