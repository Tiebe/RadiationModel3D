using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur41 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur41";
        public override double halfLife { get; } = 1.99d;
        public override double atomicWeight { get; } = 40.97959d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine41() }, { 1.0d, new BetaParticle(-1, 4150500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    