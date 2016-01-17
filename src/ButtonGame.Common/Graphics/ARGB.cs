
using System;
using System.Runtime.InteropServices;

namespace ButtonGame
{
	public struct ARGB
	{
		public byte A, R, G, B;

		public static readonly ARGB ActiveBorder = new ARGB(180, 180, 180);
		public static readonly ARGB ActiveCaption = new ARGB(153, 180, 209);
		public static readonly ARGB ActiveCaptionText = new ARGB(0, 0, 0);
		public static readonly ARGB AppWorkspace = new ARGB(171, 171, 171);
		public static readonly ARGB Control = new ARGB(240, 240, 240);
		public static readonly ARGB ControlDark = new ARGB(160, 160, 160);
		public static readonly ARGB ControlDarkDark = new ARGB(105, 105, 105);
		public static readonly ARGB ControlLight = new ARGB(227, 227, 227);
		public static readonly ARGB ControlLightLight = new ARGB(255, 255, 255);
		public static readonly ARGB ControlText = new ARGB(0, 0, 0);
		public static readonly ARGB Desktop = new ARGB(0, 0, 0);
		public static readonly ARGB GrayText = new ARGB(109, 109, 109);
		public static readonly ARGB Highlight = new ARGB(51, 153, 255);
		public static readonly ARGB HighlightText = new ARGB(255, 255, 255);
		public static readonly ARGB HotTrack = new ARGB(0, 102, 204);
		public static readonly ARGB InactiveBorder = new ARGB(244, 247, 252);
		public static readonly ARGB InactiveCaption = new ARGB(191, 205, 219);
		public static readonly ARGB InactiveCaptionText = new ARGB(0, 0, 0);
		public static readonly ARGB Info = new ARGB(255, 255, 225);
		public static readonly ARGB InfoText = new ARGB(0, 0, 0);
		public static readonly ARGB Menu = new ARGB(240, 240, 240);
		public static readonly ARGB MenuText = new ARGB(0, 0, 0);
		public static readonly ARGB ScrollBar = new ARGB(200, 200, 200);
		public static readonly ARGB Window = new ARGB(255, 255, 255);
		public static readonly ARGB WindowFrame = new ARGB(100, 100, 100);
		public static readonly ARGB WindowText = new ARGB(0, 0, 0);
		public static readonly ARGB Transparent = new ARGB(255, 255, 255);
		public static readonly ARGB AliceBlue = new ARGB(240, 248, 255);
		public static readonly ARGB AntiqueWhite = new ARGB(250, 235, 215);
		public static readonly ARGB Aqua = new ARGB(0, 255, 255);
		public static readonly ARGB Aquamarine = new ARGB(127, 255, 212);
		public static readonly ARGB Azure = new ARGB(240, 255, 255);
		public static readonly ARGB Beige = new ARGB(245, 245, 220);
		public static readonly ARGB Bisque = new ARGB(255, 228, 196);
		public static readonly ARGB Black = new ARGB(0, 0, 0);
		public static readonly ARGB BlanchedAlmond = new ARGB(255, 235, 205);
		public static readonly ARGB Blue = new ARGB(0, 0, 255);
		public static readonly ARGB BlueViolet = new ARGB(138, 43, 226);
		public static readonly ARGB Brown = new ARGB(165, 42, 42);
		public static readonly ARGB BurlyWood = new ARGB(222, 184, 135);
		public static readonly ARGB CadetBlue = new ARGB(95, 158, 160);
		public static readonly ARGB Chartreuse = new ARGB(127, 255, 0);
		public static readonly ARGB Chocolate = new ARGB(210, 105, 30);
		public static readonly ARGB Coral = new ARGB(255, 127, 80);
		public static readonly ARGB CornflowerBlue = new ARGB(100, 149, 237);
		public static readonly ARGB Cornsilk = new ARGB(255, 248, 220);
		public static readonly ARGB Crimson = new ARGB(220, 20, 60);
		public static readonly ARGB Cyan = new ARGB(0, 255, 255);
		public static readonly ARGB DarkBlue = new ARGB(0, 0, 139);
		public static readonly ARGB DarkCyan = new ARGB(0, 139, 139);
		public static readonly ARGB DarkGoldenrod = new ARGB(184, 134, 11);
		public static readonly ARGB DarkGray = new ARGB(169, 169, 169);
		public static readonly ARGB DarkGreen = new ARGB(0, 100, 0);
		public static readonly ARGB DarkKhaki = new ARGB(189, 183, 107);
		public static readonly ARGB DarkMagenta = new ARGB(139, 0, 139);
		public static readonly ARGB DarkOliveGreen = new ARGB(85, 107, 47);
		public static readonly ARGB DarkOrange = new ARGB(255, 140, 0);
		public static readonly ARGB DarkOrchid = new ARGB(153, 50, 204);
		public static readonly ARGB DarkRed = new ARGB(139, 0, 0);
		public static readonly ARGB DarkSalmon = new ARGB(233, 150, 122);
		public static readonly ARGB DarkSeaGreen = new ARGB(143, 188, 139);
		public static readonly ARGB DarkSlateBlue = new ARGB(72, 61, 139);
		public static readonly ARGB DarkSlateGray = new ARGB(47, 79, 79);
		public static readonly ARGB DarkTurquoise = new ARGB(0, 206, 209);
		public static readonly ARGB DarkViolet = new ARGB(148, 0, 211);
		public static readonly ARGB DeepPink = new ARGB(255, 20, 147);
		public static readonly ARGB DeepSkyBlue = new ARGB(0, 191, 255);
		public static readonly ARGB DimGray = new ARGB(105, 105, 105);
		public static readonly ARGB DodgerBlue = new ARGB(30, 144, 255);
		public static readonly ARGB Firebrick = new ARGB(178, 34, 34);
		public static readonly ARGB FloralWhite = new ARGB(255, 250, 240);
		public static readonly ARGB ForestGreen = new ARGB(34, 139, 34);
		public static readonly ARGB Fuchsia = new ARGB(255, 0, 255);
		public static readonly ARGB Gainsboro = new ARGB(220, 220, 220);
		public static readonly ARGB GhostWhite = new ARGB(248, 248, 255);
		public static readonly ARGB Gold = new ARGB(255, 215, 0);
		public static readonly ARGB Goldenrod = new ARGB(218, 165, 32);
		public static readonly ARGB Gray = new ARGB(128, 128, 128);
		public static readonly ARGB Green = new ARGB(0, 128, 0);
		public static readonly ARGB GreenYellow = new ARGB(173, 255, 47);
		public static readonly ARGB Honeydew = new ARGB(240, 255, 240);
		public static readonly ARGB HotPink = new ARGB(255, 105, 180);
		public static readonly ARGB IndianRed = new ARGB(205, 92, 92);
		public static readonly ARGB Indigo = new ARGB(75, 0, 130);
		public static readonly ARGB Ivory = new ARGB(255, 255, 240);
		public static readonly ARGB Khaki = new ARGB(240, 230, 140);
		public static readonly ARGB Lavender = new ARGB(230, 230, 250);
		public static readonly ARGB LavenderBlush = new ARGB(255, 240, 245);
		public static readonly ARGB LawnGreen = new ARGB(124, 252, 0);
		public static readonly ARGB LemonChiffon = new ARGB(255, 250, 205);
		public static readonly ARGB LightBlue = new ARGB(173, 216, 230);
		public static readonly ARGB LightCoral = new ARGB(240, 128, 128);
		public static readonly ARGB LightCyan = new ARGB(224, 255, 255);
		public static readonly ARGB LightGoldenrodYellow = new ARGB(250, 250, 210);
		public static readonly ARGB LightGray = new ARGB(211, 211, 211);
		public static readonly ARGB LightGreen = new ARGB(144, 238, 144);
		public static readonly ARGB LightPink = new ARGB(255, 182, 193);
		public static readonly ARGB LightSalmon = new ARGB(255, 160, 122);
		public static readonly ARGB LightSeaGreen = new ARGB(32, 178, 170);
		public static readonly ARGB LightSkyBlue = new ARGB(135, 206, 250);
		public static readonly ARGB LightSlateGray = new ARGB(119, 136, 153);
		public static readonly ARGB LightSteelBlue = new ARGB(176, 196, 222);
		public static readonly ARGB LightYellow = new ARGB(255, 255, 224);
		public static readonly ARGB Lime = new ARGB(0, 255, 0);
		public static readonly ARGB LimeGreen = new ARGB(50, 205, 50);
		public static readonly ARGB Linen = new ARGB(250, 240, 230);
		public static readonly ARGB Magenta = new ARGB(255, 0, 255);
		public static readonly ARGB Maroon = new ARGB(128, 0, 0);
		public static readonly ARGB MediumAquamarine = new ARGB(102, 205, 170);
		public static readonly ARGB MediumBlue = new ARGB(0, 0, 205);
		public static readonly ARGB MediumOrchid = new ARGB(186, 85, 211);
		public static readonly ARGB MediumPurple = new ARGB(147, 112, 219);
		public static readonly ARGB MediumSeaGreen = new ARGB(60, 179, 113);
		public static readonly ARGB MediumSlateBlue = new ARGB(123, 104, 238);
		public static readonly ARGB MediumSpringGreen = new ARGB(0, 250, 154);
		public static readonly ARGB MediumTurquoise = new ARGB(72, 209, 204);
		public static readonly ARGB MediumVioletRed = new ARGB(199, 21, 133);
		public static readonly ARGB MidnightBlue = new ARGB(25, 25, 112);
		public static readonly ARGB MintCream = new ARGB(245, 255, 250);
		public static readonly ARGB MistyRose = new ARGB(255, 228, 225);
		public static readonly ARGB Moccasin = new ARGB(255, 228, 181);
		public static readonly ARGB NavajoWhite = new ARGB(255, 222, 173);
		public static readonly ARGB Navy = new ARGB(0, 0, 128);
		public static readonly ARGB OldLace = new ARGB(253, 245, 230);
		public static readonly ARGB Olive = new ARGB(128, 128, 0);
		public static readonly ARGB OliveDrab = new ARGB(107, 142, 35);
		public static readonly ARGB Orange = new ARGB(255, 165, 0);
		public static readonly ARGB OrangeRed = new ARGB(255, 69, 0);
		public static readonly ARGB Orchid = new ARGB(218, 112, 214);
		public static readonly ARGB PaleGoldenrod = new ARGB(238, 232, 170);
		public static readonly ARGB PaleGreen = new ARGB(152, 251, 152);
		public static readonly ARGB PaleTurquoise = new ARGB(175, 238, 238);
		public static readonly ARGB PaleVioletRed = new ARGB(219, 112, 147);
		public static readonly ARGB PapayaWhip = new ARGB(255, 239, 213);
		public static readonly ARGB PeachPuff = new ARGB(255, 218, 185);
		public static readonly ARGB Peru = new ARGB(205, 133, 63);
		public static readonly ARGB Pink = new ARGB(255, 192, 203);
		public static readonly ARGB Plum = new ARGB(221, 160, 221);
		public static readonly ARGB PowderBlue = new ARGB(176, 224, 230);
		public static readonly ARGB Purple = new ARGB(128, 0, 128);
		public static readonly ARGB Red = new ARGB(255, 0, 0);
		public static readonly ARGB RosyBrown = new ARGB(188, 143, 143);
		public static readonly ARGB RoyalBlue = new ARGB(65, 105, 225);
		public static readonly ARGB SaddleBrown = new ARGB(139, 69, 19);
		public static readonly ARGB Salmon = new ARGB(250, 128, 114);
		public static readonly ARGB SandyBrown = new ARGB(244, 164, 96);
		public static readonly ARGB SeaGreen = new ARGB(46, 139, 87);
		public static readonly ARGB SeaShell = new ARGB(255, 245, 238);
		public static readonly ARGB Sienna = new ARGB(160, 82, 45);
		public static readonly ARGB Silver = new ARGB(192, 192, 192);
		public static readonly ARGB SkyBlue = new ARGB(135, 206, 235);
		public static readonly ARGB SlateBlue = new ARGB(106, 90, 205);
		public static readonly ARGB SlateGray = new ARGB(112, 128, 144);
		public static readonly ARGB Snow = new ARGB(255, 250, 250);
		public static readonly ARGB SpringGreen = new ARGB(0, 255, 127);
		public static readonly ARGB SteelBlue = new ARGB(70, 130, 180);
		public static readonly ARGB Tan = new ARGB(210, 180, 140);
		public static readonly ARGB Teal = new ARGB(0, 128, 128);
		public static readonly ARGB Thistle = new ARGB(216, 191, 216);
		public static readonly ARGB Tomato = new ARGB(255, 99, 71);
		public static readonly ARGB Turquoise = new ARGB(64, 224, 208);
		public static readonly ARGB Violet = new ARGB(238, 130, 238);
		public static readonly ARGB Wheat = new ARGB(245, 222, 179);
		public static readonly ARGB White = new ARGB(255, 255, 255);
		public static readonly ARGB WhiteSmoke = new ARGB(245, 245, 245);
		public static readonly ARGB Yellow = new ARGB(255, 255, 0);
		public static readonly ARGB YellowGreen = new ARGB(154, 205, 50);
		public static readonly ARGB ButtonFace = new ARGB(240, 240, 240);
		public static readonly ARGB ButtonHighlight = new ARGB(255, 255, 255);
		public static readonly ARGB ButtonShadow = new ARGB(160, 160, 160);
		public static readonly ARGB GradientActiveCaption = new ARGB(185, 209, 234);
		public static readonly ARGB GradientInactiveCaption = new ARGB(215, 228, 242);
		public static readonly ARGB MenuBar = new ARGB(240, 240, 240);
		public static readonly ARGB MenuHighlight = new ARGB(51, 153, 255);

		public ARGB(byte r, byte g, byte b)
		{
			A = 255;
			R = r;
			G = g;
			B = b;
		}

		public ARGB(byte a, byte r, byte g, byte b)
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}

		public static ARGB FromArgb(byte alpha, ARGB rgb)
		{
			return new ARGB(alpha, rgb.R, rgb.G, rgb.B);
		}
	}
}