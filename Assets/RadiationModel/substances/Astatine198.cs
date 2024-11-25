using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine198 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine198";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 197.9928d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth194() }, { 1.0d, new AlphaParticle(7911002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth198() }, { 1.0d, new BetaParticle(1, 6332500.0) } } },

        };
    }
}
    