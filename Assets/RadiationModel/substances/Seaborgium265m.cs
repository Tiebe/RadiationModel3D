using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium265m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium265m";
        public override double halfLife { get; } = 8.5d;
        public override double atomicWeight { get; } = 265.12109d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rutherfordium261() }, { 1.0d, new AlphaParticle(10067002.09) } } },

        };
    }
}
    