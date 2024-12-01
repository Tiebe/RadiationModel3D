using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Sulfur46 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur46";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 46.00069d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine46()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    