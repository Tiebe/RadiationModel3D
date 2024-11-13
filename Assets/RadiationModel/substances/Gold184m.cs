
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold184m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold184m";
        public override double halfLife { get; } = 47.6d;
        public override double atomicWeight { get; } = 183.96752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.3d, new List<RadioactiveSubstance> { new GammaParticle(), new Gold184() } },

            { 0.00013d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium180() } },

        };
    }
}
    
    