using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium114n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114n";
        public override double halfLife { get; } = 0.0431d;
        public override double atomicWeight { get; } = 113.90546d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium114()), new(0.15560000000000002d, new GammaParticle(190340.0, 0.00651)), new(0.8985d, new GammaParticle(311652.0, 0.00398)), new(0.055327736736000006d, new GammaParticle(3571.0, 0.3472)), new(0.12060884712704151d, new GammaParticle(24001.0, 0.05166)), new(0.22628301524773267d, new GammaParticle(24209.0, 0.05121)), new(0.06348995598758472d, new GammaParticle(27367.0, 0.0453)), new(0.0755530476252258d, new GammaParticle(27581.0, 0.04495)), new(0.012063091637641098d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    