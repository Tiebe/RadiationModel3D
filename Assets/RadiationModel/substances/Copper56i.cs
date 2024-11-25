using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper56i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper56i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 55.96232d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.44d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel55() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    