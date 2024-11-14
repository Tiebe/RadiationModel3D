using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183";
        public override double halfLife { get; } = 390.0d;
        public override double atomicWeight { get; } = 182.9616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4429000.0), new Iridium183() } },
            { 9.599999999999999e-05d, new List<RadioactiveSubstance> { new AlphaParticle(5842047.4), new Osmium179() } },

        };
    }
}
    
    