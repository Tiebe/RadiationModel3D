using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium99";
        public override double halfLife { get; } = 6661667073236.371d;
        public override double atomicWeight { get; } = 98.90625d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium99() }, { 1.0d, new BetaParticle(-1, 148750.0) }, { 6.5e-06d, new GammaParticle(89500.0, 0.01385) }, { 4.2371355000000004e-07d, new GammaParticle(2737.0, 0.45299) }, { 1.7404409582815807e-06d, new GammaParticle(19150.0, 0.06474) }, { 3.3025445128682747e-06d, new GammaParticle(19279.0, 0.06431) }, { 8.875133638985761e-07d, new GammaParticle(21736.0, 0.05704) }, { 1.0312905288501453e-06d, new GammaParticle(21875.0, 0.05668) }, { 1.4377716495156932e-07d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    