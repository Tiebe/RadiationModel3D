using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium235";
        public override double halfLife { get; } = 1464.0d;
        public override double atomicWeight { get; } = 235.0454d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium235() }, { 1.0d, new BetaParticle(-1, 685099.99999) } } },

        };
    }
}
    