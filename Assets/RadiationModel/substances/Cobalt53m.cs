using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt53m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt53m";
        public override double halfLife { get; } = 0.25d;
        public override double atomicWeight { get; } = 52.95761d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.015d, new List<RadioactiveSubstance> { new ProtonParticle(), new Iron52() } },

        };
    }
}
    
    