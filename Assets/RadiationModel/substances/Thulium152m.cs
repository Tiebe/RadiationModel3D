
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium152m";
        public override double halfLife { get; } = 5.2d;
        public override double atomicWeight { get; } = 151.94437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium152() } },

        };
    }
}
    
    