
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen13 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen13";
        public override double halfLife { get; } = 0.00858d;
        public override double atomicWeight { get; } = 13.02481d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nitrogen13() } },

        };
    }
}
    
    