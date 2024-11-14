using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium236";
        public override double halfLife { get; } = 546.0d;
        public override double atomicWeight { get; } = 236.04867d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2889400.0), new Uranium236() } },

        };
    }
}
    
    