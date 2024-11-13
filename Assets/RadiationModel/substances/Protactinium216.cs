
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium216";
        public override double halfLife { get; } = 0.105d;
        public override double atomicWeight { get; } = 216.01913d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Actinium212() } },

        };
    }
}
    
    