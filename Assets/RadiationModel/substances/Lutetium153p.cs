using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium153p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium153p";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 152.96162d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium153() }, { 0.00018999999999999998d, new GammaParticle(21000.0, 0.05904) }, { 0.486d, new GammaParticle(130400.0, 0.00951) }, { 0.414d, new GammaParticle(174000.0, 0.00713) }, { 0.585d, new GammaParticle(216500.0, 0.00573) }, { 0.21600000000000003d, new GammaParticle(270000.0, 0.00459) }, { 0.07200000000000001d, new GammaParticle(291000.0, 0.00426) }, { 0.09d, new GammaParticle(323900.0, 0.00383) }, { 0.513d, new GammaParticle(355400.0, 0.00349) }, { 0.315d, new GammaParticle(389100.0, 0.00319) }, { 0.198d, new GammaParticle(658800.0, 0.00188) }, { 0.315d, new GammaParticle(715100.0, 0.00173) }, { 0.9d, new GammaParticle(1432100.0, 0.00087) }, { 0.018000000000000002d, new GammaParticle(1606100.0, 0.00077) }, { 0.24607354338792d, new GammaParticle(8810.0, 0.14073) }, { 0.10937393686721697d, new GammaParticle(52965.0, 0.02341) }, { 0.19208629586796097d, new GammaParticle(54070.0, 0.02293) }, { 0.06320171018577701d, new GammaParticle(61387.0, 0.0202) }, { 0.07988696167482215d, new GammaParticle(62084.0, 0.01997) }, { 0.01668525148904513d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    