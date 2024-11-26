using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium160";
        public override double halfLife { get; } = 36.1d;
        public override double atomicWeight { get; } = 159.94603d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium160()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium156()), new(1.0d, new AlphaParticle(5161002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    