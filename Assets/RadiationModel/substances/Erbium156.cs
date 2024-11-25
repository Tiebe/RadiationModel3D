using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium156";
        public override double halfLife { get; } = 1170.0d;
        public override double atomicWeight { get; } = 155.93107d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium156() }, { 1.0d, new BetaParticle(1, 3158700.0) }, { 0.0169d, new GammaParticle(8720.0, 0.14218) }, { 0.00052d, new GammaParticle(26550.0, 0.0467) }, { 0.04758d, new GammaParticle(29860.0, 0.04152) }, { 0.26d, new GammaParticle(35370.0, 0.03505) }, { 0.0002366d, new GammaParticle(52370.0, 0.02367) }, { 0.00169d, new GammaParticle(65160.0, 0.01903) }, { 0.00312d, new GammaParticle(82180.0, 0.01509) }, { 0.01222d, new GammaParticle(133510.0, 0.00929) }, { 0.013000000000000001d, new GammaParticle(185890.0, 0.00667) }, { 0.007019999999999999d, new GammaParticle(221330.0, 0.0056) }, { 0.00338d, new GammaParticle(253860.0, 0.00488) }, { 0.0032500000000000003d, new GammaParticle(320550.0, 0.00387) }, { 0.00416d, new GammaParticle(352000.0, 0.00352) }, { 0.01196d, new GammaParticle(387370.0, 0.0032) }, { 0.48490043404908d, new GammaParticle(7656.0, 0.16194) }, { 0.2264443922667118d, new GammaParticle(46700.0, 0.02655) }, { 0.40328475915710027d, new GammaParticle(47547.0, 0.02608) }, { 0.1302939601398316d, new GammaParticle(53982.0, 0.02297) }, { 0.16417038977618784d, new GammaParticle(54577.0, 0.02272) }, { 0.03387642963635622d, new GammaParticle(55293.0, 0.02242) } } },
            { 1.7e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium152() }, { 1.0d, new AlphaParticle(4503002.09) } } },

        };
    }
}
    