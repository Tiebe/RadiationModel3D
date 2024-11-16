using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium83";
        public override double halfLife { get; } = 1335.0d;
        public override double atomicWeight { get; } = 82.91912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3673000.0), new Bromine83() } },

        };
    }
}
    
    