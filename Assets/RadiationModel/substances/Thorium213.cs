
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium213";
        public override double halfLife { get; } = 0.144d;
        public override double atomicWeight { get; } = 213.01301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radium209() } },

        };
    }
}
    
    