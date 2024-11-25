using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper80 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper80";
        public override double halfLife { get; } = 0.1136d;
        public override double atomicWeight { get; } = 79.96062d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc80() }, { 1.0d, new BetaParticle(-1, 7484300.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    