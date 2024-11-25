using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine221 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine221";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 221.01802d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon221() }, { 1.0d, new BetaParticle(-1, 1156000.0) } } },

        };
    }
}
    