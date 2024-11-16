using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium209m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium209m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 209.00294d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(9045047.4), new Radon205() } },
            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(1, 6522000.0), new Francium209() } },

        };
    }
}
    
    