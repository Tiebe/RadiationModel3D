using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon142 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon142";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 141.92997d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium142()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.0021d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium142()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    