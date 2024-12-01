using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon224 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon224";
        public override double halfLife { get; } = 6420.0d;
        public override double atomicWeight { get; } = 224.0241d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium224()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    