using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium138";
        public override double halfLife { get; } = 12.1d;
        public override double atomicWeight { get; } = 137.93371d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium138() }, { 1.0d, new BetaParticle(1, 6582000.0) } } },

        };
    }
}
    