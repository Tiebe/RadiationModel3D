
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium209";
        public override double halfLife { get; } = 129.72d;
        public override double atomicWeight { get; } = 208.98535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead209() } },

        };
    }
}
    
    