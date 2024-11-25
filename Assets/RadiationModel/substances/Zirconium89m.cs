using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium89m";
        public override double halfLife { get; } = 249.66d;
        public override double atomicWeight { get; } = 88.90951d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9377d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium89() }, { 0.8962d, new GammaParticle(587800.0, 0.00211) }, { 0.001367703438496d, new GammaParticle(2161.0, 0.57374) }, { 0.007614697669212526d, new GammaParticle(15691.0, 0.07902) }, { 0.01457358405590914d, new GammaParticle(15775.0, 0.0786) }, { 0.003713536156089298d, new GammaParticle(17736.0, 0.06991) }, { 0.004255712434878336d, new GammaParticle(17824.0, 0.06956) }, { 0.0005421762787890375d, new GammaParticle(17968.0, 0.069) } } },
            { 0.0623d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium89() }, { 1.0d, new BetaParticle(1, 959415.0) }, { 0.060599999999999994d, new GammaParticle(1507400.0, 0.00082) }, { 0.030600000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.0014331243831d, new GammaParticle(2027.0, 0.61166) }, { 0.00853879223081723d, new GammaParticle(14883.0, 0.08331) }, { 0.016373522973762666d, new GammaParticle(14958.0, 0.08289) }, { 0.0041111887481723244d, new GammaParticle(16803.0, 0.07379) }, { 0.004678532795420105d, new GammaParticle(16880.0, 0.07345) }, { 0.0005673440472477808d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    