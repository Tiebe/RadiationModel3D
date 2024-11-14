using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium157";
        public override double halfLife { get; } = 1119.0d;
        public override double atomicWeight { get; } = 156.93192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3419000.0), new Holmium157() } },

        };
    }
}
    
    