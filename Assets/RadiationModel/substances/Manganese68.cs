using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese68 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese68";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 67.96895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron68() }, { 1.0d, new BetaParticle(-1, 7490000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron68() }, { 1.0d, new BetaParticle(-1, 7490000.0) } } },

        };
    }
}
    