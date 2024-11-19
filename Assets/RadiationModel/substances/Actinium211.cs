using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium211";
        public override double halfLife { get; } = 0.213d;
        public override double atomicWeight { get; } = 211.00767d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8586002.09), new Francium207() } },

        };
    }
}
    
    