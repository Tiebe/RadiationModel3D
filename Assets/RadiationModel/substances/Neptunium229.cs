using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium229";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 229.03629d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.68d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium225()), new(1.0d, new AlphaParticle(8037002.09)) } },
            { 0.32d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Uranium229()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    