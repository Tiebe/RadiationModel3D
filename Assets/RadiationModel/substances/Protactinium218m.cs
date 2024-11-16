using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium218m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium218m";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 218.02011d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10893047.4), new Actinium214() } },

        };
    }
}
    
    