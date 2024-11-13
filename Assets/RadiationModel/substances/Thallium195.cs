
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium195";
        public override double halfLife { get; } = 4176.0d;
        public override double atomicWeight { get; } = 194.96977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury195() } },

        };
    }
}
    
    