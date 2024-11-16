using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium146";
        public override double halfLife { get; } = 0.155d;
        public override double atomicWeight { get; } = 145.96666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Erbium145() } },

        };
    }
}
    
    