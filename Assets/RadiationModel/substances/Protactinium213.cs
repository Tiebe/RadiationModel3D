using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium213";
        public override double halfLife { get; } = 0.0074d;
        public override double atomicWeight { get; } = 213.0211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9405047.4), new Actinium209() } },

        };
    }
}
    
    