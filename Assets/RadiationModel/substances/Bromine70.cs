using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine70 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70";
        public override double halfLife { get; } = 0.0791d;
        public override double atomicWeight { get; } = 69.94479d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic70() }, { 1.0d, new BetaParticle(1, 6454000.0) } } },

        };
    }
}
    