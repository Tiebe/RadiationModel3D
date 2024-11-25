using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium218";
        public override double halfLife { get; } = 0.00065d;
        public override double atomicWeight { get; } = 218.02351d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium214() }, { 1.0d, new AlphaParticle(9797002.09) } } },

        };
    }
}
    