using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium229";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 229.04528d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium225() }, { 1.0d, new AlphaParticle(9157002.09) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium229() }, { 1.0d, new BetaParticle(1, 4190000.0) } } },

        };
    }
}
    