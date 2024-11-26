using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium270";
        public override double halfLife { get; } = 7.6d;
        public override double atomicWeight { get; } = 270.13431d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium266()), new(1.0d, new AlphaParticle(10087002.09)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    