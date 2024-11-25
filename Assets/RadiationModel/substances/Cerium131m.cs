using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium131m";
        public override double halfLife { get; } = 324.0d;
        public override double atomicWeight { get; } = 130.91449d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium131() }, { 1.0d, new BetaParticle(1, 3514500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    