
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 89.91139d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Niobium90() } },

        };
    }
}
    
    