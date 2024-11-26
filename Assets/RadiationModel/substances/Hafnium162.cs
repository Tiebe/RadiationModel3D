using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium162";
        public override double halfLife { get; } = 39.4d;
        public override double atomicWeight { get; } = 161.94722d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99992d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 8e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium158()), new(1.0d, new AlphaParticle(5439002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    