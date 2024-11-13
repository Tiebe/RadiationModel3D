
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190m";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 189.97392d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury190() } },

        };
    }
}
    
    