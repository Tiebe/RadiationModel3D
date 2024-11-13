
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90n";
        public override double halfLife { get; } = 18.81d;
        public override double atomicWeight { get; } = 89.91139d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Niobium90() } },

        };
    }
}
    
    