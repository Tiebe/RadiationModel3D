using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium157";
        public override double halfLife { get; } = 0.115d;
        public override double atomicWeight { get; } = 156.95828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new List<RadioactiveSubstance> { new AlphaParticle(6895047.4), new Ytterbium153() } },
            { 0.14d, new List<RadioactiveSubstance> { new BetaParticle(1, 7580000.0), new Lutetium157() } },

        };
    }
}
    
    