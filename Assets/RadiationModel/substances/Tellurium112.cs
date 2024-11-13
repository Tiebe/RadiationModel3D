
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium112";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 111.91673d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony112() } },

        };
    }
}
    
    