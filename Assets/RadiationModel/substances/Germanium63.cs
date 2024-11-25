using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium63";
        public override double halfLife { get; } = 0.1533d;
        public override double atomicWeight { get; } = 62.94963d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc63() }, { 1.0d, new BetaParticle(1, 7646700.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    