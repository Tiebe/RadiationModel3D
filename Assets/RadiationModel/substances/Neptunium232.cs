using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium232";
        public override double halfLife { get; } = 882.0d;
        public override double atomicWeight { get; } = 232.04011d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2750600.0), new Uranium232() } },

        };
    }
}
    
    