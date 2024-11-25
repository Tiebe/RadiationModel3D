using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium244";
        public override double halfLife { get; } = 571495929.39986d;
        public override double atomicWeight { get; } = 244.06275d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium240() }, { 1.0d, new AlphaParticle(6923502.09) }, { 0.0002635d, new GammaParticle(42824.0, 0.02895) }, { 1.4195e-05d, new GammaParticle(98860.0, 0.01254) }, { 1.054e-05d, new GammaParticle(152630.0, 0.00812) }, { 2.38e-07d, new GammaParticle(203200.0, 0.0061) }, { 1.1134999999999999e-07d, new GammaParticle(251200.0, 0.00494) }, { 5.95e-07d, new GammaParticle(263340.0, 0.00471) }, { 1.819e-07d, new GammaParticle(302990.0, 0.00409) }, { 8.5e-08d, new GammaParticle(506900.0, 0.00245) }, { 8.5e-07d, new GammaParticle(554500.0, 0.00224) }, { 5.185e-07d, new GammaParticle(597200.0, 0.00208) }, { 7.905e-08d, new GammaParticle(605800.0, 0.00205) }, { 1.3685e-07d, new GammaParticle(758600.0, 0.00163) }, { 6.8e-07d, new GammaParticle(817800.0, 0.00152) }, { 5.61e-08d, new GammaParticle(857500.0, 0.00145) }, { 1.275e-08d, new GammaParticle(900100.0, 0.00138) }, { 4.25e-09d, new GammaParticle(937600.0, 0.00132) }, { 0.0904319824145732d, new GammaParticle(17604.0, 0.07043) }, { 6.245202605247096e-07d, new GammaParticle(99533.0, 0.01246) }, { 9.88634257598084e-07d, new GammaParticle(103741.0, 0.01195) }, { 3.6286994728374644e-07d, new GammaParticle(117130.0, 0.01059) }, { 4.887858189912064e-07d, new GammaParticle(118619.0, 0.01045) }, { 1.2591587170746003e-07d, new GammaParticle(120544.0, 0.01029) } } },
            { 1.37e-06d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    