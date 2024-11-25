using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium52";
        public override double halfLife { get; } = 224.58d;
        public override double atomicWeight { get; } = 51.94477d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium52() }, { 1.0d, new BetaParticle(-1, 1988240.0) }, { 8e-05d, new GammaParticle(398080.0, 0.00311) }, { 0.00024d, new GammaParticle(647470.0, 0.00191) }, { 1.8e-05d, new GammaParticle(704600.0, 0.00176) }, { 0.00061d, new GammaParticle(935520.0, 0.00133) }, { 0.0001d, new GammaParticle(1045720.0, 0.00119) }, { 0.00588d, new GammaParticle(1333620.0, 0.00093) }, { 1.0d, new GammaParticle(1434060.0, 0.00086) }, { 0.00116d, new GammaParticle(1530670.0, 0.00081) }, { 7.000000000000001e-05d, new GammaParticle(1727520.0, 0.00072) }, { 5e-05d, new GammaParticle(1981100.0, 0.00063) }, { 1.5e-05d, new GammaParticle(2337700.0, 0.00053) }, { 5e-06d, new GammaParticle(2965000.0, 0.00042) }, { 9e-06d, new GammaParticle(3161700.0, 0.00039) }, { 1e-05d, new GammaParticle(3772000.0, 0.00033) }, { 4.5561761813592e-07d, new GammaParticle(597.0, 2.07679) }, { 5.436478990209135e-06d, new GammaParticle(5406.0, 0.22935) }, { 1.0678607327065674e-05d, new GammaParticle(5415.0, 0.22896) }, { 2.1690906183051895e-06d, new GammaParticle(5966.0, 0.20782) }, { 2.1690906183051895e-06d, new GammaParticle(5966.0, 0.20782) } } },

        };
    }
}
    