using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium152m";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 151.94437d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium152() }, { 1.0d, new BetaParticle(1, 5892500.0) }, { 0.46d, new GammaParticle(279900.0, 0.00443) }, { 0.66d, new GammaParticle(422500.0, 0.00293) }, { 0.76d, new GammaParticle(672600.0, 0.00184) }, { 1.0d, new GammaParticle(808200.0, 0.00153) }, { 0.608d, new GammaParticle(511000.0, 0.00243) }, { 1.34d, new GammaParticle(511000.0, 0.00243) }, { 0.0348617039616d, new GammaParticle(7933.0, 0.15629) }, { 0.004d, new GammaParticle(7933.0, 0.15629) }, { 0.04250808718376519d, new GammaParticle(48222.0, 0.02571) }, { 0.004d, new GammaParticle(48222.0, 0.02571) }, { 0.07544921402869222d, new GammaParticle(49128.0, 0.02524) }, { 0.008d, new GammaParticle(49128.0, 0.02524) }, { 0.02451826760916079d, new GammaParticle(55779.0, 0.02223) }, { 0.003d, new GammaParticle(55779.0, 0.02223) }, { 0.003d, new GammaParticle(56399.0, 0.02198) }, { 0.030893017187542594d, new GammaParticle(56399.0, 0.02198) }, { 0.006374749578381805d, new GammaParticle(57145.0, 0.0217) }, { 0.0007000000000000001d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    