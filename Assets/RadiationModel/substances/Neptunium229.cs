using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium229";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 229.03629d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.68d, new List<RadioactiveSubstance> { new AlphaParticle(8037002.09), new Protactinium225() } },

        };
    }
}
    
    