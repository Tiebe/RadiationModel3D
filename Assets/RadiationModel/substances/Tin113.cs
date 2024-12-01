using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin113 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin113";
        public override double halfLife { get; } = 9943776.0d;
        public override double atomicWeight { get; } = 112.90518d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium113()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.021099999999999997d, new GammaParticle(255134.0, 0.00486)), new(6e-07d, new GammaParticle(382900.0, 0.00324)), new(0.6496999999999999d, new GammaParticle(391698.0, 0.00317)), new(9.7e-06d, new GammaParticle(638030.0, 0.00194)), new(4e-08d, new GammaParticle(646830.0, 0.00192)), new(0.08565841333005039d, new GammaParticle(3571.0, 0.3472)), new(0.27798688608293654d, new GammaParticle(24001.0, 0.05166)), new(0.5215513810186426d, new GammaParticle(24209.0, 0.05121)), new(0.1463356593064907d, new GammaParticle(27367.0, 0.0453)), new(0.17413943457472392d, new GammaParticle(27581.0, 0.04495)), new(0.027803775268233234d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    