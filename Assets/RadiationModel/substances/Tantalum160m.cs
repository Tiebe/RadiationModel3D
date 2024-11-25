using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum160m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum160m";
        public override double halfLife { get; } = 1.55d;
        public override double atomicWeight { get; } = 159.96166d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium156() }, { 1.0d, new AlphaParticle(6587002.09) } } },

        };
    }
}
    