using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold177 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold177";
        public override double halfLife { get; } = 1.501d;
        public override double atomicWeight { get; } = 176.97687d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium173()), new(1.0d, new AlphaParticle(7319002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    