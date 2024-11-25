using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium77";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 76.95014d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium77() }, { 1.0d, new BetaParticle(1, 9195250.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    