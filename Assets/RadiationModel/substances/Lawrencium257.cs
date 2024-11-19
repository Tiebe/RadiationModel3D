using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium257";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 257.09949d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10097002.09), new Mendelevium253() } },

        };
    }
}
    
    