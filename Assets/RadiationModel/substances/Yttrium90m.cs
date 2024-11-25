using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium90m";
        public override double halfLife { get; } = 11484.0d;
        public override double atomicWeight { get; } = 89.90787d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999819999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium90() }, { 0.97d, new GammaParticle(202530.0, 0.00612) }, { 0.905d, new GammaParticle(479510.0, 0.00259) }, { 0.0032d, new GammaParticle(681800.0, 0.00182) }, { 0.003442157308458d, new GammaParticle(2027.0, 0.61166) }, { 0.02024856148490041d, new GammaParticle(14883.0, 0.08331) }, { 0.03882753880134306d, new GammaParticle(14958.0, 0.08289) }, { 0.009749113913670058d, new GammaParticle(16803.0, 0.07379) }, { 0.011094491633756524d, new GammaParticle(16880.0, 0.07345) }, { 0.0013453777200864681d, new GammaParticle(17011.0, 0.07288) } } },
            { 1.8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium90() }, { 1.0d, new BetaParticle(-1, 1478825.0) }, { 1.8e-05d, new GammaParticle(2318968.0, 0.00053) }, { 2.7365747760000003e-10d, new GammaParticle(2161.0, 0.57374) }, { 1.5522238085042538e-09d, new GammaParticle(15691.0, 0.07902) }, { 2.9707632698646005e-09d, new GammaParticle(15775.0, 0.0786) }, { 7.569885878107734e-10d, new GammaParticle(17736.0, 0.06991) }, { 8.675089216311462e-10d, new GammaParticle(17824.0, 0.06956) }, { 1.105203338203729e-10d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    