//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In electromagnetism, current density is the electric current per unit area of cross section.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Current_density
    /// </remarks>
    public struct  ElectricCurrentDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricCurrentDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricCurrentDensityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricCurrentDensity(double value, ElectricCurrentDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentDensityUnit BaseUnit { get; } = ElectricCurrentDensityUnit.AmperePerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricCurrentDensity MaxValue { get; } = new ElectricCurrentDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricCurrentDensity MinValue { get; } = new ElectricCurrentDensity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCurrentDensity Zero { get; } = new ElectricCurrentDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareFoot.
        /// </summary>
        public double AmperesPerSquareFoot => As(ElectricCurrentDensityUnit.AmperePerSquareFoot);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareInch.
        /// </summary>
        public double AmperesPerSquareInch => As(ElectricCurrentDensityUnit.AmperePerSquareInch);

        /// <summary>
        ///     Get ElectricCurrentDensity in AmperesPerSquareMeter.
        /// </summary>
        public double AmperesPerSquareMeter => As(ElectricCurrentDensityUnit.AmperePerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareFoot(double amperespersquarefoot) => new ElectricCurrentDensity(amperespersquarefoot, ElectricCurrentDensityUnit.AmperePerSquareFoot);

        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareInch(double amperespersquareinch) => new ElectricCurrentDensity(amperespersquareinch, ElectricCurrentDensityUnit.AmperePerSquareInch);

        /// <summary>
        ///     Get ElectricCurrentDensity from AmperesPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrentDensity FromAmperesPerSquareMeter(double amperespersquaremeter) => new ElectricCurrentDensity(amperespersquaremeter, ElectricCurrentDensityUnit.AmperePerSquareMeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentDensityUnit" /> to <see cref="ElectricCurrentDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrentDensity unit value.</returns>
        public static ElectricCurrentDensity From(double value, ElectricCurrentDensityUnit fromUnit)
        {
            return new ElectricCurrentDensity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricCurrentDensityUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricCurrentDensity ToUnit(ElectricCurrentDensityUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new ElectricCurrentDensity(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case ElectricCurrentDensityUnit.AmperePerSquareFoot: return _value * 1.0763910416709722e1;
                case ElectricCurrentDensityUnit.AmperePerSquareInch: return _value * 1.5500031000062000e3;
                case ElectricCurrentDensityUnit.AmperePerSquareMeter: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ElectricCurrentDensityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ElectricCurrentDensityUnit.AmperePerSquareFoot: return baseUnitValue / 1.0763910416709722e1;
                case ElectricCurrentDensityUnit.AmperePerSquareInch: return baseUnitValue / 1.5500031000062000e3;
                case ElectricCurrentDensityUnit.AmperePerSquareMeter: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

