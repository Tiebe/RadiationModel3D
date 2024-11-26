using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium246";
        public override double halfLife { get; } = 1.54d;
        public override double atomicWeight { get; } = 246.07535d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.932d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium242()), new(1.0d, new AlphaParticle(9401002.09)) } },
            { 0.068d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.013000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium246()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    