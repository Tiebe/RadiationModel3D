using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron50 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron50";
        public override double halfLife { get; } = 0.152d;
        public override double atomicWeight { get; } = 49.96299d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium50() }, { 1.0d, new BetaParticle(1, 7892680.0) }, { 0.0034425d, new GammaParticle(149000.0, 0.00832) }, { 0.225d, new GammaParticle(650990.0, 0.0019) }, { 0.002205d, new GammaParticle(799600.0, 0.00155) }, { 0.0020025d, new GammaParticle(1603700.0, 0.00077) }, { 0.00063d, new GammaParticle(1883800.0, 0.00066) }, { 0.012464999999999999d, new GammaParticle(2403800.0, 0.00052) }, { 0.0062775d, new GammaParticle(2684200.0, 0.00046) }, { 0.0084375d, new GammaParticle(3380000.0, 0.00037) }, { 0.001485d, new GammaParticle(3643400.0, 0.00034) }, { 0.00042750000000000004d, new GammaParticle(4012700.0, 0.00031) }, { 0.0008100000000000001d, new GammaParticle(4315700.0, 0.00029) }, { 1.9975999999999998d, new GammaParticle(511000.0, 0.00243) }, { 8.398910702417e-06d, new GammaParticle(660.0, 1.87855) }, { 0.00010780617715467825d, new GammaParticle(5888.0, 0.21057) }, { 0.00021142611718901402d, new GammaParticle(5899.0, 0.21018) }, { 4.338366880130778e-05d, new GammaParticle(6512.0, 0.19039) }, { 4.338366880130778e-05d, new GammaParticle(6512.0, 0.19039) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium49() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    