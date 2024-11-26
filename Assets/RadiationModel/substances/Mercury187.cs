using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury187 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury187";
        public override double halfLife { get; } = 114.0d;
        public override double atomicWeight { get; } = 186.96981d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum187()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 3.7e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum183()), new(1.0d, new AlphaParticle(6251002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    