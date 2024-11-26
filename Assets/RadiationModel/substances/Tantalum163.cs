using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum163 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum163";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 162.95434d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium163()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium159()), new(1.0d, new AlphaParticle(5777002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    