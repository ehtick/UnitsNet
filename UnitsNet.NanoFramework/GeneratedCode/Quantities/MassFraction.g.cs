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
    ///     The mass fraction is defined as the mass of a constituent divided by the total mass of the mixture.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Mass_fraction_(chemistry)
    /// </remarks>
    public struct  MassFraction
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassFractionUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassFractionUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public MassFraction(double value, MassFractionUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of MassFraction, which is Second. All conversions go via this value.
        /// </summary>
        public static MassFractionUnit BaseUnit { get; } = MassFractionUnit.DecimalFraction;

        /// <summary>
        /// Represents the largest possible value of MassFraction.
        /// </summary>
        public static MassFraction MaxValue { get; } = new MassFraction(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MassFraction.
        /// </summary>
        public static MassFraction MinValue { get; } = new MassFraction(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MassFraction Zero { get; } = new MassFraction(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.CentigramPerGram"/>
        /// </summary>
        public double CentigramsPerGram => As(MassFractionUnit.CentigramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.CentigramPerKilogram"/>
        /// </summary>
        public double CentigramsPerKilogram => As(MassFractionUnit.CentigramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.DecagramPerGram"/>
        /// </summary>
        public double DecagramsPerGram => As(MassFractionUnit.DecagramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.DecagramPerKilogram"/>
        /// </summary>
        public double DecagramsPerKilogram => As(MassFractionUnit.DecagramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.DecigramPerGram"/>
        /// </summary>
        public double DecigramsPerGram => As(MassFractionUnit.DecigramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.DecigramPerKilogram"/>
        /// </summary>
        public double DecigramsPerKilogram => As(MassFractionUnit.DecigramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.DecimalFraction"/>
        /// </summary>
        public double DecimalFractions => As(MassFractionUnit.DecimalFraction);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.GramPerGram"/>
        /// </summary>
        public double GramsPerGram => As(MassFractionUnit.GramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.GramPerKilogram"/>
        /// </summary>
        public double GramsPerKilogram => As(MassFractionUnit.GramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.HectogramPerGram"/>
        /// </summary>
        public double HectogramsPerGram => As(MassFractionUnit.HectogramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.HectogramPerKilogram"/>
        /// </summary>
        public double HectogramsPerKilogram => As(MassFractionUnit.HectogramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.KilogramPerGram"/>
        /// </summary>
        public double KilogramsPerGram => As(MassFractionUnit.KilogramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.KilogramPerKilogram"/>
        /// </summary>
        public double KilogramsPerKilogram => As(MassFractionUnit.KilogramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.MicrogramPerGram"/>
        /// </summary>
        public double MicrogramsPerGram => As(MassFractionUnit.MicrogramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.MicrogramPerKilogram"/>
        /// </summary>
        public double MicrogramsPerKilogram => As(MassFractionUnit.MicrogramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.MilligramPerGram"/>
        /// </summary>
        public double MilligramsPerGram => As(MassFractionUnit.MilligramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.MilligramPerKilogram"/>
        /// </summary>
        public double MilligramsPerKilogram => As(MassFractionUnit.MilligramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.NanogramPerGram"/>
        /// </summary>
        public double NanogramsPerGram => As(MassFractionUnit.NanogramPerGram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.NanogramPerKilogram"/>
        /// </summary>
        public double NanogramsPerKilogram => As(MassFractionUnit.NanogramPerKilogram);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.PartPerBillion"/>
        /// </summary>
        public double PartsPerBillion => As(MassFractionUnit.PartPerBillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.PartPerMillion"/>
        /// </summary>
        public double PartsPerMillion => As(MassFractionUnit.PartPerMillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.PartPerThousand"/>
        /// </summary>
        public double PartsPerThousand => As(MassFractionUnit.PartPerThousand);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.PartPerTrillion"/>
        /// </summary>
        public double PartsPerTrillion => As(MassFractionUnit.PartPerTrillion);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MassFractionUnit.Percent"/>
        /// </summary>
        public double Percent => As(MassFractionUnit.Percent);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.CentigramPerGram"/>.
        /// </summary>
        public static MassFraction FromCentigramsPerGram(double centigramspergram) => new MassFraction(centigramspergram, MassFractionUnit.CentigramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.CentigramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromCentigramsPerKilogram(double centigramsperkilogram) => new MassFraction(centigramsperkilogram, MassFractionUnit.CentigramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.DecagramPerGram"/>.
        /// </summary>
        public static MassFraction FromDecagramsPerGram(double decagramspergram) => new MassFraction(decagramspergram, MassFractionUnit.DecagramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.DecagramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromDecagramsPerKilogram(double decagramsperkilogram) => new MassFraction(decagramsperkilogram, MassFractionUnit.DecagramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.DecigramPerGram"/>.
        /// </summary>
        public static MassFraction FromDecigramsPerGram(double decigramspergram) => new MassFraction(decigramspergram, MassFractionUnit.DecigramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.DecigramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromDecigramsPerKilogram(double decigramsperkilogram) => new MassFraction(decigramsperkilogram, MassFractionUnit.DecigramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.DecimalFraction"/>.
        /// </summary>
        public static MassFraction FromDecimalFractions(double decimalfractions) => new MassFraction(decimalfractions, MassFractionUnit.DecimalFraction);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.GramPerGram"/>.
        /// </summary>
        public static MassFraction FromGramsPerGram(double gramspergram) => new MassFraction(gramspergram, MassFractionUnit.GramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.GramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromGramsPerKilogram(double gramsperkilogram) => new MassFraction(gramsperkilogram, MassFractionUnit.GramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.HectogramPerGram"/>.
        /// </summary>
        public static MassFraction FromHectogramsPerGram(double hectogramspergram) => new MassFraction(hectogramspergram, MassFractionUnit.HectogramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.HectogramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromHectogramsPerKilogram(double hectogramsperkilogram) => new MassFraction(hectogramsperkilogram, MassFractionUnit.HectogramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.KilogramPerGram"/>.
        /// </summary>
        public static MassFraction FromKilogramsPerGram(double kilogramspergram) => new MassFraction(kilogramspergram, MassFractionUnit.KilogramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.KilogramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromKilogramsPerKilogram(double kilogramsperkilogram) => new MassFraction(kilogramsperkilogram, MassFractionUnit.KilogramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.MicrogramPerGram"/>.
        /// </summary>
        public static MassFraction FromMicrogramsPerGram(double microgramspergram) => new MassFraction(microgramspergram, MassFractionUnit.MicrogramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.MicrogramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromMicrogramsPerKilogram(double microgramsperkilogram) => new MassFraction(microgramsperkilogram, MassFractionUnit.MicrogramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.MilligramPerGram"/>.
        /// </summary>
        public static MassFraction FromMilligramsPerGram(double milligramspergram) => new MassFraction(milligramspergram, MassFractionUnit.MilligramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.MilligramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromMilligramsPerKilogram(double milligramsperkilogram) => new MassFraction(milligramsperkilogram, MassFractionUnit.MilligramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.NanogramPerGram"/>.
        /// </summary>
        public static MassFraction FromNanogramsPerGram(double nanogramspergram) => new MassFraction(nanogramspergram, MassFractionUnit.NanogramPerGram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.NanogramPerKilogram"/>.
        /// </summary>
        public static MassFraction FromNanogramsPerKilogram(double nanogramsperkilogram) => new MassFraction(nanogramsperkilogram, MassFractionUnit.NanogramPerKilogram);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.PartPerBillion"/>.
        /// </summary>
        public static MassFraction FromPartsPerBillion(double partsperbillion) => new MassFraction(partsperbillion, MassFractionUnit.PartPerBillion);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.PartPerMillion"/>.
        /// </summary>
        public static MassFraction FromPartsPerMillion(double partspermillion) => new MassFraction(partspermillion, MassFractionUnit.PartPerMillion);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.PartPerThousand"/>.
        /// </summary>
        public static MassFraction FromPartsPerThousand(double partsperthousand) => new MassFraction(partsperthousand, MassFractionUnit.PartPerThousand);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.PartPerTrillion"/>.
        /// </summary>
        public static MassFraction FromPartsPerTrillion(double partspertrillion) => new MassFraction(partspertrillion, MassFractionUnit.PartPerTrillion);

        /// <summary>
        ///     Creates a <see cref="MassFraction"/> from <see cref="MassFractionUnit.Percent"/>.
        /// </summary>
        public static MassFraction FromPercent(double percent) => new MassFraction(percent, MassFractionUnit.Percent);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassFractionUnit" /> to <see cref="MassFraction" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MassFraction unit value.</returns>
        public static MassFraction From(double value, MassFractionUnit fromUnit)
        {
            return new MassFraction(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MassFractionUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this MassFraction to another MassFraction with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A MassFraction with the specified unit.</returns>
                public MassFraction ToUnit(MassFractionUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new MassFraction(convertedValue, unit);
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
                        MassFractionUnit.CentigramPerGram => (_value) * 1e-2d,
                        MassFractionUnit.CentigramPerKilogram => (_value / 1e3) * 1e-2d,
                        MassFractionUnit.DecagramPerGram => (_value) * 1e1d,
                        MassFractionUnit.DecagramPerKilogram => (_value / 1e3) * 1e1d,
                        MassFractionUnit.DecigramPerGram => (_value) * 1e-1d,
                        MassFractionUnit.DecigramPerKilogram => (_value / 1e3) * 1e-1d,
                        MassFractionUnit.DecimalFraction => _value,
                        MassFractionUnit.GramPerGram => _value,
                        MassFractionUnit.GramPerKilogram => _value / 1e3,
                        MassFractionUnit.HectogramPerGram => (_value) * 1e2d,
                        MassFractionUnit.HectogramPerKilogram => (_value / 1e3) * 1e2d,
                        MassFractionUnit.KilogramPerGram => (_value) * 1e3d,
                        MassFractionUnit.KilogramPerKilogram => (_value / 1e3) * 1e3d,
                        MassFractionUnit.MicrogramPerGram => (_value) * 1e-6d,
                        MassFractionUnit.MicrogramPerKilogram => (_value / 1e3) * 1e-6d,
                        MassFractionUnit.MilligramPerGram => (_value) * 1e-3d,
                        MassFractionUnit.MilligramPerKilogram => (_value / 1e3) * 1e-3d,
                        MassFractionUnit.NanogramPerGram => (_value) * 1e-9d,
                        MassFractionUnit.NanogramPerKilogram => (_value / 1e3) * 1e-9d,
                        MassFractionUnit.PartPerBillion => _value / 1e9,
                        MassFractionUnit.PartPerMillion => _value / 1e6,
                        MassFractionUnit.PartPerThousand => _value / 1e3,
                        MassFractionUnit.PartPerTrillion => _value / 1e12,
                        MassFractionUnit.Percent => _value / 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MassFractionUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MassFractionUnit.CentigramPerGram => (baseUnitValue) / 1e-2d,
                        MassFractionUnit.CentigramPerKilogram => (baseUnitValue * 1e3) / 1e-2d,
                        MassFractionUnit.DecagramPerGram => (baseUnitValue) / 1e1d,
                        MassFractionUnit.DecagramPerKilogram => (baseUnitValue * 1e3) / 1e1d,
                        MassFractionUnit.DecigramPerGram => (baseUnitValue) / 1e-1d,
                        MassFractionUnit.DecigramPerKilogram => (baseUnitValue * 1e3) / 1e-1d,
                        MassFractionUnit.DecimalFraction => baseUnitValue,
                        MassFractionUnit.GramPerGram => baseUnitValue,
                        MassFractionUnit.GramPerKilogram => baseUnitValue * 1e3,
                        MassFractionUnit.HectogramPerGram => (baseUnitValue) / 1e2d,
                        MassFractionUnit.HectogramPerKilogram => (baseUnitValue * 1e3) / 1e2d,
                        MassFractionUnit.KilogramPerGram => (baseUnitValue) / 1e3d,
                        MassFractionUnit.KilogramPerKilogram => (baseUnitValue * 1e3) / 1e3d,
                        MassFractionUnit.MicrogramPerGram => (baseUnitValue) / 1e-6d,
                        MassFractionUnit.MicrogramPerKilogram => (baseUnitValue * 1e3) / 1e-6d,
                        MassFractionUnit.MilligramPerGram => (baseUnitValue) / 1e-3d,
                        MassFractionUnit.MilligramPerKilogram => (baseUnitValue * 1e3) / 1e-3d,
                        MassFractionUnit.NanogramPerGram => (baseUnitValue) / 1e-9d,
                        MassFractionUnit.NanogramPerKilogram => (baseUnitValue * 1e3) / 1e-9d,
                        MassFractionUnit.PartPerBillion => baseUnitValue * 1e9,
                        MassFractionUnit.PartPerMillion => baseUnitValue * 1e6,
                        MassFractionUnit.PartPerThousand => baseUnitValue * 1e3,
                        MassFractionUnit.PartPerTrillion => baseUnitValue * 1e12,
                        MassFractionUnit.Percent => baseUnitValue * 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

