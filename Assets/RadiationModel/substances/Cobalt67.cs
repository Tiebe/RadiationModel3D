using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt67 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt67";
        public override double halfLife { get; } = 0.425d;
        public override double atomicWeight { get; } = 66.94061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel67() }, { 1.0d, new BetaParticle(-1, 4210350.0) }, { 0.03d, new GammaParticle(313100.0, 0.00396) }, { 0.945d, new GammaParticle(694100.0, 0.00179) }, { 0.055d, new GammaParticle(2155000.0, 0.00058) }, { 1.03328064e-05d, new GammaParticle(874.0, 1.41858) }, { 0.00010360995299930838d, new GammaParticle(7461.0, 0.16618) }, { 0.0002022052166262849d, new GammaParticle(7478.0, 0.1658) }, { 4.214133037440675e-05d, new GammaParticle(8296.0, 0.14945) }, { 4.214133037440675e-05d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    