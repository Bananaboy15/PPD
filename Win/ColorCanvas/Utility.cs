﻿using ColorCanvas.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace ColorCanvas
{
    class Utility
    {
        public static double MeasureWidth(string text, FontFamily fontFamily, double fontSize)
        {
            return MeasureSize(text, fontFamily, fontSize).Width;
        }

        public static Size MeasureSize(string text, FontFamily fontFamily, double fontSize)
        {
            if (text == null)
            {
                text = "";
            }

            System.Windows.FontStyle fontStyle = FontStyles.Normal;
            FontWeight fontWeight = FontWeights.Medium;
            var formattedText = new FormattedText(
                text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(
                    fontFamily,
                    fontStyle,
                    fontWeight,
                    FontStretches.Normal),
                    fontSize,
                    System.Windows.Media.Brushes.Black
                );
            Geometry _textGeometry = formattedText.BuildGeometry(new System.Windows.Point(0, 0));
            Geometry _textHighLightGeometry = formattedText.BuildHighlightGeometry(new System.Windows.Point(0, 0));
            return _textHighLightGeometry == null ? new Size(0, 0) : _textHighLightGeometry.Bounds.Size;
        }

        public static HsvColor ConvertRgbToHsv(int r, int b, int g)
        {
            double delta, min;
            double h = 0, s, v;

            min = Math.Min(Math.Min(r, g), b);
            v = Math.Max(Math.Max(r, g), b);
            delta = v - min;

            if (v == 0.0)
            {
                s = 0;
            }
            else
            {
                s = delta / v;
            }

            if (s == 0)
            {
                h = 0.0;
            }
            else
            {
                if (r == v)
                {
                    h = (g - b) / delta;
                }
                else if (g == v)
                {
                    h = 2 + (b - r) / delta;
                }
                else if (b == v)
                {
                    h = 4 + (r - g) / delta;
                }
                h *= 60;
                if (h < 0.0)
                {
                    h = h + 360;
                }
            }

            return new HsvColor
            {
                H = h,
                S = s,
                V = v / 255
            };
        }

        public static Color ConvertHsvToRgb(double h, double s, double v)
        {
            double r = 0, g = 0, b = 0;

            if (s == 0)
            {
                r = v;
                g = v;
                b = v;
            }
            else
            {
                int i;
                double f, p, q, t;

                if (h == 360)
                {
                    h = 0;
                }
                else
                {
                    h = h / 60;
                }

                i = (int)Math.Truncate(h);
                f = h - i;

                p = v * (1.0 - s);
                q = v * (1.0 - (s * f));
                t = v * (1.0 - (s * (1.0 - f)));

                switch (i)
                {
                    case 0:
                        r = v;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = v;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = v;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = v;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = v;
                        break;
                    default:
                        r = v;
                        g = p;
                        b = q;
                        break;
                }

            }

            return Color.FromArgb(255, (byte)(Math.Round(r * 255)), (byte)(Math.Round(g * 255)), (byte)(Math.Round(b * 255)));
        }

        public static List<Color> GenerateHsvSpectrum()
        {
            var colorsList = new List<Color>(8);

            for (int i = 0; i < 29; i++)
            {
                colorsList.Add(ConvertHsvToRgb(i * 12, 1, 1));
            }

            colorsList.Add(ConvertHsvToRgb(0, 1, 1));

            return colorsList;
        }

        public static string FormatColorString(string stringToFormat, bool isUsingAlphaChannel)
        {
            if (!isUsingAlphaChannel && (stringToFormat.Length == 9))
            {
                return stringToFormat.Remove(1, 2);
            }
            return stringToFormat;
        }
    }
}
