using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium153m";
        public override double halfLife { get; } = 2.5d;
        public override double atomicWeight { get; } = 152.9421d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium149() }, { 1.0d, new AlphaParticle(6313002.09) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium153() }, { 1.0d, new BetaParticle(1, 5541000.0) } } },

        };
    }
}
    