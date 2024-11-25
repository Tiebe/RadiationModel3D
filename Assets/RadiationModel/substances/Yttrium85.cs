using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium85";
        public override double halfLife { get; } = 9648.0d;
        public override double atomicWeight { get; } = 84.91643d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium85() }, { 1.0d, new BetaParticle(1, 2162670.5) }, { 4.2e-08d, new GammaParticle(7120.0, 0.17414) }, { 0.00192d, new GammaParticle(215900.0, 0.00574) }, { 0.84d, new GammaParticle(231650.0, 0.00535) }, { 0.00336d, new GammaParticle(238770.0, 0.00519) }, { 0.0084d, new GammaParticle(409500.0, 0.00303) }, { 0.6d, new GammaParticle(504440.0, 0.00246) }, { 0.0018d, new GammaParticle(698000.0, 0.00178) }, { 0.09d, new GammaParticle(913890.0, 0.00136) }, { 0.0024d, new GammaParticle(1278100.0, 0.00097) }, { 0.00366d, new GammaParticle(1320600.0, 0.00094) }, { 1.31746d, new GammaParticle(511000.0, 0.00243) }, { 0.02837025023408d, new GammaParticle(1890.0, 0.656) }, { 0.06361324148375248d, new GammaParticle(14098.0, 0.08794) }, { 0.12221564165946681d, new GammaParticle(14165.0, 0.08753) }, { 0.030176637218390034d, new GammaParticle(15898.0, 0.07799) }, { 0.034099600056780734d, new GammaParticle(15955.0, 0.07771) }, { 0.003922962838390704d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    