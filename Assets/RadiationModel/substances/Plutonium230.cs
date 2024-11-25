using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium230";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 230.03965d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium226() }, { 1.0d, new AlphaParticle(8200002.09) } } },

        };
    }
}
    