using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium259";
        public override double halfLife { get; } = 3480.0d;
        public override double atomicWeight { get; } = 259.101d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium255()), new(1.0d, new AlphaParticle(8876002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium259()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    