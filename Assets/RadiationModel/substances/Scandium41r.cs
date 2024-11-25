using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium41r : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium41r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.97235d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.59d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium40() }, { 1.0d, new ProtonParticle() } } },
            { 0.41d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium41() } } },

        };
    }
}
    