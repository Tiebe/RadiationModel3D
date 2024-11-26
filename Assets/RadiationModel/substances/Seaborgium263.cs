using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium263";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 263.1183d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium259()), new(1.0d, new AlphaParticle(10427002.09)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    