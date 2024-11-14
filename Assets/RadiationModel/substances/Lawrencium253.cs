using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium253";
        public override double halfLife { get; } = 0.632d;
        public override double atomicWeight { get; } = 253.09503d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(9935047.4), new Mendelevium249() } },
            { 0.01d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    