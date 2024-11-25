using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium170";
        public override double halfLife { get; } = 0.41d;
        public override double atomicWeight { get; } = 169.95615d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium170() }, { 1.0d, new BetaParticle(-1, 2930000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    