using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium66";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 65.97301d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese66()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    