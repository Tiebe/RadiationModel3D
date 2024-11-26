using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279";
        public override double halfLife { get; } = 0.216d;
        public override double atomicWeight { get; } = 279.15998d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.885d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.125d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hassium275()), new(1.0d, new AlphaParticle(11127002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    