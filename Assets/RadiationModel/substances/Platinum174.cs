using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum174 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum174";
        public override double halfLife { get; } = 0.889d;
        public override double atomicWeight { get; } = 173.97282d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.76d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium170()), new(1.0d, new AlphaParticle(7205002.09)) } },
            { 0.24d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium174()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    