using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium112";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 111.91881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4099000.0), new Rhodium112() } },

        };
    }
}
    
    