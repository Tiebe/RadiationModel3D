using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium216m";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 216.02718d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11806002.09), new Thorium212() } },

        };
    }
}
    
    