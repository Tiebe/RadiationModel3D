using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead179 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead179";
        public override double halfLife { get; } = 0.0027d;
        public override double atomicWeight { get; } = 179.0022d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8615047.4), new Mercury175() } },

        };
    }
}
    
    