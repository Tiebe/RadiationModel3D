using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium271";
        public override double halfLife { get; } = 96.0d;
        public override double atomicWeight { get; } = 271.13379d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium267()), new(1.0d, new AlphaParticle(9777002.09)) } },
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
    