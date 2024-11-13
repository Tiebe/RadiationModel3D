
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium73 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium73";
        public override double halfLife { get; } = 25740.0d;
        public override double atomicWeight { get; } = 72.92676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic73() } },

        };
    }
}
    
    