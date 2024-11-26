using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium234";
        public override double halfLife { get; } = 7747225326762.336d;
        public override double atomicWeight { get; } = 234.04095d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium230()), new(1.0d, new AlphaParticle(5879502.09)), new(0.00123d, new GammaParticle(53200.0, 0.02331)), new(0.000342d, new GammaParticle(120900.0, 0.01026)), new(2.5e-07d, new GammaParticle(454950.0, 0.00273)), new(7.9e-09d, new GammaParticle(503500.0, 0.00246)), new(1.5e-07d, new GammaParticle(508200.0, 0.00244)), new(1.2000000000000002e-07d, new GammaParticle(581700.0, 0.00213)), new(8.4e-09d, new GammaParticle(624400.0, 0.00199)), new(1e-08d, new GammaParticle(677600.0, 0.00183)), new(0.09824816107234241d, new GammaParticle(15784.0, 0.07855)), new(2.5146901564574528e-05d, new GammaParticle(89954.0, 0.01378)), new(4.067761495401897e-05d, new GammaParticle(93347.0, 0.01328)), new(1.447450101455983e-05d, new GammaParticle(105566.0, 0.01174)), new(1.9352407856466492e-05d, new GammaParticle(106894.0, 0.0116)), new(4.877906841906663e-06d, new GammaParticle(108580.0, 0.01142)) } },
            { 1.64e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.4e-13d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    