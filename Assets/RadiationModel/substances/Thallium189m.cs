
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium189m";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 188.97388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury189() } },

        };
    }
}
    
    