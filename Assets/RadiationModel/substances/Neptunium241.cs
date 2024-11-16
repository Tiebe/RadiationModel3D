using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium241";
        public override double halfLife { get; } = 834.0d;
        public override double atomicWeight { get; } = 241.05831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1364900.0), new Plutonium241() } },

        };
    }
}
    
    