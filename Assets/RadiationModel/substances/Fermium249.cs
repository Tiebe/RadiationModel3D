
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium249";
        public override double halfLife { get; } = 96.0d;
        public override double atomicWeight { get; } = 249.07893d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.33d, new List<RadioactiveSubstance> { new AlphaParticle(), new Californium245() } },

        };
    }
}
    
    