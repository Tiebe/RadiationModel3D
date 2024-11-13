
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum124m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum124m";
        public override double halfLife { get; } = 21.0d;
        public override double atomicWeight { get; } = 123.92468d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium124() } },

        };
    }
}
    
    