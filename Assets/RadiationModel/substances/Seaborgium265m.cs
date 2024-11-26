using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium265m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium265m";
        public override double halfLife { get; } = 8.5d;
        public override double atomicWeight { get; } = 265.12109d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.51d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.49d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium261()), new(1.0d, new AlphaParticle(10067002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    