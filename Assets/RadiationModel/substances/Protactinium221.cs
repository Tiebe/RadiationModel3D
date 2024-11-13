
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium221";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 221.02187d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium217() } },

        };
    }
}
    
    