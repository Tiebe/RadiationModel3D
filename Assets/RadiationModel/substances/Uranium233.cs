using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium233";
        public override double halfLife { get; } = 5023551188880.0d;
        public override double atomicWeight { get; } = 233.03963d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5930602.09), new Thorium229() } },
            { 6e-13d, new List<RadioactiveSubstance> {  } },
            { 7.2e-13d, new List<RadioactiveSubstance> { new Neon24(), new Lead209() } },
            { 1.3e-15d, new List<RadioactiveSubstance> { new Magnesium28(), new Mercury205() } },

        };
    }
}
    
    