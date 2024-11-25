using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper78 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper78";
        public override double halfLife { get; } = 0.335d;
        public override double atomicWeight { get; } = 77.95192d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc78() }, { 1.0d, new BetaParticle(-1, 6347100.0) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc78() }, { 1.0d, new BetaParticle(-1, 6347100.0) } } },

        };
    }
}
    