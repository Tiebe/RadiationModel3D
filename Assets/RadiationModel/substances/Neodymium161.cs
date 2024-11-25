using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium161";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 160.95466d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium161() }, { 1.0d, new BetaParticle(-1, 3928500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    