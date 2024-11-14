using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium281";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 281.16957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11455047.4), new Darmstadtium277() } },

        };
    }
}
    
    