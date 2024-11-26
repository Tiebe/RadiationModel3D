using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium228";
        public override double halfLife { get; } = 60324219.69303d;
        public override double atomicWeight { get; } = 228.02874d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium224()), new(1.0d, new AlphaParticle(6542102.09)), new(3.920400000000001e-06d, new GammaParticle(74400.0, 0.01666)), new(0.01188d, new GammaParticle(84373.0, 0.01469)), new(0.0012711600000000001d, new GammaParticle(131613.0, 0.00942)), new(1.3068e-08d, new GammaParticle(142000.0, 0.00873)), new(0.0010086119999999999d, new GammaParticle(166410.0, 0.00745)), new(5.1084e-08d, new GammaParticle(182200.0, 0.0068)), new(0.000191268d, new GammaParticle(205930.0, 0.00602)), new(0.002468664d, new GammaParticle(215983.0, 0.00574)), new(1.782e-07d, new GammaParticle(228500.0, 0.00543)), new(2.9699999999999998e-08d, new GammaParticle(700500.0, 0.00177)), new(1.4255999999999999e-08d, new GammaParticle(742200.0, 0.00167)), new(1.4256e-07d, new GammaParticle(832000.0, 0.00149)), new(1.6632e-08d, new GammaParticle(908100.0, 0.00137)), new(1.4255999999999999e-08d, new GammaParticle(992900.0, 0.00125)), new(0.08423934393021919d, new GammaParticle(14920.0, 0.0831)), new(0.0001809457701011077d, new GammaParticle(85432.0, 0.01451)), new(0.0002955664327035409d, new GammaParticle(88471.0, 0.01401)), new(0.0001036988152187827d, new GammaParticle(100119.0, 0.01238)), new(0.00013771202661054345d, new GammaParticle(101370.0, 0.01223)), new(3.4013211391760726e-05d, new GammaParticle(102948.0, 0.01204)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    