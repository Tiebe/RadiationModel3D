
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium165";
        public override double halfLife { get; } = 2.53d;
        public override double atomicWeight { get; } = 164.94554d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium165() } },

        };
    }
}
    
    