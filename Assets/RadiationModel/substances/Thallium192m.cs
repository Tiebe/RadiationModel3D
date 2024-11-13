
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium192m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium192m";
        public override double halfLife { get; } = 648.0d;
        public override double atomicWeight { get; } = 191.97244d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury192() } },

        };
    }
}
    
    