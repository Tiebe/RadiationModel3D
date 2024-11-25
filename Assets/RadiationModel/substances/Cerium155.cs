using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium155";
        public override double halfLife { get; } = 0.313d;
        public override double atomicWeight { get; } = 154.94871d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium155() }, { 1.0d, new BetaParticle(-1, 3817500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    