using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead191m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead191m";
        public override double halfLife { get; } = 130.8d;
        public override double atomicWeight { get; } = 190.97828d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury191()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury187()), new(1.0d, new AlphaParticle(6482002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    