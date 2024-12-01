using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon220 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon220";
        public override double halfLife { get; } = 55.6d;
        public override double atomicWeight { get; } = 220.01139d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium216()), new(1.0d, new AlphaParticle(7426702.09)), new(0.00114d, new GammaParticle(549730.0, 0.00226)), new(9.3472766244e-06d, new GammaParticle(13292.0, 0.09328)), new(5.8789835630538626e-06d, new GammaParticle(76862.0, 0.01613)), new(9.790147482187947e-06d, new GammaParticle(79290.0, 0.01564)), new(3.370476700807162e-06d, new GammaParticle(89837.0, 0.0138)), new(4.41869495475819e-06d, new GammaParticle(90941.0, 0.01363)), new(1.0482182539510274e-06d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    