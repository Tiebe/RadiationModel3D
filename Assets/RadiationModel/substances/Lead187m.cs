using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead187m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead187m";
        public override double halfLife { get; } = 18.3d;
        public override double atomicWeight { get; } = 186.98393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(1, 7477000.0), new Thallium187() } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(7432047.4), new Mercury183() } },

        };
    }
}
    
    