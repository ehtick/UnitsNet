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

namespace UnitsNet.NumberExtensions.NumberToSpecificFuelConsumption
{
    /// <summary>
    /// A number to SpecificFuelConsumption Extensions
    /// </summary>
    public static class NumberToSpecificFuelConsumptionExtensions
    {
        /// <inheritdoc cref="SpecificFuelConsumption.FromGramsPerKilonewtonSecond(double)" />
        public static SpecificFuelConsumption GramsPerKilonewtonSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificFuelConsumption.FromGramsPerKilonewtonSecond(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificFuelConsumption.FromGramsPerKilonewtonSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(double)" />
        public static SpecificFuelConsumption KilogramsPerKilogramForceHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificFuelConsumption.FromKilogramsPerKilogramForceHour(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificFuelConsumption.FromKilogramsPerKilonewtonSecond(double)" />
        public static SpecificFuelConsumption KilogramsPerKilonewtonSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificFuelConsumption.FromKilogramsPerKilonewtonSecond(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificFuelConsumption.FromKilogramsPerKilonewtonSecond(value.ToDouble(null));
#endif

        /// <inheritdoc cref="SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(double)" />
        public static SpecificFuelConsumption PoundsMassPerPoundForceHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(double.CreateChecked(value));
#else
            , IConvertible
            => SpecificFuelConsumption.FromPoundsMassPerPoundForceHour(value.ToDouble(null));
#endif

    }
}
