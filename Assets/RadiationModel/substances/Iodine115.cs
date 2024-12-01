using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine115 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine115";
        public override double halfLife { get; } = 78.0d;
        public override double atomicWeight { get; } = 114.91805d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony115()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    