using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium285m : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium285m";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 285.1778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10947002.09), new Darmstadtium281() } },

        };
    }
}
    
    