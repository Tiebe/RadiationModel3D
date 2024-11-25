using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium9 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium9";
        public override double halfLife { get; } = 0.1783d;
        public override double atomicWeight { get; } = 9.02679d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium9() }, { 1.0d, new BetaParticle(-1, 6803230.0) } } },
            { 0.508d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium9() }, { 1.0d, new BetaParticle(-1, 6803230.0) } } },

        };
    }
}
    