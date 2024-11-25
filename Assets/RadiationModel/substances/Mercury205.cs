using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury205 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury205";
        public override double halfLife { get; } = 308.4d;
        public override double atomicWeight { get; } = 204.97607d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium205() }, { 1.0d, new BetaParticle(-1, 766400.00001) }, { 0.022000000000000002d, new GammaParticle(203700.0, 0.00609) }, { 0.00013d, new GammaParticle(415600.0, 0.00298) }, { 7e-06d, new GammaParticle(521300.0, 0.00238) }, { 1e-05d, new GammaParticle(618600.0, 0.002) }, { 1.1000000000000001e-05d, new GammaParticle(720800.0, 0.00172) }, { 2e-05d, new GammaParticle(937200.0, 0.00132) }, { 7e-06d, new GammaParticle(1014700.0, 0.00122) }, { 4.6e-05d, new GammaParticle(1136800.0, 0.00109) }, { 7e-06d, new GammaParticle(1141100.0, 0.00109) }, { 6.2e-05d, new GammaParticle(1218700.0, 0.00102) }, { 5.1e-06d, new GammaParticle(1230800.0, 0.00101) }, { 3.3e-06d, new GammaParticle(1340300.0, 0.00093) }, { 4.4000000000000006e-05d, new GammaParticle(1433900.0, 0.00086) }, { 0.0029739828101529044d, new GammaParticle(12148.0, 0.10206) }, { 0.0017952751713402422d, new GammaParticle(70832.0, 0.0175) }, { 0.003030511767961246d, new GammaParticle(72874.0, 0.01701) }, { 0.00103064223761489d, new GammaParticle(82629.0, 0.015) }, { 0.0013367429821865124d, new GammaParticle(83631.0, 0.01483) }, { 0.00030610074457162236d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    