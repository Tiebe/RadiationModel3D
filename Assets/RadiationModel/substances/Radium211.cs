using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium211";
        public override double halfLife { get; } = 12.6d;
        public override double atomicWeight { get; } = 211.00089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8062047.4), new Radon207() } },

        };
    }
}
    
    