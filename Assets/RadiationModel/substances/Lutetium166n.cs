using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium166n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium166n";
        public override double halfLife { get; } = 127.2d;
        public override double atomicWeight { get; } = 165.9399d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium166() }, { 1.0d, new BetaParticle(1, 2953000.0) }, { 0.09855d, new GammaParticle(102380.0, 0.01211) }, { 0.0378d, new GammaParticle(228120.0, 0.00544) }, { 0.00945d, new GammaParticle(518000.0, 0.00239) }, { 0.04995d, new GammaParticle(1067320.0, 0.00116) }, { 0.013500000000000002d, new GammaParticle(1249400.0, 0.00099) }, { 0.135d, new GammaParticle(1256640.0, 0.00099) }, { 0.1188d, new GammaParticle(1358790.0, 0.00091) }, { 0.20385d, new GammaParticle(1427180.0, 0.00087) }, { 0.024300000000000002d, new GammaParticle(1477500.0, 0.00084) }, { 0.09855d, new GammaParticle(1529730.0, 0.00081) }, { 0.00945d, new GammaParticle(1579400.0, 0.00079) }, { 0.008100000000000001d, new GammaParticle(1820400.0, 0.00068) }, { 0.0216d, new GammaParticle(1923200.0, 0.00064) }, { 0.0297d, new GammaParticle(1996250.0, 0.00062) }, { 0.1431d, new GammaParticle(2098600.0, 0.00059) }, { 0.0837d, new GammaParticle(2324600.0, 0.00053) }, { 0.0054d, new GammaParticle(2425900.0, 0.00051) }, { 1.04d, new GammaParticle(511000.0, 0.00243) }, { 0.16d, new GammaParticle(8502.0, 0.14583) }, { 0.15d, new GammaParticle(51354.0, 0.02414) }, { 0.26d, new GammaParticle(52389.0, 0.02367) }, { 0.087d, new GammaParticle(59481.0, 0.02084) }, { 0.109d, new GammaParticle(60151.0, 0.02061) }, { 0.023d, new GammaParticle(60961.0, 0.02034) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium166() } } },

        };
    }
}
    