using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon41 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon41";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 41.01417d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 18180000.0), new Phosphorus41() } },

        };
    }
}
    
    