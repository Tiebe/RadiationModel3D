
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium55";
        public override double halfLife { get; } = 0.096d;
        public override double atomicWeight { get; } = 54.96689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium55() } },

        };
    }
}
    
    