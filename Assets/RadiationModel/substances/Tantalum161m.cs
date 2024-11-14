using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum161m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum161m";
        public override double halfLife { get; } = 3.08d;
        public override double atomicWeight { get; } = 160.95844d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(1, 7599000.0), new Hafnium161() } },
            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(6318047.4), new Lutetium157() } },

        };
    }
}
    
    