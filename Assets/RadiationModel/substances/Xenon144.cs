using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon144 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon144";
        public override double halfLife { get; } = 1.15d;
        public override double atomicWeight { get; } = 143.93895d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium144()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    