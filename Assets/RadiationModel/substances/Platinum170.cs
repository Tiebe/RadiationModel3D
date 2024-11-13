
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum170 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum170";
        public override double halfLife { get; } = 0.01393d;
        public override double atomicWeight { get; } = 169.9825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium166() } },

        };
    }
}
    
    