using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold189m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold189m";
        public override double halfLife { get; } = 275.4d;
        public override double atomicWeight { get; } = 188.96421d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium189() }, { 1.0d, new BetaParticle(1, 2557500.0) }, { 0.594d, new GammaParticle(166400.0, 0.00745) }, { 0.1188d, new GammaParticle(321100.0, 0.00386) }, { 0.2d, new GammaParticle(511000.0, 0.00243) }, { 0.33580768181688003d, new GammaParticle(11070.0, 0.112) }, { 0.23730354634864856d, new GammaParticle(65122.0, 0.01904) }, { 0.40564708777546765d, new GammaParticle(66832.0, 0.01855) }, { 0.13648952030784114d, new GammaParticle(75821.0, 0.01635) }, { 0.1755255231158837d, new GammaParticle(76725.0, 0.01616) }, { 0.039036002808042564d, new GammaParticle(77832.0, 0.01593) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    