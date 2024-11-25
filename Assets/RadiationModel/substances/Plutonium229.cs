using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium229";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 229.04014d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium225() }, { 1.0d, new AlphaParticle(8615002.09) } } },

        };
    }
}
    