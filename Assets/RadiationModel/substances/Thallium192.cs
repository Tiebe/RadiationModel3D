
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium192";
        public override double halfLife { get; } = 576.0d;
        public override double atomicWeight { get; } = 191.97223d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury192() } },

        };
    }
}
    
    