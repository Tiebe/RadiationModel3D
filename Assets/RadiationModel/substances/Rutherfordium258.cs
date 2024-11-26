using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium258";
        public override double halfLife { get; } = 0.012d;
        public override double atomicWeight { get; } = 258.10343d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.951d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.049d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium254()), new(1.0d, new AlphaParticle(10218002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    