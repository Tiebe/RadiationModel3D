using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium167";
        public override double halfLife { get; } = 799200.0d;
        public override double atomicWeight { get; } = 166.93286d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium167()), new(0.046d, new GammaParticle(57072.3, 0.02172)), new(0.413d, new GammaParticle(207801.0, 0.00597)), new(2.2000000000000003e-05d, new GammaParticle(250200.0, 0.00496)), new(0.0004d, new GammaParticle(264900.0, 0.00468)), new(2.2000000000000003e-05d, new GammaParticle(266500.0, 0.00465)), new(2.1e-05d, new GammaParticle(323700.0, 0.00383)), new(0.00025d, new GammaParticle(346500.0, 0.00358)), new(0.016d, new GammaParticle(531540.0, 0.00233)), new(0.31d, new GammaParticle(7933.0, 0.15629)), new(0.27d, new GammaParticle(48222.0, 0.02571)), new(0.48d, new GammaParticle(49128.0, 0.02524)), new(0.157d, new GammaParticle(55779.0, 0.02223)), new(0.2d, new GammaParticle(56399.0, 0.02198)), new(0.040999999999999995d, new GammaParticle(57145.0, 0.0217)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    