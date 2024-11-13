
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium188m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium188m";
        public override double halfLife { get; } = 71.5d;
        public override double atomicWeight { get; } = 187.97605d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury188() } },

        };
    }
}
    
    