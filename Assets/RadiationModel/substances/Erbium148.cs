using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium148";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 147.94473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6511000.0), new Holmium148() } },

        };
    }
}
    
    