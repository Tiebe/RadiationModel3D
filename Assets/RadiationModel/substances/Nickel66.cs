using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel66 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel66";
        public override double halfLife { get; } = 196560.0d;
        public override double atomicWeight { get; } = 65.92914d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper66() }, { 1.0d, new BetaParticle(-1, 126000.0) } } },

        };
    }
}
    