using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus41 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus41";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 40.99465d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur41()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sulfur41()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    