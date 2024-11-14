using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium253m";
        public override double halfLife { get; } = 1.32d;
        public override double atomicWeight { get; } = 253.09507d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(9975047.4), new Mendelevium249() } },
            { 0.12d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    