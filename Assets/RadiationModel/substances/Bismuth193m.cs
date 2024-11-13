
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth193m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth193m";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 192.98327d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.84d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium189() } },

        };
    }
}
    
    