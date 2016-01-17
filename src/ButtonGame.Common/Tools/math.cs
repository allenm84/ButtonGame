using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonGame
{
	  public static class math
	  {
			/// <summary> <see cref="Math.Acos"/>. </summary>
			public static double acos(double d){ return Math.Acos(d); }

			/// <summary> <see cref="Math.Asin"/>. </summary>
			public static double asin(double d){ return Math.Asin(d); }

			/// <summary> <see cref="Math.Atan"/>. </summary>
			public static double atan(double d){ return Math.Atan(d); }

			/// <summary> <see cref="Math.Atan2"/>. </summary>
			public static double atan2(double y, double x){ return Math.Atan2(y, x); }

			/// <summary> <see cref="Math.Ceiling"/>. </summary>
			public static decimal ceiling(decimal d){ return Math.Ceiling(d); }

			/// <summary> <see cref="Math.Ceiling"/>. </summary>
			public static double ceiling(double a){ return Math.Ceiling(a); }

			/// <summary> <see cref="Math.Cos"/>. </summary>
			public static double cos(double d){ return Math.Cos(d); }

			/// <summary> <see cref="Math.Cosh"/>. </summary>
			public static double cosh(double value){ return Math.Cosh(value); }

			/// <summary> <see cref="Math.Floor"/>. </summary>
			public static decimal floor(decimal d){ return Math.Floor(d); }

			/// <summary> <see cref="Math.Floor"/>. </summary>
			public static double floor(double d){ return Math.Floor(d); }

			/// <summary> <see cref="Math.Sin"/>. </summary>
			public static double sin(double a){ return Math.Sin(a); }

			/// <summary> <see cref="Math.Tan"/>. </summary>
			public static double tan(double a){ return Math.Tan(a); }

			/// <summary> <see cref="Math.Sinh"/>. </summary>
			public static double sinh(double value){ return Math.Sinh(value); }

			/// <summary> <see cref="Math.Tanh"/>. </summary>
			public static double tanh(double value){ return Math.Tanh(value); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static double round(double a){ return Math.Round(a); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static double round(double value, int digits){ return Math.Round(value, digits); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static double round(double value, System.MidpointRounding mode){ return Math.Round(value, mode); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static double round(double value, int digits, System.MidpointRounding mode){ return Math.Round(value, digits, mode); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static decimal round(decimal d){ return Math.Round(d); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static decimal round(decimal d, int decimals){ return Math.Round(d, decimals); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static decimal round(decimal d, System.MidpointRounding mode){ return Math.Round(d, mode); }

			/// <summary> <see cref="Math.Round"/>. </summary>
			public static decimal round(decimal d, int decimals, System.MidpointRounding mode){ return Math.Round(d, decimals, mode); }

			/// <summary> <see cref="Math.Truncate"/>. </summary>
			public static decimal truncate(decimal d){ return Math.Truncate(d); }

			/// <summary> <see cref="Math.Truncate"/>. </summary>
			public static double truncate(double d){ return Math.Truncate(d); }

			/// <summary> <see cref="Math.Sqrt"/>. </summary>
			public static double sqrt(double d){ return Math.Sqrt(d); }

			/// <summary> <see cref="Math.Log"/>. </summary>
			public static double log(double d){ return Math.Log(d); }

			/// <summary> <see cref="Math.Log10"/>. </summary>
			public static double log10(double d){ return Math.Log10(d); }

			/// <summary> <see cref="Math.Exp"/>. </summary>
			public static double exp(double d){ return Math.Exp(d); }

			/// <summary> <see cref="Math.Pow"/>. </summary>
			public static double pow(double x, double y){ return Math.Pow(x, y); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static sbyte abs(sbyte value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static short abs(short value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static int abs(int value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static long abs(long value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static float abs(float value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static double abs(double value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Abs"/>. </summary>
			public static decimal abs(decimal value){ return Math.Abs(value); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static sbyte max(sbyte val1, sbyte val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static byte max(byte val1, byte val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static short max(short val1, short val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static ushort max(ushort val1, ushort val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static int max(int val1, int val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static uint max(uint val1, uint val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static long max(long val1, long val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static ulong max(ulong val1, ulong val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static float max(float val1, float val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static double max(double val1, double val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Max"/>. </summary>
			public static decimal max(decimal val1, decimal val2){ return Math.Max(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static sbyte min(sbyte val1, sbyte val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static byte min(byte val1, byte val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static short min(short val1, short val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static ushort min(ushort val1, ushort val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static int min(int val1, int val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static uint min(uint val1, uint val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static long min(long val1, long val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static ulong min(ulong val1, ulong val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static float min(float val1, float val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static double min(double val1, double val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Min"/>. </summary>
			public static decimal min(decimal val1, decimal val2){ return Math.Min(val1, val2); }

			/// <summary> <see cref="Math.Log"/>. </summary>
			public static double log(double a, double newBase){ return Math.Log(a, newBase); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(sbyte value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(short value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(int value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(long value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(float value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(double value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.Sign"/>. </summary>
			public static int sign(decimal value){ return Math.Sign(value); }

			/// <summary> <see cref="Math.BigMul"/>. </summary>
			public static long bigmul(int a, int b){ return Math.BigMul(a, b); }

			/// <summary> <see cref="Math.DivRem"/>. </summary>
			public static int divrem(int a, int b, out int result){ return Math.DivRem(a, b, out result); }

			/// <summary> <see cref="Math.DivRem"/>. </summary>
			public static long divrem(long a, long b, out long result){ return Math.DivRem(a, b, out result); }

			/// <summary> Perform linear interpolation between two values. </summary>
			public static double lerp(double v0, double v1, double t)
			{
			  return v0 + t * (v1 - v0);
			}

			/// <summary> Performs the modulo operation. </summary>
			public static int mod(int x, int m)
			{
			  return (x % m + m) % m;
			}
	}
}
