
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium272";
        public override double halfLife { get; } = 0.0042d;
        public override double atomicWeight { get; } = 272.15327d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Meitnerium268() } },

        };
    }
}
    
    