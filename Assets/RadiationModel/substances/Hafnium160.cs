using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium160";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 159.95068d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.993d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium160()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.006999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium156()), new(1.0d, new AlphaParticle(5924002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    