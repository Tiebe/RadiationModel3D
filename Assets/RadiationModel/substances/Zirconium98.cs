using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium98";
        public override double halfLife { get; } = 30.7d;
        public override double atomicWeight { get; } = 97.91274d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium98() }, { 1.0d, new BetaParticle(-1, 1121500.0) } } },

        };
    }
}
    