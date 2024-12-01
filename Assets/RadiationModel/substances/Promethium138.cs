using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium138";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 137.91958d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium138()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    