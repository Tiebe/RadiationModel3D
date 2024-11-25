using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium123";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 122.91878d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon123() }, { 1.0d, new BetaParticle(1, 4796500.0) } } },

        };
    }
}
    