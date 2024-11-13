
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum129 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum129";
        public override double halfLife { get; } = 696.0d;
        public override double atomicWeight { get; } = 128.9127d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium129() } },

        };
    }
}
    
    