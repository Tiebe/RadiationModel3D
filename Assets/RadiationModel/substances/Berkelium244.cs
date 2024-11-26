using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium244";
        public override double halfLife { get; } = 18072.0d;
        public override double atomicWeight { get; } = 244.06518d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99994d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium244()) } },
            { 6e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium240()), new(1.0d, new AlphaParticle(7801002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    