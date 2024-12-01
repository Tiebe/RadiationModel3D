using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lanthanum121 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum121";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 120.93324d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium121()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    