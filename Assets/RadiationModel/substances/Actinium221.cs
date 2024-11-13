
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium221";
        public override double halfLife { get; } = 0.052d;
        public override double atomicWeight { get; } = 221.0156d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Francium217() } },

        };
    }
}
    
    