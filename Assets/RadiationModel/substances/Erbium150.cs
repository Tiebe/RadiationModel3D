using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium150";
        public override double halfLife { get; } = 18.5d;
        public override double atomicWeight { get; } = 149.93792d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium150() }, { 1.0d, new BetaParticle(1, 5739500.0) }, { 0.024806599999999998d, new GammaParticle(130000.0, 0.00954) }, { 0.0047705d, new GammaParticle(346100.0, 0.00358) }, { 0.9541d, new GammaParticle(476000.0, 0.0026) }, { 0.0019081999999999999d, new GammaParticle(663300.0, 0.00187) }, { 0.0085869d, new GammaParticle(1014000.0, 0.00122) }, { 0.0085869d, new GammaParticle(1022100.0, 0.00121) }, { 0.0047705d, new GammaParticle(1151900.0, 0.00108) }, { 0.0028623d, new GammaParticle(1177100.0, 0.00105) }, { 0.0019081999999999999d, new GammaParticle(1320500.0, 0.00094) }, { 0.0028623d, new GammaParticle(1450900.0, 0.00085) }, { 0.0038163999999999997d, new GammaParticle(1490400.0, 0.00083) }, { 0.79732d, new GammaParticle(511000.0, 0.00243) }, { 0.10430066991509608d, new GammaParticle(7656.0, 0.16194) }, { 0.13678089468307103d, new GammaParticle(46700.0, 0.02655) }, { 0.24359910005889765d, new GammaParticle(47547.0, 0.02608) }, { 0.07870243224542162d, new GammaParticle(53982.0, 0.02297) }, { 0.09916506462923123d, new GammaParticle(54577.0, 0.02272) }, { 0.02046263238380962d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    