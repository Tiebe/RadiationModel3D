
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead196 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead196";
        public override double halfLife { get; } = 2220.0d;
        public override double atomicWeight { get; } = 195.97279d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium196() } },

            { 3e-07d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury192() } },

        };
    }
}
    
    