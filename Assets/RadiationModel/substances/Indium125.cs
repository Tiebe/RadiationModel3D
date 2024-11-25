using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium125";
        public override double halfLife { get; } = 2.36d;
        public override double atomicWeight { get; } = 124.91367d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin125() }, { 1.0d, new BetaParticle(-1, 2740700.0) }, { 0.001116d, new GammaParticle(318700.0, 0.00389) }, { 0.023250000000000003d, new GammaParticle(426030.0, 0.00291) }, { 0.0046500000000000005d, new GammaParticle(507700.0, 0.00244) }, { 0.07440000000000001d, new GammaParticle(617880.0, 0.00201) }, { 0.05208d, new GammaParticle(744620.0, 0.00167) }, { 0.023250000000000003d, new GammaParticle(827150.0, 0.0015) }, { 0.0279d, new GammaParticle(936500.0, 0.00132) }, { 0.09579d, new GammaParticle(1031750.0, 0.0012) }, { 0.7068000000000001d, new GammaParticle(1335040.0, 0.00093) }, { 0.0023250000000000002d, new GammaParticle(1362500.0, 0.00091) }, { 0.009300000000000001d, new GammaParticle(1558200.0, 0.0008) }, { 5.56597496016e-05d, new GammaParticle(3753.0, 0.33036) }, { 0.00017463286786375697d, new GammaParticle(25044.0, 0.04951) }, { 0.0003268442220920025d, new GammaParticle(25271.0, 0.04906) }, { 9.241925316979159e-05d, new GammaParticle(28579.0, 0.04338) }, { 0.00011062584604424054d, new GammaParticle(28810.0, 0.04304) }, { 1.8206592874448945e-05d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    