using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium148";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 147.94964d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.251d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium148()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    