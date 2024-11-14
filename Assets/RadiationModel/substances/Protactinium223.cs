using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium223";
        public override double halfLife { get; } = 0.0053d;
        public override double atomicWeight { get; } = 223.02398d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9365047.4), new Actinium219() } },

        };
    }
}
    
    