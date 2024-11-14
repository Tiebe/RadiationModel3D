using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth191m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth191m";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 190.98605d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.68d, new List<RadioactiveSubstance> { new AlphaParticle(8043047.4), new Thallium187() } },

        };
    }
}
    
    