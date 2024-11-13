
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium150";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 149.95009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium150() } },

        };
    }
}
    
    