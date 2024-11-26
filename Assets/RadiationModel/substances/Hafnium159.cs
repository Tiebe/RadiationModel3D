using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium159";
        public override double halfLife { get; } = 5.6d;
        public override double atomicWeight { get; } = 158.954d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.65d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium159()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.35d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium155()), new(1.0d, new AlphaParticle(6247002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    