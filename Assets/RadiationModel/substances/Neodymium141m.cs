using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium141m";
        public override double halfLife { get; } = 62.0d;
        public override double atomicWeight { get; } = 140.91043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((757000.0, 0.00164)), new Neodymium141() } },
            { 0.00032d, new List<RadioactiveSubstance> { new BetaParticle(1, 2579500.0), new Praseodymium141() } },

        };
    }
}
    
    