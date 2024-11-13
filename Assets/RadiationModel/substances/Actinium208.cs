
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208";
        public override double halfLife { get; } = 0.097d;
        public override double atomicWeight { get; } = 208.01155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium204() } },

        };
    }
}
    
    