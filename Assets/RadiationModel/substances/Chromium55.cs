using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium55";
        public override double halfLife { get; } = 209.82d;
        public override double atomicWeight { get; } = 54.94084d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese55() }, { 1.0d, new BetaParticle(-1, 1301110.0) }, { 1.739e-05d, new GammaParticle(126000.0, 0.00984) }, { 1.3320000000000001e-05d, new GammaParticle(1402000.0, 0.00088) }, { 0.00037d, new GammaParticle(1528000.0, 0.00081) }, { 4.07e-06d, new GammaParticle(2240900.0, 0.00055) }, { 3.145e-05d, new GammaParticle(2252500.0, 0.00055) }, { 1.11e-06d, new GammaParticle(2268100.0, 0.00055) }, { 1.8129999999999998e-06d, new GammaParticle(2368500.0, 0.00052) } } },

        };
    }
}
    