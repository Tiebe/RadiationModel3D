using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium197";
        public override double halfLife { get; } = 168.0d;
        public override double atomicWeight { get; } = 196.97308d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium197() }, { 1.0d, new BetaParticle(-1, 1592000.0) } } },

        };
    }
}
    