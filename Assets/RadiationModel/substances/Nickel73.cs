using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel73 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel73";
        public override double halfLife { get; } = 0.84d;
        public override double atomicWeight { get; } = 72.94621d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper73() }, { 1.0d, new BetaParticle(-1, 4439600.0) }, { 0.58d, new GammaParticle(166100.0, 0.00746) }, { 0.15776d, new GammaParticle(478900.0, 0.00259) }, { 0.028999999999999998d, new GammaParticle(676900.0, 0.00183) }, { 0.16820000000000002d, new GammaParticle(844200.0, 0.00147) }, { 0.19140000000000001d, new GammaParticle(961200.0, 0.00129) }, { 0.23199999999999998d, new GammaParticle(1010000.0, 0.00123) }, { 0.02204d, new GammaParticle(1088200.0, 0.00114) }, { 0.16820000000000002d, new GammaParticle(1131900.0, 0.0011) }, { 0.028999999999999998d, new GammaParticle(1542200.0, 0.0008) }, { 0.03944d, new GammaParticle(1995500.0, 0.00062) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    