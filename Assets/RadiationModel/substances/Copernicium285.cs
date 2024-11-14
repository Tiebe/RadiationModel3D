using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium285";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 285.17723d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10415047.4), new Darmstadtium281() } },

        };
    }
}
    
    