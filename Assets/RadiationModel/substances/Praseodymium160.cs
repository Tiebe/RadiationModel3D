using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium160";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 159.96114d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium160() }, { 1.0d, new BetaParticle(-1, 5260000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    