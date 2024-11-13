
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium283";
        public override double halfLife { get; } = 4.7d;
        public override double atomicWeight { get; } = 283.17321d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.81d, new List<RadioactiveSubstance> { new AlphaParticle(), new Darmstadtium279() } },

            { 0.19d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    