
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium219";
        public override double halfLife { get; } = 0.00057d;
        public override double atomicWeight { get; } = 219.03161d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Protactinium215() } },

        };
    }
}
    
    