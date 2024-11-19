using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium139m";
        public override double halfLife { get; } = 10.7d;
        public override double atomicWeight { get; } = 138.92279d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.937d, new List<RadioactiveSubstance> { new GammaParticle((457000.0, 0.00271)), new Samarium139() } },
            { 0.063d, new List<RadioactiveSubstance> { new BetaParticle(1, 5578000.0), new Promethium139() } },

        };
    }
}
    
    