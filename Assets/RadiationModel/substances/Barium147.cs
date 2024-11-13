
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium147";
        public override double halfLife { get; } = 0.893d;
        public override double atomicWeight { get; } = 146.9353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum147() } },

        };
    }
}
    
    