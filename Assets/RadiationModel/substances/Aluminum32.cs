using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum32 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum32";
        public override double halfLife { get; } = 0.033d;
        public override double atomicWeight { get; } = 31.98808d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon32() }, { 1.0d, new BetaParticle(-1, 6489345.0) }, { 0.12d, new GammaParticle(1941400.0, 0.00064) }, { 0.0132d, new GammaParticle(2289400.0, 0.00054) }, { 0.0432d, new GammaParticle(3042300.0, 0.00041) }, { 0.0168d, new GammaParticle(3844000.0, 0.00032) }, { 0.0168d, new GammaParticle(4230000.0, 0.00029) }, { 1.018280175e-09d, new GammaParticle(118.0, 10.50714) }, { 3.066981717206401e-08d, new GammaParticle(1740.0, 0.71255) }, { 1.5448386909568643e-08d, new GammaParticle(1740.0, 0.71255) }, { 1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753) }, { 1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753) } } },
            { 0.006999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon32() }, { 1.0d, new BetaParticle(-1, 6489345.0) }, { 0.12d, new GammaParticle(1941400.0, 0.00064) }, { 0.0132d, new GammaParticle(2289400.0, 0.00054) }, { 0.0432d, new GammaParticle(3042300.0, 0.00041) }, { 0.0168d, new GammaParticle(3844000.0, 0.00032) }, { 0.0168d, new GammaParticle(4230000.0, 0.00029) }, { 1.018280175e-09d, new GammaParticle(118.0, 10.50714) }, { 3.066981717206401e-08d, new GammaParticle(1740.0, 0.71255) }, { 1.5448386909568643e-08d, new GammaParticle(1740.0, 0.71255) }, { 1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753) }, { 1.3374279183673471e-09d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    