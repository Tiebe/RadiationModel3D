using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony120m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony120m";
        public override double halfLife { get; } = 953.4d;
        public override double atomicWeight { get; } = 119.90508d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium120() }, { 1.0d, new BetaParticle(1, -1345000.0) }, { 0.795d, new GammaParticle(89800.0, 0.01381) }, { 0.87d, new GammaParticle(197300.0, 0.00628) }, { 0.0014872d, new GammaParticle(703800.0, 0.00176) }, { 0.0006253000000000001d, new GammaParticle(988600.0, 0.00125) }, { 0.9940000000000001d, new GammaParticle(1023300.0, 0.00121) }, { 0.00821d, new GammaParticle(1113400.0, 0.00111) }, { 0.0169d, new GammaParticle(1171200.0, 0.00106) }, { 1.0d, new GammaParticle(1171700.0, 0.00106) }, { 0.820294d, new GammaParticle(511000.0, 0.00243) }, { 0.039897285446856404d, new GammaParticle(3753.0, 0.33036) }, { 0.0895285568768d, new GammaParticle(3753.0, 0.33036) }, { 0.27447609640001164d, new GammaParticle(25044.0, 0.04951) }, { 0.12437365047958845d, new GammaParticle(25044.0, 0.04951) }, { 0.2327786832857729d, new GammaParticle(25271.0, 0.04906) }, { 0.5137115785139652d, new GammaParticle(25271.0, 0.04906) }, { 0.06582105666552941d, new GammaParticle(28579.0, 0.04338) }, { 0.14525831335507375d, new GammaParticle(28579.0, 0.04338) }, { 0.0787878048286387d, new GammaParticle(28810.0, 0.04304) }, { 0.17387420108602328d, new GammaParticle(28810.0, 0.04304) }, { 0.012966748163109294d, new GammaParticle(29107.0, 0.0426) }, { 0.028615887730949526d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    