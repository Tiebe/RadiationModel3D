using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum176 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum176";
        public override double halfLife { get; } = 6.33d;
        public override double atomicWeight { get; } = 175.96894d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium176()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium172()), new(1.0d, new AlphaParticle(6907002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    