using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese47 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese47";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 46.97577d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium47()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.034d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium46()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    