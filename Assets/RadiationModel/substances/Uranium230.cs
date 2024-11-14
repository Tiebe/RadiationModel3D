using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium230";
        public override double halfLife { get; } = 1747872.0d;
        public override double atomicWeight { get; } = 230.03394d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7012047.4), new Thorium226() } },
            { 4.8e-14d, new List<RadioactiveSubstance> { new Neon22(), new Lead208() } },

        };
    }
}
    
    