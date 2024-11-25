using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255";
        public override double halfLife { get; } = 1.68d;
        public override double atomicWeight { get; } = 255.10127d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.58d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.42d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium251() }, { 1.0d, new AlphaParticle(10077002.09) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nobelium255() }, { 1.0d, new BetaParticle(1, 3759000.0) } } },

        };
    }
}
    