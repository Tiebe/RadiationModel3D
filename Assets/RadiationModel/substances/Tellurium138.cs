using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium138";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 137.92947d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine138() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },
            { 0.063d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine138() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    