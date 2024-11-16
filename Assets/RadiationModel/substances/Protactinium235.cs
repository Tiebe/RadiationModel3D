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

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1370200.0), new Uranium235() } },

        };
    }
}
    
    