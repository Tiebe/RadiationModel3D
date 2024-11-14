using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium255m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255m";
        public override double halfLife { get; } = 2.54d;
        public override double atomicWeight { get; } = 255.09661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.4d, new List<RadioactiveSubstance> { new AlphaParticle(9616047.4), new Mendelevium251() } },

        };
    }
}
    
    