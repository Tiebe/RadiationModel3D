using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth199m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth199m";
        public override double halfLife { get; } = 1482.0d;
        public override double atomicWeight { get; } = 198.97839d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium199() }, { 1.0d, new BetaParticle(1, 3964000.0) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth199() } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium195() }, { 1.0d, new AlphaParticle(6621002.09) } } },

        };
    }
}
    