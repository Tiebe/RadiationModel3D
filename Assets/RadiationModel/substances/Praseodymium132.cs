using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium132";
        public override double halfLife { get; } = 96.0d;
        public override double atomicWeight { get; } = 131.91924d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum132()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    