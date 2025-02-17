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

namespace UnitsNet.NumberExtensions.NumberToReactiveEnergy
{
    /// <summary>
    /// A number to ReactiveEnergy Extensions
    /// </summary>
    [Obsolete("ReactiveEnergy has been renamed to ElectricReactiveEnergy, and will be removed in a later major version.")]
    public static class NumberToReactiveEnergyExtensions
    {
        /// <inheritdoc cref="ReactiveEnergy.FromKilovoltampereReactiveHours(UnitsNet.QuantityValue)" />
        [Obsolete("ReactiveEnergy has been renamed to ElectricReactiveEnergy, and will be removed in a later major version.")]
        public static ReactiveEnergy KilovoltampereReactiveHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReactiveEnergy.FromKilovoltampereReactiveHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ReactiveEnergy.FromMegavoltampereReactiveHours(UnitsNet.QuantityValue)" />
        [Obsolete("ReactiveEnergy has been renamed to ElectricReactiveEnergy, and will be removed in a later major version.")]
        public static ReactiveEnergy MegavoltampereReactiveHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReactiveEnergy.FromMegavoltampereReactiveHours(Convert.ToDouble(value));

        /// <inheritdoc cref="ReactiveEnergy.FromVoltampereReactiveHours(UnitsNet.QuantityValue)" />
        [Obsolete("ReactiveEnergy has been renamed to ElectricReactiveEnergy, and will be removed in a later major version.")]
        public static ReactiveEnergy VoltampereReactiveHours<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ReactiveEnergy.FromVoltampereReactiveHours(Convert.ToDouble(value));

    }
}
