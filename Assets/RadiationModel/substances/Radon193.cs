using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon193 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon193";
        public override double halfLife { get; } = 0.00115d;
        public override double atomicWeight { get; } = 193.00971d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium189()), new(1.0d, new AlphaParticle(9062002.09)), new(0.28d, new GammaParticle(194000.0, 0.00639)), new(0.1527469944d, new GammaParticle(13292.0, 0.09328)), new(0.10912738267731269d, new GammaParticle(76862.0, 0.01613)), new(0.18172753151925514d, new GammaParticle(79290.0, 0.01564)), new(0.06256375728713358d, new GammaParticle(89837.0, 0.0138)), new(0.08202108580343212d, new GammaParticle(90941.0, 0.01363)), new(0.019457328516298545d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    