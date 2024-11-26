using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth191m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth191m";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 190.98605d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.68d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium187()), new(1.0d, new AlphaParticle(8045002.09)) } },
            { 0.32d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth191()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    