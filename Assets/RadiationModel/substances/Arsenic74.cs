
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic74 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic74";
        public override double halfLife { get; } = 1535328.0d;
        public override double atomicWeight { get; } = 73.92393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.66d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium74() } },

            { 0.34d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium74() } },

        };
    }
}
    
    