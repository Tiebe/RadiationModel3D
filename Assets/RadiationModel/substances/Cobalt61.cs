using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt61 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt61";
        public override double halfLife { get; } = 5936.4d;
        public override double atomicWeight { get; } = 60.93248d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel61() }, { 1.0d, new BetaParticle(-1, 661900.0) }, { 0.8467199999999999d, new GammaParticle(67412.0, 0.01839) }, { 0.007937999999999999d, new GammaParticle(850000.0, 0.00146) }, { 0.036162d, new GammaParticle(917500.0, 0.00135) }, { 0.001299240129603024d, new GammaParticle(874.0, 1.41858) }, { 0.013004250841479308d, new GammaParticle(7461.0, 0.16618) }, { 0.025379100002887015d, new GammaParticle(7478.0, 0.1658) }, { 0.005289225746353678d, new GammaParticle(8296.0, 0.14945) }, { 0.005289225746353678d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    