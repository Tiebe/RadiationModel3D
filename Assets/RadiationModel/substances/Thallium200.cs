using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium200";
        public override double halfLife { get; } = 93960.0d;
        public override double atomicWeight { get; } = 199.97096d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2456300.0), new Mercury200() } },

        };
    }
}
    
    