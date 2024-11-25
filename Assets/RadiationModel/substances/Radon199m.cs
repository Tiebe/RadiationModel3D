using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon199m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon199m";
        public override double halfLife { get; } = 0.31d;
        public override double atomicWeight { get; } = 198.99856d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium195() }, { 1.0d, new AlphaParticle(8374002.09) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium199() }, { 1.0d, new BetaParticle(1, 6949500.0) } } },

        };
    }
}
    