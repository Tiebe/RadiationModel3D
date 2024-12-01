using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium130m";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 129.92369d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum130()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    