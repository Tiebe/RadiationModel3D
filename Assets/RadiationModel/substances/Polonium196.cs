using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium196";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 195.98554d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.98d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead192()), new(1.0d, new AlphaParticle(7680002.09)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead196()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    