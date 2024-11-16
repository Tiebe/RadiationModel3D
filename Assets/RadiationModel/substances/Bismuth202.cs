using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth202 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth202";
        public override double halfLife { get; } = 6192.0d;
        public override double atomicWeight { get; } = 201.97772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5190000.0), new Lead202() } },
            { 1.0000000000000001e-07d, new List<RadioactiveSubstance> { new AlphaParticle(5375002.09), new Thallium198() } },

        };
    }
}
    
    