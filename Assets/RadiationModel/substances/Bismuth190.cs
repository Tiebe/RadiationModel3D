using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth190 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth190";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 189.98862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.77d, new List<RadioactiveSubstance> { new AlphaParticle(7882047.4), new Thallium186() } },
            { 0.23d, new List<RadioactiveSubstance> { new BetaParticle(1, 9821000.0), new Lead190() } },

        };
    }
}
    
    