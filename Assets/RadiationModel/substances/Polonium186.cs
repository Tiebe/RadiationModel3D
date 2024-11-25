using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium186";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 186.0044d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead182() }, { 1.0d, new AlphaParticle(9524002.09) } } },

        };
    }
}
    