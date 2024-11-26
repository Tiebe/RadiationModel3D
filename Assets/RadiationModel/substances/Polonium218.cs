using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium218";
        public override double halfLife { get; } = 185.82d;
        public override double atomicWeight { get; } = 218.00897d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead214()), new(1.0d, new AlphaParticle(7136702.09)) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine218()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    