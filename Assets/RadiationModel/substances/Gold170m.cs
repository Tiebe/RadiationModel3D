using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold170m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold170m";
        public override double halfLife { get; } = 0.00062d;
        public override double atomicWeight { get; } = 169.99633d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.58d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum169()), new(1.0d, new ProtonParticle()) } },
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium166()), new(1.0d, new AlphaParticle(8487002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    