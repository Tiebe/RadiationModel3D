
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium210";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 210.0094d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium206() } },

        };
    }
}
    
    