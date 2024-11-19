using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium229";
        public override double halfLife { get; } = 1.8d;
        public override double atomicWeight { get; } = 229.04528d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9157002.09), new Neptunium225() } },

        };
    }
}
    
    