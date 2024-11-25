using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon203 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203";
        public override double halfLife { get; } = 44.2d;
        public override double atomicWeight { get; } = 202.99336d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium199() }, { 1.0d, new AlphaParticle(7652002.09) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium203() }, { 1.0d, new BetaParticle(1, 5563500.0) } } },

        };
    }
}
    