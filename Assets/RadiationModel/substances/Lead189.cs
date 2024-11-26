using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead189 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead189";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 188.98084d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury189()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury185()), new(1.0d, new AlphaParticle(6937002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    