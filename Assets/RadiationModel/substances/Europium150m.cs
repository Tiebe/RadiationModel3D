using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium150m";
        public override double halfLife { get; } = 46080.0d;
        public override double atomicWeight { get; } = 149.91975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1014000.0), new Gadolinium150() } },
            { 0.11d, new List<RadioactiveSubstance> { new BetaParticle(1, 2301300.0), new Samarium150() } },

        };
    }
}
    
    