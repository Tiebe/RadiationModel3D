using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium78";
        public override double halfLife { get; } = 156.1d;
        public override double atomicWeight { get; } = 77.93218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3761000.0), new Rubidium78() } },

        };
    }
}
    
    