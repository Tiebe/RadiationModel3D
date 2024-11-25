using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium221";
        public override double halfLife { get; } = 112.0d;
        public override double atomicWeight { get; } = 221.02123d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine221() }, { 1.0d, new BetaParticle(-1, 1495500.0) } } },

        };
    }
}
    