
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium281m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium281m";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 281.16463d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hassium277() } },

        };
    }
}
    
    