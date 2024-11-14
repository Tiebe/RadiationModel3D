using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium162m";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 161.93713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5716000.0), new Gadolinium162() } },

        };
    }
}
    
    