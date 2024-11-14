using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium218";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 218.01165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10403047.4), new Francium214() } },

        };
    }
}
    
    