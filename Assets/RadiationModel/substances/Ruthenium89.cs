using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium89";
        public override double halfLife { get; } = 1.32d;
        public override double atomicWeight { get; } = 88.93734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9026000.0), new Technetium89() } },

        };
    }
}
    
    