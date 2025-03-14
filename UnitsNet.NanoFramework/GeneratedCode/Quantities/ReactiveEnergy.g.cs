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
    ///     The Volt-ampere reactive hour (expressed as varh) is the reactive power of one Volt-ampere reactive produced in one hour.
    /// </summary>
    /// <remarks>
    ///     <c>ReactiveEnergy</c> has been renamed to <c>ElectricReactiveEnergy</c>, and will be removed in a later major version.
    /// </remarks>
    [Obsolete("ReactiveEnergy has been renamed to ElectricReactiveEnergy, and will be removed in a later major version.")]
    public struct  ReactiveEnergy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReactiveEnergyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ReactiveEnergyUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ReactiveEnergy(double value, ReactiveEnergyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ReactiveEnergy, which is Second. All conversions go via this value.
        /// </summary>
        public static ReactiveEnergyUnit BaseUnit { get; } = ReactiveEnergyUnit.VoltampereReactiveHour;

        /// <summary>
        /// Represents the largest possible value of ReactiveEnergy.
        /// </summary>
        public static ReactiveEnergy MaxValue { get; } = new ReactiveEnergy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ReactiveEnergy.
        /// </summary>
        public static ReactiveEnergy MinValue { get; } = new ReactiveEnergy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ReactiveEnergy Zero { get; } = new ReactiveEnergy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactiveEnergyUnit.KilovoltampereReactiveHour"/>
        /// </summary>
        public double KilovoltampereReactiveHours => As(ReactiveEnergyUnit.KilovoltampereReactiveHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactiveEnergyUnit.MegavoltampereReactiveHour"/>
        /// </summary>
        public double MegavoltampereReactiveHours => As(ReactiveEnergyUnit.MegavoltampereReactiveHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReactiveEnergyUnit.VoltampereReactiveHour"/>
        /// </summary>
        public double VoltampereReactiveHours => As(ReactiveEnergyUnit.VoltampereReactiveHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReactiveEnergy"/> from <see cref="ReactiveEnergyUnit.KilovoltampereReactiveHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactiveEnergy FromKilovoltampereReactiveHours(double kilovoltamperereactivehours) => new ReactiveEnergy(kilovoltamperereactivehours, ReactiveEnergyUnit.KilovoltampereReactiveHour);

        /// <summary>
        ///     Creates a <see cref="ReactiveEnergy"/> from <see cref="ReactiveEnergyUnit.MegavoltampereReactiveHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactiveEnergy FromMegavoltampereReactiveHours(double megavoltamperereactivehours) => new ReactiveEnergy(megavoltamperereactivehours, ReactiveEnergyUnit.MegavoltampereReactiveHour);

        /// <summary>
        ///     Creates a <see cref="ReactiveEnergy"/> from <see cref="ReactiveEnergyUnit.VoltampereReactiveHour"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReactiveEnergy FromVoltampereReactiveHours(double voltamperereactivehours) => new ReactiveEnergy(voltamperereactivehours, ReactiveEnergyUnit.VoltampereReactiveHour);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReactiveEnergyUnit" /> to <see cref="ReactiveEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReactiveEnergy unit value.</returns>
        public static ReactiveEnergy From(double value, ReactiveEnergyUnit fromUnit)
        {
            return new ReactiveEnergy(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ReactiveEnergyUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ReactiveEnergy to another ReactiveEnergy with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ReactiveEnergy with the specified unit.</returns>
                public ReactiveEnergy ToUnit(ReactiveEnergyUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ReactiveEnergy(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        ReactiveEnergyUnit.KilovoltampereReactiveHour => (_value) * 1e3d,
                        ReactiveEnergyUnit.MegavoltampereReactiveHour => (_value) * 1e6d,
                        ReactiveEnergyUnit.VoltampereReactiveHour => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ReactiveEnergyUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ReactiveEnergyUnit.KilovoltampereReactiveHour => (baseUnitValue) / 1e3d,
                        ReactiveEnergyUnit.MegavoltampereReactiveHour => (baseUnitValue) / 1e6d,
                        ReactiveEnergyUnit.VoltampereReactiveHour => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

