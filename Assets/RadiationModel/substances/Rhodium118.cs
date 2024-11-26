using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium118";
        public override double halfLife { get; } = 0.286d;
        public override double atomicWeight { get; } = 117.93034d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium118()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.021d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium118()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    