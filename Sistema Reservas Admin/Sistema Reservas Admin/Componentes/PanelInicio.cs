﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Sistema_Reservas.Botones
{
    internal class PanelInicio : Panel
    {

        //Atributos
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Propiedades Botón")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Propiedades Botón")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("Propiedades Botón")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Propiedades Botón")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Propiedades Botón")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public string Asiento { get; set; }

        private ToolTip toolTip;


        //Constructor
        public PanelInicio() 
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;

            toolTip = new ToolTip();

            this.MouseEnter += new EventHandler(PanelInicio_MouseEnter);
            this.MouseLeave += new EventHandler(PanelInicio_MouseLeave);
        }

        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0,this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //Botón Redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(borderColor,borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw Surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);

                }
            }
            else // Botón Normal
            {
                //Button Surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0,this.Width-1, this.Height-1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        private void PanelInicio_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(Asiento, this, Width / 2, Height / 2);
        }

        private void PanelInicio_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(this);
        }
    }
}
