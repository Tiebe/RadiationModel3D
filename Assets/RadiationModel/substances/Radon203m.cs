using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon203m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203m";
        public override double halfLife { get; } = 26.9d;
        public override double atomicWeight { get; } = 202.99375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium199() }, { 1.0d, new AlphaParticle(8014002.09) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium203() }, { 1.0d, new BetaParticle(1, 5744500.0) } } },

        };
    }
}
    