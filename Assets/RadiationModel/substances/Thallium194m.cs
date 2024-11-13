
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium194m";
        public override double halfLife { get; } = 1968.0d;
        public override double atomicWeight { get; } = 193.97136d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury194() } },

        };
    }
}
    
    