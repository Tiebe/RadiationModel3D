
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum201 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum201";
        public override double halfLife { get; } = 150.0d;
        public override double atomicWeight { get; } = 200.97451d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gold201() } },

        };
    }
}
    
    