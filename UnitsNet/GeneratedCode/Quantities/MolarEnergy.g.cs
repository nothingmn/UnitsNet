﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Molar energy is the amount of energy stored in 1 mole of a substance.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class MolarEnergy
#else
    public partial struct MolarEnergy : IComparable, IComparable<MolarEnergy>
#endif
    {
        /// <summary>
        ///     Base unit of MolarEnergy.
        /// </summary>
        private readonly double _joulesPerMole;

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public MolarEnergy() : this(0)
        {
        }
#endif

        public MolarEnergy(double joulespermole)
        {
            _joulesPerMole = Convert.ToDouble(joulespermole);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        MolarEnergy(long joulespermole)
        {
            _joulesPerMole = Convert.ToDouble(joulespermole);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        MolarEnergy(decimal joulespermole)
        {
            _joulesPerMole = Convert.ToDouble(joulespermole);
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.MolarEnergy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MolarEnergyUnit BaseUnit
        {
            get { return MolarEnergyUnit.JoulePerMole; }
        }

        /// <summary>
        ///     All units of measurement for the MolarEnergy quantity.
        /// </summary>
        public static MolarEnergyUnit[] Units { get; } = Enum.GetValues(typeof(MolarEnergyUnit)).Cast<MolarEnergyUnit>().ToArray();

        /// <summary>
        ///     Get MolarEnergy in JoulesPerMole.
        /// </summary>
        public double JoulesPerMole
        {
            get { return _joulesPerMole; }
        }

        /// <summary>
        ///     Get MolarEnergy in KilojoulesPerMole.
        /// </summary>
        public double KilojoulesPerMole
        {
            get { return (_joulesPerMole) / 1e3d; }
        }

        /// <summary>
        ///     Get MolarEnergy in MegajoulesPerMole.
        /// </summary>
        public double MegajoulesPerMole
        {
            get { return (_joulesPerMole) / 1e6d; }
        }

        #endregion

        #region Static

        public static MolarEnergy Zero
        {
            get { return new MolarEnergy(); }
        }

        /// <summary>
        ///     Get MolarEnergy from JoulesPerMole.
        /// </summary>
#if NETFX_CORE
        [Windows.Foundation.Metadata.DefaultOverload]
#endif
        public static MolarEnergy FromJoulesPerMole(double joulespermole)
        {
            return new MolarEnergy(joulespermole);
        }

        /// <summary>
        ///     Get MolarEnergy from JoulesPerMole.
        /// </summary>
        public static MolarEnergy FromJoulesPerMole(int joulespermole)
        {
            return new MolarEnergy(joulespermole);
        }

        /// <summary>
        ///     Get MolarEnergy from JoulesPerMole.
        /// </summary>
        public static MolarEnergy FromJoulesPerMole(long joulespermole)
        {
            return new MolarEnergy(joulespermole);
        }

        // Windows Runtime Component does not support decimal type
#if !WINDOWS_UWP
        /// <summary>
        ///     Get MolarEnergy from JoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy FromJoulesPerMole(decimal joulespermole)
        {
            return new MolarEnergy(Convert.ToDouble(joulespermole));
        }
#endif

        /// <summary>
        ///     Get MolarEnergy from KilojoulesPerMole.
        /// </summary>
#if NETFX_CORE
        [Windows.Foundation.Metadata.DefaultOverload]
#endif
        public static MolarEnergy FromKilojoulesPerMole(double kilojoulespermole)
        {
            return new MolarEnergy((kilojoulespermole) * 1e3d);
        }

        /// <summary>
        ///     Get MolarEnergy from KilojoulesPerMole.
        /// </summary>
        public static MolarEnergy FromKilojoulesPerMole(int kilojoulespermole)
        {
            return new MolarEnergy((kilojoulespermole) * 1e3d);
        }

        /// <summary>
        ///     Get MolarEnergy from KilojoulesPerMole.
        /// </summary>
        public static MolarEnergy FromKilojoulesPerMole(long kilojoulespermole)
        {
            return new MolarEnergy((kilojoulespermole) * 1e3d);
        }

        // Windows Runtime Component does not support decimal type
#if !WINDOWS_UWP
        /// <summary>
        ///     Get MolarEnergy from KilojoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy FromKilojoulesPerMole(decimal kilojoulespermole)
        {
            return new MolarEnergy((Convert.ToDouble(kilojoulespermole)) * 1e3d);
        }
#endif

        /// <summary>
        ///     Get MolarEnergy from MegajoulesPerMole.
        /// </summary>
#if NETFX_CORE
        [Windows.Foundation.Metadata.DefaultOverload]
#endif
        public static MolarEnergy FromMegajoulesPerMole(double megajoulespermole)
        {
            return new MolarEnergy((megajoulespermole) * 1e6d);
        }

        /// <summary>
        ///     Get MolarEnergy from MegajoulesPerMole.
        /// </summary>
        public static MolarEnergy FromMegajoulesPerMole(int megajoulespermole)
        {
            return new MolarEnergy((megajoulespermole) * 1e6d);
        }

        /// <summary>
        ///     Get MolarEnergy from MegajoulesPerMole.
        /// </summary>
        public static MolarEnergy FromMegajoulesPerMole(long megajoulespermole)
        {
            return new MolarEnergy((megajoulespermole) * 1e6d);
        }

        // Windows Runtime Component does not support decimal type
#if !WINDOWS_UWP
        /// <summary>
        ///     Get MolarEnergy from MegajoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy FromMegajoulesPerMole(decimal megajoulespermole)
        {
            return new MolarEnergy((Convert.ToDouble(megajoulespermole)) * 1e6d);
        }
#endif

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable MolarEnergy from nullable JoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromJoulesPerMole(double? joulespermole)
        {
            if (joulespermole.HasValue)
            {
                return FromJoulesPerMole(joulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable JoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromJoulesPerMole(int? joulespermole)
        {
            if (joulespermole.HasValue)
            {
                return FromJoulesPerMole(joulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable JoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromJoulesPerMole(long? joulespermole)
        {
            if (joulespermole.HasValue)
            {
                return FromJoulesPerMole(joulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from JoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy? FromJoulesPerMole(decimal? joulespermole)
        {
            if (joulespermole.HasValue)
            {
                return FromJoulesPerMole(joulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable KilojoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromKilojoulesPerMole(double? kilojoulespermole)
        {
            if (kilojoulespermole.HasValue)
            {
                return FromKilojoulesPerMole(kilojoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable KilojoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromKilojoulesPerMole(int? kilojoulespermole)
        {
            if (kilojoulespermole.HasValue)
            {
                return FromKilojoulesPerMole(kilojoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable KilojoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromKilojoulesPerMole(long? kilojoulespermole)
        {
            if (kilojoulespermole.HasValue)
            {
                return FromKilojoulesPerMole(kilojoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from KilojoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy? FromKilojoulesPerMole(decimal? kilojoulespermole)
        {
            if (kilojoulespermole.HasValue)
            {
                return FromKilojoulesPerMole(kilojoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable MegajoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromMegajoulesPerMole(double? megajoulespermole)
        {
            if (megajoulespermole.HasValue)
            {
                return FromMegajoulesPerMole(megajoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable MegajoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromMegajoulesPerMole(int? megajoulespermole)
        {
            if (megajoulespermole.HasValue)
            {
                return FromMegajoulesPerMole(megajoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from nullable MegajoulesPerMole.
        /// </summary>
        public static MolarEnergy? FromMegajoulesPerMole(long? megajoulespermole)
        {
            if (megajoulespermole.HasValue)
            {
                return FromMegajoulesPerMole(megajoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEnergy from MegajoulesPerMole of type decimal.
        /// </summary>
        public static MolarEnergy? FromMegajoulesPerMole(decimal? megajoulespermole)
        {
            if (megajoulespermole.HasValue)
            {
                return FromMegajoulesPerMole(megajoulespermole.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEnergyUnit" /> to <see cref="MolarEnergy" />.
        /// </summary>
        /// <param name="val">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEnergy unit value.</returns>
        public static MolarEnergy From(double val, MolarEnergyUnit fromUnit)
        {
            switch (fromUnit)
            {
                case MolarEnergyUnit.JoulePerMole:
                    return FromJoulesPerMole(val);
                case MolarEnergyUnit.KilojoulePerMole:
                    return FromKilojoulesPerMole(val);
                case MolarEnergyUnit.MegajoulePerMole:
                    return FromMegajoulesPerMole(val);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEnergyUnit" /> to <see cref="MolarEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEnergy unit value.</returns>
        public static MolarEnergy? From(double? value, MolarEnergyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case MolarEnergyUnit.JoulePerMole:
                    return FromJoulesPerMole(value.Value);
                case MolarEnergyUnit.KilojoulePerMole:
                    return FromKilojoulesPerMole(value.Value);
                case MolarEnergyUnit.MegajoulePerMole:
                    return FromMegajoulesPerMole(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarEnergyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarEnergyUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static MolarEnergy operator -(MolarEnergy right)
        {
            return new MolarEnergy(-right._joulesPerMole);
        }

        public static MolarEnergy operator +(MolarEnergy left, MolarEnergy right)
        {
            return new MolarEnergy(left._joulesPerMole + right._joulesPerMole);
        }

        public static MolarEnergy operator -(MolarEnergy left, MolarEnergy right)
        {
            return new MolarEnergy(left._joulesPerMole - right._joulesPerMole);
        }

        public static MolarEnergy operator *(double left, MolarEnergy right)
        {
            return new MolarEnergy(left*right._joulesPerMole);
        }

        public static MolarEnergy operator *(MolarEnergy left, double right)
        {
            return new MolarEnergy(left._joulesPerMole*(double)right);
        }

        public static MolarEnergy operator /(MolarEnergy left, double right)
        {
            return new MolarEnergy(left._joulesPerMole/(double)right);
        }

        public static double operator /(MolarEnergy left, MolarEnergy right)
        {
            return Convert.ToDouble(left._joulesPerMole/right._joulesPerMole);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is MolarEnergy)) throw new ArgumentException("Expected type MolarEnergy.", "obj");
            return CompareTo((MolarEnergy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(MolarEnergy other)
        {
            return _joulesPerMole.CompareTo(other._joulesPerMole);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(MolarEnergy left, MolarEnergy right)
        {
            return left._joulesPerMole <= right._joulesPerMole;
        }

        public static bool operator >=(MolarEnergy left, MolarEnergy right)
        {
            return left._joulesPerMole >= right._joulesPerMole;
        }

        public static bool operator <(MolarEnergy left, MolarEnergy right)
        {
            return left._joulesPerMole < right._joulesPerMole;
        }

        public static bool operator >(MolarEnergy left, MolarEnergy right)
        {
            return left._joulesPerMole > right._joulesPerMole;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(MolarEnergy left, MolarEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerMole == right._joulesPerMole;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(MolarEnergy left, MolarEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerMole != right._joulesPerMole;
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _joulesPerMole.Equals(((MolarEnergy) obj)._joulesPerMole);
        }

        /// <summary>
        ///     Compare equality to another MolarEnergy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(MolarEnergy other, MolarEnergy maxError)
        {
            return Math.Abs(_joulesPerMole - other._joulesPerMole) <= maxError._joulesPerMole;
        }

        public override int GetHashCode()
        {
            return _joulesPerMole.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(MolarEnergyUnit unit)
        {
            switch (unit)
            {
                case MolarEnergyUnit.JoulePerMole:
                    return JoulesPerMole;
                case MolarEnergyUnit.KilojoulePerMole:
                    return KilojoulesPerMole;
                case MolarEnergyUnit.MegajoulePerMole:
                    return MegajoulesPerMole;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static MolarEnergy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static MolarEnergy Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<MolarEnergy, MolarEnergyUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    MolarEnergyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromJoulesPerMole(x.JoulesPerMole + y.JoulesPerMole));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out MolarEnergy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out MolarEnergy result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(MolarEnergy);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarEnergyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarEnergyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static MolarEnergyUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<MolarEnergyUnit>(str.Trim());

            if (unit == MolarEnergyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized MolarEnergyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is JoulePerMole
        /// </summary>
        public static MolarEnergyUnit ToStringDefaultUnit { get; set; } = MolarEnergyUnit.JoulePerMole;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarEnergyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarEnergyUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarEnergyUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarEnergyUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of MolarEnergy
        /// </summary>
        public static MolarEnergy MaxValue
        {
            get
            {
                return new MolarEnergy(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of MolarEnergy
        /// </summary>
        public static MolarEnergy MinValue
        {
            get
            {
                return new MolarEnergy(double.MinValue);
            }
        }
    }
}
