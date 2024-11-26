using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury185 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury185";
        public override double halfLife { get; } = 49.1d;
        public override double atomicWeight { get; } = 184.97189d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum185()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum181()), new(1.0d, new AlphaParticle(6794002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    