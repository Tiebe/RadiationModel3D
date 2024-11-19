using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium201";
        public override double halfLife { get; } = 936.0d;
        public override double atomicWeight { get; } = 200.98226d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9887d, new List<RadioactiveSubstance> { new BetaParticle(1, 4908000.0), new Bismuth201() } },
            { 0.0113d, new List<RadioactiveSubstance> { new AlphaParticle(6821002.09), new Lead197() } },

        };
    }
}
    
    