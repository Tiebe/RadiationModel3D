using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin121 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin121";
        public override double halfLife { get; } = 97308.0d;
        public override double atomicWeight { get; } = 120.90424d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony121() }, { 1.0d, new BetaParticle(-1, 201300.0) } } },

        };
    }
}
    