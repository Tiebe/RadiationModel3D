using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic77 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic77";
        public override double halfLife { get; } = 139644.0d;
        public override double atomicWeight { get; } = 76.92065d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium77() }, { 1.0d, new BetaParticle(-1, 341600.0) }, { 1.5899999999999998e-06d, new GammaParticle(13400.0, 0.09253) }, { 7.155e-06d, new GammaParticle(51340.0, 0.02415) }, { 7.949999999999999e-07d, new GammaParticle(62200.0, 0.01993) }, { 3.816e-06d, new GammaParticle(81150.0, 0.01528) }, { 0.0020193d, new GammaParticle(87854.0, 0.01411) }, { 1.1925e-05d, new GammaParticle(125840.0, 0.00985) }, { 9.858000000000001e-05d, new GammaParticle(139243.0, 0.0089) }, { 0.0014628d, new GammaParticle(161932.0, 0.00766) }, { 1.0653e-05d, new GammaParticle(200470.0, 0.00618) }, { 0.0159d, new GammaParticle(239011.0, 0.00519) }, { 0.0039432d, new GammaParticle(249805.0, 0.00496) }, { 8.267999999999999e-05d, new GammaParticle(270850.0, 0.00458) }, { 0.00057876d, new GammaParticle(281642.0, 0.0044) }, { 1.0176e-05d, new GammaParticle(439493.0, 0.00282) }, { 0.0055809d, new GammaParticle(520654.0, 0.00238) }, { 3.7000000000000005e-05d, new GammaParticle(1426.0, 0.86945) }, { 0.00028000000000000003d, new GammaParticle(11183.0, 0.11087) }, { 0.00053d, new GammaParticle(11223.0, 0.11047) }, { 0.000125d, new GammaParticle(12546.0, 0.09882) }, { 0.000132d, new GammaParticle(12571.0, 0.09863) }, { 7e-06d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    