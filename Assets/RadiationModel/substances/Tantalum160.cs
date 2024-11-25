using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum160 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum160";
        public override double halfLife { get; } = 1.55d;
        public override double atomicWeight { get; } = 159.96155d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium156() }, { 1.0d, new AlphaParticle(6477002.09) } } },

        };
    }
}
    