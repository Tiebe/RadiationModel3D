using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium162m";
        public override double halfLife { get; } = 0.077d;
        public override double atomicWeight { get; } = 161.97608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new List<RadioactiveSubstance> { new AlphaParticle(7437002.09), new Tantalum158() } },

        };
    }
}
    
    