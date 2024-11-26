using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium173";
        public override double halfLife { get; } = 43232988.58519d;
        public override double atomicWeight { get; } = 172.93894d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium173()), new(0.0016748d, new GammaParticle(62170.0, 0.01994)), new(0.11871999999999999d, new GammaParticle(78630.0, 0.01577)), new(0.052363999999999994d, new GammaParticle(100724.0, 0.01231)), new(0.00053424d, new GammaParticle(111109.0, 0.01116)), new(0.00016748d, new GammaParticle(122550.0, 0.01012)), new(0.029044d, new GammaParticle(171393.0, 0.00723)), new(0.0137588d, new GammaParticle(179365.0, 0.00691)), new(6.359999999999999e-06d, new GammaParticle(208780.0, 0.00594)), new(0.0013992d, new GammaParticle(223163.0, 0.00556)), new(0.0001272d, new GammaParticle(223163.0, 0.00556)), new(0.0055332d, new GammaParticle(233605.0, 0.00531)), new(0.212d, new GammaParticle(272105.0, 0.00456)), new(0.0061056d, new GammaParticle(285362.0, 0.00434)), new(5.3e-06d, new GammaParticle(319400.0, 0.00388)), new(5.512e-05d, new GammaParticle(334263.0, 0.00371)), new(0.00108968d, new GammaParticle(334321.0, 0.00371)), new(0.0030104d, new GammaParticle(350774.0, 0.00353)), new(1.696e-06d, new GammaParticle(412900.0, 0.003)), new(4.24e-06d, new GammaParticle(442080.0, 0.0028)), new(0.00140556d, new GammaParticle(456790.0, 0.00271)), new(6.359999999999999e-06d, new GammaParticle(543240.0, 0.00228)), new(0.005194d, new GammaParticle(557497.0, 0.00222)), new(1.696e-06d, new GammaParticle(621800.0, 0.00199)), new(0.014522d, new GammaParticle(636110.0, 0.00195)), new(0.39799999999999996d, new GammaParticle(8502.0, 0.14583)), new(0.43700000000000006d, new GammaParticle(51354.0, 0.02414)), new(0.77d, new GammaParticle(52389.0, 0.02367)), new(0.253d, new GammaParticle(59481.0, 0.02084)), new(0.319d, new GammaParticle(60151.0, 0.02061)), new(0.0659d, new GammaParticle(60961.0, 0.02034)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    