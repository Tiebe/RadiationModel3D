using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium157";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 156.95713d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium157() }, { 1.0d, new BetaParticle(-1, 4252500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    