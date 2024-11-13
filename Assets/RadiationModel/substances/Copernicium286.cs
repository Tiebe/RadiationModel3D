
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium286";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 286.17869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Darmstadtium282() } },

        };
    }
}
    
    