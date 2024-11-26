using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium195";
        public override double halfLife { get; } = 4.64d;
        public override double atomicWeight { get; } = 194.98807d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead191()), new(1.0d, new AlphaParticle(7771002.09)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    