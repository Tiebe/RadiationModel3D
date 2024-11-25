using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204";
        public override double halfLife { get; } = 1.8d;
        public override double atomicWeight { get; } = 204.00065d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine200() }, { 1.0d, new AlphaParticle(8192002.09) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine204() }, { 1.0d, new BetaParticle(1, 6241000.0) } } },

        };
    }
}
    