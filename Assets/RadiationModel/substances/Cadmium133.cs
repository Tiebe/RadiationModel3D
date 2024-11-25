using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium133";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 132.95261d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium133() }, { 1.0d, new BetaParticle(-1, 6775000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    