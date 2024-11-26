using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium257m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium257m";
        public override double halfLife { get; } = 4.1d;
        public override double atomicWeight { get; } = 257.103d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.88d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium253()), new(1.0d, new AlphaParticle(10178002.09)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium257()) } },
            { 0.013999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    