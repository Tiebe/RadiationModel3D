using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt50 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt50";
        public override double halfLife { get; } = 0.0388d;
        public override double atomicWeight { get; } = 49.98112d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 16886000.0), new Iron50() } },

        };
    }
}
    
    