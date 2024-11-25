using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium226";
        public override double halfLife { get; } = 0.268d;
        public override double atomicWeight { get; } = 226.02934d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium222() }, { 1.0d, new AlphaParticle(8723002.09) } } },

        };
    }
}
    