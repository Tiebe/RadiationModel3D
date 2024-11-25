using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen16i : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen16i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 16.00865d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen15() }, { 1.0d, new ProtonParticle() } } },
            { 6.2e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen16() } } },

        };
    }
}
    