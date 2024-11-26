using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium258";
        public override double halfLife { get; } = 3.92d;
        public override double atomicWeight { get; } = 258.10175d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9740000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium254()), new(1.0d, new AlphaParticle(9927002.09)) } },
            { 0.026000000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium258()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    