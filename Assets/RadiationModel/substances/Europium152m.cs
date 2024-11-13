
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium152m";
        public override double halfLife { get; } = 33521.76d;
        public override double atomicWeight { get; } = 151.9218d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.73d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium152() } },

            { 0.27d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium152() } },

        };
    }
}
    
    