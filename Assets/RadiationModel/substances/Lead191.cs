using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead191 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead191";
        public override double halfLife { get; } = 79.8d;
        public override double atomicWeight { get; } = 190.97822d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9998699999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury191()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00013d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury187()), new(1.0d, new AlphaParticle(6425002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    