using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium222";
        public override double halfLife { get; } = 852.0d;
        public override double atomicWeight { get; } = 222.01758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2058000.0), new Radium222() } },

        };
    }
}
    
    