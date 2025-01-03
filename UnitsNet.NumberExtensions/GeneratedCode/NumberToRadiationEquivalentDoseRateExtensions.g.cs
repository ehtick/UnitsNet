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

namespace UnitsNet.NumberExtensions.NumberToRadiationEquivalentDoseRate
{
    /// <summary>
    /// A number to RadiationEquivalentDoseRate Extensions
    /// </summary>
    public static class NumberToRadiationEquivalentDoseRateExtensions
    {
        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromMicrosievertsPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate MicrosievertsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromMicrosievertsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromMicrosievertsPerSecond(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate MicrosievertsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromMicrosievertsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromMilliroentgensEquivalentManPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate MilliroentgensEquivalentManPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromMilliroentgensEquivalentManPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromMillisievertsPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate MillisievertsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromMillisievertsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromMillisievertsPerSecond(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate MillisievertsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromMillisievertsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromNanosievertsPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate NanosievertsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromNanosievertsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromNanosievertsPerSecond(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate NanosievertsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromNanosievertsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromRoentgensEquivalentManPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate RoentgensEquivalentManPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromRoentgensEquivalentManPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromSievertsPerHour(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate SievertsPerHour<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromSievertsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="RadiationEquivalentDoseRate.FromSievertsPerSecond(UnitsNet.QuantityValue)" />
        public static RadiationEquivalentDoseRate SievertsPerSecond<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => RadiationEquivalentDoseRate.FromSievertsPerSecond(Convert.ToDouble(value));

    }
}
