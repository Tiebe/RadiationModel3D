using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium224";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 224.02764d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium220() }, { 1.0d, new AlphaParticle(9650002.09) } } },

        };
    }
}
    