﻿//Note: This is a generated file.
using System.Drawing;
using ColorMine.ColorSpaces.Conversions;

namespace ColorMine.ColorSpaces
{
	public interface IRgb : IColorSpace
    {
		double R { get; set; }
		double G { get; set; }
		double B { get; set; }
    }

    public class Rgb : ColorSpace, IRgb
    {
		public double R { get; set; }
		public double G { get; set; }
		public double B { get; set; }

        public override void Initialize(Color color)
        {
            RgbConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return RgbConverter.ToColor(this);
        }
    }

	public interface IXyz : IColorSpace
    {
		double X { get; set; }
		double Y { get; set; }
		double Z { get; set; }
    }

    public class Xyz : ColorSpace, IXyz
    {
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }

        public override void Initialize(Color color)
        {
            XyzConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return XyzConverter.ToColor(this);
        }
    }

	public interface IHsl : IColorSpace
    {
		double H { get; set; }
		double S { get; set; }
		double L { get; set; }
    }

    public class Hsl : ColorSpace, IHsl
    {
		public double H { get; set; }
		public double S { get; set; }
		public double L { get; set; }

        public override void Initialize(Color color)
        {
            HslConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return HslConverter.ToColor(this);
        }
    }

	public interface ILab : IColorSpace
    {
		double L { get; set; }
		double A { get; set; }
		double B { get; set; }
    }

    public class Lab : ColorSpace, ILab
    {
		public double L { get; set; }
		public double A { get; set; }
		public double B { get; set; }

        public override void Initialize(Color color)
        {
            LabConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return LabConverter.ToColor(this);
        }
    }

	public interface IYxy : IColorSpace
    {
		double Y1 { get; set; }
		double X { get; set; }
		double Y2 { get; set; }
    }

    public class Yxy : ColorSpace, IYxy
    {
		public double Y1 { get; set; }
		public double X { get; set; }
		public double Y2 { get; set; }

        public override void Initialize(Color color)
        {
            YxyConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return YxyConverter.ToColor(this);
        }
    }

	public interface ICmy : IColorSpace
    {
		double C { get; set; }
		double M { get; set; }
		double Y { get; set; }
    }

    public class Cmy : ColorSpace, ICmy
    {
		public double C { get; set; }
		public double M { get; set; }
		public double Y { get; set; }

        public override void Initialize(Color color)
        {
            CmyConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return CmyConverter.ToColor(this);
        }
    }

	public interface ICmyk : IColorSpace
    {
		double C { get; set; }
		double M { get; set; }
		double Y { get; set; }
		double K { get; set; }
    }

    public class Cmyk : ColorSpace, ICmyk
    {
		public double C { get; set; }
		public double M { get; set; }
		public double Y { get; set; }
		public double K { get; set; }

        public override void Initialize(Color color)
        {
            CmykConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return CmykConverter.ToColor(this);
        }
    }

}