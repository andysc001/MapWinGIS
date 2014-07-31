﻿
#if nsp
namespace MapWinGIS
{
#endif
    using System;

    /// <summary>
    /// Holds information about a single line or marker in the line pattern represented by LinePattern class.
    /// </summary>
    /// Here is a diagram for the LineSegment class.
    /// \dot
    /// digraph segm_diagram {
    /// nodesep = 0.3;
    /// ranksep = 0.3;
    /// splines = ortho;
    /// 
    /// node [shape= "polygon", peripheries = 3, fontname=Helvetica, fontsize=9, color = gray, style = filled, height = 0.2, width = 0.8];
    /// segm [ label="LineSegment" URL="\ref LineSegment"];
    /// 
    /// node [color = tan peripheries = 1 height = 0.3, width = 1.0];
    /// ptrn [ label="LinePattern" URL="\ref LinePattern"];
    /// 
    /// edge [ dir = "none", arrowhead="open", style = solid, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060", labeldistance = 0.6 ]
    /// ptrn -> segm [ URL="\ref LinePattern.get_Line()", tooltip = "Labels.get_Line()", headlabel = "   n"];
    /// }
    /// \enddot
    /// <a href = "diagrams.html">Graph description</a>
    /// \new48 Added in version 4.8
    #if nsp
        #if upd
            public class LineSegment : MapWinGIS.ILineSegment
        #else        
                    public class ILineSegment
        #endif
    #else
        public class LineSegment
    #endif
    {
        #region ILineSegment Members
        /// <summary>
        /// Gets or sets the color of the line or marker.
        /// </summary>
        public uint Color
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Draws a line segment on the specified device context.
        /// </summary>
        /// <remarks>The method can be used to draw map legend.</remarks>
        /// <param name="hdc">The handle of the device context.</param>
        /// <param name="x">The x coordinate of the upper left corner of the drawing.</param>
        /// <param name="y">The y coordinate of the upper left corner of the drawing.</param>
        /// <param name="clipWidth">The width of the clipping rectangle.</param>
        /// <param name="clipHeight">The height of the clipping rectangle.</param>
        /// <param name="BackColor">The back color of the device context the drawing is performed at.
        /// The value should be specified to ensure correct blending when semi-transparent colors are used.</param>
        /// <returns>True on successful drawing and false on failure.</returns>
        public bool Draw(IntPtr hdc, float x, float y, int clipWidth, int clipHeight, uint BackColor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a line segment on the specified device context.
        /// </summary>
        /// <remarks>The method can be used to draw map legend.</remarks>
        /// <param name="hdc">The handle of the device context.</param>
        /// <param name="x">The x coordinate of the upper left corner of the drawing.</param>
        /// <param name="y">The y coordinate of the upper left corner of the drawing.</param>
        /// <param name="clipWidth">The width of the clipping rectangle.</param>
        /// <param name="clipHeight">The height of the clipping rectangle.</param>
        /// <param name="BackColor">The back color of the device context the drawing is performed at.
        /// The value should be specified to ensure correct blending when semi-transparent colors are used.</param>
        /// <returns>True on successful drawing and false on failure.</returns>
        public bool DrawVB(int hdc, float x, float y, int clipWidth, int clipHeight, uint BackColor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the style of the line.
        /// </summary>
        public tkDashStyle LineStyle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the type of the line segment, either line or marker.
        /// </summary>
        public tkLineType LineType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the width of the line.
        /// </summary>
        public float LineWidth
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the marker for the line segment.
        /// </summary>
        public tkDefaultPointSymbol Marker
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the value which indicates whether the first marker in the line should be rotated by 180 degrees.
        /// </summary>
        public bool MarkerFlipFirst
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the interval between markers in pixels.
        /// </summary>
        public float MarkerInterval
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the offset for the marker. 
        /// </summary>
        /// <remarks>The first marker will be positioned with offset from 
        /// the beginning of polyline by this value.</remarks>
        public float MarkerOffset
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or set the orientation of the marker symbols relative to the polyline.
        /// </summary>
        public tkLineLabelOrientation MarkerOrientation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the outline color of the marker.
        /// </summary>
        public uint MarkerOutlineColor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the size of marker in pixels.
        /// </summary>
        public float MarkerSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
#if nsp
}
#endif

