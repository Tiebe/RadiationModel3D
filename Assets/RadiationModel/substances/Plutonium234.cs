using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium234";
        public override double halfLife { get; } = 31680.0d;
        public override double atomicWeight { get; } = 234.04332d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium234()) } },
            { 0.06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium230()), new(1.0d, new AlphaParticle(7332002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    