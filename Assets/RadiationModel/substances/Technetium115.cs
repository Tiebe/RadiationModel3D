using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium115";
        public override double halfLife { get; } = 0.078d;
        public override double atomicWeight { get; } = 114.9401d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium115() }, { 1.0d, new BetaParticle(-1, 5152500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    