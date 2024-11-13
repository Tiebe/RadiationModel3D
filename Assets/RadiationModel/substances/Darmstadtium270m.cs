
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium270m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium270m";
        public override double halfLife { get; } = 0.0043d;
        public override double atomicWeight { get; } = 270.14608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hassium266() } },

            { 0.3d, new List<RadioactiveSubstance> { new GammaParticle(), new Darmstadtium270() } },

        };
    }
}
    
    