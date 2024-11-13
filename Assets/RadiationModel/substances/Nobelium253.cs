
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253";
        public override double halfLife { get; } = 94.2d;
        public override double atomicWeight { get; } = 253.09056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.55d, new List<RadioactiveSubstance> { new AlphaParticle(), new Fermium249() } },

        };
    }
}
    
    