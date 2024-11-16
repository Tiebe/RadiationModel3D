using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium233";
        public override double halfLife { get; } = 192.0d;
        public override double atomicWeight { get; } = 233.04647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.045d, new List<RadioactiveSubstance> { new AlphaParticle(8085047.4), new Neptunium229() } },

        };
    }
}
    
    