using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium177";
        public override double halfLife { get; } = 0.018d;
        public override double atomicWeight { get; } = 176.99641d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.73d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold173()), new(1.0d, new AlphaParticle(8089002.09)) } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury176()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    