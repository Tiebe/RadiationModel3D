using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium264";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 264.12836d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Seaborgium260()), new(1.0d, new AlphaParticle(11613002.09)) } },
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
    