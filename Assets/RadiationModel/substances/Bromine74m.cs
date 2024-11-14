using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine74m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine74m";
        public override double halfLife { get; } = 2760.0d;
        public override double atomicWeight { get; } = 73.92993d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6939210.0), new Selenium74() } },

        };
    }
}
    
    