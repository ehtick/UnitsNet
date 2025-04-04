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

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToElectricApparentPower
{
    /// <summary>
    /// A number to ElectricApparentPower Extensions
    /// </summary>
    public static class NumberToElectricApparentPowerExtensions
    {
        /// <inheritdoc cref="ElectricApparentPower.FromGigavoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Gigavoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromGigavoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricApparentPower.FromKilovoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Kilovoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromKilovoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricApparentPower.FromMegavoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Megavoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromMegavoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricApparentPower.FromMicrovoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Microvoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromMicrovoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricApparentPower.FromMillivoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Millivoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromMillivoltamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricApparentPower.FromVoltamperes(UnitsNet.QuantityValue)" />
        public static ElectricApparentPower Voltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricApparentPower.FromVoltamperes(Convert.ToDouble(value));

    }
}
