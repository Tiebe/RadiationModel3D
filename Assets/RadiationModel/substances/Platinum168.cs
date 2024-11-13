
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum168 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum168";
        public override double halfLife { get; } = 0.00202d;
        public override double atomicWeight { get; } = 167.98818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium164() } },

        };
    }
}
    
    