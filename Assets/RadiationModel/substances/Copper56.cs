using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper56 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper56";
        public override double halfLife { get; } = 0.0804d;
        public override double atomicWeight { get; } = 55.95853d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt56() }, { 1.0d, new BetaParticle(1, 8705250.0) }, { 0.08576d, new GammaParticle(950700.0, 0.0013) }, { 0.11135999999999999d, new GammaParticle(1010400.0, 0.00123) }, { 0.9856d, new GammaParticle(1224500.0, 0.00101) }, { 0.07551999999999999d, new GammaParticle(1653100.0, 0.00075) }, { 0.06527999999999999d, new GammaParticle(2062800.0, 0.0006) }, { 0.06656d, new GammaParticle(2234500.0, 0.00055) }, { 0.59008d, new GammaParticle(2506700.0, 0.00049) }, { 1.28d, new GammaParticle(2700600.0, 0.00046) }, { 0.1856d, new GammaParticle(2780400.0, 0.00045) }, { 0.0512d, new GammaParticle(3287400.0, 0.00038) }, { 2.5639999999999996d, new GammaParticle(511000.0, 0.00243) }, { 1.3269450431999999e-05d, new GammaParticle(874.0, 1.41858) }, { 0.00013237503444543216d, new GammaParticle(7461.0, 0.16618) }, { 0.00025834315855861076d, new GammaParticle(7478.0, 0.1658) }, { 5.384096699595711e-05d, new GammaParticle(8296.0, 0.14945) }, { 5.384096699595711e-05d, new GammaParticle(8296.0, 0.14945) } } },
            { 0.004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt55() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    