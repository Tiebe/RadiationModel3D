using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten179 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten179";
        public override double halfLife { get; } = 2223.0d;
        public override double atomicWeight { get; } = 178.94708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1062500.0), new Tantalum179() } },

        };
    }
}
    
    