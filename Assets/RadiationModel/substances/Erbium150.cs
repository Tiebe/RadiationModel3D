
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium150";
        public override double halfLife { get; } = 18.5d;
        public override double atomicWeight { get; } = 149.93792d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium150() } },

        };
    }
}
    
    