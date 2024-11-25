using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium232";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 232.04946d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium232() }, { 1.0d, new BetaParticle(-1, 2788000.0) }, { 0.009000000000000001d, new GammaParticle(54500.0, 0.02275) }, { 0.2d, new GammaParticle(124700.0, 0.00994) }, { 0.18d, new GammaParticle(188400.0, 0.00658) }, { 0.016d, new GammaParticle(670000.0, 0.00185) }, { 0.032d, new GammaParticle(682000.0, 0.00182) }, { 0.17d, new GammaParticle(721000.0, 0.00172) }, { 0.81124877736d, new GammaParticle(14920.0, 0.0831) }, { 0.026856878504660307d, new GammaParticle(85432.0, 0.01451) }, { 0.04386945198409067d, new GammaParticle(88471.0, 0.01401) }, { 0.015391498125940534d, new GammaParticle(100119.0, 0.01238) }, { 0.020439909511249032d, new GammaParticle(101370.0, 0.01223) }, { 0.005048411385308495d, new GammaParticle(102948.0, 0.01204) } } },

        };
    }
}
    