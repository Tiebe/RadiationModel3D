using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium229";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 229.04528d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium225()), new(1.0d, new AlphaParticle(9157002.09)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium229()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    