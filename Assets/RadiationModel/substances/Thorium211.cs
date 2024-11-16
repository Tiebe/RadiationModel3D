using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium211";
        public override double halfLife { get; } = 0.048d;
        public override double atomicWeight { get; } = 211.0149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8965047.4), new Radium207() } },

        };
    }
}
    
    