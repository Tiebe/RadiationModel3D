using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver111 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver111";
        public override double halfLife { get; } = 643680.0d;
        public override double atomicWeight { get; } = 110.9053d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium111() }, { 1.0d, new BetaParticle(-1, 518400.0) }, { 0.00115564d, new GammaParticle(96750.0, 0.01281) }, { 0.012358000000000001d, new GammaParticle(245400.0, 0.00505) }, { 5.344e-06d, new GammaParticle(278300.0, 0.00446) }, { 0.0668d, new GammaParticle(342130.0, 0.00362) }, { 3.1396e-05d, new GammaParticle(374600.0, 0.00331) }, { 1.3359999999999999e-05d, new GammaParticle(509400.0, 0.00243) }, { 9.352e-06d, new GammaParticle(522400.0, 0.00237) }, { 2.0708e-05d, new GammaParticle(524300.0, 0.00236) }, { 5.344e-06d, new GammaParticle(619300.0, 0.002) }, { 0.000109552d, new GammaParticle(620300.0, 0.002) }, { 6.012e-05d, new GammaParticle(622000.0, 0.00199) }, { 2.6719999999999998e-05d, new GammaParticle(754600.0, 0.00164) }, { 1.5364e-05d, new GammaParticle(865100.0, 0.00143) }, { 3.6072e-05d, new GammaParticle(867000.0, 0.00143) }, { 0.00015409054001576194d, new GammaParticle(3388.0, 0.36595) }, { 0.0005374020328330236d, new GammaParticle(22983.0, 0.05395) }, { 0.0010107241542844153d, new GammaParticle(23173.0, 0.0535) }, { 0.0002817275320211177d, new GammaParticle(26184.0, 0.04735) }, { 0.0003330019428489611d, new GammaParticle(26381.0, 0.047) }, { 5.127441082784342e-05d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    