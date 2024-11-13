
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead194 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead194";
        public override double halfLife { get; } = 642.0d;
        public override double atomicWeight { get; } = 193.97401d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium194() } },

            { 7.3e-08d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury190() } },

        };
    }
}
    
    