using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium249m";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 249.08296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9557002.09), new Einsteinium245() } },

        };
    }
}
    
    