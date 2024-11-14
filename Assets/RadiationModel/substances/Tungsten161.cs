using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten161 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten161";
        public override double halfLife { get; } = 0.409d;
        public override double atomicWeight { get; } = 160.96725d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new List<RadioactiveSubstance> { new AlphaParticle(6945047.4), new Hafnium157() } },
            { 0.27d, new List<RadioactiveSubstance> { new BetaParticle(1, 8269000.0), new Tantalum161() } },

        };
    }
}
    
    