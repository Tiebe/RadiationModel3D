using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium170m";
        public override double halfLife { get; } = 0.811d;
        public override double atomicWeight { get; } = 169.97516d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.38d, new List<RadioactiveSubstance> { new AlphaParticle(7297002.09), new Rhenium166() } },

        };
    }
}
    
    