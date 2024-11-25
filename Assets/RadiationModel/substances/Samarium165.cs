using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium165";
        public override double halfLife { get; } = 0.98d;
        public override double atomicWeight { get; } = 164.95329d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium165() }, { 1.0d, new BetaParticle(-1, 3609500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    