using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium217";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 217.00463d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9490047.4), new Astatine213() } },

        };
    }
}
    
    