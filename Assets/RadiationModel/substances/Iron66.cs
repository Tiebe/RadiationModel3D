using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iron66 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron66";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 65.94625d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt66()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    